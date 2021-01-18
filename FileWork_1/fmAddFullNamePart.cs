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
       private void btnAddFullNamePart_Click(object sender, EventArgs e)
        {
            if ( textBox1.Text!="")
            {
                AddFullNamePartInFile(textBox1.Text);
                AddFullNamePartInComboBox();
                Close();
            }
            else
            {
                MessageBox.Show("Не введены данные!");
            }
            
        }
        private void AddFullNamePartInComboBox()
        {
            if (FmMain.FileNameFullNamePart == Constants.FILE_NAME)
            {
                FmMain.WriteCombobox(Constants.FILE_NAME, Program.fmMain.GetCbName());
                Program.fmMain.GetCbName().Text = textBox1.Text;
            }
            if (FmMain.FileNameFullNamePart == Constants.FILE_SURNAME)
            {
                FmMain.WriteCombobox(Constants.FILE_SURNAME, Program.fmMain.GetCbSurname());
                Program.fmMain.GetCbSurname().Text = textBox1.Text;
            }
            if (FmMain.FileNameFullNamePart == Constants.FILE_MIDDLENAME)
            {
                FmMain.WriteCombobox(Constants.FILE_MIDDLENAME, Program.fmMain.GetCbMiddleName());
                Program.fmMain.GetCbMiddleName().Text = textBox1.Text;
            }
        }
        private void AddFullNamePartInFile(string textBoxText)
        {
            bool nullString = true;
            List<string> listFullNamePart = new List<string>();
            if (File.Exists(FmMain.FileNameFullNamePart))
            {
                StreamReader streamReader = new StreamReader(FmMain.FileNameFullNamePart);

                if (streamReader.ReadToEnd() != "")
                {
                    nullString = false;
                }
                streamReader.DiscardBufferedData();
                streamReader.BaseStream.Seek(0, System.IO.SeekOrigin.Begin);
                while (!streamReader.EndOfStream)
                {
                    listFullNamePart.Add(streamReader.ReadLine());
                }
                streamReader.Close();
            }
            foreach (string fullName in listFullNamePart)
            {
                if (fullName==textBoxText)
                {
                    MessageBox.Show("Данное значение уже есть в списке!");
                    return;
                }
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
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
