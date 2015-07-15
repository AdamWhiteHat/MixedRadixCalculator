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
		MixedRadixSystem radixCalc;


		public MainForm()
		{
			InitializeComponent();
			Initialize();
			UpdateGUI();
		}

		void Initialize()
		{
			radixCalc = MixedRadixSystem.Factory.TimeDateRadix1();
			radixCalc.LeftToRight = cbLeftToRight.Checked;
			panelCustom.Visible = false;

			listNumberSystems.Items.Add("Base 2");
			listNumberSystems.Items.Add("Base 3");
			listNumberSystems.Items.Add("Base 7");
			listNumberSystems.Items.Add("Base 10");
			listNumberSystems.Items.Add("Base 12");
			listNumberSystems.Items.Add("Base 16");
			listNumberSystems.Items.Add("60:60:24:7:52");
			listNumberSystems.Items.Add("3:5:7:11:13:17:19:23:29:");
			listNumberSystems.Items.Add("1:2:3:4:5:6:7:8:9");
			
			panelRadixChoose.BringToFront();			
		}

		void UpdateGUI()
		{			
			tbRadixValue.Text = radixCalc.GetValue();
			lblDecimalValue.Text = radixCalc.DecimalValue.ToString();
			lblCurrentRadixSystem.Text = radixCalc.ToString();
		}
			
		void BtnIncrementClick(object sender, EventArgs e)
		{
			radixCalc.Increment();
			UpdateGUI();
		}

		private void btnIncrement5_Click(object sender, EventArgs e)
		{
			radixCalc.AddDecimalValue(5);
			UpdateGUI();
		}
		
		void BtnIncrement10Click(object sender, EventArgs e)
		{
			radixCalc.AddDecimalValue(10);
			UpdateGUI();
		}
		
		void BtnIncrement100Click(object sender, EventArgs e)
		{
			radixCalc.AddDecimalValue(100);
			UpdateGUI();
		}
		
		private void btnCustomAmmount_Click(object sender, EventArgs e)
		{
			int customAmnt = 0;
			if (int.TryParse(tbIncrementAmmount.Text, out customAmnt))
			{
				radixCalc.AddDecimalValue(customAmnt);
				UpdateGUI();
			}
		}
				
		bool IsTimer = false;
		void BtnAutoClick(object sender, EventArgs e)
		{
			if(IsTimer)
			{
				timerAutoIncrement.Stop();
				IsTimer = false;
				btnAuto.Text = "Auto";
			}
			else
			{
				timerAutoIncrement.Start();
				IsTimer = true;
				btnAuto.Text = "Stop Auto";
			}
		}
		
		void AutoIncrement1Tick(object sender, EventArgs e)
		{
			radixCalc.Increment();
			UpdateGUI();
		}
		
		private void cbRightToLeft_CheckedChanged(object sender, EventArgs e)
		{
			bool leftMostSignifigant = cbLeftToRight.Checked;
			ContentAlignment labelAlignment = ContentAlignment.MiddleRight;
			HorizontalAlignment textboxAlignment = HorizontalAlignment.Right;

			if (leftMostSignifigant)
			{
				labelAlignment = ContentAlignment.MiddleLeft;
				textboxAlignment = HorizontalAlignment.Left;
			}

			radixCalc.LeftToRight = leftMostSignifigant;
			lblCurrentRadixSystem.TextAlign = labelAlignment;
			lblDecimalValue.TextAlign = labelAlignment;
			tbRadixValue.TextAlign = textboxAlignment;

			UpdateGUI();
		}

		private void btnClear_Click(object sender, EventArgs e)
		{
			radixCalc.Zero();
			UpdateGUI();
		}

		private void btnLoad_Click(object sender, EventArgs e)
		{
			string selectedNumberSystem = Convert.ToString(listNumberSystems.SelectedItem);

			if (selectedNumberSystem.Contains("Base "))
			{
				selectedNumberSystem = selectedNumberSystem.Replace("Base ", "");
				int baseNumber = int.Parse(selectedNumberSystem);

				radixCalc = new MixedRadixSystem(baseNumber, 8);

			}
			else if (selectedNumberSystem.Contains(":"))
			{
				List<string> baseArray = new List<string>(selectedNumberSystem.Split(new char[] { ':' }));
				List<int> baseDefinition = baseArray.Select(s => int.Parse(s)).ToList();

				radixCalc = new MixedRadixSystem(baseDefinition);
			}

			UpdateGUI();
		}

		List<int> customRadixSystem = new List<int>();
		
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

		private void btnCreate_Click(object sender, EventArgs e)
		{
			panelCustom.Visible = true;
			clearCustom();
		}

		private void btnCustomSave_Click(object sender, EventArgs e)
		{
			if (tbCustomDigit.Text.Contains(':'))
			{
				listNumberSystems.Items.Add(tbCustomDigit.Text);
				return;
			}
			listNumberSystems.Items.Add(string.Join(":", customRadixSystem));
			panelCustom.Visible = false;
			clearCustom();
		}

		private void btnAbort_Click(object sender, EventArgs e)
		{
			panelCustom.Visible = false;
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
