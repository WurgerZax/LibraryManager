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
    public partial class FormFilterByTitle : Form
    {
        public string Title { get; private set; }
        public FormFilterByTitle()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            UpdateForm();
        }

        private void UpdateForm()
        {
            Title = textBox1.Text;
            button1.Enabled = InputValidator.validateTitle(Title);
        }

        private void FormFilterByName_Load(object sender, EventArgs e)
        {
            UpdateForm();
        }
    }
}
