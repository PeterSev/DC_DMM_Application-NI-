namespace DC_DMM_Application
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grpConfigDCPowerIVI = new System.Windows.Forms.GroupBox();
            this.statusStripDC = new System.Windows.Forms.StatusStrip();
            this.txtDCStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.switchDCOutput = new NationalInstruments.UI.WindowsForms.Switch();
            this.knobVoltageLevel = new NationalInstruments.UI.WindowsForms.Knob();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.voltageLevelLabel = new System.Windows.Forms.Label();
            this.numCurrentLimit = new System.Windows.Forms.NumericUpDown();
            this.numVoltageLevel = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbCurrentLimitBehavior = new System.Windows.Forms.ComboBox();
            this.cmbChannelIVI = new System.Windows.Forms.ComboBox();
            this.grpInitIVIDCPower = new System.Windows.Forms.GroupBox();
            this.btnCloseIVIDCPower = new System.Windows.Forms.Button();
            this.chkResetDevice = new System.Windows.Forms.CheckBox();
            this.chkIdQuery = new System.Windows.Forms.CheckBox();
            this.btnInitIVIDCPower = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIVIDeviceName = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.switchDMM = new NationalInstruments.UI.WindowsForms.Switch();
            this.statusStripDMM = new System.Windows.Forms.StatusStrip();
            this.txtDMMStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtDMMTotalSamples = new System.Windows.Forms.TextBox();
            this.numberOfSamplesLabel = new System.Windows.Forms.Label();
            this.meterDMM = new NationalInstruments.UI.WindowsForms.Meter();
            this.maxReadingTextBox = new System.Windows.Forms.TextBox();
            this.minReadingTextBox = new System.Windows.Forms.TextBox();
            this.minReadingLabel = new System.Windows.Forms.Label();
            this.maxReadingLabel = new System.Windows.Forms.Label();
            this.averageReadingLabel = new System.Windows.Forms.Label();
            this.averageReadingTextBox = new System.Windows.Forms.TextBox();
            this.actualRangeLabel = new System.Windows.Forms.Label();
            this.actualRangeTextBox = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.numDMMSamplesPerReading = new System.Windows.Forms.NumericUpDown();
            this.samplesPerReadingLabel = new System.Windows.Forms.Label();
            this.txtDMMRange = new System.Windows.Forms.TextBox();
            this.powerlineFrequencyLabel = new System.Windows.Forms.Label();
            this.resolutionLabel = new System.Windows.Forms.Label();
            this.rangeLabel = new System.Windows.Forms.Label();
            this.cmbPowerlineFreq = new System.Windows.Forms.ComboBox();
            this.cmbDMMResolution = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cmbDMMName = new System.Windows.Forms.ComboBox();
            this.measurementTypeLabel = new System.Windows.Forms.Label();
            this.resourceNameLabel = new System.Windows.Forms.Label();
            this.cmbMeasureDMMMode = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.statusAllDevices = new System.Windows.Forms.StatusStrip();
            this.txtDeviceStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.dataDeviceAttributes = new System.Windows.Forms.DataGridView();
            this.listDevices = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbDrivers = new System.Windows.Forms.ComboBox();
            this.tmr = new System.Windows.Forms.Timer(this.components);
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.topologyNameLabel = new System.Windows.Forms.Label();
            this.cmbTopology = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbSwitch = new System.Windows.Forms.ComboBox();
            this.panelSwitch = new System.Windows.Forms.Panel();
            this.btnRelayConnect = new System.Windows.Forms.Button();
            this.btnRelayDisconnect = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.grpConfigDCPowerIVI.SuspendLayout();
            this.statusStripDC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.switchDCOutput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.knobVoltageLevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCurrentLimit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numVoltageLevel)).BeginInit();
            this.grpInitIVIDCPower.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.switchDMM)).BeginInit();
            this.statusStripDMM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.meterDMM)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDMMSamplesPerReading)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.statusAllDevices.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataDeviceAttributes)).BeginInit();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.grpConfigDCPowerIVI);
            this.groupBox1.Controls.Add(this.grpInitIVIDCPower);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(386, 447);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DC-POWER";
            // 
            // grpConfigDCPowerIVI
            // 
            this.grpConfigDCPowerIVI.Controls.Add(this.statusStripDC);
            this.grpConfigDCPowerIVI.Controls.Add(this.switchDCOutput);
            this.grpConfigDCPowerIVI.Controls.Add(this.knobVoltageLevel);
            this.grpConfigDCPowerIVI.Controls.Add(this.label7);
            this.grpConfigDCPowerIVI.Controls.Add(this.label6);
            this.grpConfigDCPowerIVI.Controls.Add(this.voltageLevelLabel);
            this.grpConfigDCPowerIVI.Controls.Add(this.numCurrentLimit);
            this.grpConfigDCPowerIVI.Controls.Add(this.numVoltageLevel);
            this.grpConfigDCPowerIVI.Controls.Add(this.label5);
            this.grpConfigDCPowerIVI.Controls.Add(this.cmbCurrentLimitBehavior);
            this.grpConfigDCPowerIVI.Controls.Add(this.cmbChannelIVI);
            this.grpConfigDCPowerIVI.Location = new System.Drawing.Point(8, 109);
            this.grpConfigDCPowerIVI.Name = "grpConfigDCPowerIVI";
            this.grpConfigDCPowerIVI.Size = new System.Drawing.Size(372, 332);
            this.grpConfigDCPowerIVI.TabIndex = 6;
            this.grpConfigDCPowerIVI.TabStop = false;
            this.grpConfigDCPowerIVI.Text = "Конфигурация";
            // 
            // statusStripDC
            // 
            this.statusStripDC.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.txtDCStatus});
            this.statusStripDC.Location = new System.Drawing.Point(3, 307);
            this.statusStripDC.Name = "statusStripDC";
            this.statusStripDC.Size = new System.Drawing.Size(366, 22);
            this.statusStripDC.TabIndex = 11;
            this.statusStripDC.Text = "statusStrip1";
            // 
            // txtDCStatus
            // 
            this.txtDCStatus.Name = "txtDCStatus";
            this.txtDCStatus.Size = new System.Drawing.Size(0, 17);
            // 
            // switchDCOutput
            // 
            this.switchDCOutput.Location = new System.Drawing.Point(268, 170);
            this.switchDCOutput.Name = "switchDCOutput";
            this.switchDCOutput.OnColor = System.Drawing.Color.Coral;
            this.switchDCOutput.Size = new System.Drawing.Size(98, 126);
            this.switchDCOutput.SwitchStyle = NationalInstruments.UI.SwitchStyle.VerticalToggle3D;
            this.switchDCOutput.TabIndex = 10;
            this.switchDCOutput.StateChanged += new NationalInstruments.UI.ActionEventHandler(this.switchOutput_StateChanged);
            // 
            // knobVoltageLevel
            // 
            this.knobVoltageLevel.DialColor = System.Drawing.Color.Coral;
            this.knobVoltageLevel.ImmediateUpdates = true;
            this.knobVoltageLevel.KnobStyle = NationalInstruments.UI.KnobStyle.FlatWithThinNeedle;
            this.knobVoltageLevel.Location = new System.Drawing.Point(6, 75);
            this.knobVoltageLevel.Name = "knobVoltageLevel";
            this.knobVoltageLevel.PointerColor = System.Drawing.Color.White;
            this.knobVoltageLevel.Range = new NationalInstruments.UI.Range(0.1D, 60D);
            this.knobVoltageLevel.Size = new System.Drawing.Size(263, 221);
            this.knobVoltageLevel.TabIndex = 8;
            this.knobVoltageLevel.Value = 1D;
            this.knobVoltageLevel.AfterChangeValue += new NationalInstruments.UI.AfterChangeNumericValueEventHandler(this.knobVoltageLevel_AfterChangeValue);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Повед. огран.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(186, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Огран. тока (А)";
            // 
            // voltageLevelLabel
            // 
            this.voltageLevelLabel.AutoSize = true;
            this.voltageLevelLabel.Location = new System.Drawing.Point(187, 22);
            this.voltageLevelLabel.Name = "voltageLevelLabel";
            this.voltageLevelLabel.Size = new System.Drawing.Size(82, 13);
            this.voltageLevelLabel.TabIndex = 6;
            this.voltageLevelLabel.Text = "DC уровень (V)";
            // 
            // numCurrentLimit
            // 
            this.numCurrentLimit.DecimalPlaces = 6;
            this.numCurrentLimit.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numCurrentLimit.Location = new System.Drawing.Point(275, 46);
            this.numCurrentLimit.Maximum = new decimal(new int[] {
            -1,
            -1,
            -1,
            0});
            this.numCurrentLimit.Minimum = new decimal(new int[] {
            -1,
            -1,
            -1,
            -2147483648});
            this.numCurrentLimit.Name = "numCurrentLimit";
            this.numCurrentLimit.Size = new System.Drawing.Size(91, 20);
            this.numCurrentLimit.TabIndex = 7;
            this.numCurrentLimit.Value = new decimal(new int[] {
            2,
            0,
            0,
            131072});
            this.numCurrentLimit.ValueChanged += new System.EventHandler(this.numCurrentLimit_ValueChanged);
            // 
            // numVoltageLevel
            // 
            this.numVoltageLevel.DecimalPlaces = 6;
            this.numVoltageLevel.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numVoltageLevel.Location = new System.Drawing.Point(275, 20);
            this.numVoltageLevel.Maximum = new decimal(new int[] {
            -1,
            -1,
            -1,
            0});
            this.numVoltageLevel.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numVoltageLevel.Name = "numVoltageLevel";
            this.numVoltageLevel.Size = new System.Drawing.Size(91, 20);
            this.numVoltageLevel.TabIndex = 7;
            this.numVoltageLevel.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numVoltageLevel.ValueChanged += new System.EventHandler(this.numVoltageLevel_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(56, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Канал";
            // 
            // cmbCurrentLimitBehavior
            // 
            this.cmbCurrentLimitBehavior.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCurrentLimitBehavior.FormattingEnabled = true;
            this.cmbCurrentLimitBehavior.Location = new System.Drawing.Point(100, 45);
            this.cmbCurrentLimitBehavior.Name = "cmbCurrentLimitBehavior";
            this.cmbCurrentLimitBehavior.Size = new System.Drawing.Size(71, 21);
            this.cmbCurrentLimitBehavior.TabIndex = 0;
            this.cmbCurrentLimitBehavior.SelectedIndexChanged += new System.EventHandler(this.cmbCurrentLimitBehavior_SelectedIndexChanged);
            // 
            // cmbChannelIVI
            // 
            this.cmbChannelIVI.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbChannelIVI.FormattingEnabled = true;
            this.cmbChannelIVI.Location = new System.Drawing.Point(100, 19);
            this.cmbChannelIVI.Name = "cmbChannelIVI";
            this.cmbChannelIVI.Size = new System.Drawing.Size(71, 21);
            this.cmbChannelIVI.TabIndex = 0;
            // 
            // grpInitIVIDCPower
            // 
            this.grpInitIVIDCPower.Controls.Add(this.btnCloseIVIDCPower);
            this.grpInitIVIDCPower.Controls.Add(this.chkResetDevice);
            this.grpInitIVIDCPower.Controls.Add(this.chkIdQuery);
            this.grpInitIVIDCPower.Controls.Add(this.btnInitIVIDCPower);
            this.grpInitIVIDCPower.Controls.Add(this.label4);
            this.grpInitIVIDCPower.Controls.Add(this.txtIVIDeviceName);
            this.grpInitIVIDCPower.Location = new System.Drawing.Point(8, 19);
            this.grpInitIVIDCPower.Name = "grpInitIVIDCPower";
            this.grpInitIVIDCPower.Size = new System.Drawing.Size(372, 84);
            this.grpInitIVIDCPower.TabIndex = 5;
            this.grpInitIVIDCPower.TabStop = false;
            this.grpInitIVIDCPower.Text = "Инициализация";
            // 
            // btnCloseIVIDCPower
            // 
            this.btnCloseIVIDCPower.Enabled = false;
            this.btnCloseIVIDCPower.Location = new System.Drawing.Point(295, 45);
            this.btnCloseIVIDCPower.Name = "btnCloseIVIDCPower";
            this.btnCloseIVIDCPower.Size = new System.Drawing.Size(71, 23);
            this.btnCloseIVIDCPower.TabIndex = 4;
            this.btnCloseIVIDCPower.Text = "Закрыть";
            this.btnCloseIVIDCPower.UseVisualStyleBackColor = true;
            this.btnCloseIVIDCPower.Click += new System.EventHandler(this.btnCloseIVIDCPower_Click);
            // 
            // chkResetDevice
            // 
            this.chkResetDevice.AutoSize = true;
            this.chkResetDevice.Checked = true;
            this.chkResetDevice.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkResetDevice.Location = new System.Drawing.Point(75, 21);
            this.chkResetDevice.Name = "chkResetDevice";
            this.chkResetDevice.Size = new System.Drawing.Size(54, 17);
            this.chkResetDevice.TabIndex = 3;
            this.chkResetDevice.Text = "Reset";
            this.chkResetDevice.UseVisualStyleBackColor = true;
            // 
            // chkIdQuery
            // 
            this.chkIdQuery.AutoSize = true;
            this.chkIdQuery.Checked = true;
            this.chkIdQuery.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkIdQuery.Location = new System.Drawing.Point(6, 21);
            this.chkIdQuery.Name = "chkIdQuery";
            this.chkIdQuery.Size = new System.Drawing.Size(63, 17);
            this.chkIdQuery.TabIndex = 3;
            this.chkIdQuery.Text = "IdQuery";
            this.chkIdQuery.UseVisualStyleBackColor = true;
            // 
            // btnInitIVIDCPower
            // 
            this.btnInitIVIDCPower.Location = new System.Drawing.Point(6, 45);
            this.btnInitIVIDCPower.Name = "btnInitIVIDCPower";
            this.btnInitIVIDCPower.Size = new System.Drawing.Size(123, 23);
            this.btnInitIVIDCPower.TabIndex = 2;
            this.btnInitIVIDCPower.Text = "Инициализация";
            this.btnInitIVIDCPower.UseVisualStyleBackColor = true;
            this.btnInitIVIDCPower.Click += new System.EventHandler(this.btnInitIVIDCPower_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(152, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Логическое имя (из MAX)";
            // 
            // txtIVIDeviceName
            // 
            this.txtIVIDeviceName.Location = new System.Drawing.Point(295, 19);
            this.txtIVIDeviceName.MaxLength = 12;
            this.txtIVIDeviceName.Name = "txtIVIDeviceName";
            this.txtIVIDeviceName.Size = new System.Drawing.Size(71, 20);
            this.txtIVIDeviceName.TabIndex = 0;
            this.txtIVIDeviceName.Text = "DC";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox6);
            this.groupBox2.Controls.Add(this.groupBox5);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Location = new System.Drawing.Point(404, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(386, 447);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "NI-DMM";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.switchDMM);
            this.groupBox6.Controls.Add(this.statusStripDMM);
            this.groupBox6.Controls.Add(this.txtDMMTotalSamples);
            this.groupBox6.Controls.Add(this.numberOfSamplesLabel);
            this.groupBox6.Controls.Add(this.meterDMM);
            this.groupBox6.Controls.Add(this.maxReadingTextBox);
            this.groupBox6.Controls.Add(this.minReadingTextBox);
            this.groupBox6.Controls.Add(this.minReadingLabel);
            this.groupBox6.Controls.Add(this.maxReadingLabel);
            this.groupBox6.Controls.Add(this.averageReadingLabel);
            this.groupBox6.Controls.Add(this.averageReadingTextBox);
            this.groupBox6.Controls.Add(this.actualRangeLabel);
            this.groupBox6.Controls.Add(this.actualRangeTextBox);
            this.groupBox6.Location = new System.Drawing.Point(6, 199);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(374, 242);
            this.groupBox6.TabIndex = 10;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Измерение";
            // 
            // switchDMM
            // 
            this.switchDMM.Location = new System.Drawing.Point(270, 80);
            this.switchDMM.Name = "switchDMM";
            this.switchDMM.OnColor = System.Drawing.Color.Coral;
            this.switchDMM.Size = new System.Drawing.Size(98, 126);
            this.switchDMM.SwitchStyle = NationalInstruments.UI.SwitchStyle.VerticalToggle3D;
            this.switchDMM.TabIndex = 25;
            this.switchDMM.StateChanged += new NationalInstruments.UI.ActionEventHandler(this.switchDMM_StateChanged);
            // 
            // statusStripDMM
            // 
            this.statusStripDMM.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.txtDMMStatus});
            this.statusStripDMM.Location = new System.Drawing.Point(3, 217);
            this.statusStripDMM.Name = "statusStripDMM";
            this.statusStripDMM.Size = new System.Drawing.Size(368, 22);
            this.statusStripDMM.TabIndex = 24;
            this.statusStripDMM.Text = "statusStrip1";
            // 
            // txtDMMStatus
            // 
            this.txtDMMStatus.Name = "txtDMMStatus";
            this.txtDMMStatus.Size = new System.Drawing.Size(0, 17);
            // 
            // txtDMMTotalSamples
            // 
            this.txtDMMTotalSamples.Location = new System.Drawing.Point(96, 68);
            this.txtDMMTotalSamples.Margin = new System.Windows.Forms.Padding(2);
            this.txtDMMTotalSamples.Name = "txtDMMTotalSamples";
            this.txtDMMTotalSamples.ReadOnly = true;
            this.txtDMMTotalSamples.Size = new System.Drawing.Size(100, 20);
            this.txtDMMTotalSamples.TabIndex = 22;
            // 
            // numberOfSamplesLabel
            // 
            this.numberOfSamplesLabel.AutoSize = true;
            this.numberOfSamplesLabel.Location = new System.Drawing.Point(52, 71);
            this.numberOfSamplesLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.numberOfSamplesLabel.Name = "numberOfSamplesLabel";
            this.numberOfSamplesLabel.Size = new System.Drawing.Size(40, 13);
            this.numberOfSamplesLabel.TabIndex = 23;
            this.numberOfSamplesLabel.Text = "Точек:";
            // 
            // meterDMM
            // 
            this.meterDMM.DialColor = System.Drawing.Color.Coral;
            this.meterDMM.Location = new System.Drawing.Point(4, 93);
            this.meterDMM.Name = "meterDMM";
            this.meterDMM.PointerColor = System.Drawing.Color.White;
            this.meterDMM.Range = new NationalInstruments.UI.Range(0D, 60D);
            this.meterDMM.ScaleArc = new NationalInstruments.UI.Arc(135F, -90F);
            this.meterDMM.Size = new System.Drawing.Size(238, 122);
            this.meterDMM.SpindleColor = System.Drawing.Color.Black;
            this.meterDMM.TabIndex = 21;
            this.meterDMM.Value = 2D;
            // 
            // maxReadingTextBox
            // 
            this.maxReadingTextBox.Location = new System.Drawing.Point(268, 44);
            this.maxReadingTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.maxReadingTextBox.Name = "maxReadingTextBox";
            this.maxReadingTextBox.ReadOnly = true;
            this.maxReadingTextBox.Size = new System.Drawing.Size(100, 20);
            this.maxReadingTextBox.TabIndex = 14;
            // 
            // minReadingTextBox
            // 
            this.minReadingTextBox.Location = new System.Drawing.Point(96, 44);
            this.minReadingTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.minReadingTextBox.Name = "minReadingTextBox";
            this.minReadingTextBox.ReadOnly = true;
            this.minReadingTextBox.Size = new System.Drawing.Size(100, 20);
            this.minReadingTextBox.TabIndex = 13;
            // 
            // minReadingLabel
            // 
            this.minReadingLabel.AutoSize = true;
            this.minReadingLabel.Location = new System.Drawing.Point(61, 47);
            this.minReadingLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.minReadingLabel.Name = "minReadingLabel";
            this.minReadingLabel.Size = new System.Drawing.Size(31, 13);
            this.minReadingLabel.TabIndex = 19;
            this.minReadingLabel.Text = "Мин:";
            // 
            // maxReadingLabel
            // 
            this.maxReadingLabel.AutoSize = true;
            this.maxReadingLabel.Location = new System.Drawing.Point(227, 47);
            this.maxReadingLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.maxReadingLabel.Name = "maxReadingLabel";
            this.maxReadingLabel.Size = new System.Drawing.Size(37, 13);
            this.maxReadingLabel.TabIndex = 20;
            this.maxReadingLabel.Text = "Макс:";
            // 
            // averageReadingLabel
            // 
            this.averageReadingLabel.AutoSize = true;
            this.averageReadingLabel.Location = new System.Drawing.Point(14, 22);
            this.averageReadingLabel.Name = "averageReadingLabel";
            this.averageReadingLabel.Size = new System.Drawing.Size(76, 13);
            this.averageReadingLabel.TabIndex = 15;
            this.averageReadingLabel.Text = "Ср. значение:";
            // 
            // averageReadingTextBox
            // 
            this.averageReadingTextBox.Location = new System.Drawing.Point(96, 19);
            this.averageReadingTextBox.Name = "averageReadingTextBox";
            this.averageReadingTextBox.ReadOnly = true;
            this.averageReadingTextBox.Size = new System.Drawing.Size(100, 20);
            this.averageReadingTextBox.TabIndex = 12;
            // 
            // actualRangeLabel
            // 
            this.actualRangeLabel.AutoSize = true;
            this.actualRangeLabel.Location = new System.Drawing.Point(201, 22);
            this.actualRangeLabel.Name = "actualRangeLabel";
            this.actualRangeLabel.Size = new System.Drawing.Size(61, 13);
            this.actualRangeLabel.TabIndex = 18;
            this.actualRangeLabel.Text = "Диапазон:";
            // 
            // actualRangeTextBox
            // 
            this.actualRangeTextBox.Location = new System.Drawing.Point(268, 19);
            this.actualRangeTextBox.Name = "actualRangeTextBox";
            this.actualRangeTextBox.ReadOnly = true;
            this.actualRangeTextBox.Size = new System.Drawing.Size(100, 20);
            this.actualRangeTextBox.TabIndex = 17;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.numDMMSamplesPerReading);
            this.groupBox5.Controls.Add(this.samplesPerReadingLabel);
            this.groupBox5.Controls.Add(this.txtDMMRange);
            this.groupBox5.Controls.Add(this.powerlineFrequencyLabel);
            this.groupBox5.Controls.Add(this.resolutionLabel);
            this.groupBox5.Controls.Add(this.rangeLabel);
            this.groupBox5.Controls.Add(this.cmbPowerlineFreq);
            this.groupBox5.Controls.Add(this.cmbDMMResolution);
            this.groupBox5.Location = new System.Drawing.Point(6, 109);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(374, 84);
            this.groupBox5.TabIndex = 9;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Конфигурация";
            // 
            // numDMMSamplesPerReading
            // 
            this.numDMMSamplesPerReading.Location = new System.Drawing.Point(112, 23);
            this.numDMMSamplesPerReading.Margin = new System.Windows.Forms.Padding(2);
            this.numDMMSamplesPerReading.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numDMMSamplesPerReading.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numDMMSamplesPerReading.Name = "numDMMSamplesPerReading";
            this.numDMMSamplesPerReading.Size = new System.Drawing.Size(70, 20);
            this.numDMMSamplesPerReading.TabIndex = 17;
            this.numDMMSamplesPerReading.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // samplesPerReadingLabel
            // 
            this.samplesPerReadingLabel.AutoSize = true;
            this.samplesPerReadingLabel.Location = new System.Drawing.Point(16, 26);
            this.samplesPerReadingLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.samplesPerReadingLabel.Name = "samplesPerReadingLabel";
            this.samplesPerReadingLabel.Size = new System.Drawing.Size(92, 13);
            this.samplesPerReadingLabel.TabIndex = 16;
            this.samplesPerReadingLabel.Text = "Точек на чтение:";
            // 
            // txtDMMRange
            // 
            this.txtDMMRange.Location = new System.Drawing.Point(299, 48);
            this.txtDMMRange.Name = "txtDMMRange";
            this.txtDMMRange.Size = new System.Drawing.Size(69, 20);
            this.txtDMMRange.TabIndex = 10;
            this.txtDMMRange.Text = "10";
            // 
            // powerlineFrequencyLabel
            // 
            this.powerlineFrequencyLabel.AutoSize = true;
            this.powerlineFrequencyLabel.Location = new System.Drawing.Point(1, 51);
            this.powerlineFrequencyLabel.Name = "powerlineFrequencyLabel";
            this.powerlineFrequencyLabel.Size = new System.Drawing.Size(107, 13);
            this.powerlineFrequencyLabel.TabIndex = 15;
            this.powerlineFrequencyLabel.Text = "Частота линии (Hz):";
            // 
            // resolutionLabel
            // 
            this.resolutionLabel.AutoSize = true;
            this.resolutionLabel.Location = new System.Drawing.Point(187, 25);
            this.resolutionLabel.Name = "resolutionLabel";
            this.resolutionLabel.Size = new System.Drawing.Size(106, 13);
            this.resolutionLabel.TabIndex = 14;
            this.resolutionLabel.Text = "Разрешение (digits):";
            // 
            // rangeLabel
            // 
            this.rangeLabel.AutoSize = true;
            this.rangeLabel.Location = new System.Drawing.Point(232, 51);
            this.rangeLabel.Name = "rangeLabel";
            this.rangeLabel.Size = new System.Drawing.Size(61, 13);
            this.rangeLabel.TabIndex = 13;
            this.rangeLabel.Text = "Диапазон:";
            // 
            // cmbPowerlineFreq
            // 
            this.cmbPowerlineFreq.FormattingEnabled = true;
            this.cmbPowerlineFreq.Location = new System.Drawing.Point(112, 48);
            this.cmbPowerlineFreq.Name = "cmbPowerlineFreq";
            this.cmbPowerlineFreq.Size = new System.Drawing.Size(69, 21);
            this.cmbPowerlineFreq.TabIndex = 12;
            // 
            // cmbDMMResolution
            // 
            this.cmbDMMResolution.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDMMResolution.FormattingEnabled = true;
            this.cmbDMMResolution.Location = new System.Drawing.Point(299, 22);
            this.cmbDMMResolution.Name = "cmbDMMResolution";
            this.cmbDMMResolution.Size = new System.Drawing.Size(69, 21);
            this.cmbDMMResolution.TabIndex = 11;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cmbDMMName);
            this.groupBox4.Controls.Add(this.measurementTypeLabel);
            this.groupBox4.Controls.Add(this.resourceNameLabel);
            this.groupBox4.Controls.Add(this.cmbMeasureDMMMode);
            this.groupBox4.Location = new System.Drawing.Point(6, 19);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(374, 84);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Выбор устройства и режим измерения";
            // 
            // cmbDMMName
            // 
            this.cmbDMMName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDMMName.FormattingEnabled = true;
            this.cmbDMMName.Location = new System.Drawing.Point(261, 19);
            this.cmbDMMName.Name = "cmbDMMName";
            this.cmbDMMName.Size = new System.Drawing.Size(107, 21);
            this.cmbDMMName.TabIndex = 4;
            // 
            // measurementTypeLabel
            // 
            this.measurementTypeLabel.AutoSize = true;
            this.measurementTypeLabel.Location = new System.Drawing.Point(151, 50);
            this.measurementTypeLabel.Name = "measurementTypeLabel";
            this.measurementTypeLabel.Size = new System.Drawing.Size(104, 13);
            this.measurementTypeLabel.TabIndex = 7;
            this.measurementTypeLabel.Text = "Режим измерения:";
            // 
            // resourceNameLabel
            // 
            this.resourceNameLabel.AutoSize = true;
            this.resourceNameLabel.Location = new System.Drawing.Point(109, 22);
            this.resourceNameLabel.Name = "resourceNameLabel";
            this.resourceNameLabel.Size = new System.Drawing.Size(146, 13);
            this.resourceNameLabel.TabIndex = 6;
            this.resourceNameLabel.Text = "Наименование устройства:";
            // 
            // cmbMeasureDMMMode
            // 
            this.cmbMeasureDMMMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMeasureDMMMode.FormattingEnabled = true;
            this.cmbMeasureDMMMode.Location = new System.Drawing.Point(261, 47);
            this.cmbMeasureDMMMode.Name = "cmbMeasureDMMMode";
            this.cmbMeasureDMMMode.Size = new System.Drawing.Size(107, 21);
            this.cmbMeasureDMMMode.TabIndex = 5;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.statusAllDevices);
            this.groupBox3.Controls.Add(this.dataDeviceAttributes);
            this.groupBox3.Controls.Add(this.listDevices);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.cmbDrivers);
            this.groupBox3.Location = new System.Drawing.Point(796, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(386, 447);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Все устройства";
            // 
            // statusAllDevices
            // 
            this.statusAllDevices.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.txtDeviceStatus});
            this.statusAllDevices.Location = new System.Drawing.Point(3, 422);
            this.statusAllDevices.Name = "statusAllDevices";
            this.statusAllDevices.Size = new System.Drawing.Size(380, 22);
            this.statusAllDevices.TabIndex = 4;
            this.statusAllDevices.Text = "statusStrip1";
            // 
            // txtDeviceStatus
            // 
            this.txtDeviceStatus.Name = "txtDeviceStatus";
            this.txtDeviceStatus.Size = new System.Drawing.Size(0, 17);
            // 
            // dataDeviceAttributes
            // 
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.CadetBlue;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            this.dataDeviceAttributes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataDeviceAttributes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataDeviceAttributes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataDeviceAttributes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataDeviceAttributes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataDeviceAttributes.Location = new System.Drawing.Point(6, 202);
            this.dataDeviceAttributes.Name = "dataDeviceAttributes";
            this.dataDeviceAttributes.Size = new System.Drawing.Size(374, 217);
            this.dataDeviceAttributes.TabIndex = 3;
            // 
            // listDevices
            // 
            this.listDevices.FormattingEnabled = true;
            this.listDevices.Location = new System.Drawing.Point(6, 49);
            this.listDevices.Name = "listDevices";
            this.listDevices.Size = new System.Drawing.Size(374, 147);
            this.listDevices.TabIndex = 2;
            this.listDevices.SelectedIndexChanged += new System.EventHandler(this.listDevices_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(147, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Тип драйвера";
            // 
            // cmbDrivers
            // 
            this.cmbDrivers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDrivers.FormattingEnabled = true;
            this.cmbDrivers.Location = new System.Drawing.Point(230, 22);
            this.cmbDrivers.Name = "cmbDrivers";
            this.cmbDrivers.Size = new System.Drawing.Size(150, 21);
            this.cmbDrivers.TabIndex = 0;
            this.cmbDrivers.SelectedIndexChanged += new System.EventHandler(this.cmbDrivers_SelectedIndexChanged);
            // 
            // tmr
            // 
            this.tmr.Interval = 1000;
            this.tmr.Tick += new System.EventHandler(this.tmr_Tick);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.btnRelayDisconnect);
            this.groupBox7.Controls.Add(this.btnRelayConnect);
            this.groupBox7.Controls.Add(this.panelSwitch);
            this.groupBox7.Controls.Add(this.topologyNameLabel);
            this.groupBox7.Controls.Add(this.cmbTopology);
            this.groupBox7.Controls.Add(this.label2);
            this.groupBox7.Controls.Add(this.cmbSwitch);
            this.groupBox7.Location = new System.Drawing.Point(12, 465);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(1170, 239);
            this.groupBox7.TabIndex = 3;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "NI-SWITCH";
            // 
            // topologyNameLabel
            // 
            this.topologyNameLabel.AutoSize = true;
            this.topologyNameLabel.Location = new System.Drawing.Point(302, 22);
            this.topologyNameLabel.Name = "topologyNameLabel";
            this.topologyNameLabel.Size = new System.Drawing.Size(61, 13);
            this.topologyNameLabel.TabIndex = 10;
            this.topologyNameLabel.Text = "Топология";
            // 
            // cmbTopology
            // 
            this.cmbTopology.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTopology.FormattingEnabled = true;
            this.cmbTopology.Location = new System.Drawing.Point(369, 19);
            this.cmbTopology.Name = "cmbTopology";
            this.cmbTopology.Size = new System.Drawing.Size(409, 21);
            this.cmbTopology.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Блок реле";
            // 
            // cmbSwitch
            // 
            this.cmbSwitch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSwitch.FormattingEnabled = true;
            this.cmbSwitch.Location = new System.Drawing.Point(108, 19);
            this.cmbSwitch.Name = "cmbSwitch";
            this.cmbSwitch.Size = new System.Drawing.Size(121, 21);
            this.cmbSwitch.TabIndex = 7;
            // 
            // panelSwitch
            // 
            this.panelSwitch.Enabled = false;
            this.panelSwitch.Location = new System.Drawing.Point(6, 46);
            this.panelSwitch.Name = "panelSwitch";
            this.panelSwitch.Size = new System.Drawing.Size(1158, 186);
            this.panelSwitch.TabIndex = 11;
            // 
            // btnRelayConnect
            // 
            this.btnRelayConnect.Location = new System.Drawing.Point(784, 17);
            this.btnRelayConnect.Name = "btnRelayConnect";
            this.btnRelayConnect.Size = new System.Drawing.Size(75, 23);
            this.btnRelayConnect.TabIndex = 12;
            this.btnRelayConnect.Text = "Соединить";
            this.btnRelayConnect.UseVisualStyleBackColor = true;
            this.btnRelayConnect.Click += new System.EventHandler(this.btnRelayConnect_Click);
            // 
            // btnRelayDisconnect
            // 
            this.btnRelayDisconnect.Enabled = false;
            this.btnRelayDisconnect.Location = new System.Drawing.Point(1089, 17);
            this.btnRelayDisconnect.Name = "btnRelayDisconnect";
            this.btnRelayDisconnect.Size = new System.Drawing.Size(75, 23);
            this.btnRelayDisconnect.TabIndex = 12;
            this.btnRelayDisconnect.Text = "Отключить";
            this.btnRelayDisconnect.UseVisualStyleBackColor = true;
            this.btnRelayDisconnect.Click += new System.EventHandler(this.btnRelayDisconnect_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1192, 713);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.Text = "DC-Power And Digital Multimeter Application";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.grpConfigDCPowerIVI.ResumeLayout(false);
            this.grpConfigDCPowerIVI.PerformLayout();
            this.statusStripDC.ResumeLayout(false);
            this.statusStripDC.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.switchDCOutput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.knobVoltageLevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCurrentLimit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numVoltageLevel)).EndInit();
            this.grpInitIVIDCPower.ResumeLayout(false);
            this.grpInitIVIDCPower.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.switchDMM)).EndInit();
            this.statusStripDMM.ResumeLayout(false);
            this.statusStripDMM.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.meterDMM)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDMMSamplesPerReading)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.statusAllDevices.ResumeLayout(false);
            this.statusAllDevices.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataDeviceAttributes)).EndInit();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataDeviceAttributes;
        private System.Windows.Forms.ListBox listDevices;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbDrivers;
        private System.Windows.Forms.StatusStrip statusAllDevices;
        private System.Windows.Forms.ToolStripStatusLabel txtDeviceStatus;
        private System.Windows.Forms.GroupBox grpInitIVIDCPower;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtIVIDeviceName;
        private System.Windows.Forms.GroupBox grpConfigDCPowerIVI;
        private System.Windows.Forms.Button btnCloseIVIDCPower;
        private System.Windows.Forms.CheckBox chkResetDevice;
        private System.Windows.Forms.CheckBox chkIdQuery;
        private System.Windows.Forms.Button btnInitIVIDCPower;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label voltageLevelLabel;
        private System.Windows.Forms.NumericUpDown numCurrentLimit;
        private System.Windows.Forms.NumericUpDown numVoltageLevel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbChannelIVI;
        private NationalInstruments.UI.WindowsForms.Knob knobVoltageLevel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbCurrentLimitBehavior;
        private NationalInstruments.UI.WindowsForms.Switch switchDCOutput;
        private System.Windows.Forms.StatusStrip statusStripDC;
        private System.Windows.Forms.ToolStripStatusLabel txtDCStatus;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox cmbDMMName;
        private System.Windows.Forms.Label measurementTypeLabel;
        private System.Windows.Forms.Label resourceNameLabel;
        private System.Windows.Forms.ComboBox cmbMeasureDMMMode;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.NumericUpDown numDMMSamplesPerReading;
        private System.Windows.Forms.Label samplesPerReadingLabel;
        private System.Windows.Forms.TextBox txtDMMRange;
        private System.Windows.Forms.Label powerlineFrequencyLabel;
        private System.Windows.Forms.Label resolutionLabel;
        private System.Windows.Forms.Label rangeLabel;
        private System.Windows.Forms.ComboBox cmbPowerlineFreq;
        private System.Windows.Forms.ComboBox cmbDMMResolution;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.StatusStrip statusStripDMM;
        private System.Windows.Forms.ToolStripStatusLabel txtDMMStatus;
        private System.Windows.Forms.TextBox txtDMMTotalSamples;
        private System.Windows.Forms.Label numberOfSamplesLabel;
        private NationalInstruments.UI.WindowsForms.Meter meterDMM;
        private System.Windows.Forms.TextBox maxReadingTextBox;
        private System.Windows.Forms.TextBox minReadingTextBox;
        private System.Windows.Forms.Label minReadingLabel;
        private System.Windows.Forms.Label maxReadingLabel;
        private System.Windows.Forms.Label averageReadingLabel;
        private System.Windows.Forms.TextBox averageReadingTextBox;
        private System.Windows.Forms.Label actualRangeLabel;
        private System.Windows.Forms.TextBox actualRangeTextBox;
        private NationalInstruments.UI.WindowsForms.Switch switchDMM;
        private System.Windows.Forms.Timer tmr;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Panel panelSwitch;
        private System.Windows.Forms.Label topologyNameLabel;
        private System.Windows.Forms.ComboBox cmbTopology;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbSwitch;
        private System.Windows.Forms.Button btnRelayDisconnect;
        private System.Windows.Forms.Button btnRelayConnect;
    }
}

