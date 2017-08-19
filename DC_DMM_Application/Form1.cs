using NationalInstruments.Analysis;
using NationalInstruments.Analysis.Conversion;
using NationalInstruments.Analysis.Dsp;
using NationalInstruments.Analysis.Dsp.Filters;
using NationalInstruments.Analysis.Math;
using NationalInstruments.Analysis.Monitoring;
using NationalInstruments.Analysis.SignalGeneration;
using NationalInstruments.Analysis.SpectralMeasurements;
using NationalInstruments;
using NationalInstruments.UI;
using NationalInstruments.ModularInstruments.NIDCPower;
using NationalInstruments.ModularInstruments;
using NationalInstruments.ModularInstruments.SystemServices.DeviceServices;
using NationalInstruments.ModularInstruments.NIDmm;
using NationalInstruments.UI.WindowsForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Ivi.DCPwr;
using System.Threading;
using NationalInstruments.ModularInstruments.NISwitch;
using System.Reflection;

namespace DC_DMM_Application
{
    public partial class frmMain : Form
    {
        //Переменные для отображения всех устройств
        DataSet myDataSet;
        ModularInstrumentsSystem modularInstruments;
        int deviceCount;

        //Переменные для источника питания (Через стандарт)
        NIDCPower dcPower;
        CurrentLimitBehavior curLimitBehavior;
        double curLimit, voltageLevel;

        //Переменные для источника питания (через IVI-драйвер)
        IIviDCPwr ividcPower;
        Thread thr;
        bool bNeedUpdate = false, bNeedExit = false;


        //Переменные для мультиметра
        NIDmm dmmSession;
        const int maxSamplesPerReading = 100000;
        int samplesPerReading;
        int totalNumberOfSamples = 0;
        double averageReading, minReading = Double.PositiveInfinity, maxReading = double.NegativeInfinity;
        bool aqusitionStopped;
        double[] readBuf = new double[maxSamplesPerReading];
        bool isStartSuccessful = false;


        //Переменные для работы с блоками реле 2530B и 2569
        NISwitch switchRelay;
        PrecisionTimeSpan maxTime = new PrecisionTimeSpan(5);
        string currentRelayToWorkWith = string.Empty;


        public frmMain()
        {
            InitializeComponent();

            //Начальная инициализация всех компонентов
            InitAllDevice();
            InitDC();
            InitDMM();
            InitRelay();
            
        }

        void InitRelay()
        {
            LoadSwitchDeviceNames();
            LoadTopology();

            ShowRelays();
        }

        void InitAllDevice()
        {
            cmbDrivers.Items.AddRange(new object[]{
                "NI-DMM",
                "NI-DCPower",
                "NI-FGEN",
                "NI-HSDIO",
                "NI-RFSA",
                "NI-RFSG",
                "NI-SCOPE",
                "NI-SWITCH",
                "All devices"});
        }
        void InitDC()
        {
            //LoadDCDeviceNames();
            txtDCStatus.Text = "Начало работы с ИП";
            grpConfigDCPowerIVI.Enabled = false;
            curLimitBehavior = CurrentLimitBehavior.Regulate;
            curLimit = (double)numCurrentLimit.Value;
            voltageLevel = (double)numVoltageLevel.Value;

            thr = new Thread(updateDCProcessing);
            thr.Start();

        }
        void InitDMM()
        {
            aqusitionStopped = false;
            LoadDMMDeviceName();
            LoadDMMMeasurementModes();
            LoadDMMPowerlineFrequency();
            LoadDMMResolution();
        }

