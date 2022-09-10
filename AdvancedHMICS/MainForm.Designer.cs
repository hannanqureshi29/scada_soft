namespace AdvancedHMICS
{
    partial class MainForm
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
            AdvancedHMIDrivers.ModbusTCPCom FATEK;
            AdvancedHMIDrivers.ModbusTCPCom modbusTCPCom1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.button1 = new System.Windows.Forms.Button();
            this.analogValueDisplay12 = new AdvancedHMIControls.AnalogValueDisplay();
            this.rtd_1 = new AdvancedHMIControls.AnalogValueDisplay();
            this.USR_2 = new AdvancedHMIDrivers.ModbusTCPCom(this.components);
            this.analogValueDisplay21 = new AdvancedHMIControls.AnalogValueDisplay();
            this.analogValueDisplay9 = new AdvancedHMIControls.AnalogValueDisplay();
            this.basicIndicator9 = new AdvancedHMIControls.BasicIndicator();
            this.PLC1 = new AdvancedHMIDrivers.ModbusTCPCom(this.components);
            this.basicIndicator8 = new AdvancedHMIControls.BasicIndicator();
            this.analogValueDisplay7 = new AdvancedHMIControls.AnalogValueDisplay();
            this.analogValueDisplay6 = new AdvancedHMIControls.AnalogValueDisplay();
            this.analogValueDisplay4 = new AdvancedHMIControls.AnalogValueDisplay();
            this.analogValueDisplay2 = new AdvancedHMIControls.AnalogValueDisplay();
            this.analogValueDisplay1 = new AdvancedHMIControls.AnalogValueDisplay();
            this.basicIndicator5 = new AdvancedHMIControls.BasicIndicator();
            this.basicButton1 = new AdvancedHMIControls.BasicButton();
            this.analogValueDisplay3 = new AdvancedHMIControls.AnalogValueDisplay();
            this.azbil_com = new AdvancedHMIDrivers.ModbusTCPCom(this.components);
            this.dataSubscriber1 = new AdvancedHMIControls.DataSubscriber(this.components);
            this.rtd_2 = new AdvancedHMIControls.AnalogValueDisplay();
            this.rtd_3 = new AdvancedHMIControls.AnalogValueDisplay();
            this.analogValueDisplay16 = new AdvancedHMIControls.AnalogValueDisplay();
            this.analogValueDisplay17 = new AdvancedHMIControls.AnalogValueDisplay();
            this.lbl_result = new System.Windows.Forms.Label();
            this.lbl_1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.lable1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.temp_k1 = new System.Windows.Forms.Label();
            this.temp_k2 = new System.Windows.Forms.Label();
            this.temp_k3 = new System.Windows.Forms.Label();
            this.resis_1 = new System.Windows.Forms.Label();
            this.resis_2 = new System.Windows.Forms.Label();
            this.resis_3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.basicDataLogger1 = new AdvancedHMIControls.BasicDataLogger();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.door_2 = new AdvancedHMIControls.AnalogValueDisplay();
            this.door_1 = new AdvancedHMIControls.AnalogValueDisplay();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.button3 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            this.button4 = new System.Windows.Forms.Button();
            FATEK = new AdvancedHMIDrivers.ModbusTCPCom(this.components);
            modbusTCPCom1 = new AdvancedHMIDrivers.ModbusTCPCom(this.components);
            ((System.ComponentModel.ISupportInitialize)(FATEK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(modbusTCPCom1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.USR_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PLC1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.azbil_com)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSubscriber1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.basicDataLogger1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // FATEK
            // 
            FATEK.DisableSubscriptions = false;
            FATEK.IniFileName = "";
            FATEK.IniFileSection = null;
            FATEK.IPAddress = "192.168.2.3";
            FATEK.MaxReadGroupSize = 20;
            FATEK.PollRateOverride = 500;
            FATEK.SwapBytes = true;
            FATEK.SwapWords = false;
            FATEK.TcpipPort = ((ushort)(502));
            FATEK.TimeOut = 3000;
            FATEK.UnitId = ((byte)(1));
            // 
            // modbusTCPCom1
            // 
            modbusTCPCom1.DisableSubscriptions = false;
            modbusTCPCom1.IniFileName = "";
            modbusTCPCom1.IniFileSection = null;
            modbusTCPCom1.IPAddress = "192.168.2.21";
            modbusTCPCom1.MaxReadGroupSize = 200;
            modbusTCPCom1.PollRateOverride = 500;
            modbusTCPCom1.SwapBytes = false;
            modbusTCPCom1.SwapWords = false;
            modbusTCPCom1.TcpipPort = ((ushort)(504));
            modbusTCPCom1.TimeOut = 6000;
            modbusTCPCom1.UnitId = ((byte)(1));
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gray;
            this.button1.Location = new System.Drawing.Point(-375, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(207, 102);
            this.button1.TabIndex = 70;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // analogValueDisplay12
            // 
            this.analogValueDisplay12.AutoSize = true;
            this.analogValueDisplay12.BackColor = System.Drawing.Color.Gray;
            this.analogValueDisplay12.ComComponent = FATEK;
            this.analogValueDisplay12.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.analogValueDisplay12.ForeColor = System.Drawing.Color.Black;
            this.analogValueDisplay12.ForeColorInLimits = System.Drawing.Color.Black;
            this.analogValueDisplay12.ForeColorOverLimit = System.Drawing.Color.Red;
            this.analogValueDisplay12.ForeColorUnderLimit = System.Drawing.Color.Yellow;
            this.analogValueDisplay12.KeypadFontColor = System.Drawing.Color.WhiteSmoke;
            this.analogValueDisplay12.KeypadMaxValue = 0D;
            this.analogValueDisplay12.KeypadMinValue = 0D;
            this.analogValueDisplay12.KeypadPasscode = null;
            this.analogValueDisplay12.KeypadScaleFactor = 1D;
            this.analogValueDisplay12.KeypadText = null;
            this.analogValueDisplay12.KeypadWidth = 300;
            this.analogValueDisplay12.Location = new System.Drawing.Point(540, 374);
            this.analogValueDisplay12.Name = "analogValueDisplay12";
            this.analogValueDisplay12.NumericFormat = null;
            this.analogValueDisplay12.PLCAddressKeypad = "";
            this.analogValueDisplay12.PLCAddressValue = ((MfgControl.AdvancedHMI.Drivers.PLCAddressItem)(resources.GetObject("analogValueDisplay12.PLCAddressValue")));
            this.analogValueDisplay12.PLCAddressValueLimitLower = null;
            this.analogValueDisplay12.PLCAddressValueLimitUpper = null;
            this.analogValueDisplay12.PLCAddressVisible = null;
            this.analogValueDisplay12.ShowValue = true;
            this.analogValueDisplay12.Size = new System.Drawing.Size(79, 33);
            this.analogValueDisplay12.SuppressErrorDisplay = true;
            this.analogValueDisplay12.TabIndex = 1519;
            this.analogValueDisplay12.Text = "0000";
            this.analogValueDisplay12.Value = "0000";
            this.analogValueDisplay12.ValueLimitLower = -999999D;
            this.analogValueDisplay12.ValueLimitUpper = 99999999D;
            this.analogValueDisplay12.ValuePrefix = null;
            this.analogValueDisplay12.ValueSuffix = null;
            this.analogValueDisplay12.VisibleControl = AdvancedHMIControls.AnalogValueDisplay.VisibleControlEnum.Always;
            // 
            // rtd_1
            // 
            this.rtd_1.AutoSize = true;
            this.rtd_1.BackColor = System.Drawing.Color.Gray;
            this.rtd_1.ComComponent = FATEK;
            this.rtd_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtd_1.ForeColor = System.Drawing.Color.Black;
            this.rtd_1.ForeColorInLimits = System.Drawing.Color.Black;
            this.rtd_1.ForeColorOverLimit = System.Drawing.Color.Red;
            this.rtd_1.ForeColorUnderLimit = System.Drawing.Color.Yellow;
            this.rtd_1.KeypadFontColor = System.Drawing.Color.WhiteSmoke;
            this.rtd_1.KeypadMaxValue = 0D;
            this.rtd_1.KeypadMinValue = 0D;
            this.rtd_1.KeypadPasscode = null;
            this.rtd_1.KeypadScaleFactor = 1D;
            this.rtd_1.KeypadText = null;
            this.rtd_1.KeypadWidth = 300;
            this.rtd_1.Location = new System.Drawing.Point(416, 374);
            this.rtd_1.Name = "rtd_1";
            this.rtd_1.NumericFormat = null;
            this.rtd_1.PLCAddressKeypad = "";
            this.rtd_1.PLCAddressValue = ((MfgControl.AdvancedHMI.Drivers.PLCAddressItem)(resources.GetObject("rtd_1.PLCAddressValue")));
            this.rtd_1.PLCAddressValueLimitLower = null;
            this.rtd_1.PLCAddressValueLimitUpper = null;
            this.rtd_1.PLCAddressVisible = null;
            this.rtd_1.ShowValue = true;
            this.rtd_1.Size = new System.Drawing.Size(79, 33);
            this.rtd_1.SuppressErrorDisplay = true;
            this.rtd_1.TabIndex = 1518;
            this.rtd_1.Text = "0000";
            this.rtd_1.Value = "0000";
            this.rtd_1.ValueLimitLower = -999999D;
            this.rtd_1.ValueLimitUpper = 99999999D;
            this.rtd_1.ValuePrefix = null;
            this.rtd_1.ValueSuffix = null;
            this.rtd_1.VisibleControl = AdvancedHMIControls.AnalogValueDisplay.VisibleControlEnum.Always;
            this.rtd_1.ValueChanged += new System.EventHandler(this.rtd_1_ValueChanged);
            this.rtd_1.Click += new System.EventHandler(this.analogValueDisplay12_Click);
            // 
            // USR_2
            // 
            this.USR_2.DisableSubscriptions = false;
            this.USR_2.IniFileName = "";
            this.USR_2.IniFileSection = null;
            this.USR_2.IPAddress = "192.168.2.21";
            this.USR_2.MaxReadGroupSize = 200;
            this.USR_2.PollRateOverride = 500;
            this.USR_2.SwapBytes = false;
            this.USR_2.SwapWords = true;
            this.USR_2.TcpipPort = ((ushort)(6));
            this.USR_2.TimeOut = 60000;
            this.USR_2.UnitId = ((byte)(1));
            this.USR_2.DataReceived += new System.EventHandler<MfgControl.AdvancedHMI.Drivers.Common.PlcComEventArgs>(this.USR_2_DataReceived);
            // 
            // analogValueDisplay21
            // 
            this.analogValueDisplay21.AutoSize = true;
            this.analogValueDisplay21.BackColor = System.Drawing.Color.Gray;
            this.analogValueDisplay21.ComComponent = FATEK;
            this.analogValueDisplay21.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.analogValueDisplay21.ForeColor = System.Drawing.Color.White;
            this.analogValueDisplay21.ForeColorInLimits = System.Drawing.Color.Black;
            this.analogValueDisplay21.ForeColorOverLimit = System.Drawing.Color.Red;
            this.analogValueDisplay21.ForeColorUnderLimit = System.Drawing.Color.Yellow;
            this.analogValueDisplay21.KeypadFontColor = System.Drawing.Color.WhiteSmoke;
            this.analogValueDisplay21.KeypadMaxValue = 0D;
            this.analogValueDisplay21.KeypadMinValue = 0D;
            this.analogValueDisplay21.KeypadPasscode = null;
            this.analogValueDisplay21.KeypadScaleFactor = 1D;
            this.analogValueDisplay21.KeypadText = null;
            this.analogValueDisplay21.KeypadWidth = 300;
            this.analogValueDisplay21.Location = new System.Drawing.Point(-106, 375);
            this.analogValueDisplay21.Name = "analogValueDisplay21";
            this.analogValueDisplay21.NumericFormat = null;
            this.analogValueDisplay21.PLCAddressKeypad = "";
            this.analogValueDisplay21.PLCAddressValue = ((MfgControl.AdvancedHMI.Drivers.PLCAddressItem)(resources.GetObject("analogValueDisplay21.PLCAddressValue")));
            this.analogValueDisplay21.PLCAddressValueLimitLower = null;
            this.analogValueDisplay21.PLCAddressValueLimitUpper = null;
            this.analogValueDisplay21.PLCAddressVisible = null;
            this.analogValueDisplay21.ShowValue = true;
            this.analogValueDisplay21.Size = new System.Drawing.Size(45, 20);
            this.analogValueDisplay21.TabIndex = 921;
            this.analogValueDisplay21.Text = "0000";
            this.analogValueDisplay21.Value = "0000";
            this.analogValueDisplay21.ValueLimitLower = -999999D;
            this.analogValueDisplay21.ValueLimitUpper = 999999D;
            this.analogValueDisplay21.ValuePrefix = null;
            this.analogValueDisplay21.ValueSuffix = null;
            this.analogValueDisplay21.VisibleControl = AdvancedHMIControls.AnalogValueDisplay.VisibleControlEnum.Always;
            // 
            // analogValueDisplay9
            // 
            this.analogValueDisplay9.AutoSize = true;
            this.analogValueDisplay9.BackColor = System.Drawing.Color.Gray;
            this.analogValueDisplay9.ComComponent = FATEK;
            this.analogValueDisplay9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.analogValueDisplay9.ForeColor = System.Drawing.Color.Black;
            this.analogValueDisplay9.ForeColorInLimits = System.Drawing.Color.Black;
            this.analogValueDisplay9.ForeColorOverLimit = System.Drawing.Color.Red;
            this.analogValueDisplay9.ForeColorUnderLimit = System.Drawing.Color.Yellow;
            this.analogValueDisplay9.KeypadFontColor = System.Drawing.Color.WhiteSmoke;
            this.analogValueDisplay9.KeypadMaxValue = 0D;
            this.analogValueDisplay9.KeypadMinValue = 0D;
            this.analogValueDisplay9.KeypadPasscode = null;
            this.analogValueDisplay9.KeypadScaleFactor = 1D;
            this.analogValueDisplay9.KeypadText = null;
            this.analogValueDisplay9.KeypadWidth = 300;
            this.analogValueDisplay9.Location = new System.Drawing.Point(-228, 361);
            this.analogValueDisplay9.Name = "analogValueDisplay9";
            this.analogValueDisplay9.NumericFormat = null;
            this.analogValueDisplay9.PLCAddressKeypad = "";
            this.analogValueDisplay9.PLCAddressValue = ((MfgControl.AdvancedHMI.Drivers.PLCAddressItem)(resources.GetObject("analogValueDisplay9.PLCAddressValue")));
            this.analogValueDisplay9.PLCAddressValueLimitLower = null;
            this.analogValueDisplay9.PLCAddressValueLimitUpper = null;
            this.analogValueDisplay9.PLCAddressVisible = null;
            this.analogValueDisplay9.ShowValue = true;
            this.analogValueDisplay9.Size = new System.Drawing.Size(45, 20);
            this.analogValueDisplay9.TabIndex = 919;
            this.analogValueDisplay9.Text = "0000";
            this.analogValueDisplay9.Value = "0000";
            this.analogValueDisplay9.ValueLimitLower = -999999D;
            this.analogValueDisplay9.ValueLimitUpper = 999999D;
            this.analogValueDisplay9.ValuePrefix = null;
            this.analogValueDisplay9.ValueSuffix = null;
            this.analogValueDisplay9.VisibleControl = AdvancedHMIControls.AnalogValueDisplay.VisibleControlEnum.Always;
            // 
            // basicIndicator9
            // 
            this.basicIndicator9.Color1 = System.Drawing.Color.DarkGray;
            this.basicIndicator9.Color2 = System.Drawing.Color.Green;
            this.basicIndicator9.Color3 = System.Drawing.Color.Red;
            this.basicIndicator9.ComComponent = this.PLC1;
            this.basicIndicator9.Location = new System.Drawing.Point(-115, 150);
            this.basicIndicator9.Name = "basicIndicator9";
            this.basicIndicator9.OutlineColor = System.Drawing.Color.Transparent;
            this.basicIndicator9.OutlineWidth = 1;
            this.basicIndicator9.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet;
            this.basicIndicator9.PLCAddressSelectColor2 = "10002";
            this.basicIndicator9.SelectColor2 = false;
            this.basicIndicator9.SelectColor3 = false;
            this.basicIndicator9.Shape = MfgControl.AdvancedHMI.Controls.Indicator.ShapeTypes.Round;
            this.basicIndicator9.Size = new System.Drawing.Size(115, 105);
            this.basicIndicator9.TabIndex = 900;
            // 
            // PLC1
            // 
            this.PLC1.DisableSubscriptions = false;
            this.PLC1.IniFileName = "";
            this.PLC1.IniFileSection = null;
            this.PLC1.IPAddress = "192.168.0.1";
            this.PLC1.MaxReadGroupSize = 20;
            this.PLC1.PollRateOverride = 500;
            this.PLC1.SwapBytes = true;
            this.PLC1.SwapWords = false;
            this.PLC1.TcpipPort = ((ushort)(502));
            this.PLC1.TimeOut = 3000;
            this.PLC1.UnitId = ((byte)(1));
            this.PLC1.ConnectionEstablished += new System.EventHandler(this.PLC1_ConnectionEstablished);
            // 
            // basicIndicator8
            // 
            this.basicIndicator8.Color1 = System.Drawing.Color.DarkGray;
            this.basicIndicator8.Color2 = System.Drawing.Color.Green;
            this.basicIndicator8.Color3 = System.Drawing.Color.Red;
            this.basicIndicator8.ComComponent = this.PLC1;
            this.basicIndicator8.Location = new System.Drawing.Point(-115, 31);
            this.basicIndicator8.Name = "basicIndicator8";
            this.basicIndicator8.OutlineColor = System.Drawing.Color.Transparent;
            this.basicIndicator8.OutlineWidth = 1;
            this.basicIndicator8.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet;
            this.basicIndicator8.PLCAddressSelectColor2 = "10001";
            this.basicIndicator8.SelectColor2 = false;
            this.basicIndicator8.SelectColor3 = false;
            this.basicIndicator8.Shape = MfgControl.AdvancedHMI.Controls.Indicator.ShapeTypes.Round;
            this.basicIndicator8.Size = new System.Drawing.Size(115, 105);
            this.basicIndicator8.TabIndex = 899;
            this.basicIndicator8.Click += new System.EventHandler(this.basicIndicator8_Click);
            // 
            // analogValueDisplay7
            // 
            this.analogValueDisplay7.AutoSize = true;
            this.analogValueDisplay7.BackColor = System.Drawing.Color.Gray;
            this.analogValueDisplay7.ComComponent = FATEK;
            this.analogValueDisplay7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.analogValueDisplay7.ForeColor = System.Drawing.Color.White;
            this.analogValueDisplay7.ForeColorInLimits = System.Drawing.Color.Black;
            this.analogValueDisplay7.ForeColorOverLimit = System.Drawing.Color.Red;
            this.analogValueDisplay7.ForeColorUnderLimit = System.Drawing.Color.Yellow;
            this.analogValueDisplay7.KeypadFontColor = System.Drawing.Color.WhiteSmoke;
            this.analogValueDisplay7.KeypadMaxValue = 0D;
            this.analogValueDisplay7.KeypadMinValue = 0D;
            this.analogValueDisplay7.KeypadPasscode = null;
            this.analogValueDisplay7.KeypadScaleFactor = 1D;
            this.analogValueDisplay7.KeypadText = null;
            this.analogValueDisplay7.KeypadWidth = 300;
            this.analogValueDisplay7.Location = new System.Drawing.Point(-264, 195);
            this.analogValueDisplay7.Name = "analogValueDisplay7";
            this.analogValueDisplay7.NumericFormat = null;
            this.analogValueDisplay7.PLCAddressKeypad = "";
            this.analogValueDisplay7.PLCAddressValue = ((MfgControl.AdvancedHMI.Drivers.PLCAddressItem)(resources.GetObject("analogValueDisplay7.PLCAddressValue")));
            this.analogValueDisplay7.PLCAddressValueLimitLower = null;
            this.analogValueDisplay7.PLCAddressValueLimitUpper = null;
            this.analogValueDisplay7.PLCAddressVisible = null;
            this.analogValueDisplay7.ShowValue = true;
            this.analogValueDisplay7.Size = new System.Drawing.Size(45, 20);
            this.analogValueDisplay7.TabIndex = 898;
            this.analogValueDisplay7.Text = "0000";
            this.analogValueDisplay7.Value = "0000";
            this.analogValueDisplay7.ValueLimitLower = -999999D;
            this.analogValueDisplay7.ValueLimitUpper = 999999D;
            this.analogValueDisplay7.ValuePrefix = null;
            this.analogValueDisplay7.ValueSuffix = null;
            this.analogValueDisplay7.VisibleControl = AdvancedHMIControls.AnalogValueDisplay.VisibleControlEnum.Always;
            this.analogValueDisplay7.Click += new System.EventHandler(this.analogValueDisplay7_Click);
            // 
            // analogValueDisplay6
            // 
            this.analogValueDisplay6.AutoSize = true;
            this.analogValueDisplay6.BackColor = System.Drawing.Color.Gray;
            this.analogValueDisplay6.ComComponent = this.PLC1;
            this.analogValueDisplay6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.analogValueDisplay6.ForeColor = System.Drawing.Color.White;
            this.analogValueDisplay6.ForeColorInLimits = System.Drawing.Color.Black;
            this.analogValueDisplay6.ForeColorOverLimit = System.Drawing.Color.Red;
            this.analogValueDisplay6.ForeColorUnderLimit = System.Drawing.Color.Yellow;
            this.analogValueDisplay6.KeypadFontColor = System.Drawing.Color.WhiteSmoke;
            this.analogValueDisplay6.KeypadMaxValue = 0D;
            this.analogValueDisplay6.KeypadMinValue = 0D;
            this.analogValueDisplay6.KeypadPasscode = null;
            this.analogValueDisplay6.KeypadScaleFactor = 1D;
            this.analogValueDisplay6.KeypadText = null;
            this.analogValueDisplay6.KeypadWidth = 300;
            this.analogValueDisplay6.Location = new System.Drawing.Point(-264, 220);
            this.analogValueDisplay6.Name = "analogValueDisplay6";
            this.analogValueDisplay6.NumericFormat = null;
            this.analogValueDisplay6.PLCAddressKeypad = "";
            this.analogValueDisplay6.PLCAddressValue = ((MfgControl.AdvancedHMI.Drivers.PLCAddressItem)(resources.GetObject("analogValueDisplay6.PLCAddressValue")));
            this.analogValueDisplay6.PLCAddressValueLimitLower = null;
            this.analogValueDisplay6.PLCAddressValueLimitUpper = null;
            this.analogValueDisplay6.PLCAddressVisible = null;
            this.analogValueDisplay6.ShowValue = true;
            this.analogValueDisplay6.Size = new System.Drawing.Size(45, 20);
            this.analogValueDisplay6.TabIndex = 104;
            this.analogValueDisplay6.Text = "0000";
            this.analogValueDisplay6.Value = "0000";
            this.analogValueDisplay6.ValueLimitLower = -999999D;
            this.analogValueDisplay6.ValueLimitUpper = 999999D;
            this.analogValueDisplay6.ValuePrefix = null;
            this.analogValueDisplay6.ValueSuffix = null;
            this.analogValueDisplay6.VisibleControl = AdvancedHMIControls.AnalogValueDisplay.VisibleControlEnum.Always;
            this.analogValueDisplay6.Click += new System.EventHandler(this.analogValueDisplay6_Click);
            // 
            // analogValueDisplay4
            // 
            this.analogValueDisplay4.AutoSize = true;
            this.analogValueDisplay4.BackColor = System.Drawing.Color.Gray;
            this.analogValueDisplay4.ComComponent = this.PLC1;
            this.analogValueDisplay4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.analogValueDisplay4.ForeColor = System.Drawing.Color.White;
            this.analogValueDisplay4.ForeColorInLimits = System.Drawing.Color.Black;
            this.analogValueDisplay4.ForeColorOverLimit = System.Drawing.Color.Red;
            this.analogValueDisplay4.ForeColorUnderLimit = System.Drawing.Color.Yellow;
            this.analogValueDisplay4.KeypadFontColor = System.Drawing.Color.WhiteSmoke;
            this.analogValueDisplay4.KeypadMaxValue = 0D;
            this.analogValueDisplay4.KeypadMinValue = 0D;
            this.analogValueDisplay4.KeypadPasscode = null;
            this.analogValueDisplay4.KeypadScaleFactor = 1D;
            this.analogValueDisplay4.KeypadText = null;
            this.analogValueDisplay4.KeypadWidth = 300;
            this.analogValueDisplay4.Location = new System.Drawing.Point(-362, 156);
            this.analogValueDisplay4.Name = "analogValueDisplay4";
            this.analogValueDisplay4.NumericFormat = null;
            this.analogValueDisplay4.PLCAddressKeypad = "";
            this.analogValueDisplay4.PLCAddressValue = ((MfgControl.AdvancedHMI.Drivers.PLCAddressItem)(resources.GetObject("analogValueDisplay4.PLCAddressValue")));
            this.analogValueDisplay4.PLCAddressValueLimitLower = null;
            this.analogValueDisplay4.PLCAddressValueLimitUpper = null;
            this.analogValueDisplay4.PLCAddressVisible = null;
            this.analogValueDisplay4.ShowValue = true;
            this.analogValueDisplay4.Size = new System.Drawing.Size(45, 20);
            this.analogValueDisplay4.TabIndex = 98;
            this.analogValueDisplay4.Text = "0000";
            this.analogValueDisplay4.Value = "0000";
            this.analogValueDisplay4.ValueLimitLower = -999999D;
            this.analogValueDisplay4.ValueLimitUpper = 999999D;
            this.analogValueDisplay4.ValuePrefix = null;
            this.analogValueDisplay4.ValueSuffix = null;
            this.analogValueDisplay4.VisibleControl = AdvancedHMIControls.AnalogValueDisplay.VisibleControlEnum.Always;
            // 
            // analogValueDisplay2
            // 
            this.analogValueDisplay2.AutoSize = true;
            this.analogValueDisplay2.BackColor = System.Drawing.Color.Gray;
            this.analogValueDisplay2.ComComponent = this.PLC1;
            this.analogValueDisplay2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.analogValueDisplay2.ForeColor = System.Drawing.Color.White;
            this.analogValueDisplay2.ForeColorInLimits = System.Drawing.Color.Black;
            this.analogValueDisplay2.ForeColorOverLimit = System.Drawing.Color.Red;
            this.analogValueDisplay2.ForeColorUnderLimit = System.Drawing.Color.Yellow;
            this.analogValueDisplay2.KeypadFontColor = System.Drawing.Color.WhiteSmoke;
            this.analogValueDisplay2.KeypadMaxValue = 0D;
            this.analogValueDisplay2.KeypadMinValue = 0D;
            this.analogValueDisplay2.KeypadPasscode = null;
            this.analogValueDisplay2.KeypadScaleFactor = 1D;
            this.analogValueDisplay2.KeypadText = null;
            this.analogValueDisplay2.KeypadWidth = 300;
            this.analogValueDisplay2.Location = new System.Drawing.Point(-362, 136);
            this.analogValueDisplay2.Name = "analogValueDisplay2";
            this.analogValueDisplay2.NumericFormat = null;
            this.analogValueDisplay2.PLCAddressKeypad = "";
            this.analogValueDisplay2.PLCAddressValue = ((MfgControl.AdvancedHMI.Drivers.PLCAddressItem)(resources.GetObject("analogValueDisplay2.PLCAddressValue")));
            this.analogValueDisplay2.PLCAddressValueLimitLower = null;
            this.analogValueDisplay2.PLCAddressValueLimitUpper = null;
            this.analogValueDisplay2.PLCAddressVisible = null;
            this.analogValueDisplay2.ShowValue = true;
            this.analogValueDisplay2.Size = new System.Drawing.Size(45, 20);
            this.analogValueDisplay2.TabIndex = 97;
            this.analogValueDisplay2.Text = "0000";
            this.analogValueDisplay2.Value = "0000";
            this.analogValueDisplay2.ValueLimitLower = -999999D;
            this.analogValueDisplay2.ValueLimitUpper = 999999D;
            this.analogValueDisplay2.ValuePrefix = null;
            this.analogValueDisplay2.ValueSuffix = null;
            this.analogValueDisplay2.VisibleControl = AdvancedHMIControls.AnalogValueDisplay.VisibleControlEnum.Always;
            // 
            // analogValueDisplay1
            // 
            this.analogValueDisplay1.AutoSize = true;
            this.analogValueDisplay1.BackColor = System.Drawing.Color.Gray;
            this.analogValueDisplay1.ComComponent = this.PLC1;
            this.analogValueDisplay1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.analogValueDisplay1.ForeColor = System.Drawing.Color.White;
            this.analogValueDisplay1.ForeColorInLimits = System.Drawing.Color.Black;
            this.analogValueDisplay1.ForeColorOverLimit = System.Drawing.Color.Red;
            this.analogValueDisplay1.ForeColorUnderLimit = System.Drawing.Color.Yellow;
            this.analogValueDisplay1.KeypadFontColor = System.Drawing.Color.WhiteSmoke;
            this.analogValueDisplay1.KeypadMaxValue = 0D;
            this.analogValueDisplay1.KeypadMinValue = 0D;
            this.analogValueDisplay1.KeypadPasscode = null;
            this.analogValueDisplay1.KeypadScaleFactor = 1D;
            this.analogValueDisplay1.KeypadText = null;
            this.analogValueDisplay1.KeypadWidth = 300;
            this.analogValueDisplay1.Location = new System.Drawing.Point(-362, 116);
            this.analogValueDisplay1.Name = "analogValueDisplay1";
            this.analogValueDisplay1.NumericFormat = null;
            this.analogValueDisplay1.PLCAddressKeypad = "";
            this.analogValueDisplay1.PLCAddressValue = ((MfgControl.AdvancedHMI.Drivers.PLCAddressItem)(resources.GetObject("analogValueDisplay1.PLCAddressValue")));
            this.analogValueDisplay1.PLCAddressValueLimitLower = null;
            this.analogValueDisplay1.PLCAddressValueLimitUpper = null;
            this.analogValueDisplay1.PLCAddressVisible = null;
            this.analogValueDisplay1.ShowValue = true;
            this.analogValueDisplay1.Size = new System.Drawing.Size(45, 20);
            this.analogValueDisplay1.TabIndex = 96;
            this.analogValueDisplay1.Text = "0000";
            this.analogValueDisplay1.Value = "0000";
            this.analogValueDisplay1.ValueLimitLower = -999999D;
            this.analogValueDisplay1.ValueLimitUpper = 999999D;
            this.analogValueDisplay1.ValuePrefix = null;
            this.analogValueDisplay1.ValueSuffix = null;
            this.analogValueDisplay1.VisibleControl = AdvancedHMIControls.AnalogValueDisplay.VisibleControlEnum.Always;
            // 
            // basicIndicator5
            // 
            this.basicIndicator5.Color1 = System.Drawing.Color.DarkGray;
            this.basicIndicator5.Color2 = System.Drawing.Color.Green;
            this.basicIndicator5.Color3 = System.Drawing.Color.Red;
            this.basicIndicator5.ComComponent = this.PLC1;
            this.basicIndicator5.Location = new System.Drawing.Point(499, -66);
            this.basicIndicator5.Name = "basicIndicator5";
            this.basicIndicator5.OutlineColor = System.Drawing.Color.Transparent;
            this.basicIndicator5.OutlineWidth = 1;
            this.basicIndicator5.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet;
            this.basicIndicator5.SelectColor2 = false;
            this.basicIndicator5.SelectColor3 = false;
            this.basicIndicator5.Shape = MfgControl.AdvancedHMI.Controls.Indicator.ShapeTypes.Round;
            this.basicIndicator5.Size = new System.Drawing.Size(66, 65);
            this.basicIndicator5.TabIndex = 92;
            // 
            // basicButton1
            // 
            this.basicButton1.BackColor = System.Drawing.Color.Black;
            this.basicButton1.ComComponent = this.PLC1;
            this.basicButton1.ForeColor = System.Drawing.Color.Black;
            this.basicButton1.ForeColorAltername = System.Drawing.Color.Black;
            this.basicButton1.Highlight = false;
            this.basicButton1.HighlightColor = System.Drawing.Color.Green;
            this.basicButton1.Location = new System.Drawing.Point(390, -60);
            this.basicButton1.MaximumHoldTime = 3000;
            this.basicButton1.MinimumHoldTime = 500;
            this.basicButton1.Name = "basicButton1";
            this.basicButton1.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.Toggle;
            this.basicButton1.PLCAddressClick = "0001";
            this.basicButton1.SelectTextAlternate = false;
            this.basicButton1.Size = new System.Drawing.Size(75, 59);
            this.basicButton1.TabIndex = 91;
            this.basicButton1.Text = "ON/OFF";
            this.basicButton1.TextAlternate = null;
            this.basicButton1.UseVisualStyleBackColor = true;
            this.basicButton1.ValueToWrite = 0;
            this.basicButton1.Click += new System.EventHandler(this.basicButton1_Click);
            // 
            // analogValueDisplay3
            // 
            this.analogValueDisplay3.AutoSize = true;
            this.analogValueDisplay3.ComComponent = this.PLC1;
            this.analogValueDisplay3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.analogValueDisplay3.ForeColor = System.Drawing.Color.White;
            this.analogValueDisplay3.ForeColorInLimits = System.Drawing.Color.White;
            this.analogValueDisplay3.ForeColorOverLimit = System.Drawing.Color.Red;
            this.analogValueDisplay3.ForeColorUnderLimit = System.Drawing.Color.Yellow;
            this.analogValueDisplay3.KeypadFontColor = System.Drawing.Color.WhiteSmoke;
            this.analogValueDisplay3.KeypadMaxValue = 0D;
            this.analogValueDisplay3.KeypadMinValue = 0D;
            this.analogValueDisplay3.KeypadPasscode = null;
            this.analogValueDisplay3.KeypadScaleFactor = 1D;
            this.analogValueDisplay3.KeypadText = null;
            this.analogValueDisplay3.KeypadWidth = 300;
            this.analogValueDisplay3.Location = new System.Drawing.Point(435, -169);
            this.analogValueDisplay3.Name = "analogValueDisplay3";
            this.analogValueDisplay3.NumericFormat = null;
            this.analogValueDisplay3.PLCAddressKeypad = "";
            this.analogValueDisplay3.PLCAddressValue = null;
            this.analogValueDisplay3.PLCAddressValueLimitLower = null;
            this.analogValueDisplay3.PLCAddressValueLimitUpper = null;
            this.analogValueDisplay3.PLCAddressVisible = null;
            this.analogValueDisplay3.ShowValue = true;
            this.analogValueDisplay3.Size = new System.Drawing.Size(45, 20);
            this.analogValueDisplay3.TabIndex = 75;
            this.analogValueDisplay3.Text = "0000";
            this.analogValueDisplay3.Value = "0000";
            this.analogValueDisplay3.ValueLimitLower = -999999D;
            this.analogValueDisplay3.ValueLimitUpper = 999999D;
            this.analogValueDisplay3.ValuePrefix = null;
            this.analogValueDisplay3.ValueSuffix = null;
            this.analogValueDisplay3.VisibleControl = AdvancedHMIControls.AnalogValueDisplay.VisibleControlEnum.Always;
            // 
            // azbil_com
            // 
            this.azbil_com.DisableSubscriptions = false;
            this.azbil_com.IniFileName = "";
            this.azbil_com.IniFileSection = null;
            this.azbil_com.IPAddress = "192.168.2.44";
            this.azbil_com.MaxReadGroupSize = 200;
            this.azbil_com.PollRateOverride = 500;
            this.azbil_com.SwapBytes = true;
            this.azbil_com.SwapWords = false;
            this.azbil_com.TcpipPort = ((ushort)(502));
            this.azbil_com.TimeOut = 30000;
            this.azbil_com.UnitId = ((byte)(1));
            // 
            // dataSubscriber1
            // 
            this.dataSubscriber1.ComComponent = this.PLC1;
            this.dataSubscriber1.PLCAddressValue = ((MfgControl.AdvancedHMI.Drivers.PLCAddressItem)(resources.GetObject("dataSubscriber1.PLCAddressValue")));
            this.dataSubscriber1.Value = null;
            this.dataSubscriber1.DataChanged += new System.EventHandler<MfgControl.AdvancedHMI.Drivers.Common.PlcComEventArgs>(this.dataSubscriber1_DataChanged);
            // 
            // rtd_2
            // 
            this.rtd_2.AutoSize = true;
            this.rtd_2.BackColor = System.Drawing.Color.Gray;
            this.rtd_2.ComComponent = FATEK;
            this.rtd_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtd_2.ForeColor = System.Drawing.Color.Black;
            this.rtd_2.ForeColorInLimits = System.Drawing.Color.Black;
            this.rtd_2.ForeColorOverLimit = System.Drawing.Color.Red;
            this.rtd_2.ForeColorUnderLimit = System.Drawing.Color.Yellow;
            this.rtd_2.KeypadFontColor = System.Drawing.Color.WhiteSmoke;
            this.rtd_2.KeypadMaxValue = 0D;
            this.rtd_2.KeypadMinValue = 0D;
            this.rtd_2.KeypadPasscode = null;
            this.rtd_2.KeypadScaleFactor = 1D;
            this.rtd_2.KeypadText = null;
            this.rtd_2.KeypadWidth = 300;
            this.rtd_2.Location = new System.Drawing.Point(416, 443);
            this.rtd_2.Name = "rtd_2";
            this.rtd_2.NumericFormat = null;
            this.rtd_2.PLCAddressKeypad = "";
            this.rtd_2.PLCAddressValue = ((MfgControl.AdvancedHMI.Drivers.PLCAddressItem)(resources.GetObject("rtd_2.PLCAddressValue")));
            this.rtd_2.PLCAddressValueLimitLower = null;
            this.rtd_2.PLCAddressValueLimitUpper = null;
            this.rtd_2.PLCAddressVisible = null;
            this.rtd_2.ShowValue = true;
            this.rtd_2.Size = new System.Drawing.Size(79, 33);
            this.rtd_2.SuppressErrorDisplay = true;
            this.rtd_2.TabIndex = 1520;
            this.rtd_2.Text = "0000";
            this.rtd_2.Value = "0000";
            this.rtd_2.ValueLimitLower = -999999D;
            this.rtd_2.ValueLimitUpper = 99999999D;
            this.rtd_2.ValuePrefix = null;
            this.rtd_2.ValueSuffix = null;
            this.rtd_2.VisibleControl = AdvancedHMIControls.AnalogValueDisplay.VisibleControlEnum.Always;
            this.rtd_2.ValueChanged += new System.EventHandler(this.rtd_2_ValueChanged);
            this.rtd_2.Click += new System.EventHandler(this.rtd_2_Click);
            // 
            // rtd_3
            // 
            this.rtd_3.AutoSize = true;
            this.rtd_3.BackColor = System.Drawing.Color.Gray;
            this.rtd_3.ComComponent = FATEK;
            this.rtd_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtd_3.ForeColor = System.Drawing.Color.Black;
            this.rtd_3.ForeColorInLimits = System.Drawing.Color.Black;
            this.rtd_3.ForeColorOverLimit = System.Drawing.Color.Red;
            this.rtd_3.ForeColorUnderLimit = System.Drawing.Color.Yellow;
            this.rtd_3.KeypadFontColor = System.Drawing.Color.WhiteSmoke;
            this.rtd_3.KeypadMaxValue = 0D;
            this.rtd_3.KeypadMinValue = 0D;
            this.rtd_3.KeypadPasscode = null;
            this.rtd_3.KeypadScaleFactor = 1D;
            this.rtd_3.KeypadText = null;
            this.rtd_3.KeypadWidth = 300;
            this.rtd_3.Location = new System.Drawing.Point(416, 516);
            this.rtd_3.Name = "rtd_3";
            this.rtd_3.NumericFormat = null;
            this.rtd_3.PLCAddressKeypad = "";
            this.rtd_3.PLCAddressValue = ((MfgControl.AdvancedHMI.Drivers.PLCAddressItem)(resources.GetObject("rtd_3.PLCAddressValue")));
            this.rtd_3.PLCAddressValueLimitLower = null;
            this.rtd_3.PLCAddressValueLimitUpper = null;
            this.rtd_3.PLCAddressVisible = null;
            this.rtd_3.ShowValue = true;
            this.rtd_3.Size = new System.Drawing.Size(79, 33);
            this.rtd_3.SuppressErrorDisplay = true;
            this.rtd_3.TabIndex = 1521;
            this.rtd_3.Text = "0000";
            this.rtd_3.Value = "0000";
            this.rtd_3.ValueLimitLower = -999999D;
            this.rtd_3.ValueLimitUpper = 99999999D;
            this.rtd_3.ValuePrefix = null;
            this.rtd_3.ValueSuffix = null;
            this.rtd_3.VisibleControl = AdvancedHMIControls.AnalogValueDisplay.VisibleControlEnum.Always;
            this.rtd_3.ValueChanged += new System.EventHandler(this.rtd_3_ValueChanged);
            this.rtd_3.Click += new System.EventHandler(this.rtd_3_Click);
            // 
            // analogValueDisplay16
            // 
            this.analogValueDisplay16.AutoSize = true;
            this.analogValueDisplay16.BackColor = System.Drawing.Color.Gray;
            this.analogValueDisplay16.ComComponent = FATEK;
            this.analogValueDisplay16.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.analogValueDisplay16.ForeColor = System.Drawing.Color.Black;
            this.analogValueDisplay16.ForeColorInLimits = System.Drawing.Color.Black;
            this.analogValueDisplay16.ForeColorOverLimit = System.Drawing.Color.Red;
            this.analogValueDisplay16.ForeColorUnderLimit = System.Drawing.Color.Yellow;
            this.analogValueDisplay16.KeypadFontColor = System.Drawing.Color.WhiteSmoke;
            this.analogValueDisplay16.KeypadMaxValue = 0D;
            this.analogValueDisplay16.KeypadMinValue = 0D;
            this.analogValueDisplay16.KeypadPasscode = null;
            this.analogValueDisplay16.KeypadScaleFactor = 1D;
            this.analogValueDisplay16.KeypadText = null;
            this.analogValueDisplay16.KeypadWidth = 300;
            this.analogValueDisplay16.Location = new System.Drawing.Point(540, 443);
            this.analogValueDisplay16.Name = "analogValueDisplay16";
            this.analogValueDisplay16.NumericFormat = null;
            this.analogValueDisplay16.PLCAddressKeypad = "";
            this.analogValueDisplay16.PLCAddressValue = ((MfgControl.AdvancedHMI.Drivers.PLCAddressItem)(resources.GetObject("analogValueDisplay16.PLCAddressValue")));
            this.analogValueDisplay16.PLCAddressValueLimitLower = null;
            this.analogValueDisplay16.PLCAddressValueLimitUpper = null;
            this.analogValueDisplay16.PLCAddressVisible = null;
            this.analogValueDisplay16.ShowValue = true;
            this.analogValueDisplay16.Size = new System.Drawing.Size(79, 33);
            this.analogValueDisplay16.SuppressErrorDisplay = true;
            this.analogValueDisplay16.TabIndex = 1522;
            this.analogValueDisplay16.Text = "0000";
            this.analogValueDisplay16.Value = "0000";
            this.analogValueDisplay16.ValueLimitLower = -999999D;
            this.analogValueDisplay16.ValueLimitUpper = 99999999D;
            this.analogValueDisplay16.ValuePrefix = null;
            this.analogValueDisplay16.ValueSuffix = null;
            this.analogValueDisplay16.VisibleControl = AdvancedHMIControls.AnalogValueDisplay.VisibleControlEnum.Always;
            // 
            // analogValueDisplay17
            // 
            this.analogValueDisplay17.AutoSize = true;
            this.analogValueDisplay17.BackColor = System.Drawing.Color.Gray;
            this.analogValueDisplay17.ComComponent = FATEK;
            this.analogValueDisplay17.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.analogValueDisplay17.ForeColor = System.Drawing.Color.Black;
            this.analogValueDisplay17.ForeColorInLimits = System.Drawing.Color.Black;
            this.analogValueDisplay17.ForeColorOverLimit = System.Drawing.Color.Red;
            this.analogValueDisplay17.ForeColorUnderLimit = System.Drawing.Color.Yellow;
            this.analogValueDisplay17.KeypadFontColor = System.Drawing.Color.WhiteSmoke;
            this.analogValueDisplay17.KeypadMaxValue = 0D;
            this.analogValueDisplay17.KeypadMinValue = 0D;
            this.analogValueDisplay17.KeypadPasscode = null;
            this.analogValueDisplay17.KeypadScaleFactor = 1D;
            this.analogValueDisplay17.KeypadText = null;
            this.analogValueDisplay17.KeypadWidth = 300;
            this.analogValueDisplay17.Location = new System.Drawing.Point(540, 516);
            this.analogValueDisplay17.Name = "analogValueDisplay17";
            this.analogValueDisplay17.NumericFormat = null;
            this.analogValueDisplay17.PLCAddressKeypad = "";
            this.analogValueDisplay17.PLCAddressValue = ((MfgControl.AdvancedHMI.Drivers.PLCAddressItem)(resources.GetObject("analogValueDisplay17.PLCAddressValue")));
            this.analogValueDisplay17.PLCAddressValueLimitLower = null;
            this.analogValueDisplay17.PLCAddressValueLimitUpper = null;
            this.analogValueDisplay17.PLCAddressVisible = null;
            this.analogValueDisplay17.ShowValue = true;
            this.analogValueDisplay17.Size = new System.Drawing.Size(79, 33);
            this.analogValueDisplay17.SuppressErrorDisplay = true;
            this.analogValueDisplay17.TabIndex = 1523;
            this.analogValueDisplay17.Text = "0000";
            this.analogValueDisplay17.Value = "0000";
            this.analogValueDisplay17.ValueLimitLower = -999999D;
            this.analogValueDisplay17.ValueLimitUpper = 99999999D;
            this.analogValueDisplay17.ValuePrefix = null;
            this.analogValueDisplay17.ValueSuffix = null;
            this.analogValueDisplay17.VisibleControl = AdvancedHMIControls.AnalogValueDisplay.VisibleControlEnum.Always;
            this.analogValueDisplay17.ValueChanged += new System.EventHandler(this.analogValueDisplay17_ValueChanged);
            // 
            // lbl_result
            // 
            this.lbl_result.AutoSize = true;
            this.lbl_result.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_result.Location = new System.Drawing.Point(417, 598);
            this.lbl_result.Name = "lbl_result";
            this.lbl_result.Size = new System.Drawing.Size(70, 25);
            this.lbl_result.TabIndex = 1524;
            this.lbl_result.Text = "label1";
            // 
            // lbl_1
            // 
            this.lbl_1.AutoSize = true;
            this.lbl_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_1.Location = new System.Drawing.Point(567, 598);
            this.lbl_1.Name = "lbl_1";
            this.lbl_1.Size = new System.Drawing.Size(70, 25);
            this.lbl_1.TabIndex = 1525;
            this.lbl_1.Text = "label1";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(436, 680);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1526;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lable1
            // 
            this.lable1.AutoSize = true;
            this.lable1.Location = new System.Drawing.Point(395, 345);
            this.lable1.Name = "lable1";
            this.lable1.Size = new System.Drawing.Size(117, 13);
            this.lable1.TabIndex = 1527;
            this.lable1.Text = "Temperature In Degree";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(651, 345);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 13);
            this.label2.TabIndex = 1528;
            this.label2.Text = "Temperature In Kelvin";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(815, 345);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 1529;
            this.label3.Text = "Resistence";
            // 
            // temp_k1
            // 
            this.temp_k1.AutoSize = true;
            this.temp_k1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.temp_k1.Location = new System.Drawing.Point(658, 373);
            this.temp_k1.Name = "temp_k1";
            this.temp_k1.Size = new System.Drawing.Size(93, 33);
            this.temp_k1.TabIndex = 1530;
            this.temp_k1.Text = "label1";
            // 
            // temp_k2
            // 
            this.temp_k2.AutoSize = true;
            this.temp_k2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.temp_k2.Location = new System.Drawing.Point(658, 451);
            this.temp_k2.Name = "temp_k2";
            this.temp_k2.Size = new System.Drawing.Size(93, 33);
            this.temp_k2.TabIndex = 1531;
            this.temp_k2.Text = "label4";
            // 
            // temp_k3
            // 
            this.temp_k3.AutoSize = true;
            this.temp_k3.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.temp_k3.Location = new System.Drawing.Point(658, 524);
            this.temp_k3.Name = "temp_k3";
            this.temp_k3.Size = new System.Drawing.Size(93, 33);
            this.temp_k3.TabIndex = 1532;
            this.temp_k3.Text = "label5";
            this.temp_k3.Click += new System.EventHandler(this.label5_Click);
            // 
            // resis_1
            // 
            this.resis_1.AutoSize = true;
            this.resis_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resis_1.Location = new System.Drawing.Point(779, 373);
            this.resis_1.Name = "resis_1";
            this.resis_1.Size = new System.Drawing.Size(93, 33);
            this.resis_1.TabIndex = 1533;
            this.resis_1.Text = "label6";
            // 
            // resis_2
            // 
            this.resis_2.AutoSize = true;
            this.resis_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resis_2.Location = new System.Drawing.Point(779, 451);
            this.resis_2.Name = "resis_2";
            this.resis_2.Size = new System.Drawing.Size(93, 33);
            this.resis_2.TabIndex = 1534;
            this.resis_2.Text = "label7";
            // 
            // resis_3
            // 
            this.resis_3.AutoSize = true;
            this.resis_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resis_3.Location = new System.Drawing.Point(779, 525);
            this.resis_3.Name = "resis_3";
            this.resis_3.Size = new System.Drawing.Size(93, 33);
            this.resis_3.TabIndex = 1535;
            this.resis_3.Text = "label8";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(595, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(277, 33);
            this.label1.TabIndex = 1536;
            this.label1.Text = "Scada Temp Values";
            // 
            // basicDataLogger1
            // 
            this.basicDataLogger1.ComComponent = FATEK;
            this.basicDataLogger1.FileFolder = "C:";
            this.basicDataLogger1.FileName = "PLCDataLog.log";
            this.basicDataLogger1.LogInterval = 1000;
            this.basicDataLogger1.LogTriggerType = AdvancedHMIControls.BasicDataLogger.TriggerType.TimeInterval;
            this.basicDataLogger1.MaximumPoints = 0;
            this.basicDataLogger1.PLCAddressValue = null;
            this.basicDataLogger1.Prefix = null;
            this.basicDataLogger1.TimeStampFormat = "dd-MMM-yy HH:mm:ss";
            this.basicDataLogger1.Value = null;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(28, 54);
            this.chart1.Name = "chart1";
            this.chart1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chart1.Size = new System.Drawing.Size(1414, 250);
            this.chart1.TabIndex = 1539;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 500;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // door_2
            // 
            this.door_2.AutoSize = true;
            this.door_2.BackColor = System.Drawing.Color.Gray;
            this.door_2.ComComponent = FATEK;
            this.door_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.door_2.ForeColor = System.Drawing.Color.Black;
            this.door_2.ForeColorInLimits = System.Drawing.Color.Black;
            this.door_2.ForeColorOverLimit = System.Drawing.Color.Red;
            this.door_2.ForeColorUnderLimit = System.Drawing.Color.Yellow;
            this.door_2.KeypadFontColor = System.Drawing.Color.WhiteSmoke;
            this.door_2.KeypadMaxValue = 0D;
            this.door_2.KeypadMinValue = 0D;
            this.door_2.KeypadPasscode = null;
            this.door_2.KeypadScaleFactor = 1D;
            this.door_2.KeypadText = null;
            this.door_2.KeypadWidth = 300;
            this.door_2.Location = new System.Drawing.Point(246, 442);
            this.door_2.Name = "door_2";
            this.door_2.NumericFormat = null;
            this.door_2.PLCAddressKeypad = "";
            this.door_2.PLCAddressValue = ((MfgControl.AdvancedHMI.Drivers.PLCAddressItem)(resources.GetObject("door_2.PLCAddressValue")));
            this.door_2.PLCAddressValueLimitLower = null;
            this.door_2.PLCAddressValueLimitUpper = null;
            this.door_2.PLCAddressVisible = null;
            this.door_2.ShowValue = true;
            this.door_2.Size = new System.Drawing.Size(79, 33);
            this.door_2.SuppressErrorDisplay = true;
            this.door_2.TabIndex = 1541;
            this.door_2.Text = "0000";
            this.door_2.Value = "0000";
            this.door_2.ValueLimitLower = -999999D;
            this.door_2.ValueLimitUpper = 99999999D;
            this.door_2.ValuePrefix = null;
            this.door_2.ValueSuffix = null;
            this.door_2.VisibleControl = AdvancedHMIControls.AnalogValueDisplay.VisibleControlEnum.Always;
            this.door_2.ValueChanged += new System.EventHandler(this.door_2_ValueChanged);
            // 
            // door_1
            // 
            this.door_1.AutoSize = true;
            this.door_1.BackColor = System.Drawing.Color.Gray;
            this.door_1.ComComponent = FATEK;
            this.door_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.door_1.ForeColor = System.Drawing.Color.Black;
            this.door_1.ForeColorInLimits = System.Drawing.Color.Black;
            this.door_1.ForeColorOverLimit = System.Drawing.Color.Red;
            this.door_1.ForeColorUnderLimit = System.Drawing.Color.Yellow;
            this.door_1.KeypadFontColor = System.Drawing.Color.WhiteSmoke;
            this.door_1.KeypadMaxValue = 0D;
            this.door_1.KeypadMinValue = 0D;
            this.door_1.KeypadPasscode = null;
            this.door_1.KeypadScaleFactor = 1D;
            this.door_1.KeypadText = null;
            this.door_1.KeypadWidth = 300;
            this.door_1.Location = new System.Drawing.Point(246, 373);
            this.door_1.Name = "door_1";
            this.door_1.NumericFormat = null;
            this.door_1.PLCAddressKeypad = "";
            this.door_1.PLCAddressValue = ((MfgControl.AdvancedHMI.Drivers.PLCAddressItem)(resources.GetObject("door_1.PLCAddressValue")));
            this.door_1.PLCAddressValueLimitLower = null;
            this.door_1.PLCAddressValueLimitUpper = null;
            this.door_1.PLCAddressVisible = null;
            this.door_1.ShowValue = true;
            this.door_1.Size = new System.Drawing.Size(79, 33);
            this.door_1.SuppressErrorDisplay = true;
            this.door_1.TabIndex = 1540;
            this.door_1.Text = "0000";
            this.door_1.Value = "0000";
            this.door_1.ValueLimitLower = -999999D;
            this.door_1.ValueLimitUpper = 99999999D;
            this.door_1.ValuePrefix = null;
            this.door_1.ValueSuffix = null;
            this.door_1.VisibleControl = AdvancedHMIControls.AnalogValueDisplay.VisibleControlEnum.Always;
            this.door_1.ValueChanged += new System.EventHandler(this.door_1_ValueChanged);
            // 
            // timer3
            // 
            this.timer3.Enabled = true;
            this.timer3.Interval = 10000;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(250, 680);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 1542;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(105, 441);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 33);
            this.label4.TabIndex = 1544;
            this.label4.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(105, 363);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 33);
            this.label5.TabIndex = 1543;
            this.label5.Text = "label1";
            // 
            // timer4
            // 
            this.timer4.Enabled = true;
            this.timer4.Interval = 10000;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(99, 641);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 1545;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(1467, 761);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.door_2);
            this.Controls.Add(this.door_1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.resis_3);
            this.Controls.Add(this.resis_2);
            this.Controls.Add(this.resis_1);
            this.Controls.Add(this.temp_k3);
            this.Controls.Add(this.temp_k2);
            this.Controls.Add(this.temp_k1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lable1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lbl_1);
            this.Controls.Add(this.lbl_result);
            this.Controls.Add(this.analogValueDisplay17);
            this.Controls.Add(this.analogValueDisplay16);
            this.Controls.Add(this.rtd_3);
            this.Controls.Add(this.rtd_2);
            this.Controls.Add(this.analogValueDisplay12);
            this.Controls.Add(this.rtd_1);
            this.Controls.Add(this.analogValueDisplay21);
            this.Controls.Add(this.analogValueDisplay9);
            this.Controls.Add(this.basicIndicator9);
            this.Controls.Add(this.basicIndicator8);
            this.Controls.Add(this.analogValueDisplay7);
            this.Controls.Add(this.analogValueDisplay6);
            this.Controls.Add(this.analogValueDisplay4);
            this.Controls.Add(this.analogValueDisplay2);
            this.Controls.Add(this.analogValueDisplay1);
            this.Controls.Add(this.basicIndicator5);
            this.Controls.Add(this.basicButton1);
            this.Controls.Add(this.analogValueDisplay3);
            this.Controls.Add(this.button1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(FATEK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(modbusTCPCom1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.USR_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PLC1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.azbil_com)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSubscriber1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.basicDataLogger1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private AdvancedHMIDrivers.ModbusTCPCom PLC1;
        private AdvancedHMIControls.AnalogValueDisplay analogValueDisplay3;
        private AdvancedHMIControls.BasicIndicator basicIndicator1;
        private AdvancedHMIControls.BasicIndicator basicIndicator2;
        private AdvancedHMIControls.DataSubscriber dataSubscriber1;
        private AdvancedHMIControls.BasicButton basicButton1;
        private AdvancedHMIControls.BasicIndicator basicIndicator5;
        private AdvancedHMIControls.AnalogValueDisplay analogValueDisplay1;
        private AdvancedHMIControls.AnalogValueDisplay analogValueDisplay2;
        private AdvancedHMIControls.AnalogValueDisplay analogValueDisplay4;
        private AdvancedHMIControls.AnalogValueDisplay analogValueDisplay6;
        public AdvancedHMIDrivers.ModbusTCPCom azbil_com;
        private AdvancedHMIControls.AnalogValueDisplay analogValueDisplay7;
        private AdvancedHMIControls.BasicIndicator basicIndicator8;
        private AdvancedHMIControls.BasicIndicator basicIndicator9;
        private AdvancedHMIControls.AnalogValueDisplay analogValueDisplay9;
        private AdvancedHMIControls.AnalogValueDisplay analogValueDisplay21;
        private AdvancedHMIDrivers.ModbusTCPCom USR_2;
        public AdvancedHMIControls.AnalogValueDisplay rtd_1;
        public AdvancedHMIControls.AnalogValueDisplay analogValueDisplay12;
        public AdvancedHMIControls.AnalogValueDisplay rtd_2;
        public AdvancedHMIControls.AnalogValueDisplay rtd_3;
        public AdvancedHMIControls.AnalogValueDisplay analogValueDisplay16;
        public AdvancedHMIControls.AnalogValueDisplay analogValueDisplay17;
        private System.Windows.Forms.Label lbl_result;
        private System.Windows.Forms.Label lbl_1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lable1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label temp_k1;
        private System.Windows.Forms.Label temp_k2;
        private System.Windows.Forms.Label temp_k3;
        private System.Windows.Forms.Label resis_1;
        private System.Windows.Forms.Label resis_2;
        private System.Windows.Forms.Label resis_3;
        private System.Windows.Forms.Label label1;
        private AdvancedHMIControls.BasicDataLogger basicDataLogger1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Timer timer2;
        public AdvancedHMIControls.AnalogValueDisplay door_2;
        public AdvancedHMIControls.AnalogValueDisplay door_1;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Timer timer4;
        private System.Windows.Forms.Button button4;
    }
}

