using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManager
{
    public partial class FormFilterByPrice : Form
    {
        public float PriceMinimum { get; private set; }
        public float PriceMaximum { get; private set; }

        public FormFilterByPrice()
        {
            InitializeComponent();
        }

        private void FormFilterByPrice_Load(object sender, EventArgs e)
        {
            this.fromNumericUpDown.Minimum = Convert.ToDecimal(InputValidator.PriceMinimum);
            this.fromNumericUpDown.Maximum = Convert.ToDecimal(InputValidator.PriceMaximum);
            this.fromNumericUpDown.Value = Convert.ToDecimal(InputValidator.PriceDefault);
            this.toNumericUpDown.Minimum = Convert.ToDecimal(InputValidator.PriceMinimum);
            this.toNumericUpDown.Maximum = Convert.ToDecimal(InputValidator.PriceMaximum);
            this.toNumericUpDown.Value = Convert.ToDecimal(InputValidator.PriceDefault);
            this.priceNumericUpDown.Minimum = Convert.ToDecimal(InputValidator.PriceMinimum);
            this.priceNumericUpDown.Maximum = Convert.ToDecimal(InputValidator.PriceMaximum);
            this.priceNumericUpDown.Value = Convert.ToDecimal(InputValidator.PriceDefault);
            UpdateForm();
        }

        private void UpdateForm()
        {
            if (this.tabControl1.SelectedTab == this.yearTabPage)
            {
                PriceMinimum = this.lessRadioButton.Checked ? InputValidator.PriceMinimum : Convert.ToSingle(Math.Round(priceNumericUpDown.Value, 2));
                PriceMaximum = this.moreRadioButton.Checked ? InputValidator.PriceMaximum : Convert.ToSingle(Math.Round(priceNumericUpDown.Value, 2));
            }
            else if (this.tabControl1.SelectedTab == this.rangeTabPage)
            {
                PriceMinimum = Convert.ToSingle(Math.Round(fromNumericUpDown.Value, 2));
                PriceMaximum = Convert.ToSingle(Math.Round(toNumericUpDown.Value, 2));
            }

            this.button1.Enabled = InputValidator.validatePrice(PriceMinimum) &&
                InputValidator.validatePrice(PriceMaximum) &&
                (PriceMinimum <= PriceMaximum);
        }

        private void lessRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            UpdateForm();
        }

        private void moreRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            UpdateForm();
        }

        private void equalRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            UpdateForm();
        }

        private void priceNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            UpdateForm();
        }

        private void yearTabPage_Click(object sender, EventArgs e)
        {
            UpdateForm();
        }

        private void rangeTabPage_Click(object sender, EventArgs e)
        {
            UpdateForm();
        }

        private void fromNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            UpdateForm();
        }

        private void toNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            UpdateForm();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }
    }
    
}
