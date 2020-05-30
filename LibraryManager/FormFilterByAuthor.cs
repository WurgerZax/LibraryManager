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
    public partial class FormFilterByAuthor : Form
    {
        public string Author { get; private set; }

        public FormFilterByAuthor()
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
            Author = textBox1.Text;
            button1.Enabled = InputValidator.validateAuthor(Author);
        }

        private void FormFilterByAuthor_Load(object sender, EventArgs e)
        {
            UpdateForm();
        }
    }
}