        #region Блок данных считывания всех устройств с текущего шасси PXI
        private void cmbDrivers_SelectedIndexChanged(object sender, EventArgs e)
        {
            //txtDeviceStatus.Text = string.Empty;
            listDevices.Items.Clear();
            txtDeviceStatus.Text = "Поиск устройств...";
            try
            {
                
                if (modularInstruments != null)
                {
                    modularInstruments.Dispose();
                }
                if (cmbDrivers.SelectedItem.ToString().Equals("All devices"))
                {
                    modularInstruments = new ModularInstrumentsSystem();
                }
                else
                {
                    modularInstruments = new ModularInstrumentsSystem(cmbDrivers.SelectedItem.ToString());
                }

                deviceCount = modularInstruments.DeviceCollection.Count;

                if (deviceCount != 0)
                {
                    txtDeviceStatus.Text = string.Format("Найдено {0} устройств(о)",deviceCount);
                    foreach (DeviceInfo device in modularInstruments.DeviceCollection)
                    {
                        listDevices.Items.Add(device.Name);
                    }
                }
                else
                {
                    txtDeviceStatus.Text = "В системе не найдено устройств.";
                }

            }
            catch(Exception ex)
            {
                txtDeviceStatus.Text = ex.Message;
            }

        }
        private void listDevices_SelectedIndexChanged(object sender, EventArgs e)
        {
            DeviceInfo reqDevice = null;
            if (listDevices.SelectedItem != null)
            {
                string name = listDevices.SelectedItem.ToString();
                foreach (DeviceInfo device in modularInstruments.DeviceCollection)
                {
                    if (name.Equals(device.Name))
                    {
                        reqDevice = device;
                        break;
                    }
                }
                UpdateData(reqDevice);
            }
        }
        private void UpdateData(DeviceInfo reqDevice)
        {
            MakeTable(reqDevice);
            BindToGrid();
        }
        private void MakeTable(DeviceInfo reqDevice)
        {
            DeviceInfo device = reqDevice;

            DataTable dataTable = new DataTable("AttributeTable");
            DataColumn dataColumn;
            DataRow dataRow;

            dataColumn = new DataColumn();
            dataColumn.DataType = Type.GetType("System.String");
            dataColumn.ColumnName = "Аттрибут";
            //dataColumn.Caption = "Аттрибут";
            dataColumn.ReadOnly = true;
            dataColumn.Unique = true;
            dataTable.Columns.Add(dataColumn);

            dataColumn = new DataColumn();
            dataColumn.ColumnName = "Значение";
            dataColumn.AutoIncrement = false;
            //dataColumn.Caption = "Значение";
            dataColumn.ReadOnly = true;
            dataColumn.Unique = false;
            dataTable.Columns.Add(dataColumn);

            
            myDataSet = new DataSet();
            myDataSet.Tables.Add(dataTable);

            dataRow = dataTable.NewRow();
            dataRow["Аттрибут"] = "Модель";
            dataRow["Значение"] = device.Model;
            dataTable.Rows.Add(dataRow);

            dataRow = dataTable.NewRow();
            dataRow["Аттрибут"] = "Название";
            dataRow["Значение"] = device.Name;
            dataTable.Rows.Add(dataRow);

            dataRow = dataTable.NewRow();
            dataRow["Аттрибут"] = "Серийный номер";
            dataRow["Значение"] = device.SerialNumber;
            dataTable.Rows.Add(dataRow);

            dataRow = dataTable.NewRow();
            dataRow["Аттрибут"] = "Номер слота";
            dataRow["Значение"] = device.SlotNumber;
            dataTable.Rows.Add(dataRow);

            dataRow = dataTable.NewRow();
            dataRow["Аттрибут"] = "Номер сокета";
            dataRow["Значение"] = device.SocketNumber;
            dataTable.Rows.Add(dataRow);

            dataRow = dataTable.NewRow();
            dataRow["Аттрибут"] = "Номер шасси";
            dataRow["Значение"] = device.ChassisNumber;
            dataTable.Rows.Add(dataRow);

            dataRow = dataTable.NewRow();
            dataRow["Аттрибут"] = "Номер шины";
            dataRow["Значение"] = device.BusNumber;

            dataTable.Rows.Add(dataRow);
        }
        private void BindToGrid()
        {
            dataDeviceAttributes.AutoGenerateColumns = true;
            dataDeviceAttributes.DataSource = myDataSet;
            dataDeviceAttributes.DataMember = "AttributeTable";
            //dataDeviceAttributes.Update();
        }
        #endregion


        #region Блок функция источника питания(стандарт и через IVI)

        private void LoadDCDeviceNames()
        {
            //Для работы добавить два комбобокса с соответствующими именами. Требуется для работы при стандартном подходе через NI-DCPower(не IVI!)

            /*using (ModularInstrumentsSystem dcDevices = new ModularInstrumentsSystem("NI-DCPower"))
            {
                foreach (DeviceInfo device in dcDevices.DeviceCollection)
                {
                    cmbDC.Items.Add(device.Name);
                }
            }
            if (cmbDC.Items.Count > 0)
                cmbDC.SelectedIndex = 0;
            if (cmbChannel.Items.Count > 0)
                cmbChannel.SelectedIndex = 0;*/
        }

