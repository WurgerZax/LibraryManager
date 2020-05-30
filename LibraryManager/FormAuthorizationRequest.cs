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
    public partial class FormAuthorizationRequest : Form
    {
        public string Password { get; private set; }
        public FormAuthorizationRequest()
        {
            InitializeComponent();
        }

        private void FormAuthorizationRequest_Load(object sender, EventArgs e)
        {
            Password = textBox1.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Password = textBox1.Text;
        }
    }
}
