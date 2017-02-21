using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RevitButton.WindowsForm
{
    public partial class Form3 : Form
    {
        Array arr;

        public Form3(Array _arr)
        {
            arr = _arr;

            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

            foreach (string s in arr)
            {
                checkedListBox1.Items.Add(s);
            }
            
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
