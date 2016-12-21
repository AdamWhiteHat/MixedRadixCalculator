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
using System.Numerics;
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
        MixedRadixSystem currentNumeralSystem;


        public MainForm()
        {
            InitializeComponent();
            Initialize();
            UpdateGUI();
        }

        void Initialize()
        {
            currentNumeralSystem = MixedRadixSystem.Factory.TimeDateRadix52();
            currentNumeralSystem.LeftToRight = cbLeftToRight.Checked;
            panelCustom.Visible = false;

            listNumberSystems.Items.Add("Base 2");
            listNumberSystems.Items.Add("Base 3");
            listNumberSystems.Items.Add("Base 5");
            listNumberSystems.Items.Add("Base 7");
            listNumberSystems.Items.Add("Base 10");
            listNumberSystems.Items.Add("Base 12");
            listNumberSystems.Items.Add("Base 16");
            listNumberSystems.Items.Add("Base 256");
            listNumberSystems.Items.Add("60:60:24:7:4:12");
            listNumberSystems.Items.Add("60:60:24:360:280000");
            listNumberSystems.Items.Add("60:60:24:6:60");
            listNumberSystems.Items.Add("1:2:3:4:5:6:7:8:9");
            listNumberSystems.Items.Add("3:5:7:11:13:17:19:23:29");
            listNumberSystems.Items.Add("2:3:5:8:13:21:34:55:89:144:233");
            listNumberSystems.Items.Add("*Hexadecimal");
            listNumberSystems.Items.Add("*Symbols9");
            listNumberSystems.Items.Add("*Lines");
            listNumberSystems.Items.Add("*Alien");



            panelRadixChoose.BringToFront();
        }

        void UpdateGUI()
        {
            tbTabularFormat.Text = currentNumeralSystem.GetTabularFormat();
            tbNumeralFormat.Text = currentNumeralSystem.GetNumeralFormat();
            tbDecimalValue.Text = string.Format("{0:n0}", currentNumeralSystem.DecimalValue);
        }

        void BtnIncrementClick(object sender, EventArgs e)
        {
            currentNumeralSystem.Increment();
            UpdateGUI();
        }

        private void btnIncrement5_Click(object sender, EventArgs e)
        {
            currentNumeralSystem.AddDecimalValue(5);
            UpdateGUI();
        }

        void BtnIncrement10Click(object sender, EventArgs e)
        {
            currentNumeralSystem.AddDecimalValue(10);
            UpdateGUI();
        }

        void BtnIncrement100Click(object sender, EventArgs e)
        {
            currentNumeralSystem.AddDecimalValue(100);
            UpdateGUI();
            int i = 100;
            i++;

        }

        private void btnCustomAmmount_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(tbIncrementAmmount.Text))
            { return; }

            BigInteger customAmnt = BigInteger.Parse(tbIncrementAmmount.Text);
            while (customAmnt > 0)
            {
                if (customAmnt > long.MaxValue)
                {
                    customAmnt -= long.MaxValue;
                    currentNumeralSystem.AddDecimalValue(long.MaxValue);
                }
                else
                {
                    long addValue = (long)customAmnt;
                    currentNumeralSystem.AddDecimalValue(addValue);
                    customAmnt = 0;
                }
            }

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
