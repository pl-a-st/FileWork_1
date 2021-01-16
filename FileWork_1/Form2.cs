using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileWork_1
{
    public partial class fmAddFullNamePart : Form
    {
        public fmAddFullNamePart()
        {
            InitializeComponent();
        }

        private void fmAddFullNamePart_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text!="")
            {
                Form1.AddFullNamePart(Form1.FileNameFullNamePart, textBox1.Text);
                Close();
            }
            else
            {
                MessageBox.Show("Не введены данные!");
            }
            
        }
    }
}
