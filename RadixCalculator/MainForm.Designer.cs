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
			this.tbOutput = new System.Windows.Forms.TextBox();
			this.btnIncrement = new System.Windows.Forms.Button();
			this.btnIncrement10 = new System.Windows.Forms.Button();
			this.btnIncrement100 = new System.Windows.Forms.Button();
			this.btnAuto = new System.Windows.Forms.Button();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btnCustomAmmount = new System.Windows.Forms.Button();
			this.tbIncrementAmmount = new System.Windows.Forms.TextBox();
			this.btnIncrement5 = new System.Windows.Forms.Button();
			this.btnClear = new System.Windows.Forms.Button();
			this.lblBaseArray = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// tbOutput
			// 
			this.tbOutput.Location = new System.Drawing.Point(12, 12);
			this.tbOutput.Name = "tbOutput";
			this.tbOutput.Size = new System.Drawing.Size(221, 20);
			this.tbOutput.TabIndex = 0;
			this.tbOutput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// btnIncrement
			// 
			this.btnIncrement.Location = new System.Drawing.Point(19, 35);
			this.btnIncrement.Name = "btnIncrement";
			this.btnIncrement.Size = new System.Drawing.Size(33, 23);
			this.btnIncrement.TabIndex = 1;
			this.btnIncrement.Text = "1";
			this.btnIncrement.UseVisualStyleBackColor = true;
			this.btnIncrement.Click += new System.EventHandler(this.BtnIncrementClick);
			// 
			// btnIncrement10
			// 
			this.btnIncrement10.Location = new System.Drawing.Point(97, 35);
			this.btnIncrement10.Name = "btnIncrement10";
			this.btnIncrement10.Size = new System.Drawing.Size(33, 23);
			this.btnIncrement10.TabIndex = 2;
			this.btnIncrement10.Text = "10";
			this.btnIncrement10.UseVisualStyleBackColor = true;
			this.btnIncrement10.Click += new System.EventHandler(this.BtnIncrement10Click);
			// 
			// btnIncrement100
			// 
			this.btnIncrement100.Location = new System.Drawing.Point(136, 35);
			this.btnIncrement100.Name = "btnIncrement100";
			this.btnIncrement100.Size = new System.Drawing.Size(33, 23);
			this.btnIncrement100.TabIndex = 3;
			this.btnIncrement100.Text = "100";
			this.btnIncrement100.UseVisualStyleBackColor = true;
			this.btnIncrement100.Click += new System.EventHandler(this.BtnIncrement100Click);
			// 
			// btnAuto
			// 
			this.btnAuto.Location = new System.Drawing.Point(175, 35);
			this.btnAuto.Name = "btnAuto";
			this.btnAuto.Size = new System.Drawing.Size(95, 23);
			this.btnAuto.TabIndex = 4;
			this.btnAuto.Text = "Auto Increment";
			this.btnAuto.UseVisualStyleBackColor = true;
			this.btnAuto.Click += new System.EventHandler(this.BtnAutoClick);
			// 
			// timer1
			// 
			this.timer1.Interval = 1000;
			this.timer1.Tick += new System.EventHandler(this.Timer1Tick);
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
			this.groupBox1.Location = new System.Drawing.Point(12, 55);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(281, 100);
			this.groupBox1.TabIndex = 5;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Increase value:";
			// 
			// btnCustomAmmount
			// 
			this.btnCustomAmmount.Location = new System.Drawing.Point(136, 64);
			this.btnCustomAmmount.Name = "btnCustomAmmount";
			this.btnCustomAmmount.Size = new System.Drawing.Size(134, 23);
			this.btnCustomAmmount.TabIndex = 7;
			this.btnCustomAmmount.Text = "<--   Custom Ammount";
			this.btnCustomAmmount.UseVisualStyleBackColor = true;
			this.btnCustomAmmount.Click += new System.EventHandler(this.btnCustomAmmount_Click);
			// 
			// tbIncrementAmmount
			// 
			this.tbIncrementAmmount.Location = new System.Drawing.Point(19, 64);
			this.tbIncrementAmmount.Name = "tbIncrementAmmount";
			this.tbIncrementAmmount.Size = new System.Drawing.Size(111, 20);
			this.tbIncrementAmmount.TabIndex = 6;
			this.tbIncrementAmmount.Text = "13";
			// 
			// btnIncrement5
			// 
			this.btnIncrement5.Location = new System.Drawing.Point(58, 35);
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
			this.btnClear.Location = new System.Drawing.Point(239, 9);
			this.btnClear.Name = "btnClear";
			this.btnClear.Size = new System.Drawing.Size(54, 23);
			this.btnClear.TabIndex = 7;
			this.btnClear.Text = "Clear";
			this.btnClear.UseVisualStyleBackColor = true;
			// 
			// lblBaseArray
			// 
			this.lblBaseArray.Location = new System.Drawing.Point(12, 35);
			this.lblBaseArray.Name = "lblBaseArray";
			this.lblBaseArray.Size = new System.Drawing.Size(221, 13);
			this.lblBaseArray.TabIndex = 8;
			this.lblBaseArray.Text = "0:0:0:0";
			this.lblBaseArray.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.ClientSize = new System.Drawing.Size(305, 170);
			this.Controls.Add(this.lblBaseArray);
			this.Controls.Add(this.btnClear);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.tbOutput);
			this.Name = "MainForm";
			this.Text = "RadixCalculator";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Button btnAuto;
		private System.Windows.Forms.Button btnIncrement100;
		private System.Windows.Forms.Button btnIncrement10;
		private System.Windows.Forms.Button btnIncrement;
		private System.Windows.Forms.TextBox tbOutput;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button btnIncrement5;
		private System.Windows.Forms.Button btnCustomAmmount;
		private System.Windows.Forms.TextBox tbIncrementAmmount;
		private System.Windows.Forms.Button btnClear;
		private System.Windows.Forms.Label lblBaseArray;
	}
}
