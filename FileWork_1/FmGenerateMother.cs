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
                    if (textBox is TextBox)
                    {
                        textBox.Enabled = false;
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
        public void FmGenerateMother_Load(object sender, EventArgs e)
        {
            SetGenerateOrChange(generateOrChange.generate);
            FormSettingsGenerateOrChange();
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
            
            Random rnd = new Random();
            Gender gender = Calculate.GenerateGender();
            string surname;
            string fileSurname=Calculate.SetFileSurName(gender);
            string fileName = Calculate.SetFileSurName(gender);
            string fileMiddlename=Calculate.SetFileMiddleName(gender);
            string fullNamePart = "";
            List<string> listFullNamePart = Calculate.SetListFullNamePart(fileSurname);
            
            
            
            
            {//выбрать случайную часть полного имени
                fullNamePart = listFullNamePart[rnd.Next(0, listFullNamePart.Count + 1)];
            }//
            //Person person = new Person(fullNamePart,);
        }
    }
}
