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
        public enum Gender
        {
            mail,
            femail
        }
        public Gender GenderPersone
        {
            get; private set;
        }
        public void SetGenderMail()
        {
            GenderPersone = Gender.mail;
        }
        public void SetGenderFeMail()
        {
            GenderPersone = Gender.femail;
        }
        public string FileNames
        {
            get; private set;
        }
        public void SetFileNames(string fileNames)
        {
            FileNames = fileNames;
        }
        public string FileSurnames
        {
            get; private set;
        }
        public void SetFileSurnames(string fileNames)
        {
            FileSurnames = fileNames;
        }
        public string FileMiddlenames
        {
            get; private set;
        }
        public void SetFileMiddlenames(string fileNames)
        {
            FileMiddlenames = fileNames;
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
            AddLBHumansList(Constants.FILE_HUMANS_LIST);
            RBMail.Checked=true;
        }
        public void AddLBHumansList(string fileName)
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
        }
        /// <summary>
        /// Запиcывает в передаваемый ComboBox данные из передаваемого файла
        /// </summary>
        /// <param name="fileName">Файл с данными для ComboBox</param>
        /// <param name="comboBox">передаваемый ComboBox</param>
        static public void WriteCombobox(string fileName, ComboBox comboBox)
        {
            comboBox.Items.Clear();
            comboBox.Text = "";
            if (File.Exists(fileName))
            {
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
            if (cBName.Text=="")
            {
                string nameToMessage = "Имя";
                string surnameToMessage="";
                if (cBSurname.Text=="")
                {
                    surnameToMessage = "Фамилия, ";
                }
                MessageBox.Show("Не указаны: " + surnameToMessage + nameToMessage + ". Данные не будут введены!");
                return;
            }
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
                StreamWriter streamWriter = new StreamWriter(Constants.FILE_HUMANS_LIST, true);
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
            FileNameFullNamePart = FileNames;
            FmAddFullNamePart fmAddFullNamePart = new FmAddFullNamePart();
            fmAddFullNamePart.Text = "Добавление Имени";
            fmAddFullNamePart.label1.Text = "Введите имя";
            fmAddFullNamePart.ShowDialog();
        }
        private void btnSurameAdd_Click(object sender, EventArgs e)
        {
            FileNameFullNamePart = FileSurnames;
            FmAddFullNamePart fmAddFullNamePart = new FmAddFullNamePart();
            fmAddFullNamePart.Text = "Добавление Фамилии";
            fmAddFullNamePart.label1.Text = "Введите фамилию";
            fmAddFullNamePart.ShowDialog();
        }

        private void btnMidlenameAdd_Click(object sender, EventArgs e)
        {
            FileNameFullNamePart = FileMiddlenames;
            FmAddFullNamePart fmAddFullNamePart = new FmAddFullNamePart();
            fmAddFullNamePart.Text = "Добавление Отчества";
            fmAddFullNamePart.label1.Text = "Введите отчество";
            fmAddFullNamePart.ShowDialog();
        }
        /// <summary>
        /// ПО поставленному RadianBaton устанавливаем пол, устанавливаем соответствующие файлы, записываем соответствующие кобобоксы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RBMail_CheckedChanged(object sender, EventArgs e)
        {
            if (RBMail.Checked)
            {
                SetGenderMail();
                ChangeFileName();
                WriteCombobox(FileNames, cBName);
                WriteCombobox(FileSurnames, cBSurname);
                WriteCombobox(FileMiddlenames, cBMiddleName);
            }
        }
        static public void AddFullNamePartInComboBox(string textForComboBoxtext)
        {
            if (FmMain.FileNameFullNamePart == Program.fmMain.FileNames)
            {
                FmMain.WriteCombobox(Program.fmMain.FileNames, Program.fmMain.GetCbName());
                Program.fmMain.GetCbName().Text = textForComboBoxtext;
            }
            if (FmMain.FileNameFullNamePart == Program.fmMain.FileSurnames)
            {
                FmMain.WriteCombobox(Program.fmMain.FileSurnames, Program.fmMain.GetCbSurname());
                Program.fmMain.GetCbSurname().Text = textForComboBoxtext;
            }
            if (FmMain.FileNameFullNamePart == Program.fmMain.FileMiddlenames)
            {
                FmMain.WriteCombobox(Program.fmMain.FileMiddlenames, Program.fmMain.GetCbMiddleName());
                Program.fmMain.GetCbMiddleName().Text = textForComboBoxtext;
            }
        }
        private void RBFemaill_CheckedChanged(object sender, EventArgs e)
        {
            if(RBFemaill.Checked)
            {
                SetGenderFeMail();
                ChangeFileName();
                WriteCombobox(FileNames, cBName);
                WriteCombobox(FileSurnames, cBSurname);
                WriteCombobox(FileMiddlenames, cBMiddleName);
            }
        }
        /// <summary>
        /// Устанавливает имена файлов для мужчин и для женщин
        /// </summary>
        private void ChangeFileName()
        {
            if (GenderPersone == Gender.mail)
            {
                SetFileNames(Constants.FILE_NAME);
                SetFileSurnames(Constants.FILE_SURNAME);
                SetFileMiddlenames(Constants.FILE_MIDDLENAME);
            }
            if (GenderPersone == Gender.femail)
            {
                SetFileNames(Constants.FILE_NAME_WOOMEN); 
                SetFileSurnames(Constants.FILE_SURNAME_WOOMEN);
                SetFileMiddlenames(Constants.FILE_MIDDLENAME_WOOMEN);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(lBHumansList.SelectedItem.ToString());
        }

        private void btnSurnameRemove_Click(object sender, EventArgs e)
        {
            FileNameFullNamePart = FileSurnames;
            FmRemoveFullNameOrPart fmRemoveFullNameOrPart = new FmRemoveFullNameOrPart();
            fmRemoveFullNameOrPart.Text = "Удаление Фамилии";
            fmRemoveFullNameOrPart.chBRemoveAllPerson.Text = "Удалить всех товарищей\n с удаленными фамилиями";
            fmRemoveFullNameOrPart.lbListChangeRemove.Text = "Выберите фамилию для удаления";
            fmRemoveFullNameOrPart.ShowDialog();
            AddLBHumansList(Constants.FILE_HUMANS_LIST);
        }

        private void btnNameRemove_Click(object sender, EventArgs e)
        {
            FileNameFullNamePart = FileNames;
            FmRemoveFullNameOrPart fmRemoveFullNameOrPart = new FmRemoveFullNameOrPart();
            fmRemoveFullNameOrPart.Text = "Удаление Имени";
            fmRemoveFullNameOrPart.chBRemoveAllPerson.Text = "Удалить всех товарищей\n с удаленными именами";
            fmRemoveFullNameOrPart.lbListChangeRemove.Text = "Выберите имя для удаления";
            fmRemoveFullNameOrPart.ShowDialog();
            AddLBHumansList(Constants.FILE_HUMANS_LIST);
        }

        private void btnMidlenameRemove_Click(object sender, EventArgs e)
        {
            FileNameFullNamePart = FileMiddlenames;
            FmRemoveFullNameOrPart fmRemoveFullNameOrPart = new FmRemoveFullNameOrPart();
            fmRemoveFullNameOrPart.Text = "Удаление Отчества";
            fmRemoveFullNameOrPart.chBRemoveAllPerson.Text = "Удалить всех товарищей\n с удаленными отчествами";
            fmRemoveFullNameOrPart.lbListChangeRemove.Text = "Выберите отчество для удаления";
            fmRemoveFullNameOrPart.ShowDialog();
            AddLBHumansList(Constants.FILE_HUMANS_LIST);
        }
    }
}
