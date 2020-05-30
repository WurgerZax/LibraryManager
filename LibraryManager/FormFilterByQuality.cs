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
    public partial class FormFilterByQuality : Form
    {
        public string Quality { get; private set; }
        private readonly List<string> qualityList = new List<string>();
        public List<string> QualityList
        {
            get
            {
                return qualityList;
            }
        }

        public FormFilterByQuality()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void FormFilterByQuality_Load(object sender, EventArgs e)
        {
            comboBox1.Items.AddRange(qualityList.ToArray());
            UpdateForm();
        }

        private void UpdateForm()
        {
            Quality = comboBox1.Text;
            button1.Enabled = InputValidator.validateQuality(Quality);
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            UpdateForm();
        }
    }
}
