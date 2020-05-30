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
    public partial class FormAddBook : Form
    {
        public string Title { get; private set; }
        public string Author { get; private set; }
        public string Publisher { get; private set; }
        public int Year { get; private set; }
        public string Quality { get; private set; }
        public float Price { get; private set; }

        public FormAddBook()
        {
            InitializeComponent();
        }

        private void qualityTextBox_TextChanged(object sender, EventArgs e)
        {
            UpdateForm();
        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {
            UpdateForm();
        }

        private void publisherTextBox_TextChanged(object sender, EventArgs e)
        {
            UpdateForm();
        }

        private void authorTextBox_TextChanged(object sender, EventArgs e)
        {
            UpdateForm();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void FormAddBook_Load(object sender, EventArgs e)
        {
            yearNumericUpDown.Minimum = InputValidator.YearMinimum;
            yearNumericUpDown.Maximum = InputValidator.YearMaximum;
            yearNumericUpDown.Value = InputValidator.YearDefault;
            priceNumericUpDown.Minimum = Convert.ToDecimal(InputValidator.PriceMinimum);
            priceNumericUpDown.Maximum = Convert.ToDecimal(InputValidator.PriceMaximum);
            priceNumericUpDown.Value = Convert.ToDecimal(InputValidator.PriceDefault);
            UpdateForm();
        }

        private void UpdateForm()
        {
            Title = titleTextBox.Text;
            Author = authorTextBox.Text;
            Publisher = publisherTextBox.Text;
            Year = Convert.ToInt32(yearNumericUpDown.Value);
            Quality = qualityTextBox.Text;
            Price = Convert.ToSingle(priceNumericUpDown.Value);
            button1.Enabled = InputValidator.validateTitle(Title) &&
                InputValidator.validateAuthor(Author) &&
                InputValidator.validatePublisher(Publisher) &&
                InputValidator.validateYear(Year) &&
                InputValidator.validateQuality(Quality) &&
                InputValidator.validatePrice(Price);
        }

        private void yearNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            UpdateForm();
        }

        private void priceNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            UpdateForm();
        }
    }
}
