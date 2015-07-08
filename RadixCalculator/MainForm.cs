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
using System.Linq;
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
			UpdateGUI();
		}

		void Initialize()
		{
			radixCalc = RadixCalculator.Factory.TimeDateRadix1();
			radixCalc.RightToLeft = cbRightToLeft.Checked;

			listNumberSystems.Items.Add("Base 2");
			listNumberSystems.Items.Add("Base 10");
			listNumberSystems.Items.Add("Base 12");
			listNumberSystems.Items.Add("Base 16");
			listNumberSystems.Items.Add("60:60:24:7:52");

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

		private void cbRightToLeft_CheckedChanged(object sender, EventArgs e)
		{
			radixCalc.RightToLeft = cbRightToLeft.Checked;
			UpdateGUI();
		}

		private void btnClear_Click(object sender, EventArgs e)
		{
			radixCalc = RadixCalculator.Factory.TimeDateRadix1();
			UpdateGUI();
		}

		private void btnLoad_Click(object sender, EventArgs e)
		{
			string selectedNumberSystem = Convert.ToString(listNumberSystems.SelectedItem);

			if (selectedNumberSystem.Contains("Base "))
			{
				selectedNumberSystem = selectedNumberSystem.Replace("Base ", "");
				int baseNumber = int.Parse(selectedNumberSystem);

				radixCalc = new RadixCalculator(baseNumber, 8);

			}
			else if (selectedNumberSystem.Contains(":"))
			{
				List<string> baseArray = new List<string>(selectedNumberSystem.Split(new char[] { ':' }));

				List<int> baseDefinition = baseArray.Select(s => int.Parse(s)).ToList();

				radixCalc = new RadixCalculator(baseDefinition);
			}

			UpdateGUI();
		}

		List<int> customRadixSystem = new List<int>();

		private void btnCreate_Click(object sender, EventArgs e)
		{
			clearCustom();
		}

		private void btnCustomAdd_Click(object sender, EventArgs e)
		{
			int digit = 0;
			if (int.TryParse(tbCustomDigit.Text, out digit))
			{
				customRadixSystem.Add(digit);
				tbCustomDigit.Text = string.Empty;

				if (lblCustomDisplay.Text.Length > 0)
				{
					lblCustomDisplay.Text += ":";
				}

				lblCustomDisplay.Text += digit.ToString();
			}

		}

		private void btnCustomSave_Click(object sender, EventArgs e)
		{
			listNumberSystems.Items.Add(string.Join(":", customRadixSystem));
			clearCustom();
		}

		private void btnAbort_Click(object sender, EventArgs e)
		{
			clearCustom();
		}

		private void clearCustom()
		{
			customRadixSystem = new List<int>();
			tbCustomDigit.Text = string.Empty;
			lblCustomDisplay.Text = string.Empty;
			UpdateGUI();
		}

	}
}
