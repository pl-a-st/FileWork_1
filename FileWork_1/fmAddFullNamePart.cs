using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileWork_1
{
    public partial class FmAddFullNamePart : Form
    {
        public FmAddFullNamePart()
        {
            InitializeComponent();
        }

        private void fmAddFullNamePart_Load(object sender, EventArgs e)
        {

        }

       private void btnAddFullNamePart_Click(object sender, EventArgs e)
        {
            if ( textBox1.Text!="")
            {
                bool nullString = true;
                if (File.Exists(FmMain.FileNameFullNamePart))
                {
                    StreamReader streamReader = new StreamReader(FmMain.FileNameFullNamePart);

                    if (streamReader.ReadToEnd() != "")
                    {
                        nullString = false;
                    }
                    streamReader.Close();
                }
                try
                {
                    StreamWriter streamWriter = new StreamWriter(FmMain.FileNameFullNamePart, true);
                    if (!nullString)
                    {
                        streamWriter.WriteLine();
                    }
                    streamWriter.Write(textBox1.Text);
                    streamWriter.Close();
                }
                catch
                {
                    MessageBox.Show("Не доступен файл для записи: " + FmMain.FileNameFullNamePart);
                }
                FmMain.WriteCombobox(Constants.FILE_NAME, Program.fmMain.returncBName());
                FmMain.WriteCombobox(Constants.FILE_SURNAME, Program.fmMain.returncBSurname());
                FmMain.WriteCombobox(Constants.FILE_MIDDLENAME, Program.fmMain.returncBMiddleName());
                Close();
            }
            else
            {
                MessageBox.Show("Не введены данные!");
            }
            
        }
    }
}
