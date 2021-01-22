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
    public partial class FmRemoveFullNameOrPart : Form
    {
        public FmRemoveFullNameOrPart()
        {
            InitializeComponent();
        }

        private void FmRemoveFullNameOrPart_Load(object sender, EventArgs e)
        {
            lbListFullNamePart.Items.Clear();
            if (File.Exists(FmMain.FileNameFullNamePart))
            {
                StreamReader streamReader = new StreamReader(FmMain.FileNameFullNamePart);
                while (!streamReader.EndOfStream)
                {
                    lbListFullNamePart.Items.Add(streamReader.ReadLine());
                }
                streamReader.Close();
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            lbListFullNamePart.Items.RemoveAt(lbListFullNamePart.SelectedIndex);
        }

        private void btnSaveRemove_Click(object sender, EventArgs e)
        {
            StreamWriter streamWriter = new StreamWriter(FmMain.FileNameFullNamePart, false);
            foreach (string fullNamePart in lbListFullNamePart.Items)
            {
                streamWriter.WriteLine(fullNamePart);
            }
            streamWriter.Close();
            FmMain.AddFullNamePartInComboBox("");
            Close();
        }

        private void btnCancelRemove_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Действительно выйти? Если Вы нажмете 'Да' то все изменения будут утерянны ", "Отмена изменений", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {

            }
            if (result == DialogResult.Yes)
            {
                Close();
            }
            
        }
    }
}
