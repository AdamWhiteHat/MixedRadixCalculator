/*
 *
 * Developed by Adam White 
 *  http://csharpcodewhisperer.blogspot.com
 *    http://aWhite.wix.com/intelligentsoftware
 *
 *
 * Made using SharpDevelop
 *
 * 
 */
namespace RadixCalculator
{
    partial class MainForm
    {
        /// <summary>
        /// Designer variable used to keep track of non-visual components.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Disposes resources used by the form.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        /// <summary>
        /// This method is required for Windows Forms designer support.
        /// Do not change the method contents inside the source code editor. The Forms designer might
        /// not be able to load this method if it was changed manually.
        /// </summary>
        private void InitializeComponent()
        {
			this.components = new System.ComponentModel.Container();
			this.tbTabularFormat = new System.Windows.Forms.TextBox();
			this.btnIncrement = new System.Windows.Forms.Button();
			this.btnIncrement10 = new System.Windows.Forms.Button();
			this.btnIncrement100 = new System.Windows.Forms.Button();
			this.btnAuto = new System.Windows.Forms.Button();
			this.timerAutoIncrement = new System.Windows.Forms.Timer(this.components);
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.button0 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.button6 = new System.Windows.Forms.Button();
			this.button7 = new System.Windows.Forms.Button();
			this.btnCustomAmmount = new System.Windows.Forms.Button();
			this.tbIncrementAmmount = new System.Windows.Forms.TextBox();
			this.btnIncrement5 = new System.Windows.Forms.Button();
			this.btnClear = new System.Windows.Forms.Button();
			this.cbLeftToRight = new System.Windows.Forms.CheckBox();
			this.panelRadixUse = new System.Windows.Forms.Panel();
			this.tbNumeralFormat = new System.Windows.Forms.TextBox();
			this.tbDecimalValue = new System.Windows.Forms.TextBox();
			this.labelHeaderRight = new System.Windows.Forms.Label();
			this.panelRadixChoose = new System.Windows.Forms.Panel();
			this.labelHeaderLeft = new System.Windows.Forms.Label();
			this.panelCustom = new System.Windows.Forms.Panel();
			this.btnCancel = new System.Windows.Forms.Button();
			this.lblCustomDisplay = new System.Windows.Forms.Label();
			this.tbCustomDigit = new System.Windows.Forms.TextBox();
			this.btnCustomSave = new System.Windows.Forms.Button();
			this.btnCustomAdd = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.btnCreate = new System.Windows.Forms.Button();
			this.btnLoad = new System.Windows.Forms.Button();
			this.listNumberSystems = new System.Windows.Forms.ListBox();
			this.errorProvider_CustomDigit = new System.Windows.Forms.ErrorProvider(this.components);
			this.groupBox1.SuspendLayout();
			this.flowLayoutPanel1.SuspendLayout();
			this.panelRadixUse.SuspendLayout();
			this.panelRadixChoose.SuspendLayout();
			this.panelCustom.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider_CustomDigit)).BeginInit();
			this.SuspendLayout();
			// 
			// tbTabularFormat
			// 
			this.tbTabularFormat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tbTabularFormat.BackColor = System.Drawing.SystemColors.Control;
			this.tbTabularFormat.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbTabularFormat.Location = new System.Drawing.Point(4, 28);
			this.tbTabularFormat.Name = "tbTabularFormat";
			this.tbTabularFormat.Size = new System.Drawing.Size(664, 21);
			this.tbTabularFormat.TabIndex = 0;
			this.tbTabularFormat.Text = "0 : 0 : 0 : 0 ";
			this.tbTabularFormat.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.tbTabularFormat.WordWrap = false;
			// 
			// btnIncrement
			// 
			this.btnIncrement.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnIncrement.Location = new System.Drawing.Point(363, 16);
			this.btnIncrement.Name = "btnIncrement";
			this.btnIncrement.Size = new System.Drawing.Size(33, 23);
			this.btnIncrement.TabIndex = 1;
			this.btnIncrement.Text = "1";
			this.btnIncrement.UseVisualStyleBackColor = true;
			this.btnIncrement.Click += new System.EventHandler(this.BtnIncrementClick);
			// 
			// btnIncrement10
			// 
			this.btnIncrement10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnIncrement10.Location = new System.Drawing.Point(441, 16);
			this.btnIncrement10.Name = "btnIncrement10";
			this.btnIncrement10.Size = new System.Drawing.Size(33, 23);
			this.btnIncrement10.TabIndex = 2;
			this.btnIncrement10.Text = "10";
			this.btnIncrement10.UseVisualStyleBackColor = true;
			this.btnIncrement10.Click += new System.EventHandler(this.BtnIncrement10Click);
			// 
			// btnIncrement100
			// 
			this.btnIncrement100.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnIncrement100.Location = new System.Drawing.Point(480, 16);
			this.btnIncrement100.Name = "btnIncrement100";
			this.btnIncrement100.Size = new System.Drawing.Size(33, 23);
			this.btnIncrement100.TabIndex = 3;
			this.btnIncrement100.Text = "100";
			this.btnIncrement100.UseVisualStyleBackColor = true;
			this.btnIncrement100.Click += new System.EventHandler(this.BtnIncrement100Click);
			// 
			// btnAuto
			// 
			this.btnAuto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnAuto.Location = new System.Drawing.Point(519, 16);
			this.btnAuto.Name = "btnAuto";
			this.btnAuto.Size = new System.Drawing.Size(95, 23);
			this.btnAuto.TabIndex = 4;
			this.btnAuto.Text = "Auto Increment";
			this.btnAuto.UseVisualStyleBackColor = true;
			this.btnAuto.Click += new System.EventHandler(this.BtnAutoClick);
			// 
			// timerAutoIncrement
			// 
			this.timerAutoIncrement.Interval = 1000;
			this.timerAutoIncrement.Tick += new System.EventHandler(this.AutoIncrement1Tick);
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox1.Controls.Add(this.flowLayoutPanel1);
			this.groupBox1.Controls.Add(this.btnCustomAmmount);
			this.groupBox1.Controls.Add(this.tbIncrementAmmount);
			this.groupBox1.Controls.Add(this.btnIncrement5);
			this.groupBox1.Controls.Add(this.btnIncrement);
			this.groupBox1.Controls.Add(this.btnAuto);
			this.groupBox1.Controls.Add(this.btnIncrement10);
			this.groupBox1.Controls.Add(this.btnIncrement100);
			this.groupBox1.Location = new System.Drawing.Point(52, 100);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(618, 107);
			this.groupBox1.TabIndex = 5;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Increase value:";
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.flowLayoutPanel1.Controls.Add(this.button0);
			this.flowLayoutPanel1.Controls.Add(this.button1);
			this.flowLayoutPanel1.Controls.Add(this.button2);
			this.flowLayoutPanel1.Controls.Add(this.button3);
			this.flowLayoutPanel1.Controls.Add(this.button4);
			this.flowLayoutPanel1.Controls.Add(this.button5);
			this.flowLayoutPanel1.Controls.Add(this.button6);
			this.flowLayoutPanel1.Controls.Add(this.button7);
			this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
			this.flowLayoutPanel1.Location = new System.Drawing.Point(8, 40);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(605, 32);
			this.flowLayoutPanel1.TabIndex = 9;
			// 
			// button0
			// 
			this.button0.AutoSize = true;
			this.button0.Location = new System.Drawing.Point(561, 3);
			this.button0.Name = "button0";
			this.button0.Size = new System.Drawing.Size(41, 25);
			this.button0.TabIndex = 8;
			this.button0.Text = "n^0";
			this.button0.UseVisualStyleBackColor = true;
			// 
			// button1
			// 
			this.button1.AutoSize = true;
			this.button1.Location = new System.Drawing.Point(514, 3);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(41, 25);
			this.button1.TabIndex = 9;
			this.button1.Text = "n^1";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// button2
			// 
			this.button2.AutoSize = true;
			this.button2.Location = new System.Drawing.Point(467, 3);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(41, 25);
			this.button2.TabIndex = 10;
			this.button2.Text = "n^2";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// button3
			// 
			this.button3.AutoSize = true;
			this.button3.Location = new System.Drawing.Point(420, 3);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(41, 25);
			this.button3.TabIndex = 11;
			this.button3.Text = "n^3";
			this.button3.UseVisualStyleBackColor = true;
			// 
			// button4
			// 
			this.button4.AutoSize = true;
			this.button4.Location = new System.Drawing.Point(373, 3);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(41, 25);
			this.button4.TabIndex = 12;
			this.button4.Text = "n^4";
			this.button4.UseVisualStyleBackColor = true;
			// 
			// button5
			// 
			this.button5.AutoSize = true;
			this.button5.Location = new System.Drawing.Point(326, 3);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(41, 25);
			this.button5.TabIndex = 13;
			this.button5.Text = "n^5";
			this.button5.UseVisualStyleBackColor = true;
			// 
			// button6
			// 
			this.button6.AutoSize = true;
			this.button6.Location = new System.Drawing.Point(279, 3);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(41, 25);
			this.button6.TabIndex = 14;
			this.button6.Text = "n^6";
			this.button6.UseVisualStyleBackColor = true;
			// 
			// button7
			// 
			this.button7.AutoSize = true;
			this.button7.Location = new System.Drawing.Point(232, 3);
			this.button7.Name = "button7";
			this.button7.Size = new System.Drawing.Size(41, 25);
			this.button7.TabIndex = 16;
			this.button7.Text = "n^7";
			this.button7.UseVisualStyleBackColor = true;
			// 
			// btnCustomAmmount
			// 
			this.btnCustomAmmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCustomAmmount.Location = new System.Drawing.Point(480, 80);
			this.btnCustomAmmount.Name = "btnCustomAmmount";
			this.btnCustomAmmount.Size = new System.Drawing.Size(134, 23);
			this.btnCustomAmmount.TabIndex = 7;
			this.btnCustomAmmount.Text = "<--   Custom Ammount";
			this.btnCustomAmmount.UseVisualStyleBackColor = true;
			this.btnCustomAmmount.Click += new System.EventHandler(this.btnCustomAmmount_Click);
			// 
			// tbIncrementAmmount
			// 
			this.tbIncrementAmmount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tbIncrementAmmount.Location = new System.Drawing.Point(8, 80);
			this.tbIncrementAmmount.Name = "tbIncrementAmmount";
			this.tbIncrementAmmount.Size = new System.Drawing.Size(470, 20);
			this.tbIncrementAmmount.TabIndex = 6;
			this.tbIncrementAmmount.Text = "13";
			this.tbIncrementAmmount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbIncrementAmmount_KeyDown);
			// 
			// btnIncrement5
			// 
			this.btnIncrement5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnIncrement5.Location = new System.Drawing.Point(402, 16);
			this.btnIncrement5.Name = "btnIncrement5";
			this.btnIncrement5.Size = new System.Drawing.Size(33, 23);
			this.btnIncrement5.TabIndex = 5;
			this.btnIncrement5.Text = "5";
			this.btnIncrement5.UseVisualStyleBackColor = true;
			this.btnIncrement5.Click += new System.EventHandler(this.btnIncrement5_Click);
			// 
			// btnClear
			// 
			this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnClear.AutoSize = true;
			this.btnClear.Location = new System.Drawing.Point(592, 2);
			this.btnClear.Name = "btnClear";
			this.btnClear.Size = new System.Drawing.Size(75, 23);
			this.btnClear.TabIndex = 7;
			this.btnClear.Text = "Clear";
			this.btnClear.UseVisualStyleBackColor = true;
			this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
			// 
			// cbLeftToRight
			// 
			this.cbLeftToRight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.cbLeftToRight.AutoSize = true;
			this.cbLeftToRight.Location = new System.Drawing.Point(376, 8);
			this.cbLeftToRight.Name = "cbLeftToRight";
			this.cbLeftToRight.Size = new System.Drawing.Size(215, 17);
			this.cbLeftToRight.TabIndex = 9;
			this.cbLeftToRight.Text = "Left-to-right (Most signifigant digit on left)";
			this.cbLeftToRight.UseVisualStyleBackColor = true;
			this.cbLeftToRight.CheckedChanged += new System.EventHandler(this.cbRightToLeft_CheckedChanged);
			// 
			// panelRadixUse
			// 
			this.panelRadixUse.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panelRadixUse.Controls.Add(this.tbNumeralFormat);
			this.panelRadixUse.Controls.Add(this.tbDecimalValue);
			this.panelRadixUse.Controls.Add(this.tbTabularFormat);
			this.panelRadixUse.Controls.Add(this.cbLeftToRight);
			this.panelRadixUse.Controls.Add(this.groupBox1);
			this.panelRadixUse.Controls.Add(this.btnClear);
			this.panelRadixUse.Controls.Add(this.labelHeaderRight);
			this.panelRadixUse.Location = new System.Drawing.Point(9, 192);
			this.panelRadixUse.Name = "panelRadixUse";
			this.panelRadixUse.Size = new System.Drawing.Size(673, 210);
			this.panelRadixUse.TabIndex = 10;
			// 
			// tbNumeralFormat
			// 
			this.tbNumeralFormat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tbNumeralFormat.BackColor = System.Drawing.SystemColors.Control;
			this.tbNumeralFormat.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.tbNumeralFormat.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbNumeralFormat.Location = new System.Drawing.Point(8, 52);
			this.tbNumeralFormat.Name = "tbNumeralFormat";
			this.tbNumeralFormat.Size = new System.Drawing.Size(659, 14);
			this.tbNumeralFormat.TabIndex = 15;
			this.tbNumeralFormat.Text = "[0] [0] [0] [0]";
			this.tbNumeralFormat.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.tbNumeralFormat.WordWrap = false;
			// 
			// tbDecimalValue
			// 
			this.tbDecimalValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tbDecimalValue.BackColor = System.Drawing.SystemColors.Control;
			this.tbDecimalValue.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.tbDecimalValue.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbDecimalValue.Location = new System.Drawing.Point(8, 76);
			this.tbDecimalValue.Name = "tbDecimalValue";
			this.tbDecimalValue.Size = new System.Drawing.Size(659, 14);
			this.tbDecimalValue.TabIndex = 14;
			this.tbDecimalValue.Text = "0";
			this.tbDecimalValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.tbDecimalValue.WordWrap = false;
			// 
			// labelHeaderRight
			// 
			this.labelHeaderRight.Location = new System.Drawing.Point(3, 4);
			this.labelHeaderRight.Name = "labelHeaderRight";
			this.labelHeaderRight.Size = new System.Drawing.Size(269, 13);
			this.labelHeaderRight.TabIndex = 12;
			this.labelHeaderRight.Text = "    Use your mixed radix number system:";
			// 
			// panelRadixChoose
			// 
			this.panelRadixChoose.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panelRadixChoose.Controls.Add(this.labelHeaderLeft);
			this.panelRadixChoose.Controls.Add(this.panelCustom);
			this.panelRadixChoose.Controls.Add(this.label1);
			this.panelRadixChoose.Controls.Add(this.btnCreate);
			this.panelRadixChoose.Controls.Add(this.btnLoad);
			this.panelRadixChoose.Controls.Add(this.listNumberSystems);
			this.panelRadixChoose.Location = new System.Drawing.Point(9, 10);
			this.panelRadixChoose.Name = "panelRadixChoose";
			this.panelRadixChoose.Size = new System.Drawing.Size(673, 178);
			this.panelRadixChoose.TabIndex = 11;
			// 
			// labelHeaderLeft
			// 
			this.labelHeaderLeft.Location = new System.Drawing.Point(3, 4);
			this.labelHeaderLeft.Name = "labelHeaderLeft";
			this.labelHeaderLeft.Size = new System.Drawing.Size(294, 13);
			this.labelHeaderLeft.TabIndex = 13;
			this.labelHeaderLeft.Text = "      Choose/Create a mixed radix number system";
			// 
			// panelCustom
			// 
			this.panelCustom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panelCustom.Controls.Add(this.btnCancel);
			this.panelCustom.Controls.Add(this.lblCustomDisplay);
			this.panelCustom.Controls.Add(this.tbCustomDigit);
			this.panelCustom.Controls.Add(this.btnCustomSave);
			this.panelCustom.Controls.Add(this.btnCustomAdd);
			this.panelCustom.Location = new System.Drawing.Point(218, 88);
			this.panelCustom.Name = "panelCustom";
			this.panelCustom.Size = new System.Drawing.Size(452, 76);
			this.panelCustom.TabIndex = 12;
			this.panelCustom.Visible = false;
			// 
			// btnCancel
			// 
			this.btnCancel.Location = new System.Drawing.Point(84, 48);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 11;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnAbort_Click);
			// 
			// lblCustomDisplay
			// 
			this.lblCustomDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.lblCustomDisplay.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Bold);
			this.lblCustomDisplay.Location = new System.Drawing.Point(3, 6);
			this.lblCustomDisplay.Name = "lblCustomDisplay";
			this.lblCustomDisplay.Size = new System.Drawing.Size(365, 16);
			this.lblCustomDisplay.TabIndex = 10;
			this.lblCustomDisplay.Text = "0:0:0:0";
			this.lblCustomDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// tbCustomDigit
			// 
			this.tbCustomDigit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.tbCustomDigit.Location = new System.Drawing.Point(6, 26);
			this.tbCustomDigit.Name = "tbCustomDigit";
			this.tbCustomDigit.Size = new System.Drawing.Size(347, 20);
			this.tbCustomDigit.TabIndex = 4;
			this.tbCustomDigit.TextChanged += new System.EventHandler(this.tbCustomDigit_TextChanged);
			this.tbCustomDigit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbCustomDigit_KeyDown);
			// 
			// btnCustomSave
			// 
			this.btnCustomSave.Location = new System.Drawing.Point(4, 48);
			this.btnCustomSave.Name = "btnCustomSave";
			this.btnCustomSave.Size = new System.Drawing.Size(75, 23);
			this.btnCustomSave.TabIndex = 6;
			this.btnCustomSave.Text = "<--  Save ";
			this.btnCustomSave.UseVisualStyleBackColor = true;
			this.btnCustomSave.Click += new System.EventHandler(this.btnCustomSave_Click);
			// 
			// btnCustomAdd
			// 
			this.btnCustomAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCustomAdd.Location = new System.Drawing.Point(374, 26);
			this.btnCustomAdd.Name = "btnCustomAdd";
			this.btnCustomAdd.Size = new System.Drawing.Size(75, 23);
			this.btnCustomAdd.TabIndex = 5;
			this.btnCustomAdd.Text = "Add base";
			this.btnCustomAdd.UseVisualStyleBackColor = true;
			this.btnCustomAdd.Click += new System.EventHandler(this.btnCustomAdd_Click);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(220, 48);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(160, 13);
			this.label1.TabIndex = 3;
			this.label1.Text = "- or -";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btnCreate
			// 
			this.btnCreate.Location = new System.Drawing.Point(220, 60);
			this.btnCreate.Name = "btnCreate";
			this.btnCreate.Size = new System.Drawing.Size(160, 23);
			this.btnCreate.TabIndex = 2;
			this.btnCreate.Text = "Create a new one";
			this.btnCreate.UseVisualStyleBackColor = true;
			this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
			// 
			// btnLoad
			// 
			this.btnLoad.Location = new System.Drawing.Point(220, 23);
			this.btnLoad.Name = "btnLoad";
			this.btnLoad.Size = new System.Drawing.Size(160, 23);
			this.btnLoad.TabIndex = 1;
			this.btnLoad.Text = "Load numbering system";
			this.btnLoad.UseVisualStyleBackColor = true;
			this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
			// 
			// listNumberSystems
			// 
			this.listNumberSystems.FormattingEnabled = true;
			this.listNumberSystems.Location = new System.Drawing.Point(5, 24);
			this.listNumberSystems.Name = "listNumberSystems";
			this.listNumberSystems.Size = new System.Drawing.Size(207, 147);
			this.listNumberSystems.TabIndex = 0;
			// 
			// errorProvider_CustomDigit
			// 
			this.errorProvider_CustomDigit.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
			this.errorProvider_CustomDigit.ContainerControl = this;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.ClientSize = new System.Drawing.Size(691, 412);
			this.Controls.Add(this.panelRadixUse);
			this.Controls.Add(this.panelRadixChoose);
			this.MinimumSize = new System.Drawing.Size(600, 450);
			this.Name = "MainForm";
			this.Text = "Mixed Radix Numbering System Creater & Calculator";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.flowLayoutPanel1.ResumeLayout(false);
			this.flowLayoutPanel1.PerformLayout();
			this.panelRadixUse.ResumeLayout(false);
			this.panelRadixUse.PerformLayout();
			this.panelRadixChoose.ResumeLayout(false);
			this.panelCustom.ResumeLayout(false);
			this.panelCustom.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider_CustomDigit)).EndInit();
			this.ResumeLayout(false);

        }
        private System.Windows.Forms.Timer timerAutoIncrement;
        private System.Windows.Forms.Button btnAuto;
        private System.Windows.Forms.Button btnIncrement100;
        private System.Windows.Forms.Button btnIncrement10;
        private System.Windows.Forms.Button btnIncrement;
        private System.Windows.Forms.TextBox tbTabularFormat;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnIncrement5;
        private System.Windows.Forms.Button btnCustomAmmount;
        private System.Windows.Forms.TextBox tbIncrementAmmount;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.CheckBox cbLeftToRight;
        private System.Windows.Forms.Panel panelRadixUse;
        private System.Windows.Forms.Panel panelRadixChoose;
        private System.Windows.Forms.Panel panelCustom;
        private System.Windows.Forms.Label lblCustomDisplay;
        private System.Windows.Forms.TextBox tbCustomDigit;
        private System.Windows.Forms.Button btnCustomSave;
        private System.Windows.Forms.Button btnCustomAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.ListBox listNumberSystems;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label labelHeaderRight;
        private System.Windows.Forms.Label labelHeaderLeft;
        private System.Windows.Forms.TextBox tbDecimalValue;
        private System.Windows.Forms.TextBox tbNumeralFormat;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
		private System.Windows.Forms.ErrorProvider errorProvider_CustomDigit;
	}
}
