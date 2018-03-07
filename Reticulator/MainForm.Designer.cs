namespace Reticulator
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
			if(disposing && (components != null))
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
            this.MasterLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.WidgetyPanel = new System.Windows.Forms.Panel();
            this.ArcLengthGroupBox = new System.Windows.Forms.GroupBox();
            this.EstArcLenWBPErrorBox = new System.Windows.Forms.TextBox();
            this.EstArcLenBPErrorBox = new System.Windows.Forms.TextBox();
            this.EstArcLenWBPHintLabel = new System.Windows.Forms.Label();
            this.EstArcLenWBPBox = new System.Windows.Forms.TextBox();
            this.EstArcLenNumericHintLabel = new System.Windows.Forms.Label();
            this.EstArcLenNumericalBox = new System.Windows.Forms.TextBox();
            this.EstArcLenBPBox = new System.Windows.Forms.TextBox();
            this.EstArcLenBPMethodHintLabel = new System.Windows.Forms.Label();
            this.SamplePointGroupBox = new System.Windows.Forms.GroupBox();
            this.D2XD2YRatioBox = new System.Windows.Forms.TextBox();
            this.D2YHintLabel = new System.Windows.Forms.Label();
            this.SampleD2YBox = new System.Windows.Forms.TextBox();
            this.D2XHintLabel = new System.Windows.Forms.Label();
            this.SampleD2XBox = new System.Windows.Forms.TextBox();
            this.DXDYRatioBox = new System.Windows.Forms.TextBox();
            this.SampleDYBox = new System.Windows.Forms.TextBox();
            this.SampleDYHint = new System.Windows.Forms.Label();
            this.SampleDXBox = new System.Windows.Forms.TextBox();
            this.SampleDXHint = new System.Windows.Forms.Label();
            this.SampleYBox = new System.Windows.Forms.TextBox();
            this.SampleYHint = new System.Windows.Forms.Label();
            this.SampleXBox = new System.Windows.Forms.TextBox();
            this.SampleXHint = new System.Windows.Forms.Label();
            this.SampleTPicker = new System.Windows.Forms.TrackBar();
            this.THintLabel = new System.Windows.Forms.Label();
            this.TBox = new System.Windows.Forms.TextBox();
            this.DisplayOptions = new System.Windows.Forms.GroupBox();
            this.ExitPointCheckbox = new System.Windows.Forms.CheckBox();
            this.ControlPoint2Checkbox = new System.Windows.Forms.CheckBox();
            this.ControlPoint1Checkbox = new System.Windows.Forms.CheckBox();
            this.EntryPointCheckbox = new System.Windows.Forms.CheckBox();
            this.SamplePointCheckbox = new System.Windows.Forms.CheckBox();
            this.AccelVectorCheckbox = new System.Windows.Forms.CheckBox();
            this.TangentCheckbox = new System.Windows.Forms.CheckBox();
            this.SplineCheckbox = new System.Windows.Forms.CheckBox();
            this.BoundingPolyCheckbox = new System.Windows.Forms.CheckBox();
            this.ControlPointGroupBox = new System.Windows.Forms.GroupBox();
            this.ExitPointHintLabel = new System.Windows.Forms.Label();
            this.ControlPoint2HintLabel = new System.Windows.Forms.Label();
            this.ControlPoint1HintLabel = new System.Windows.Forms.Label();
            this.EntryPointHintLabel = new System.Windows.Forms.Label();
            this.ResetButton = new System.Windows.Forms.Button();
            this.YCoordHintLabel = new System.Windows.Forms.Label();
            this.XCoordHintLabel = new System.Windows.Forms.Label();
            this.Viewport = new System.Windows.Forms.PictureBox();
            this.EntryPointX = new System.Windows.Forms.NumericUpDown();
            this.EntryPointY = new System.Windows.Forms.NumericUpDown();
            this.ControlPoint1X = new System.Windows.Forms.NumericUpDown();
            this.ControlPoint1Y = new System.Windows.Forms.NumericUpDown();
            this.ControlPoint2Y = new System.Windows.Forms.NumericUpDown();
            this.ControlPoint2X = new System.Windows.Forms.NumericUpDown();
            this.ExitPointY = new System.Windows.Forms.NumericUpDown();
            this.ExitPointX = new System.Windows.Forms.NumericUpDown();
            this.ArcErrorHintLabel = new System.Windows.Forms.Label();
            this.ArcResultHintLabel = new System.Windows.Forms.Label();
            this.ReticulatorToolTips = new System.Windows.Forms.ToolTip(this.components);
            this.DXRatioHintLabel = new System.Windows.Forms.Label();
            this.D2XRatioHintLabel = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.StatusLabelMouseCoordinates = new System.Windows.Forms.ToolStripStatusLabel();
            this.NormalCheckBox = new System.Windows.Forms.CheckBox();
            this.MasterLayoutPanel.SuspendLayout();
            this.WidgetyPanel.SuspendLayout();
            this.ArcLengthGroupBox.SuspendLayout();
            this.SamplePointGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SampleTPicker)).BeginInit();
            this.DisplayOptions.SuspendLayout();
            this.ControlPointGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Viewport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EntryPointX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EntryPointY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ControlPoint1X)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ControlPoint1Y)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ControlPoint2Y)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ControlPoint2X)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitPointY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitPointX)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MasterLayoutPanel
            // 
            this.MasterLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MasterLayoutPanel.ColumnCount = 2;
            this.MasterLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MasterLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 464F));
            this.MasterLayoutPanel.Controls.Add(this.WidgetyPanel, 1, 0);
            this.MasterLayoutPanel.Controls.Add(this.Viewport, 0, 0);
            this.MasterLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.MasterLayoutPanel.Name = "MasterLayoutPanel";
            this.MasterLayoutPanel.RowCount = 1;
            this.MasterLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MasterLayoutPanel.Size = new System.Drawing.Size(776, 546);
            this.MasterLayoutPanel.TabIndex = 43;
            // 
            // WidgetyPanel
            // 
            this.WidgetyPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.WidgetyPanel.Controls.Add(this.ArcLengthGroupBox);
            this.WidgetyPanel.Controls.Add(this.SamplePointGroupBox);
            this.WidgetyPanel.Controls.Add(this.DisplayOptions);
            this.WidgetyPanel.Controls.Add(this.ControlPointGroupBox);
            this.WidgetyPanel.Location = new System.Drawing.Point(315, 3);
            this.WidgetyPanel.MinimumSize = new System.Drawing.Size(460, 0);
            this.WidgetyPanel.Name = "WidgetyPanel";
            this.WidgetyPanel.Size = new System.Drawing.Size(460, 505);
            this.WidgetyPanel.TabIndex = 43;
            // 
            // ArcLengthGroupBox
            // 
            this.ArcLengthGroupBox.Controls.Add(this.ArcResultHintLabel);
            this.ArcLengthGroupBox.Controls.Add(this.ArcErrorHintLabel);
            this.ArcLengthGroupBox.Controls.Add(this.EstArcLenWBPErrorBox);
            this.ArcLengthGroupBox.Controls.Add(this.EstArcLenBPErrorBox);
            this.ArcLengthGroupBox.Controls.Add(this.EstArcLenWBPHintLabel);
            this.ArcLengthGroupBox.Controls.Add(this.EstArcLenWBPBox);
            this.ArcLengthGroupBox.Controls.Add(this.EstArcLenNumericHintLabel);
            this.ArcLengthGroupBox.Controls.Add(this.EstArcLenNumericalBox);
            this.ArcLengthGroupBox.Controls.Add(this.EstArcLenBPBox);
            this.ArcLengthGroupBox.Controls.Add(this.EstArcLenBPMethodHintLabel);
            this.ArcLengthGroupBox.Location = new System.Drawing.Point(244, 3);
            this.ArcLengthGroupBox.Name = "ArcLengthGroupBox";
            this.ArcLengthGroupBox.Size = new System.Drawing.Size(208, 185);
            this.ArcLengthGroupBox.TabIndex = 45;
            this.ArcLengthGroupBox.TabStop = false;
            this.ArcLengthGroupBox.Text = "Arc Length Computation";
            // 
            // EstArcLenWBPErrorBox
            // 
            this.EstArcLenWBPErrorBox.Location = new System.Drawing.Point(154, 72);
            this.EstArcLenWBPErrorBox.Name = "EstArcLenWBPErrorBox";
            this.EstArcLenWBPErrorBox.ReadOnly = true;
            this.EstArcLenWBPErrorBox.Size = new System.Drawing.Size(48, 20);
            this.EstArcLenWBPErrorBox.TabIndex = 8;
            this.ReticulatorToolTips.SetToolTip(this.EstArcLenWBPErrorBox, "Approximate error between the Weighted BP Method result and the numerical integra" +
        "tion result.");
            // 
            // EstArcLenBPErrorBox
            // 
            this.EstArcLenBPErrorBox.Location = new System.Drawing.Point(154, 46);
            this.EstArcLenBPErrorBox.Name = "EstArcLenBPErrorBox";
            this.EstArcLenBPErrorBox.ReadOnly = true;
            this.EstArcLenBPErrorBox.Size = new System.Drawing.Size(48, 20);
            this.EstArcLenBPErrorBox.TabIndex = 7;
            this.ReticulatorToolTips.SetToolTip(this.EstArcLenBPErrorBox, "Approximate error between the BP Method result and the numerical integration resu" +
        "lt.");
            // 
            // EstArcLenWBPHintLabel
            // 
            this.EstArcLenWBPHintLabel.AutoSize = true;
            this.EstArcLenWBPHintLabel.Location = new System.Drawing.Point(7, 75);
            this.EstArcLenWBPHintLabel.Name = "EstArcLenWBPHintLabel";
            this.EstArcLenWBPHintLabel.Size = new System.Drawing.Size(73, 13);
            this.EstArcLenWBPHintLabel.TabIndex = 6;
            this.EstArcLenWBPHintLabel.Text = "Weighted BP:";
            // 
            // EstArcLenWBPBox
            // 
            this.EstArcLenWBPBox.Location = new System.Drawing.Point(86, 72);
            this.EstArcLenWBPBox.Name = "EstArcLenWBPBox";
            this.EstArcLenWBPBox.ReadOnly = true;
            this.EstArcLenWBPBox.Size = new System.Drawing.Size(62, 20);
            this.EstArcLenWBPBox.TabIndex = 5;
            this.ReticulatorToolTips.SetToolTip(this.EstArcLenWBPBox, "Approximate arc length of the spline.\r\n\r\nComputed using the \"weighted bounding po" +
        "lygon\" method.\r\nSee BezierSpline.cs for details.");
            // 
            // EstArcLenNumericHintLabel
            // 
            this.EstArcLenNumericHintLabel.AutoSize = true;
            this.EstArcLenNumericHintLabel.Location = new System.Drawing.Point(23, 99);
            this.EstArcLenNumericHintLabel.Name = "EstArcLenNumericHintLabel";
            this.EstArcLenNumericHintLabel.Size = new System.Drawing.Size(57, 13);
            this.EstArcLenNumericHintLabel.TabIndex = 4;
            this.EstArcLenNumericHintLabel.Text = "Numerical:";
            // 
            // EstArcLenNumericalBox
            // 
            this.EstArcLenNumericalBox.Location = new System.Drawing.Point(86, 98);
            this.EstArcLenNumericalBox.Name = "EstArcLenNumericalBox";
            this.EstArcLenNumericalBox.ReadOnly = true;
            this.EstArcLenNumericalBox.Size = new System.Drawing.Size(62, 20);
            this.EstArcLenNumericalBox.TabIndex = 3;
            this.ReticulatorToolTips.SetToolTip(this.EstArcLenNumericalBox, "Approximate arc length of the spline.\r\n\r\nComputed using a simple numerical integr" +
        "ation method.\r\nSee BezierSpline.cs for details.");
            // 
            // EstArcLenBPBox
            // 
            this.EstArcLenBPBox.Location = new System.Drawing.Point(86, 46);
            this.EstArcLenBPBox.Name = "EstArcLenBPBox";
            this.EstArcLenBPBox.ReadOnly = true;
            this.EstArcLenBPBox.Size = new System.Drawing.Size(62, 20);
            this.EstArcLenBPBox.TabIndex = 2;
            this.ReticulatorToolTips.SetToolTip(this.EstArcLenBPBox, "Approximate arc length of the spline.\r\n\r\nComputed using the \"bounding polygon\" me" +
        "thod.\r\nSee BezierSpline.cs for details.");
            // 
            // EstArcLenBPMethodHintLabel
            // 
            this.EstArcLenBPMethodHintLabel.AutoSize = true;
            this.EstArcLenBPMethodHintLabel.Location = new System.Drawing.Point(17, 49);
            this.EstArcLenBPMethodHintLabel.Name = "EstArcLenBPMethodHintLabel";
            this.EstArcLenBPMethodHintLabel.Size = new System.Drawing.Size(63, 13);
            this.EstArcLenBPMethodHintLabel.TabIndex = 1;
            this.EstArcLenBPMethodHintLabel.Text = "BP Method:";
            // 
            // SamplePointGroupBox
            // 
            this.SamplePointGroupBox.Controls.Add(this.D2XRatioHintLabel);
            this.SamplePointGroupBox.Controls.Add(this.DXRatioHintLabel);
            this.SamplePointGroupBox.Controls.Add(this.D2XD2YRatioBox);
            this.SamplePointGroupBox.Controls.Add(this.D2YHintLabel);
            this.SamplePointGroupBox.Controls.Add(this.SampleD2YBox);
            this.SamplePointGroupBox.Controls.Add(this.D2XHintLabel);
            this.SamplePointGroupBox.Controls.Add(this.SampleD2XBox);
            this.SamplePointGroupBox.Controls.Add(this.DXDYRatioBox);
            this.SamplePointGroupBox.Controls.Add(this.SampleDYBox);
            this.SamplePointGroupBox.Controls.Add(this.SampleDYHint);
            this.SamplePointGroupBox.Controls.Add(this.SampleDXBox);
            this.SamplePointGroupBox.Controls.Add(this.SampleDXHint);
            this.SamplePointGroupBox.Controls.Add(this.SampleYBox);
            this.SamplePointGroupBox.Controls.Add(this.SampleYHint);
            this.SamplePointGroupBox.Controls.Add(this.SampleXBox);
            this.SamplePointGroupBox.Controls.Add(this.SampleXHint);
            this.SamplePointGroupBox.Controls.Add(this.SampleTPicker);
            this.SamplePointGroupBox.Controls.Add(this.THintLabel);
            this.SamplePointGroupBox.Controls.Add(this.TBox);
            this.SamplePointGroupBox.Location = new System.Drawing.Point(3, 343);
            this.SamplePointGroupBox.Name = "SamplePointGroupBox";
            this.SamplePointGroupBox.Padding = new System.Windows.Forms.Padding(6);
            this.SamplePointGroupBox.Size = new System.Drawing.Size(450, 161);
            this.SamplePointGroupBox.TabIndex = 44;
            this.SamplePointGroupBox.TabStop = false;
            this.SamplePointGroupBox.Text = "Sample Point";
            // 
            // D2XD2YRatioBox
            // 
            this.D2XD2YRatioBox.Location = new System.Drawing.Point(220, 123);
            this.D2XD2YRatioBox.Name = "D2XD2YRatioBox";
            this.D2XD2YRatioBox.ReadOnly = true;
            this.D2XD2YRatioBox.Size = new System.Drawing.Size(67, 20);
            this.D2XD2YRatioBox.TabIndex = 49;
            // 
            // D2YHintLabel
            // 
            this.D2YHintLabel.AutoSize = true;
            this.D2YHintLabel.Location = new System.Drawing.Point(92, 126);
            this.D2YHintLabel.Name = "D2YHintLabel";
            this.D2YHintLabel.Size = new System.Drawing.Size(29, 13);
            this.D2YHintLabel.TabIndex = 48;
            this.D2YHintLabel.Text = "d2Y:";
            // 
            // SampleD2YBox
            // 
            this.SampleD2YBox.Location = new System.Drawing.Point(127, 123);
            this.SampleD2YBox.Name = "SampleD2YBox";
            this.SampleD2YBox.ReadOnly = true;
            this.SampleD2YBox.Size = new System.Drawing.Size(46, 20);
            this.SampleD2YBox.TabIndex = 47;
            // 
            // D2XHintLabel
            // 
            this.D2XHintLabel.AutoSize = true;
            this.D2XHintLabel.Location = new System.Drawing.Point(5, 126);
            this.D2XHintLabel.Name = "D2XHintLabel";
            this.D2XHintLabel.Size = new System.Drawing.Size(29, 13);
            this.D2XHintLabel.TabIndex = 46;
            this.D2XHintLabel.Text = "d2X:";
            // 
            // SampleD2XBox
            // 
            this.SampleD2XBox.Location = new System.Drawing.Point(40, 123);
            this.SampleD2XBox.Name = "SampleD2XBox";
            this.SampleD2XBox.ReadOnly = true;
            this.SampleD2XBox.Size = new System.Drawing.Size(47, 20);
            this.SampleD2XBox.TabIndex = 45;
            // 
            // DXDYRatioBox
            // 
            this.DXDYRatioBox.Location = new System.Drawing.Point(220, 96);
            this.DXDYRatioBox.Name = "DXDYRatioBox";
            this.DXDYRatioBox.ReadOnly = true;
            this.DXDYRatioBox.Size = new System.Drawing.Size(67, 20);
            this.DXDYRatioBox.TabIndex = 44;
            // 
            // SampleDYBox
            // 
            this.SampleDYBox.Location = new System.Drawing.Point(127, 96);
            this.SampleDYBox.Name = "SampleDYBox";
            this.SampleDYBox.ReadOnly = true;
            this.SampleDYBox.Size = new System.Drawing.Size(46, 20);
            this.SampleDYBox.TabIndex = 43;
            // 
            // SampleDYHint
            // 
            this.SampleDYHint.AutoSize = true;
            this.SampleDYHint.Location = new System.Drawing.Point(98, 99);
            this.SampleDYHint.Name = "SampleDYHint";
            this.SampleDYHint.Size = new System.Drawing.Size(23, 13);
            this.SampleDYHint.TabIndex = 42;
            this.SampleDYHint.Text = "dY:";
            // 
            // SampleDXBox
            // 
            this.SampleDXBox.Location = new System.Drawing.Point(40, 96);
            this.SampleDXBox.Name = "SampleDXBox";
            this.SampleDXBox.ReadOnly = true;
            this.SampleDXBox.Size = new System.Drawing.Size(47, 20);
            this.SampleDXBox.TabIndex = 41;
            // 
            // SampleDXHint
            // 
            this.SampleDXHint.AutoSize = true;
            this.SampleDXHint.Location = new System.Drawing.Point(11, 99);
            this.SampleDXHint.Name = "SampleDXHint";
            this.SampleDXHint.Size = new System.Drawing.Size(23, 13);
            this.SampleDXHint.TabIndex = 40;
            this.SampleDXHint.Text = "dX:";
            // 
            // SampleYBox
            // 
            this.SampleYBox.Location = new System.Drawing.Point(127, 70);
            this.SampleYBox.Name = "SampleYBox";
            this.SampleYBox.ReadOnly = true;
            this.SampleYBox.Size = new System.Drawing.Size(46, 20);
            this.SampleYBox.TabIndex = 39;
            // 
            // SampleYHint
            // 
            this.SampleYHint.AutoSize = true;
            this.SampleYHint.Location = new System.Drawing.Point(104, 73);
            this.SampleYHint.Name = "SampleYHint";
            this.SampleYHint.Size = new System.Drawing.Size(17, 13);
            this.SampleYHint.TabIndex = 38;
            this.SampleYHint.Text = "Y:";
            // 
            // SampleXBox
            // 
            this.SampleXBox.Location = new System.Drawing.Point(40, 70);
            this.SampleXBox.Name = "SampleXBox";
            this.SampleXBox.ReadOnly = true;
            this.SampleXBox.Size = new System.Drawing.Size(47, 20);
            this.SampleXBox.TabIndex = 37;
            // 
            // SampleXHint
            // 
            this.SampleXHint.AutoSize = true;
            this.SampleXHint.Location = new System.Drawing.Point(17, 73);
            this.SampleXHint.Name = "SampleXHint";
            this.SampleXHint.Size = new System.Drawing.Size(17, 13);
            this.SampleXHint.TabIndex = 36;
            this.SampleXHint.Text = "X:";
            // 
            // SampleTPicker
            // 
            this.SampleTPicker.LargeChange = 250;
            this.SampleTPicker.Location = new System.Drawing.Point(40, 22);
            this.SampleTPicker.Maximum = 1000;
            this.SampleTPicker.Name = "SampleTPicker";
            this.SampleTPicker.Size = new System.Drawing.Size(133, 45);
            this.SampleTPicker.SmallChange = 100;
            this.SampleTPicker.TabIndex = 25;
            this.SampleTPicker.TickFrequency = 100;
            this.SampleTPicker.Value = 500;
            this.SampleTPicker.Scroll += new System.EventHandler(this.SampleTPicker_Scroll);
            // 
            // THintLabel
            // 
            this.THintLabel.AutoSize = true;
            this.THintLabel.Location = new System.Drawing.Point(17, 28);
            this.THintLabel.Name = "THintLabel";
            this.THintLabel.Size = new System.Drawing.Size(17, 13);
            this.THintLabel.TabIndex = 26;
            this.THintLabel.Text = "T:";
            // 
            // TBox
            // 
            this.TBox.Location = new System.Drawing.Point(179, 28);
            this.TBox.Name = "TBox";
            this.TBox.ReadOnly = true;
            this.TBox.Size = new System.Drawing.Size(47, 20);
            this.TBox.TabIndex = 27;
            // 
            // DisplayOptions
            // 
            this.DisplayOptions.Controls.Add(this.NormalCheckBox);
            this.DisplayOptions.Controls.Add(this.ExitPointCheckbox);
            this.DisplayOptions.Controls.Add(this.ControlPoint2Checkbox);
            this.DisplayOptions.Controls.Add(this.ControlPoint1Checkbox);
            this.DisplayOptions.Controls.Add(this.EntryPointCheckbox);
            this.DisplayOptions.Controls.Add(this.SamplePointCheckbox);
            this.DisplayOptions.Controls.Add(this.AccelVectorCheckbox);
            this.DisplayOptions.Controls.Add(this.TangentCheckbox);
            this.DisplayOptions.Controls.Add(this.SplineCheckbox);
            this.DisplayOptions.Controls.Add(this.BoundingPolyCheckbox);
            this.DisplayOptions.Location = new System.Drawing.Point(3, 194);
            this.DisplayOptions.Name = "DisplayOptions";
            this.DisplayOptions.Padding = new System.Windows.Forms.Padding(6);
            this.DisplayOptions.Size = new System.Drawing.Size(449, 143);
            this.DisplayOptions.TabIndex = 43;
            this.DisplayOptions.TabStop = false;
            this.DisplayOptions.Text = "Display Options";
            // 
            // ExitPointCheckbox
            // 
            this.ExitPointCheckbox.AutoSize = true;
            this.ExitPointCheckbox.Checked = true;
            this.ExitPointCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ExitPointCheckbox.Location = new System.Drawing.Point(251, 93);
            this.ExitPointCheckbox.Name = "ExitPointCheckbox";
            this.ExitPointCheckbox.Size = new System.Drawing.Size(98, 17);
            this.ExitPointCheckbox.TabIndex = 74;
            this.ExitPointCheckbox.Text = "Show exit point";
            this.ExitPointCheckbox.UseVisualStyleBackColor = true;
            // 
            // ControlPoint2Checkbox
            // 
            this.ControlPoint2Checkbox.AutoSize = true;
            this.ControlPoint2Checkbox.Checked = true;
            this.ControlPoint2Checkbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ControlPoint2Checkbox.Location = new System.Drawing.Point(251, 70);
            this.ControlPoint2Checkbox.Name = "ControlPoint2Checkbox";
            this.ControlPoint2Checkbox.Size = new System.Drawing.Size(123, 17);
            this.ControlPoint2Checkbox.TabIndex = 73;
            this.ControlPoint2Checkbox.Text = "Show control point 2";
            this.ControlPoint2Checkbox.UseVisualStyleBackColor = true;
            // 
            // ControlPoint1Checkbox
            // 
            this.ControlPoint1Checkbox.AutoSize = true;
            this.ControlPoint1Checkbox.Checked = true;
            this.ControlPoint1Checkbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ControlPoint1Checkbox.Location = new System.Drawing.Point(251, 47);
            this.ControlPoint1Checkbox.Name = "ControlPoint1Checkbox";
            this.ControlPoint1Checkbox.Size = new System.Drawing.Size(123, 17);
            this.ControlPoint1Checkbox.TabIndex = 72;
            this.ControlPoint1Checkbox.Text = "Show control point 1";
            this.ControlPoint1Checkbox.UseVisualStyleBackColor = true;
            // 
            // EntryPointCheckbox
            // 
            this.EntryPointCheckbox.AutoSize = true;
            this.EntryPointCheckbox.Checked = true;
            this.EntryPointCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.EntryPointCheckbox.Location = new System.Drawing.Point(251, 24);
            this.EntryPointCheckbox.Name = "EntryPointCheckbox";
            this.EntryPointCheckbox.Size = new System.Drawing.Size(105, 17);
            this.EntryPointCheckbox.TabIndex = 71;
            this.EntryPointCheckbox.Text = "Show entry point";
            this.EntryPointCheckbox.UseVisualStyleBackColor = true;
            // 
            // SamplePointCheckbox
            // 
            this.SamplePointCheckbox.AutoSize = true;
            this.SamplePointCheckbox.Checked = true;
            this.SamplePointCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.SamplePointCheckbox.Location = new System.Drawing.Point(251, 116);
            this.SamplePointCheckbox.Name = "SamplePointCheckbox";
            this.SamplePointCheckbox.Size = new System.Drawing.Size(115, 17);
            this.SamplePointCheckbox.TabIndex = 4;
            this.SamplePointCheckbox.Text = "Show sample point";
            this.SamplePointCheckbox.UseVisualStyleBackColor = true;
            this.SamplePointCheckbox.CheckedChanged += new System.EventHandler(this.SamplePointCheckbox_CheckedChanged);
            // 
            // AccelVectorCheckbox
            // 
            this.AccelVectorCheckbox.AutoSize = true;
            this.AccelVectorCheckbox.Checked = true;
            this.AccelVectorCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.AccelVectorCheckbox.Location = new System.Drawing.Point(30, 116);
            this.AccelVectorCheckbox.Name = "AccelVectorCheckbox";
            this.AccelVectorCheckbox.Size = new System.Drawing.Size(171, 17);
            this.AccelVectorCheckbox.TabIndex = 3;
            this.AccelVectorCheckbox.Text = "Show acceleration vector (red)\r\n";
            this.AccelVectorCheckbox.UseVisualStyleBackColor = true;
            this.AccelVectorCheckbox.CheckedChanged += new System.EventHandler(this.AccelVectorCheckbox_CheckedChanged);
            // 
            // TangentCheckbox
            // 
            this.TangentCheckbox.AutoSize = true;
            this.TangentCheckbox.Checked = true;
            this.TangentCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.TangentCheckbox.Location = new System.Drawing.Point(30, 70);
            this.TangentCheckbox.Name = "TangentCheckbox";
            this.TangentCheckbox.Size = new System.Drawing.Size(140, 17);
            this.TangentCheckbox.TabIndex = 2;
            this.TangentCheckbox.Text = "Show tangent line (blue)";
            this.TangentCheckbox.UseVisualStyleBackColor = true;
            this.TangentCheckbox.CheckedChanged += new System.EventHandler(this.TangentCheckbox_CheckedChanged);
            // 
            // SplineCheckbox
            // 
            this.SplineCheckbox.AutoSize = true;
            this.SplineCheckbox.Checked = true;
            this.SplineCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.SplineCheckbox.Location = new System.Drawing.Point(30, 24);
            this.SplineCheckbox.Name = "SplineCheckbox";
            this.SplineCheckbox.Size = new System.Drawing.Size(118, 17);
            this.SplineCheckbox.TabIndex = 1;
            this.SplineCheckbox.Text = "Show spline (black)";
            this.SplineCheckbox.UseVisualStyleBackColor = true;
            this.SplineCheckbox.CheckedChanged += new System.EventHandler(this.SplineCheckbox_CheckedChanged);
            // 
            // BoundingPolyCheckbox
            // 
            this.BoundingPolyCheckbox.AutoSize = true;
            this.BoundingPolyCheckbox.Checked = true;
            this.BoundingPolyCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.BoundingPolyCheckbox.Location = new System.Drawing.Point(30, 47);
            this.BoundingPolyCheckbox.Name = "BoundingPolyCheckbox";
            this.BoundingPolyCheckbox.Size = new System.Drawing.Size(176, 17);
            this.BoundingPolyCheckbox.TabIndex = 0;
            this.BoundingPolyCheckbox.Text = "Show bounding polygon (green)";
            this.BoundingPolyCheckbox.UseVisualStyleBackColor = true;
            this.BoundingPolyCheckbox.CheckedChanged += new System.EventHandler(this.BoundingPolyCheckbox_CheckedChanged);
            // 
            // ControlPointGroupBox
            // 
            this.ControlPointGroupBox.Controls.Add(this.ExitPointY);
            this.ControlPointGroupBox.Controls.Add(this.ExitPointX);
            this.ControlPointGroupBox.Controls.Add(this.ControlPoint2Y);
            this.ControlPointGroupBox.Controls.Add(this.ControlPoint2X);
            this.ControlPointGroupBox.Controls.Add(this.ControlPoint1Y);
            this.ControlPointGroupBox.Controls.Add(this.ControlPoint1X);
            this.ControlPointGroupBox.Controls.Add(this.EntryPointY);
            this.ControlPointGroupBox.Controls.Add(this.EntryPointX);
            this.ControlPointGroupBox.Controls.Add(this.ExitPointHintLabel);
            this.ControlPointGroupBox.Controls.Add(this.ControlPoint2HintLabel);
            this.ControlPointGroupBox.Controls.Add(this.ControlPoint1HintLabel);
            this.ControlPointGroupBox.Controls.Add(this.EntryPointHintLabel);
            this.ControlPointGroupBox.Controls.Add(this.ResetButton);
            this.ControlPointGroupBox.Controls.Add(this.YCoordHintLabel);
            this.ControlPointGroupBox.Controls.Add(this.XCoordHintLabel);
            this.ControlPointGroupBox.Location = new System.Drawing.Point(3, 3);
            this.ControlPointGroupBox.Name = "ControlPointGroupBox";
            this.ControlPointGroupBox.Padding = new System.Windows.Forms.Padding(6);
            this.ControlPointGroupBox.Size = new System.Drawing.Size(235, 185);
            this.ControlPointGroupBox.TabIndex = 42;
            this.ControlPointGroupBox.TabStop = false;
            this.ControlPointGroupBox.Text = "Spline Control Points";
            // 
            // ExitPointHintLabel
            // 
            this.ExitPointHintLabel.AutoSize = true;
            this.ExitPointHintLabel.Location = new System.Drawing.Point(34, 127);
            this.ExitPointHintLabel.Name = "ExitPointHintLabel";
            this.ExitPointHintLabel.Size = new System.Drawing.Size(50, 13);
            this.ExitPointHintLabel.TabIndex = 71;
            this.ExitPointHintLabel.Text = "Exit point";
            this.ExitPointHintLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // ControlPoint2HintLabel
            // 
            this.ControlPoint2HintLabel.AutoSize = true;
            this.ControlPoint2HintLabel.Location = new System.Drawing.Point(9, 101);
            this.ControlPoint2HintLabel.Name = "ControlPoint2HintLabel";
            this.ControlPoint2HintLabel.Size = new System.Drawing.Size(75, 13);
            this.ControlPoint2HintLabel.TabIndex = 70;
            this.ControlPoint2HintLabel.Text = "Control point 2";
            this.ControlPoint2HintLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // ControlPoint1HintLabel
            // 
            this.ControlPoint1HintLabel.AutoSize = true;
            this.ControlPoint1HintLabel.Location = new System.Drawing.Point(9, 75);
            this.ControlPoint1HintLabel.Name = "ControlPoint1HintLabel";
            this.ControlPoint1HintLabel.Size = new System.Drawing.Size(75, 13);
            this.ControlPoint1HintLabel.TabIndex = 69;
            this.ControlPoint1HintLabel.Text = "Control point 1";
            this.ControlPoint1HintLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // EntryPointHintLabel
            // 
            this.EntryPointHintLabel.AutoSize = true;
            this.EntryPointHintLabel.Location = new System.Drawing.Point(27, 49);
            this.EntryPointHintLabel.Name = "EntryPointHintLabel";
            this.EntryPointHintLabel.Size = new System.Drawing.Size(57, 13);
            this.EntryPointHintLabel.TabIndex = 68;
            this.EntryPointHintLabel.Text = "Entry point";
            this.EntryPointHintLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // ResetButton
            // 
            this.ResetButton.Location = new System.Drawing.Point(41, 153);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(153, 23);
            this.ResetButton.TabIndex = 3;
            this.ResetButton.Text = "Reset Control Points";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // YCoordHintLabel
            // 
            this.YCoordHintLabel.AutoSize = true;
            this.YCoordHintLabel.Location = new System.Drawing.Point(186, 24);
            this.YCoordHintLabel.Name = "YCoordHintLabel";
            this.YCoordHintLabel.Size = new System.Drawing.Size(14, 13);
            this.YCoordHintLabel.TabIndex = 67;
            this.YCoordHintLabel.Text = "Y";
            // 
            // XCoordHintLabel
            // 
            this.XCoordHintLabel.AutoSize = true;
            this.XCoordHintLabel.Location = new System.Drawing.Point(115, 24);
            this.XCoordHintLabel.Name = "XCoordHintLabel";
            this.XCoordHintLabel.Size = new System.Drawing.Size(14, 13);
            this.XCoordHintLabel.TabIndex = 66;
            this.XCoordHintLabel.Text = "X";
            // 
            // Viewport
            // 
            this.Viewport.BackColor = System.Drawing.Color.White;
            this.Viewport.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Viewport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Viewport.Location = new System.Drawing.Point(3, 3);
            this.Viewport.Name = "Viewport";
            this.Viewport.Size = new System.Drawing.Size(306, 540);
            this.Viewport.TabIndex = 44;
            this.Viewport.TabStop = false;
            // 
            // EntryPointX
            // 
            this.EntryPointX.Location = new System.Drawing.Point(90, 47);
            this.EntryPointX.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.EntryPointX.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.EntryPointX.Name = "EntryPointX";
            this.EntryPointX.Size = new System.Drawing.Size(65, 20);
            this.EntryPointX.TabIndex = 72;
            this.EntryPointX.ValueChanged += new System.EventHandler(this.EntryPointX_ValueChanged);
            // 
            // EntryPointY
            // 
            this.EntryPointY.Location = new System.Drawing.Point(161, 47);
            this.EntryPointY.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.EntryPointY.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.EntryPointY.Name = "EntryPointY";
            this.EntryPointY.Size = new System.Drawing.Size(65, 20);
            this.EntryPointY.TabIndex = 73;
            this.EntryPointY.ValueChanged += new System.EventHandler(this.EntryPointY_ValueChanged);
            // 
            // ControlPoint1X
            // 
            this.ControlPoint1X.Location = new System.Drawing.Point(90, 73);
            this.ControlPoint1X.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.ControlPoint1X.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.ControlPoint1X.Name = "ControlPoint1X";
            this.ControlPoint1X.Size = new System.Drawing.Size(65, 20);
            this.ControlPoint1X.TabIndex = 74;
            this.ControlPoint1X.ValueChanged += new System.EventHandler(this.ControlPoint1X_ValueChanged);
            // 
            // ControlPoint1Y
            // 
            this.ControlPoint1Y.Location = new System.Drawing.Point(161, 73);
            this.ControlPoint1Y.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.ControlPoint1Y.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.ControlPoint1Y.Name = "ControlPoint1Y";
            this.ControlPoint1Y.Size = new System.Drawing.Size(65, 20);
            this.ControlPoint1Y.TabIndex = 75;
            this.ControlPoint1Y.ValueChanged += new System.EventHandler(this.ControlPoint1Y_ValueChanged);
            // 
            // ControlPoint2Y
            // 
            this.ControlPoint2Y.Location = new System.Drawing.Point(161, 99);
            this.ControlPoint2Y.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.ControlPoint2Y.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.ControlPoint2Y.Name = "ControlPoint2Y";
            this.ControlPoint2Y.Size = new System.Drawing.Size(65, 20);
            this.ControlPoint2Y.TabIndex = 77;
            this.ControlPoint2Y.ValueChanged += new System.EventHandler(this.ControlPoint2Y_ValueChanged);
            // 
            // ControlPoint2X
            // 
            this.ControlPoint2X.Location = new System.Drawing.Point(90, 99);
            this.ControlPoint2X.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.ControlPoint2X.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.ControlPoint2X.Name = "ControlPoint2X";
            this.ControlPoint2X.Size = new System.Drawing.Size(65, 20);
            this.ControlPoint2X.TabIndex = 76;
            this.ControlPoint2X.ValueChanged += new System.EventHandler(this.ControlPoint2X_ValueChanged);
            // 
            // ExitPointY
            // 
            this.ExitPointY.Location = new System.Drawing.Point(161, 125);
            this.ExitPointY.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.ExitPointY.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.ExitPointY.Name = "ExitPointY";
            this.ExitPointY.Size = new System.Drawing.Size(65, 20);
            this.ExitPointY.TabIndex = 79;
            this.ExitPointY.ValueChanged += new System.EventHandler(this.ExitPointY_ValueChanged);
            // 
            // ExitPointX
            // 
            this.ExitPointX.Location = new System.Drawing.Point(90, 125);
            this.ExitPointX.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.ExitPointX.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.ExitPointX.Name = "ExitPointX";
            this.ExitPointX.Size = new System.Drawing.Size(65, 20);
            this.ExitPointX.TabIndex = 78;
            this.ExitPointX.ValueChanged += new System.EventHandler(this.ExitPointX_ValueChanged);
            // 
            // ArcErrorHintLabel
            // 
            this.ArcErrorHintLabel.AutoSize = true;
            this.ArcErrorHintLabel.Location = new System.Drawing.Point(151, 24);
            this.ArcErrorHintLabel.Name = "ArcErrorHintLabel";
            this.ArcErrorHintLabel.Size = new System.Drawing.Size(29, 13);
            this.ArcErrorHintLabel.TabIndex = 9;
            this.ArcErrorHintLabel.Text = "Error";
            // 
            // ArcResultHintLabel
            // 
            this.ArcResultHintLabel.AutoSize = true;
            this.ArcResultHintLabel.Location = new System.Drawing.Point(83, 24);
            this.ArcResultHintLabel.Name = "ArcResultHintLabel";
            this.ArcResultHintLabel.Size = new System.Drawing.Size(37, 13);
            this.ArcResultHintLabel.TabIndex = 10;
            this.ArcResultHintLabel.Text = "Result";
            // 
            // ReticulatorToolTips
            // 
            this.ReticulatorToolTips.ShowAlways = true;
            // 
            // DXRatioHintLabel
            // 
            this.DXRatioHintLabel.AutoSize = true;
            this.DXRatioHintLabel.Location = new System.Drawing.Point(179, 99);
            this.DXRatioHintLabel.Name = "DXRatioHintLabel";
            this.DXRatioHintLabel.Size = new System.Drawing.Size(35, 13);
            this.DXRatioHintLabel.TabIndex = 50;
            this.DXRatioHintLabel.Text = "Ratio:";
            // 
            // D2XRatioHintLabel
            // 
            this.D2XRatioHintLabel.AutoSize = true;
            this.D2XRatioHintLabel.Location = new System.Drawing.Point(179, 126);
            this.D2XRatioHintLabel.Name = "D2XRatioHintLabel";
            this.D2XRatioHintLabel.Size = new System.Drawing.Size(35, 13);
            this.D2XRatioHintLabel.TabIndex = 51;
            this.D2XRatioHintLabel.Text = "Ratio:";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusLabelMouseCoordinates});
            this.statusStrip1.Location = new System.Drawing.Point(0, 552);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(782, 22);
            this.statusStrip1.TabIndex = 44;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // StatusLabelMouseCoordinates
            // 
            this.StatusLabelMouseCoordinates.Name = "StatusLabelMouseCoordinates";
            this.StatusLabelMouseCoordinates.Size = new System.Drawing.Size(121, 17);
            this.StatusLabelMouseCoordinates.Text = "Mouse Position: (0, 0)";
            // 
            // NormalCheckBox
            // 
            this.NormalCheckBox.AutoSize = true;
            this.NormalCheckBox.Checked = true;
            this.NormalCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.NormalCheckBox.Location = new System.Drawing.Point(30, 93);
            this.NormalCheckBox.Name = "NormalCheckBox";
            this.NormalCheckBox.Size = new System.Drawing.Size(156, 17);
            this.NormalCheckBox.TabIndex = 75;
            this.NormalCheckBox.Text = "Show normal vector (green)";
            this.NormalCheckBox.UseVisualStyleBackColor = true;
            this.NormalCheckBox.CheckedChanged += new System.EventHandler(this.NormalCheckBox_CheckedChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 574);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.MasterLayoutPanel);
            this.MinimumSize = new System.Drawing.Size(790, 562);
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "The Reticulator";
            this.MasterLayoutPanel.ResumeLayout(false);
            this.WidgetyPanel.ResumeLayout(false);
            this.ArcLengthGroupBox.ResumeLayout(false);
            this.ArcLengthGroupBox.PerformLayout();
            this.SamplePointGroupBox.ResumeLayout(false);
            this.SamplePointGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SampleTPicker)).EndInit();
            this.DisplayOptions.ResumeLayout(false);
            this.DisplayOptions.PerformLayout();
            this.ControlPointGroupBox.ResumeLayout(false);
            this.ControlPointGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Viewport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EntryPointX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EntryPointY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ControlPoint1X)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ControlPoint1Y)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ControlPoint2Y)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ControlPoint2X)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitPointY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitPointX)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

        private System.Windows.Forms.TableLayoutPanel MasterLayoutPanel;
        private System.Windows.Forms.Panel WidgetyPanel;
        private System.Windows.Forms.GroupBox SamplePointGroupBox;
        private System.Windows.Forms.TextBox D2XD2YRatioBox;
        private System.Windows.Forms.Label D2YHintLabel;
        private System.Windows.Forms.TextBox SampleD2YBox;
        private System.Windows.Forms.Label D2XHintLabel;
        private System.Windows.Forms.TextBox SampleD2XBox;
        private System.Windows.Forms.TextBox DXDYRatioBox;
        private System.Windows.Forms.TextBox SampleDYBox;
        private System.Windows.Forms.Label SampleDYHint;
        private System.Windows.Forms.TextBox SampleDXBox;
        private System.Windows.Forms.Label SampleDXHint;
        private System.Windows.Forms.TextBox SampleYBox;
        private System.Windows.Forms.Label SampleYHint;
        private System.Windows.Forms.TextBox SampleXBox;
        private System.Windows.Forms.Label SampleXHint;
        private System.Windows.Forms.TrackBar SampleTPicker;
        private System.Windows.Forms.Label THintLabel;
        private System.Windows.Forms.TextBox TBox;
        private System.Windows.Forms.GroupBox DisplayOptions;
        private System.Windows.Forms.CheckBox SamplePointCheckbox;
        private System.Windows.Forms.CheckBox AccelVectorCheckbox;
        private System.Windows.Forms.CheckBox TangentCheckbox;
        private System.Windows.Forms.CheckBox SplineCheckbox;
        private System.Windows.Forms.CheckBox BoundingPolyCheckbox;
        private System.Windows.Forms.GroupBox ControlPointGroupBox;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Label YCoordHintLabel;
        private System.Windows.Forms.Label XCoordHintLabel;
        private System.Windows.Forms.PictureBox Viewport;
        private System.Windows.Forms.GroupBox ArcLengthGroupBox;
        private System.Windows.Forms.Label EstArcLenBPMethodHintLabel;
        private System.Windows.Forms.TextBox EstArcLenBPBox;
        private System.Windows.Forms.Label EstArcLenNumericHintLabel;
        private System.Windows.Forms.TextBox EstArcLenNumericalBox;
        private System.Windows.Forms.Label EstArcLenWBPHintLabel;
        private System.Windows.Forms.TextBox EstArcLenWBPBox;
        private System.Windows.Forms.TextBox EstArcLenBPErrorBox;
        private System.Windows.Forms.TextBox EstArcLenWBPErrorBox;
        private System.Windows.Forms.CheckBox ExitPointCheckbox;
        private System.Windows.Forms.CheckBox ControlPoint2Checkbox;
        private System.Windows.Forms.CheckBox ControlPoint1Checkbox;
        private System.Windows.Forms.CheckBox EntryPointCheckbox;
        private System.Windows.Forms.Label EntryPointHintLabel;
        private System.Windows.Forms.Label ControlPoint2HintLabel;
        private System.Windows.Forms.Label ControlPoint1HintLabel;
        private System.Windows.Forms.Label ExitPointHintLabel;
        private System.Windows.Forms.NumericUpDown EntryPointX;
        private System.Windows.Forms.NumericUpDown EntryPointY;
        private System.Windows.Forms.NumericUpDown ControlPoint1X;
        private System.Windows.Forms.NumericUpDown ControlPoint1Y;
        private System.Windows.Forms.NumericUpDown ControlPoint2Y;
        private System.Windows.Forms.NumericUpDown ControlPoint2X;
        private System.Windows.Forms.NumericUpDown ExitPointY;
        private System.Windows.Forms.NumericUpDown ExitPointX;
        private System.Windows.Forms.Label ArcErrorHintLabel;
        private System.Windows.Forms.Label ArcResultHintLabel;
        private System.Windows.Forms.ToolTip ReticulatorToolTips;
        private System.Windows.Forms.Label DXRatioHintLabel;
        private System.Windows.Forms.Label D2XRatioHintLabel;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel StatusLabelMouseCoordinates;
        private System.Windows.Forms.CheckBox NormalCheckBox;
    }
}

