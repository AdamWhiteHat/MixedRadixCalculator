/*
 *
 * Developed by Adam Rakaska 
 *  http://csharpcodewhisperer.blogspot.com
 *    http://arakaska.wix.com/intelligentsoftware
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
			if (disposing) {
				if (components != null) {
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
			this.tbRadixValue = new System.Windows.Forms.TextBox();
			this.btnIncrement = new System.Windows.Forms.Button();
			this.btnIncrement10 = new System.Windows.Forms.Button();
			this.btnIncrement100 = new System.Windows.Forms.Button();
			this.btnAuto = new System.Windows.Forms.Button();
			this.timerAutoIncrement = new System.Windows.Forms.Timer(this.components);
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btnCustomAmmount = new System.Windows.Forms.Button();
			this.tbIncrementAmmount = new System.Windows.Forms.TextBox();
			this.btnIncrement5 = new System.Windows.Forms.Button();
			this.btnClear = new System.Windows.Forms.Button();
			this.lblCurrentRadixSystem = new System.Windows.Forms.Label();
			this.cbLeftToRight = new System.Windows.Forms.CheckBox();
			this.panelRadixUse = new System.Windows.Forms.Panel();
			this.lblDecimalValue = new System.Windows.Forms.Label();
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
			this.groupBox1.SuspendLayout();
			this.panelRadixUse.SuspendLayout();
			this.panelRadixChoose.SuspendLayout();
			this.panelCustom.SuspendLayout();
			this.SuspendLayout();
			// 
			// tbRadixValue
			// 
			this.tbRadixValue.BackColor = System.Drawing.SystemColors.Control;
			this.tbRadixValue.Location = new System.Drawing.Point(9, 37);
			this.tbRadixValue.Name = "tbRadixValue";
			this.tbRadixValue.Size = new System.Drawing.Size(549, 20);
			this.tbRadixValue.TabIndex = 0;
			this.tbRadixValue.Text = "0:0:0:0";
			this.tbRadixValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// btnIncrement
			// 
			this.btnIncrement.Location = new System.Drawing.Point(11, 23);
			this.btnIncrement.Name = "btnIncrement";
			this.btnIncrement.Size = new System.Drawing.Size(33, 23);
			this.btnIncrement.TabIndex = 1;
			this.btnIncrement.Text = "1";
			this.btnIncrement.UseVisualStyleBackColor = true;
			this.btnIncrement.Click += new System.EventHandler(this.BtnIncrementClick);
			// 
			// btnIncrement10
			// 
			this.btnIncrement10.Location = new System.Drawing.Point(89, 23);
			this.btnIncrement10.Name = "btnIncrement10";
			this.btnIncrement10.Size = new System.Drawing.Size(33, 23);
			this.btnIncrement10.TabIndex = 2;
			this.btnIncrement10.Text = "10";
			this.btnIncrement10.UseVisualStyleBackColor = true;
			this.btnIncrement10.Click += new System.EventHandler(this.BtnIncrement10Click);
			// 
			// btnIncrement100
			// 
			this.btnIncrement100.Location = new System.Drawing.Point(128, 23);
			this.btnIncrement100.Name = "btnIncrement100";
			this.btnIncrement100.Size = new System.Drawing.Size(33, 23);
			this.btnIncrement100.TabIndex = 3;
			this.btnIncrement100.Text = "100";
			this.btnIncrement100.UseVisualStyleBackColor = true;
			this.btnIncrement100.Click += new System.EventHandler(this.BtnIncrement100Click);
			// 
			// btnAuto
			// 
			this.btnAuto.Location = new System.Drawing.Point(167, 23);
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
			this.groupBox1.Controls.Add(this.btnCustomAmmount);
			this.groupBox1.Controls.Add(this.tbIncrementAmmount);
			this.groupBox1.Controls.Add(this.btnIncrement5);
			this.groupBox1.Controls.Add(this.btnIncrement);
			this.groupBox1.Controls.Add(this.btnAuto);
			this.groupBox1.Controls.Add(this.btnIncrement10);
			this.groupBox1.Controls.Add(this.btnIncrement100);
			this.groupBox1.Location = new System.Drawing.Point(290, 103);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(273, 84);
			this.groupBox1.TabIndex = 5;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Increase value:";
			// 
			// btnCustomAmmount
			// 
			this.btnCustomAmmount.Location = new System.Drawing.Point(128, 52);
			this.btnCustomAmmount.Name = "btnCustomAmmount";
			this.btnCustomAmmount.Size = new System.Drawing.Size(134, 23);
			this.btnCustomAmmount.TabIndex = 7;
			this.btnCustomAmmount.Text = "<--   Custom Ammount";
			this.btnCustomAmmount.UseVisualStyleBackColor = true;
			this.btnCustomAmmount.Click += new System.EventHandler(this.btnCustomAmmount_Click);
			// 
			// tbIncrementAmmount
			// 
			this.tbIncrementAmmount.Location = new System.Drawing.Point(11, 52);
			this.tbIncrementAmmount.Name = "tbIncrementAmmount";
			this.tbIncrementAmmount.Size = new System.Drawing.Size(111, 20);
			this.tbIncrementAmmount.TabIndex = 6;
			this.tbIncrementAmmount.Text = "13";
			// 
			// btnIncrement5
			// 
			this.btnIncrement5.Location = new System.Drawing.Point(50, 23);
			this.btnIncrement5.Name = "btnIncrement5";
			this.btnIncrement5.Size = new System.Drawing.Size(33, 23);
			this.btnIncrement5.TabIndex = 5;
			this.btnIncrement5.Text = "5";
			this.btnIncrement5.UseVisualStyleBackColor = true;
			this.btnIncrement5.Click += new System.EventHandler(this.btnIncrement5_Click);
			// 
			// btnClear
			// 
			this.btnClear.AutoSize = true;
			this.btnClear.Location = new System.Drawing.Point(483, 13);
			this.btnClear.Name = "btnClear";
			this.btnClear.Size = new System.Drawing.Size(75, 23);
			this.btnClear.TabIndex = 7;
			this.btnClear.Text = "Clear";
			this.btnClear.UseVisualStyleBackColor = true;
			this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
			// 
			// lblCurrentRadixSystem
			// 
			this.lblCurrentRadixSystem.Location = new System.Drawing.Point(9, 60);
			this.lblCurrentRadixSystem.Name = "lblCurrentRadixSystem";
			this.lblCurrentRadixSystem.Size = new System.Drawing.Size(549, 13);
			this.lblCurrentRadixSystem.TabIndex = 8;
			this.lblCurrentRadixSystem.Text = "0:0:0:0";
			this.lblCurrentRadixSystem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// cbLeftToRight
			// 
			this.cbLeftToRight.AutoSize = true;
			this.cbLeftToRight.Location = new System.Drawing.Point(256, 17);
			this.cbLeftToRight.Name = "cbLeftToRight";
			this.cbLeftToRight.Size = new System.Drawing.Size(215, 17);
			this.cbLeftToRight.TabIndex = 9;
			this.cbLeftToRight.Text = "Left-to-right (Most signifigant digit on left)";
			this.cbLeftToRight.UseVisualStyleBackColor = true;
			this.cbLeftToRight.CheckedChanged += new System.EventHandler(this.cbRightToLeft_CheckedChanged);
			// 
			// panelRadixUse
			// 
			this.panelRadixUse.Controls.Add(this.lblDecimalValue);
			this.panelRadixUse.Controls.Add(this.tbRadixValue);
			this.panelRadixUse.Controls.Add(this.cbLeftToRight);
			this.panelRadixUse.Controls.Add(this.groupBox1);
			this.panelRadixUse.Controls.Add(this.lblCurrentRadixSystem);
			this.panelRadixUse.Controls.Add(this.btnClear);
			this.panelRadixUse.Controls.Add(this.labelHeaderRight);
			this.panelRadixUse.Location = new System.Drawing.Point(9, 212);
			this.panelRadixUse.Name = "panelRadixUse";
			this.panelRadixUse.Size = new System.Drawing.Size(566, 190);
			this.panelRadixUse.TabIndex = 10;
			// 
			// lblDecimalValue
			// 
			this.lblDecimalValue.Location = new System.Drawing.Point(12, 76);
			this.lblDecimalValue.Name = "lblDecimalValue";
			this.lblDecimalValue.Size = new System.Drawing.Size(546, 13);
			this.lblDecimalValue.TabIndex = 13;
			this.lblDecimalValue.Text = "0";
			this.lblDecimalValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// labelHeaderRight
			// 
			this.labelHeaderRight.Location = new System.Drawing.Point(3, 4);
			this.labelHeaderRight.Name = "labelHeaderRight";
			this.labelHeaderRight.Size = new System.Drawing.Size(294, 13);
			this.labelHeaderRight.TabIndex = 12;
			this.labelHeaderRight.Text = "    Use your mixed radix number system";
			// 
			// panelRadixChoose
			// 
			this.panelRadixChoose.Controls.Add(this.labelHeaderLeft);
			this.panelRadixChoose.Controls.Add(this.panelCustom);
			this.panelRadixChoose.Controls.Add(this.label1);
			this.panelRadixChoose.Controls.Add(this.btnCreate);
			this.panelRadixChoose.Controls.Add(this.btnLoad);
			this.panelRadixChoose.Controls.Add(this.listNumberSystems);
			this.panelRadixChoose.Location = new System.Drawing.Point(9, 10);
			this.panelRadixChoose.Name = "panelRadixChoose";
			this.panelRadixChoose.Size = new System.Drawing.Size(566, 190);
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
			this.panelCustom.Controls.Add(this.btnCancel);
			this.panelCustom.Controls.Add(this.lblCustomDisplay);
			this.panelCustom.Controls.Add(this.tbCustomDigit);
			this.panelCustom.Controls.Add(this.btnCustomSave);
			this.panelCustom.Controls.Add(this.btnCustomAdd);
			this.panelCustom.Location = new System.Drawing.Point(218, 92);
			this.panelCustom.Name = "panelCustom";
			this.panelCustom.Size = new System.Drawing.Size(345, 92);
			this.panelCustom.TabIndex = 12;
			this.panelCustom.Visible = false;
			// 
			// btnCancel
			// 
			this.btnCancel.Location = new System.Drawing.Point(87, 54);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 11;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnAbort_Click);
			// 
			// lblCustomDisplay
			// 
			this.lblCustomDisplay.Location = new System.Drawing.Point(3, 10);
			this.lblCustomDisplay.Name = "lblCustomDisplay";
			this.lblCustomDisplay.Size = new System.Drawing.Size(337, 13);
			this.lblCustomDisplay.TabIndex = 10;
			this.lblCustomDisplay.Text = "0:0:0:0";
			this.lblCustomDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// tbCustomDigit
			// 
			this.tbCustomDigit.Location = new System.Drawing.Point(6, 28);
			this.tbCustomDigit.Name = "tbCustomDigit";
			this.tbCustomDigit.Size = new System.Drawing.Size(255, 20);
			this.tbCustomDigit.TabIndex = 4;
			// 
			// btnCustomSave
			// 
			this.btnCustomSave.Location = new System.Drawing.Point(6, 54);
			this.btnCustomSave.Name = "btnCustomSave";
			this.btnCustomSave.Size = new System.Drawing.Size(75, 23);
			this.btnCustomSave.TabIndex = 6;
			this.btnCustomSave.Text = "<--  Save ";
			this.btnCustomSave.UseVisualStyleBackColor = true;
			this.btnCustomSave.Click += new System.EventHandler(this.btnCustomSave_Click);
			// 
			// btnCustomAdd
			// 
			this.btnCustomAdd.Location = new System.Drawing.Point(267, 26);
			this.btnCustomAdd.Name = "btnCustomAdd";
			this.btnCustomAdd.Size = new System.Drawing.Size(75, 23);
			this.btnCustomAdd.TabIndex = 5;
			this.btnCustomAdd.Text = "Add base";
			this.btnCustomAdd.UseVisualStyleBackColor = true;
			this.btnCustomAdd.Click += new System.EventHandler(this.btnCustomAdd_Click);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(398, 48);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(160, 13);
			this.label1.TabIndex = 3;
			this.label1.Text = "- or -";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btnCreate
			// 
			this.btnCreate.Location = new System.Drawing.Point(398, 62);
			this.btnCreate.Name = "btnCreate";
			this.btnCreate.Size = new System.Drawing.Size(160, 23);
			this.btnCreate.TabIndex = 2;
			this.btnCreate.Text = "Create a new one";
			this.btnCreate.UseVisualStyleBackColor = true;
			this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
			// 
			// btnLoad
			// 
			this.btnLoad.Location = new System.Drawing.Point(398, 24);
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
			this.listNumberSystems.Size = new System.Drawing.Size(207, 160);
			this.listNumberSystems.TabIndex = 0;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.ClientSize = new System.Drawing.Size(584, 411);
			this.Controls.Add(this.panelRadixUse);
			this.Controls.Add(this.panelRadixChoose);
			this.MaximumSize = new System.Drawing.Size(600, 450);
			this.MinimumSize = new System.Drawing.Size(600, 250);
			this.Name = "MainForm";
			this.Text = "Mixed Radix Numbering System Creater & Calculator";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.panelRadixUse.ResumeLayout(false);
			this.panelRadixUse.PerformLayout();
			this.panelRadixChoose.ResumeLayout(false);
			this.panelCustom.ResumeLayout(false);
			this.panelCustom.PerformLayout();
			this.ResumeLayout(false);

		}
		private System.Windows.Forms.Timer timerAutoIncrement;
		private System.Windows.Forms.Button btnAuto;
		private System.Windows.Forms.Button btnIncrement100;
		private System.Windows.Forms.Button btnIncrement10;
		private System.Windows.Forms.Button btnIncrement;
		private System.Windows.Forms.TextBox tbRadixValue;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button btnIncrement5;
		private System.Windows.Forms.Button btnCustomAmmount;
		private System.Windows.Forms.TextBox tbIncrementAmmount;
		private System.Windows.Forms.Button btnClear;
		private System.Windows.Forms.Label lblCurrentRadixSystem;
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
		private System.Windows.Forms.Label lblDecimalValue;
	}
}
