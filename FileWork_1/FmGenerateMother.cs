﻿using System;
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
                foreach (Control control in this.Controls)
                {
                    if (control is TextBox)
                    {
                        TextBox textBox1 = control as TextBox;
                        textBox1.ReadOnly = true;
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
                foreach (Control control in this.Controls)
                {
                    if (control is TextBox)
                    {
                        TextBox textBox1 = control as TextBox;
                        textBox1.ReadOnly = false;
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
            {//Записать измененного персонажа
                int indexList = lbxGeneratedPersons.SelectedIndex;
                ListPerson[indexList].SetSurname(tBSurname.Text);
                ListPerson[indexList].SetName(tBName.Text);
                ListPerson[indexList].SetMiddlename(tBMiddlename.Text);
                ListPerson[indexList].SetAge(Convert.ToInt32(tBAge.Text));
                ListPerson[indexList].SetFunction(tBFuntion.Text);
                ListPerson[indexList].SetSalary(Convert.ToInt32(tBSalary.Text));
                DAO.WriteListInToFile(ListPerson, Constants.FILE_GENERATED_PERSONS);
                lbxGeneratedPersons.Items.Clear();
                foreach (string person in DAO.SetListStringFromFile(Constants.FILE_GENERATED_PERSONS))
                {
                    lbxGeneratedPersons.Items.Add(Calculate.SetPersonStringForListBox(person));
                }
                lbxGeneratedPersons.SelectedIndex = indexList;
            }
            FormSettingsGenerateOrChange();
        }

        private void btnCancell_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Действительно выйти? Если Вы нажмете 'Да' то все изменения будут утерянны ", "Отмена изменений", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {

            }
            if (result == DialogResult.Yes)
            {
                int indexList = lbxGeneratedPersons.SelectedIndex;
                lbxGeneratedPersons.SelectedIndex = -1;
                lbxGeneratedPersons.SelectedIndex = indexList;
                SetGenerateOrChange(generateOrChange.generate);
                FormSettingsGenerateOrChange();

            }
           
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
            if (indexList>=0)
            {
                tBSurname.Text= ListPerson[indexList].Surname;
                tBName.Text = ListPerson[indexList].Name;
                tBMiddlename.Text= ListPerson[indexList].Middlename;
                tBAge.Text= Convert.ToString(ListPerson[indexList].Age);
                tBFuntion.Text= ListPerson[indexList].Function;
                tBSalary.Text = Convert.ToString(ListPerson[indexList].Salary);
            }
        }
    }
}
