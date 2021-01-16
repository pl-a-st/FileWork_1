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
    
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            
        }
        private void AddFullNamePart(string FaileName, string fullNamePart)
        {
            StreamWriter streamWriter = new StreamWriter(FaileName,true);
            streamWriter.WriteLine();
            streamWriter.Write(fullNamePart);
            streamWriter.Close();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

            lBHumansList.Items.Clear();
            if (File.Exists(Constants.FILE_HUMANS_LIST))
            {
                lBHumansList.Items.Clear();
                StreamReader streamReader = new StreamReader(Constants.FILE_HUMANS_LIST);
                while (!streamReader.EndOfStream)
                {
                    lBHumansList.Items.Add(streamReader.ReadLine());
                }
                streamReader.Close();
            }
            WriteCombobox(Constants.FILE_NAME, cBName);
            WriteCombobox(Constants.FILE_SURNAME, cBSurname);
            WriteCombobox(Constants.FILE_MIDDLENAME, cBMiddleName);

        }
        private void WriteCombobox(string fileName,ComboBox comboBox)
        {
            if (File.Exists(fileName))
            {
                comboBox.Items.Clear();
                StreamReader streamReader = new StreamReader(fileName);
                while (!streamReader.EndOfStream)
                {
                    comboBox.Items.Add(streamReader.ReadLine());
                }
                streamReader.Close();
            }
            else
            {
                MessageBox.Show("Файл " + fileName + " отсуттвует, соответствующий список быдет пустым.");
            }
        }

        private void btnWritePerson_Click(object sender, EventArgs e)
        {
            string fullName = cBSurname.Text + " " + cBName.Text + " " + cBMiddleName.Text;
            foreach (string fullNamePersone in lBHumansList.Items)
            {
                if (fullNamePersone == fullName)
                {
                    MessageBox.Show("Такой товарищ уже внесен в список");
                    return;
                }
            }
            lBHumansList.Items.Add(fullName);
            try
            {
                StreamWriter streamWriter = new StreamWriter(Constants.FILE_HUMANS_LIST,true);
                streamWriter.WriteLine(fullName);
                streamWriter.Close();
            }
            catch
            {

            }

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void btnNameAdd_Click(object sender, EventArgs e)
        {
            AddFullNamePart(Constants.FILE_NAME, cBName.Text);
        }

        private void btnSurameAdd_Click(object sender, EventArgs e)
        {
            AddFullNamePart(Constants.FILE_SURNAME, cBSurname.Text);
        }

        private void btnMidlenameAdd_Click(object sender, EventArgs e)
        {
            AddFullNamePart(Constants.FILE_MIDDLENAME, cBMiddleName.Text);
        }
    }
}