        private void btnInitIVIDCPower_Click(object sender, EventArgs e)
        {
            DCStatusUpdate("Идет инициализация...");
            try
            {
                
                ividcPower = IviDCPwr.Create(txtIVIDeviceName.Text, chkIdQuery.Checked, chkResetDevice.Checked);
                ChangeControlToConfiguration();
                DCStatusUpdate("Инициализация ИП " + txtIVIDeviceName.Text + " прошла успешно");
                //ShowOperationSuccessful("Инициализация DC-Power (IVI)");
                
                
            }
            catch (Exception ex)
            {
                ShowError(ex);
            }
        }

        void ChangeControlToConfiguration()
        {
            ConfigureChannelName();
            ConfigureCurrentlimitBehavior();
            //grpInitIVIDCPower.Enabled = false;
            btnInitIVIDCPower.Enabled = false;
            btnCloseIVIDCPower.Enabled = true;
            grpConfigDCPowerIVI.Enabled = true;
            txtIVIDeviceName.Enabled = false;

        }
        private void tmr_Tick(object sender, EventArgs e)
        {
            if (bNeedUpdate)
            {
                UpdateIVIDCpwrOutput();

                bNeedUpdate = false;
            }
        }


        int cnt = 0;
        void UpdateIVIDCpwrOutput()
        {
            cnt++;
            //Application.DoEvents();
            if (ividcPower == null) return;
            try
            {
                BeginInvoke((MethodInvoker)delegate
                {
                        if (switchDCOutput.Value)
                    {
                        ividcPower.Outputs[cmbChannelIVI.Text].ConfigureCurrentLimit(curLimitBehavior,curLimit);
                        ividcPower.Outputs[cmbChannelIVI.Text].VoltageLevel = voltageLevel;
                        //ividcPower.Outputs[cmbChannelIVI.Text].ConfigureCurrentLimit((CurrentLimitBehavior)cmbCurrentLimitBehavior.SelectedItem, (double)numCurrentLimit.Value);
                        //ividcPower.Outputs[cmbChannelIVI.Text].VoltageLevel = (double)numVoltageLevel.Value;
                        ividcPower.Outputs[cmbChannelIVI.Text].Enabled = true;
                    }
                    else
                    {
                        ividcPower.Outputs[cmbChannelIVI.Text].Enabled = false;
                    }
                });
            }
            catch (Exception ex)
            {
                ShowError(ex);
            }
        }

        private void updateDCProcessing()
        {
            while (!bNeedExit)
            {
                if (bNeedUpdate)
                {
                    UpdateIVIDCpwrOutput();

                    bNeedUpdate = false;
                }
                Thread.Sleep(100);
            }
        }

        void ConfigureChannelName()
        {
            foreach (IIviDCPwrOutput channel in ividcPower.Outputs)
            {
                cmbChannelIVI.Items.Add(channel.Name);
            }
            if (cmbChannelIVI.Items.Count > 0)
                cmbChannelIVI.SelectedIndex = 0;
        }

        void ConfigureCurrentlimitBehavior()
        {
            foreach (CurrentLimitBehavior item in Enum.GetValues(typeof(CurrentLimitBehavior)))
            {
                cmbCurrentLimitBehavior.Items.Add(item);
            }
            cmbCurrentLimitBehavior.SelectedIndex = 0;
        }

        private void btnCloseIVIDCPower_Click(object sender, EventArgs e)
        {
            CloseIVISession(false);
            switchDCOutput.Value = false;
            grpConfigDCPowerIVI.Enabled = false;
            btnInitIVIDCPower.Enabled = true;
            btnCloseIVIDCPower.Enabled = false;
            txtIVIDeviceName.Enabled = true;
            DCStatusUpdate("Работа с источником питания " + txtIVIDeviceName.Text + " успешно завершена");
        }

        void CloseIVISession(bool isExitProgram)
        {
            bNeedExit = true;
            if (ividcPower != null)
            {
                try
                {
                    ividcPower.Outputs[cmbChannelIVI.Text].Enabled = false;
                    ividcPower.Close();
                    ividcPower = null;

                    
                }
                catch (Exception ex)
                {
                    ShowError(ex);
                    if(isExitProgram) 
                        Application.Exit();
                }
            }

        }

        private void switchOutput_StateChanged(object sender, ActionEventArgs e)
        {
            DCStatusUpdate("Идет работа с источником питания " + txtIVIDeviceName.Text);
            UpdateIVIDCpwrOutput();
        }

