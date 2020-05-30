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
    public partial class FormFilterByYear : Form
    {
        public int YearMinimum { get; private set; }
        public int YearMaximum { get; private set; }

        public FormFilterByYear()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
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

        private void UpdateForm()
        {
            if (this.tabControl1.SelectedTab == this.yearTabPage)
            {
                YearMinimum = this.lessRadioButton.Checked ? InputValidator.YearMinimum : Convert.ToInt32(yearNumericUpDown.Value);
                YearMaximum = this.moreRadioButton.Checked ? InputValidator.YearMaximum : Convert.ToInt32(yearNumericUpDown.Value);
            }
            else if (this.tabControl1.SelectedTab == this.rangeTabPage)
            {
                YearMinimum = Convert.ToInt32(fromNumericUpDown.Value);
                YearMaximum = Convert.ToInt32(toNumericUpDown.Value);
            }

            this.button1.Enabled = InputValidator.validateYear(YearMinimum) &&
                InputValidator.validateYear(YearMaximum) &&
                (YearMinimum <= YearMaximum);
        }

        private void FormFilterByYear_Load(object sender, EventArgs e)
        {
            this.fromNumericUpDown.Minimum = InputValidator.YearMinimum;
            this.fromNumericUpDown.Maximum = InputValidator.YearMaximum;
            this.fromNumericUpDown.Value = InputValidator.YearDefault;
            this.toNumericUpDown.Minimum = InputValidator.YearMinimum;
            this.toNumericUpDown.Maximum = InputValidator.YearMaximum;
            this.toNumericUpDown.Value = InputValidator.YearDefault;
            this.yearNumericUpDown.Minimum = InputValidator.YearMinimum;
            this.yearNumericUpDown.Maximum = InputValidator.YearMaximum;
            this.yearNumericUpDown.Value = InputValidator.YearDefault;
            UpdateForm();
        }

        private void yearNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            UpdateForm();
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
    }
}
