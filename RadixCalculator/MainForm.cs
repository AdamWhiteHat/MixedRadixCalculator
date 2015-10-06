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
			listNumberSystems.Items.Add("60:60:24:7:4:12");
			listNumberSystems.Items.Add("60:60:24:360");
			listNumberSystems.Items.Add("60:60:24:6:60");
			listNumberSystems.Items.Add("3:5:7:11:13:17:19:23:29");
			listNumberSystems.Items.Add("2:3:5:8:13:21:34:55:89:144:233");
			listNumberSystems.Items.Add("1:2:3:4:5:6:7:8:9");
			listNumberSystems.Items.Add("3:3:3:3:3:3:3:3:3:3:3:3");
			listNumberSystems.Items.Add("5:5:5:5:5:5:5:5:5:5:5:5");
			listNumberSystems.Items.Add("7:7:7:7:7:7:7:7:7:7:7:7");


			panelRadixChoose.BringToFront();			
		}

		void UpdateGUI()
		{			
			tbRadixValue.Text = radixCalc.GetValue();
			tbCurrentRadixSystem.Text = radixCalc.ToString();
			tbDecimalValue.Text = string.Format("{0:n0}", radixCalc.DecimalValue);
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
			radixCalc.LeftToRight = cbLeftToRight.Checked;
			HorizontalAlignment textboxAlignment = HorizontalAlignment.Right;

			if (radixCalc.LeftToRight)
			{
				textboxAlignment = HorizontalAlignment.Left;
			}

			tbCurrentRadixSystem.TextAlign = textboxAlignment;
			tbDecimalValue.TextAlign = textboxAlignment;
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

			radixCalc = new MixedRadixSystem(selectedNumberSystem, cbLeftToRight.Checked);			

			UpdateGUI();
		}

		List<long> customRadixSystem = new List<long>();
		
		private void btnCustomAdd_Click(object sender, EventArgs e)
		{
			long digit = 0;
			if (long.TryParse(tbCustomDigit.Text, out digit))
			{
				customRadixSystem.Add(digit);
				tbCustomDigit.Text = string.Empty;

				if (lblCustomDisplay.Text.Length > 0)
				{
					lblCustomDisplay.Text += MixedRadixSystem.BaseStringSeparator;
				}

				lblCustomDisplay.Text += digit.ToString();
			}
		}

		private void btnCreate_Click(object sender, EventArgs e)
		{
			clearCustom();
			panelCustom.Visible = true;			
		}

		private void btnCustomSave_Click(object sender, EventArgs e)
		{
			if (tbCustomDigit.Text.Contains(MixedRadixSystem.BaseStringSeparator))
			{
				listNumberSystems.Items.Add(tbCustomDigit.Text);
			}
			else
			{
				listNumberSystems.Items.Add(string.Join(MixedRadixSystem.BaseStringSeparator, customRadixSystem));
				customRadixSystem = new List<long>();
			}
			panelCustom.Visible = false;
			//clearCustom();
		}

		private void btnAbort_Click(object sender, EventArgs e)
		{
			panelCustom.Visible = false;
			//clearCustom();
		}

		private void clearCustom()
		{
			customRadixSystem = new List<long>();
			tbCustomDigit.Text = string.Empty;
			lblCustomDisplay.Text = string.Empty;
			UpdateGUI();
		}

	}
}
