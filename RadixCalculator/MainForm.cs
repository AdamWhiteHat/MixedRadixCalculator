/*
 *
 * Developed by Adam White 
 *  http://csharpcodewhisperer.blogspot.com
 * 
 */
using System;
using System.Linq;
using System.Drawing;
using System.Numerics;
using System.Windows.Forms;
using System.Collections.Generic;
using RadixCalculator;

namespace RadixCalculator
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		MixedRadixSystem currentNumeralSystem;


		public MainForm()
		{
			InitializeComponent();
			Initialize();
			this.button7.Click += new EventHandler((o, e) => { currentNumeralSystem.Digits[7].Increment(); UpdateGUI(); });
			this.button6.Click += new EventHandler((o, e) => { currentNumeralSystem.Digits[6].Increment(); UpdateGUI(); });
			this.button5.Click += new EventHandler((o, e) => { currentNumeralSystem.Digits[5].Increment(); UpdateGUI(); });
			this.button4.Click += new EventHandler((o, e) => { currentNumeralSystem.Digits[4].Increment(); UpdateGUI(); });
			this.button3.Click += new EventHandler((o, e) => { currentNumeralSystem.Digits[3].Increment(); UpdateGUI(); });
			this.button2.Click += new EventHandler((o, e) => { currentNumeralSystem.Digits[2].Increment(); UpdateGUI(); });
			this.button1.Click += new EventHandler((o, e) => { currentNumeralSystem.Digits[1].Increment(); UpdateGUI(); });
			this.button0.Click += new EventHandler((o, e) => { currentNumeralSystem.Digits[0].Increment(); UpdateGUI(); });

			tbIncrementAmmount.Text = "3218147";

			UpdateGUI();
		}

		void Initialize()
		{
			currentNumeralSystem = MixedRadixSystem.Factory.TimeDateRadix52();
			currentNumeralSystem.LeftToRight = cbLeftToRight.Checked;
			panelCustom.Visible = false;

			listNumberSystems.Items.Add("117:117:117:117");
			listNumberSystems.Items.Add("Base 2");
			listNumberSystems.Items.Add("Base 10");
			listNumberSystems.Items.Add("Base 12");
			listNumberSystems.Items.Add("Base 60");
			listNumberSystems.Items.Add("*Lines");
			listNumberSystems.Items.Add("*Alien");
			listNumberSystems.Items.Add("*Symbols9");
			listNumberSystems.Items.Add("*Hexadecimal");
			listNumberSystems.Items.Add("60:60:24:360");
			listNumberSystems.Items.Add("2:3:5:7:11:13:17:19:23:29");
			listNumberSystems.Items.Add("4:16:256:65536:4294967296:18446744073709551616");
			listNumberSystems.Items.Add("4:9:16:25:36:49:64:81:100:121:144:169:196:225:256:289");
			listNumberSystems.SelectedIndex = 2;
			panelRadixChoose.BringToFront();
		}

		void UpdateGUI()
		{
			if (tbDecimalValue.InvokeRequired)
			{
				tbDecimalValue.Invoke(new MethodInvoker(() => { UpdateGUI(); }));
			}
			else
			{
				tbTabularFormat.Text = currentNumeralSystem.GetTabularFormat();
				tbNumeralFormat.Text = currentNumeralSystem.GetPolynomialFormat(); // currentNumeralSystem.GetNumeralFormat();
				tbDecimalValue.Text = string.Format("{0:n0}", currentNumeralSystem.DecimalValue);
			}
		}

		void BtnIncrementClick(object sender, EventArgs e)
		{
			currentNumeralSystem.Increment();
			UpdateGUI();
		}

		private void btnIncrement5_Click(object sender, EventArgs e)
		{
			currentNumeralSystem.Increment(5);
			UpdateGUI();
		}

		void BtnIncrement10Click(object sender, EventArgs e)
		{
			currentNumeralSystem.Increment(10);
			UpdateGUI();
		}

		void BtnIncrement100Click(object sender, EventArgs e)
		{
			currentNumeralSystem.Increment(100);
			UpdateGUI();
			int i = 100;
			i++;

		}

		private void btnCustomAmmount_Click(object sender, EventArgs e)
		{
			IncrementCustomAmmount();
		}

		private void IncrementCustomAmmount()
		{
			if (string.IsNullOrWhiteSpace(tbIncrementAmmount.Text))
			{ return; }

			currentNumeralSystem.Increment(BigInteger.Parse(tbIncrementAmmount.Text));

			UpdateGUI();
		}

		bool IsTimer = false;
		void BtnAutoClick(object sender, EventArgs e)
		{
			if (IsTimer)
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
			currentNumeralSystem.Increment();
			UpdateGUI();
		}

		private void cbRightToLeft_CheckedChanged(object sender, EventArgs e)
		{
			currentNumeralSystem.LeftToRight = cbLeftToRight.Checked;
			HorizontalAlignment textboxAlignment = HorizontalAlignment.Right;

			if (currentNumeralSystem.LeftToRight)
			{
				textboxAlignment = HorizontalAlignment.Left;
			}

			tbNumeralFormat.TextAlign = textboxAlignment;
			tbDecimalValue.TextAlign = textboxAlignment;
			tbTabularFormat.TextAlign = textboxAlignment;

			UpdateGUI();
		}

		private void btnClear_Click(object sender, EventArgs e)
		{
			currentNumeralSystem.Zero();
			UpdateGUI();
		}

		private void btnLoad_Click(object sender, EventArgs e)
		{
			string selectedNumberSystem = Convert.ToString(listNumberSystems.SelectedItem);

			switch (selectedNumberSystem)
			{
				case "*Hexadecimal":
					currentNumeralSystem = MixedRadixSystem.Factory.Hexadecimal();
					break;
				case "*Symbols9":
					currentNumeralSystem = MixedRadixSystem.Factory.Symbols9();
					break;
				case "*Lines":
					currentNumeralSystem = MixedRadixSystem.Factory.Lines();
					break;
				case "*Alien":
					currentNumeralSystem = MixedRadixSystem.Factory.Alien();
					break;
				default:
					currentNumeralSystem = new MixedRadixSystem(selectedNumberSystem, cbLeftToRight.Checked);
					break;
			}


			UpdateGUI();
		}

		List<BigInteger> customRadixSystem = new List<BigInteger>();

		private void btnCustomAdd_Click(object sender, EventArgs e)
		{
			customAddDigit();
		}

		private void btnCreate_Click(object sender, EventArgs e)
		{
			customClear();
			panelCustom.Visible = true;
			tbCustomDigit.Focus();
		}

		private void btnCustomSave_Click(object sender, EventArgs e)
		{
			if (!string.IsNullOrWhiteSpace(tbCustomDigit.Text))
			{

				if (customRadixSystem.Count == 0 && tbCustomDigit.Text.Contains(MixedRadixSystem.BaseStringSeparator))
				{
					listNumberSystems.Items.Add(tbCustomDigit.Text);
					return;
				}

				btnCustomAdd_Click(null, null);
			}

			if (customRadixSystem.Count > 0)
			{
				listNumberSystems.Items.Add(string.Join(MixedRadixSystem.BaseStringSeparator, customRadixSystem));
				customRadixSystem.Clear();
			}

			panelCustom.Visible = false;
			//clearCustom();
		}

		private void tbCustomDigit_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				customAddDigit();
				e.Handled = true;
				e.SuppressKeyPress = true;
			}
		}

		private void btnAbort_Click(object sender, EventArgs e)
		{
			panelCustom.Visible = false;
			//clearCustom();
		}

		private void customClear()
		{
			customRadixSystem = new List<BigInteger>();
			tbCustomDigit.Text = string.Empty;
			lblCustomDisplay.Text = string.Empty;
			UpdateGUI();
		}

		private void customAddDigit()
		{
			BigInteger digit = 0;
			if (!BigInteger.TryParse(tbCustomDigit.Text, out digit) || digit.Sign != 1)
			{

				MessageBox.Show("Unable to parse text into type BigInteger. You must enter a natural number (whole, positive integers).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				tbCustomDigit.Focus();
				tbCustomDigit.SelectAll();
				return;
			}

			customRadixSystem.Add(digit);
			tbCustomDigit.Text = string.Empty;

			if (lblCustomDisplay.Text.Length > 0)
			{
				lblCustomDisplay.Text += MixedRadixSystem.BaseStringSeparator;
			}

			lblCustomDisplay.Text += digit.ToString();

			tbCustomDigit.Focus();
		}

		private void tbIncrementAmmount_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				IncrementCustomAmmount();
				e.Handled = true;
				e.SuppressKeyPress = true;
			}
			else if (e.KeyCode == Keys.Up)
			{
				BigInteger value = BigInteger.MinusOne;
				if (BigInteger.TryParse(tbIncrementAmmount.Text, out value))
				{
					tbIncrementAmmount.Text = (value + 1).ToString();
				}

				e.Handled = true;
				e.SuppressKeyPress = true;
			}
			else if (e.KeyCode == Keys.Down)
			{
				BigInteger value = BigInteger.MinusOne;
				if (BigInteger.TryParse(tbIncrementAmmount.Text, out value))
				{
					tbIncrementAmmount.Text = (value - 1).ToString();
				}

				e.Handled = true;
				e.SuppressKeyPress = true;
			}
		}

		private void tbCustomDigit_TextChanged(object sender, EventArgs e)
		{
			if (!string.IsNullOrWhiteSpace(tbCustomDigit.Text))
			{
				BigInteger digit = 0;
				if (!BigInteger.TryParse(tbCustomDigit.Text, out digit))
				{
					errorProvider_CustomDigit.SetError(tbCustomDigit, "Only natural numbers allowed.");
				}
				else
				{
					errorProvider_CustomDigit.Clear();
				}
			}
			else
			{
				errorProvider_CustomDigit.Clear();
			}
		}
	}
}