        void UpdateColorCheckBoxOutput(CheckBox chk, bool isChecked)
        {
            if (isChecked)
            {
                chk.BackColor = Color.Coral;
                chk.ForeColor = Color.White;
            }
            else
            {
                chk.BackColor = SystemColors.Control;
                chk.ForeColor = Color.Black;
            }
        }

        private void knobVoltageLevel_AfterChangeValue(object sender, AfterChangeNumericValueEventArgs e)
        {
            numVoltageLevel.Value = (decimal)knobVoltageLevel.Value;
        }

        private void numVoltageLevel_ValueChanged(object sender, EventArgs e)
        {
            bNeedUpdate = true;
            //UpdateIVIDCpwrOutput();
            knobVoltageLevel.Value = (double)numVoltageLevel.Value;
            voltageLevel = (double)numVoltageLevel.Value;
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            CloseIVISession(true);
            CloseRelaySession();
        }

        void DCStatusUpdate(string msg)
        {
            txtDCStatus.Text = msg;
            //MessageBox.Show("Операция " + operation + " успешно завершена.");
        }

        void ShowError(Exception ex)
        {
            DCStatusUpdate("Произошла ошибка");
            MessageBox.Show(ex.Message, ex.GetType().ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        #endregion


        #region Блок функций мультиметра, считывание данных
        void LoadDMMDeviceName()
        {
            ModularInstrumentsSystem modularInstrumentsSystem = new ModularInstrumentsSystem("NI-DMM");
            foreach (DeviceInfo device in modularInstrumentsSystem.DeviceCollection)
                cmbDMMName.Items.Add(device.Name);
            if (modularInstrumentsSystem.DeviceCollection.Count > 0)
                cmbDMMName.SelectedIndex = 0;
        }

        void LoadDMMMeasurementModes()
        {
            cmbMeasureDMMMode.Items.AddRange(Enum.GetNames(typeof(DmmMeasurementFunction)));
            cmbMeasureDMMMode.Items.Remove(DmmMeasurementFunction.WaveformCurrent.ToString());
            cmbMeasureDMMMode.Items.Remove(DmmMeasurementFunction.WaveformVoltage.ToString());
            cmbMeasureDMMMode.SelectedIndex = 0;
        }

        void LoadDMMPowerlineFrequency()
        {
            double[] powerlineFrequencyValues = { 50, 60 };
            for (int i = 0; i < powerlineFrequencyValues.Length; i++)
                cmbPowerlineFreq.Items.Add(powerlineFrequencyValues[i]);
            cmbPowerlineFreq.SelectedIndex = 1;
        }

        private void LoadDMMResolution()
        {
            double[] resolutionValues = { 3.5, 4.5, 5.5, 6.5, 7.5 };
            for (int i = 0; i < resolutionValues.Length; i++)
                cmbDMMResolution.Items.Add(resolutionValues[i]);
            cmbDMMResolution.SelectedIndex = 2;
        }

        private void switchDMM_StateChanged(object sender, ActionEventArgs e)
        {
            if (switchDMM.Value)
                Aquire();
            else
                StopAquiring();
        }

        void Aquire()
        {
            aqusitionStopped = false;
            EnableControls(false);
            ResetValues();
            txtDMMStatus.Text = "";
            ClearMeasurementDisplay();
            Application.DoEvents();
            try
            {
                dmmSession = new NIDmm(cmbDMMName.Text, true, true);
                dmmSession.Measurement.ReadMultiPointCompleted += Measurement_ReadMultiPointCompleted;
                Configure();
                txtDMMStatus.Text = "Идет сбор данных...";
                TakeMeasurement();
                isStartSuccessful = true;
            }
            catch (Exception ex)
            {
                DisplayMessageAndCloseSession(ex.Message);
            }
        }

        void Measurement_ReadMultiPointCompleted(object sender, DmmMeasurementEventArgs<double[]> e)
        {
            if (e.Error != null)
            {
                DisplayMessageAndCloseSession(e.Error.Message);
                return;
            }
            totalNumberOfSamples += e.ActualNumberOfPoints;
            UpdateMeasurementDisplay(e.Reading, e.ActualNumberOfPoints);

            if (!aqusitionStopped)
            {
                // Continue Acquisition
                TakeMeasurement();
            }
            else
            {
                DisplayMessageAndCloseSession("Сбор данных завершен.");
            }
        }

        void StopAquiring()
        {
            if (isStartSuccessful) txtDMMStatus.Text = "Ждите, идет завершение сбора данных...";
            isStartSuccessful = false;
            aqusitionStopped = true;
            
            EnableControls(false);
            Application.DoEvents();
        }

        void UpdateMeasurementDisplay(double[] reading, int numberOfMeasurements)
        {
            double sum = 0;
            for (int i = 0; i < numberOfMeasurements; i++)
            {
                minReading = (reading[i] < minReading) ? reading[i] : minReading;
                maxReading = (reading[i] > maxReading) ? reading[i] : maxReading;
                sum += reading[i];
            }
            averageReading = (sum + averageReading) / (numberOfMeasurements + 1);
            averageReadingTextBox.Text = String.Format("{0:G8}", averageReading);
            minReadingTextBox.Text = String.Format("{0:G8}", minReading);
            maxReadingTextBox.Text = String.Format("{0:G8}", maxReading);
            txtDMMTotalSamples.Text = totalNumberOfSamples.ToString();

            UpdateActualRange();

            if (!meterDMM.IsDisposed)
            {
                if (!double.IsNaN(averageReading))
                    meterDMM.Value = averageReading;
                else
                    meterDMM.Value = 0;
            }
            
        }

        void UpdateActualRange()
        {
            double actualRange = dmmSession.Range;
            
            actualRangeTextBox.Text = String.Format("{0:G5}", actualRange);
        }

        private void TakeMeasurement()
        {
            dmmSession.Trigger.MultiPoint.SampleCount = samplesPerReading;
            dmmSession.Measurement.MemoryOptimizedReadMultiPointAsync(samplesPerReading, readBuf, null);
        }

        void Configure()
        {
            DmmMeasurementFunction measurementMode = (DmmMeasurementFunction)Enum.Parse(typeof(DmmMeasurementFunction), cmbMeasureDMMMode.Text);
            double range = double.Parse(txtDMMRange.Text);
            double resolution = double.Parse(cmbDMMResolution.Text);
            samplesPerReading = int.Parse(numDMMSamplesPerReading.Text);
            double powerlineFrequency = double.Parse(cmbPowerlineFreq.Text);
            //Configure Dmm session Measurement parameters
            dmmSession.ConfigureMeasurementDigits(measurementMode, range, resolution);
            //Configure Powerline Frequency
            dmmSession.Advanced.PowerlineFrequency = powerlineFrequency;

            meterDMM.Range = new Range(-0.1, 61);
        }

        private void DisplayMessageAndCloseSession(string messageText)
        {
            if (dmmSession != null && !dmmSession.IsDisposed)
            {
                dmmSession.Measurement.ReadMultiPointCompleted -= Measurement_ReadMultiPointCompleted;
                dmmSession.Close();
            }
            txtDMMStatus.Text = messageText;
            EnableControls(true);
        }

        private void cmbCurrentLimitBehavior_SelectedIndexChanged(object sender, EventArgs e)
        {
            curLimitBehavior = (CurrentLimitBehavior)cmbCurrentLimitBehavior.SelectedItem;
        }

        private void numCurrentLimit_ValueChanged(object sender, EventArgs e)
        {
            curLimit = (double)numCurrentLimit.Value;
        }

        void EnableControls(bool enabled)
        {
            cmbDMMName.Enabled =
                cmbDMMResolution.Enabled =
                txtDMMRange.Enabled =
                cmbMeasureDMMMode.Enabled =
                numDMMSamplesPerReading.Enabled =
                cmbPowerlineFreq.Enabled = enabled;
        }

        void ResetValues()
        {
            minReading = double.PositiveInfinity;
            maxReading = double.NegativeInfinity;
            averageReading = 0;
            totalNumberOfSamples = 0;
        }

        void ClearMeasurementDisplay()
        {
            minReadingTextBox.Clear();
            maxReadingTextBox.Clear();
            averageReadingTextBox.Clear();
            txtDMMTotalSamples.Clear();
            actualRangeTextBox.Clear();
        }
        #endregion


        #region Блок функций обработки реле
        private void LoadTopology()
        {
            Type myType = typeof(SwitchDeviceTopology);
            PropertyInfo[] properties = myType.GetProperties();

            foreach (PropertyInfo prop in properties)
            {
                string topology = prop.GetValue(myType, null).ToString();
                if(topology.StartsWith("2530") || topology.StartsWith("2569"))
                    cmbTopology.Items.Add(topology);
            }
            cmbTopology.SelectedIndex = 0;
        }
        private void LoadSwitchDeviceNames()
        {
            ModularInstrumentsSystem modularInstrumentsSystem = new ModularInstrumentsSystem("NI-SWITCH");
            foreach (DeviceInfo device in modularInstrumentsSystem.DeviceCollection)
            {
                cmbSwitch.Items.Add(device.Name);
            }
            if (modularInstrumentsSystem.DeviceCollection.Count > 0)
            {
                cmbSwitch.Sorted = true;
                cmbSwitch.SelectedIndex = 0;
            }
        }

        private void ShowRelays()
        {
            int j = 0, n = 23, cnt = 128, leftOffset = 10, topOffset = 10;
            
            for (int i = 0; i < cnt; i++)
            {
                if ((i > 0) && (i % n == 0)) j++;

                CheckBox chk = new CheckBox();
                chk.Name = "chk" + i.ToString();
                chk.Appearance = Appearance.Button;
                chk.Text = "k" + i.ToString(); 
                chk.Size = new Size(40, 20);
                chk.Top = topOffset + 30 * j;
                chk.Left = leftOffset + 50 * (i % n);
                chk.TextAlign = ContentAlignment.MiddleCenter;
                chk.Click += Chk_MouseClick;
                //chk.Click += Chk_Click;
                //if ((i>0) && (i % n == 0)) j++;

                panelSwitch.Controls.Add(chk);
            }
        }

        private void Chk_MouseClick(object sender, EventArgs e)
        {
            CheckBox chk = (CheckBox)sender;
            PerformChkClick(chk);
        }

        void PerformChkClick(CheckBox chk)
        {
            currentRelayToWorkWith = chk.Text;
            if (chk.Checked)
            {
                chk.BackColor = Color.Coral;
                chk.ForeColor = Color.White;
                ChangeRelayState(SwitchRelayAction.CloseRelay);

            }
            else
            {
                chk.BackColor = SystemColors.Control;
                chk.ForeColor = SystemColors.ControlText;
                ChangeRelayState(SwitchRelayAction.OpenRelay);
            }
        }

        void ChangeRelayState(SwitchRelayAction action)
        {
            try
            {
                //CloseRelaySession();

                //InitRelaySession();

                switchRelay.RelayOperations.RelayControl(currentRelayToWorkWith, action);

                switchRelay.Path.WaitForDebounce(maxTime);
            }
            catch(Exception ex)
            {
                ShowRelayError(ex.Message);
            }
            finally
            {
                //CloseRelaySession();
            }
        }

        private void btnRelayConnect_Click(object sender, EventArgs e)
        {
            try
            {
                InitRelaySession();
                btnRelayConnect.Enabled = false;
                btnRelayDisconnect.Enabled = true;
                panelSwitch.Enabled = true;
            }
            catch(Exception ex)
            {
                ShowRelayError(ex.Message);
            }
        }

        private void btnRelayDisconnect_Click(object sender, EventArgs e)
        {

            /*foreach(Control cntrl in panelSwitch.Controls)
            {
                CheckBox chk = (CheckBox)cntrl;
                if (chk.Checked) chk.Checked = false;
                    
            }*/

            CloseRelaySession();


            btnRelayDisconnect.Enabled = false;
            btnRelayConnect.Enabled = true;

            panelSwitch.Enabled = false;
            panelSwitch.Controls.Clear();
            ShowRelays();
        }

        void InitRelaySession()
        {
            switchRelay = new NISwitch(cmbSwitch.SelectedItem.ToString(), cmbTopology.SelectedItem.ToString(), false, true);
            switchRelay.DriverOperation.Warning += DriverOperation_Warning;
        }

        private void DriverOperation_Warning(object sender, SwitchWarningEventArgs e)
        {
            ShowRelayError(e.ToString());
        }

        private void CloseRelaySession()
        {
            if (switchRelay != null)
            {
                try
                {
                    switchRelay.Utility.Reset();
                    switchRelay.Close();
                    
                    switchRelay = null;
                }
                catch (System.Exception ex)
                {
                    ShowRelayError("Невозможно закрыть сессию. Перегрузите устройства.\n" + "Ошибка : " + ex.Message);
                    Application.Exit();
                }
            }
        }

        private static void ShowRelayError(string message)
        {
            if (string.IsNullOrEmpty(message))
                message = "Неизвестная ошибка";
            MessageBox.Show(message, "Ошибка"); ;
        }
        #endregion


    }
}
