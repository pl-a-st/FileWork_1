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
    
    public partial class FmMain : Form
    {
        /// <summary>
        /// Поле для передачи имени файла для сохранения
        /// </summary>
        static public string FileNameFullNamePart
        {
            get; private set;
        }
        public FmMain()
        {
            Program.fmMain = this; //в fmMain помещаем эту форму
            InitializeComponent();
        }
        
        public ComboBox GetCbName()
        {
            return cBName;
        }
        public ComboBox GetCbSurname()
        {
            return cBSurname;
        }
        public ComboBox GetCbMiddleName()
        {
            return cBMiddleName;
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
        static public void WriteCombobox(string fileName,ComboBox comboBox)
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
            foreach (string fullNameInLbHumanList in lBHumansList.Items)
            {
                if (fullNameInLbHumanList == fullName)
                {
                    MessageBox.Show("Такой товарищ уже внесен в список");
                    return;
                }
            }
           
            try
            {
                lBHumansList.Items.Add(fullName);
                StreamWriter streamWriter = new StreamWriter(Constants.FILE_HUMANS_LIST,true);
                streamWriter.WriteLine(fullName);
                streamWriter.Close();
            }
            catch
            {
                MessageBox.Show("Не удалось сорхранить товарища. Файл для сохранения не доступен.");
            }
        }
        private void btnNameAdd_Click(object sender, EventArgs e)
        {
            FmAddFullNamePart fmAddFullNamePart = new FmAddFullNamePart();
            FileNameFullNamePart = Constants.FILE_NAME;
            fmAddFullNamePart.Text = "Добавление Имени";
            fmAddFullNamePart.label1.Text = "Введите имя";
            fmAddFullNamePart.ShowDialog();
        }
        private void btnSurameAdd_Click(object sender, EventArgs e)
        {
            FmAddFullNamePart fmAddFullNamePart = new FmAddFullNamePart();
            FileNameFullNamePart = Constants.FILE_SURNAME;
            fmAddFullNamePart.Text = "Добавление Фамилии";
            fmAddFullNamePart.label1.Text = "Введите фамилию";
            fmAddFullNamePart.ShowDialog();
        }

        private void btnMidlenameAdd_Click(object sender, EventArgs e)
        {
            FmAddFullNamePart fmAddFullNamePart = new FmAddFullNamePart();
            FileNameFullNamePart = Constants.FILE_MIDDLENAME;
            fmAddFullNamePart.Text = "Добавление Отчества";
            fmAddFullNamePart.label1.Text = "Введите отчество";
            fmAddFullNamePart.ShowDialog();
        }
    }
}
