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
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using RadixCalculator;

namespace RadixCalculator
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		RadixCalculator radixCalc;
		public MainForm()
		{
			InitializeComponent();
			Initialize();
		}

		void Initialize()
		{
			radixCalc = RadixCalculator.Factory.TimeDateRadix1();
		}
			
		void BtnIncrementClick(object sender, EventArgs e)
		{
			radixCalc.Increment();
			UpdateGUI();
		}

		private void btnIncrement5_Click(object sender, EventArgs e)
		{
			radixCalc.Increment(5);
			UpdateGUI();
		}
		
		void BtnIncrement10Click(object sender, EventArgs e)
		{
			radixCalc.Increment(10);
			UpdateGUI();
		}
		
		void BtnIncrement100Click(object sender, EventArgs e)
		{
			radixCalc.Increment(100);
			UpdateGUI();
		}
		
		private void btnCustomAmmount_Click(object sender, EventArgs e)
		{
			int customAmnt = 0;
			if (int.TryParse(tbIncrementAmmount.Text, out customAmnt))
			{
				radixCalc.Increment(customAmnt);
				UpdateGUI();
			}
		}
				
		bool IsTimer = false;
		void BtnAutoClick(object sender, EventArgs e)
		{
			if(IsTimer)
			{
				timer1.Stop();
				IsTimer = false;
				btnAuto.Text = "Auto";
			}
			else
			{
				timer1.Start();
				IsTimer = true;
				btnAuto.Text = "Stop Auto";
			}
		}
		
		void Timer1Tick(object sender, EventArgs e)
		{
			radixCalc.Increment();
			UpdateGUI();
		}
		
		void UpdateGUI()
		{
			tbOutput.Text = radixCalc.GetValue();
			lblBaseArray.Text = radixCalc.ToString();
		}

	}
}
