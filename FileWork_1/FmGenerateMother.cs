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
    public partial class FmGenerateMother : Form
    {
        public enum generateOrChange
        {
            generate,
            change
        }
        /// <summary>
        /// Режим работы формы
        /// </summary>
        public generateOrChange GenerateOrChange
        { get; private set; }
        public void SetGenerateOrChange(generateOrChange generateOrChange)
        {
            GenerateOrChange = generateOrChange;
        }
        public FmGenerateMother()
        {
            InitializeComponent();
        }
        private void FormSettingsGenerateOrChange()
        {
            if (GenerateOrChange == generateOrChange.generate)
            {
                foreach (Control textBox in this.Controls)
                {
                    List<TextBox> textBoxes = new List<TextBox>();
                    if (textBox is TextBox)
                    {
                        textBoxes.Add(textBox);
                        textBox.ReadOnly = true;
                    }
                }
                lbxGeneratedPersons.Enabled = true;
                btnCancell.Visible = false;
                btnSave.Visible = false;
                btnGenerate.Visible = true;
                btnChangePersone.Visible = true;
            }
            if (GenerateOrChange == generateOrChange.change)
            {
                foreach (Control textBox in this.Controls)
                {
                    if (textBox is TextBox)
                    {
                        textBox.Enabled = true;
                    }
                }
                lbxGeneratedPersons.Enabled = false;
                btnCancell.Visible = true;
                btnSave.Visible = true;
                btnGenerate.Visible = false;
                btnChangePersone.Visible = false;
            }
        }
        public List<Person> ListPerson
        { get; private set; }

        public void AddListPerson(Person person)
        {
            ListPerson.Add(person);
        }
        public void FmGenerateMother_Load(object sender, EventArgs e)
        {
            SetGenerateOrChange(generateOrChange.generate);
            FormSettingsGenerateOrChange();
            ListPerson = new List<Person>();
            foreach(string person in DAO.SetListStringFromFile(Constants.FILE_GENERATED_PERSONS))
            {
                lbxGeneratedPersons.Items.Add(Calculate.SetPersonStringForListBox(person));
                AddListPerson(Calculate.CreatePersonFromString(person));
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SetGenerateOrChange(generateOrChange.generate);
            FormSettingsGenerateOrChange();
        }

        private void btnCancell_Click(object sender, EventArgs e)
        {
            SetGenerateOrChange(generateOrChange.generate);
            FormSettingsGenerateOrChange();
        }

        private void btnChangePersone_Click(object sender, EventArgs e)
        {
            SetGenerateOrChange(generateOrChange.change);
            FormSettingsGenerateOrChange();
        }
        
        private void btnGenerate_Click(object sender, EventArgs e)
        {
            Gender gender = Calculate.GenerateGender();
            string surname = Calculate.SetRandomStringiInList(DAO.SetListStringFromFile(Calculate.SetFileSurName(gender)));
            string name = Calculate.SetRandomStringiInList(DAO.SetListStringFromFile(Calculate.SetFileName(gender)));
            string midllename = Calculate.SetRandomStringiInList(DAO.SetListStringFromFile(Calculate.SetFileMiddleName(gender)));
            string function = Calculate.SetRandomStringiInList(DAO.SetListStringFromFile(Constants.FILE_FUNCTION));
            int age = Calculate.SetRandomAge();
            int salary = Calculate.SetRandomSalary();
            Person person = new Person(surname, name, midllename, age, function, salary, gender);
            AddListPerson(person);
            DAO.AddStringInToFile(Calculate.SetPersonStingForFile(person), Constants.FILE_GENERATED_PERSONS);
            lbxGeneratedPersons.Items.Add(Calculate.SetPersonStingForListBox(person));
        }

        private void lbxGeneratedPersons_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indexList = lbxGeneratedPersons.SelectedIndex;
            tBName.Text = ListPerson[indexList].Name;
        }
    }
}
