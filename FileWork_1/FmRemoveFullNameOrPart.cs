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
            try
            {
                lbListFullNamePart.Items.RemoveAt(lbListFullNamePart.SelectedIndex);
            }
            catch { }
        }
        private void removeFullNamePart()
        {
            StreamWriter streamWriter = new StreamWriter(FmMain.FileNameFullNamePart, false);
            foreach (string fullNamePart in lbListFullNamePart.Items)
            {
                streamWriter.WriteLine(fullNamePart);
            }
            streamWriter.Close();
        }
        private void btnSaveRemove_Click(object sender, EventArgs e)
        {
            if(!chBRemoveAllPerson.Checked)
            {
                removeFullNamePart();
            }
            
            if (chBRemoveAllPerson.Checked)
            {
                // в отдельный метод записать массив значений оставленных после удаления
                int itemsCount = lbListFullNamePart.Items.Count;
                string[] listFullNamePart = new string[itemsCount];
                List<string> listFullName = new List<string>();
                List<string> listDeletedFullNamePart = new List<string>();
                List < string [] > listFullNameInWords = new List<string[]>();
                for (int i=0;i<itemsCount;i++)
                {
                    listFullNamePart[i] = lbListFullNamePart.Items[i].ToString();
                }
                // в отдельный методо записать массив удаленных
               
                    bool entring ;
                    StreamReader streamReader = new StreamReader(FmMain.FileNameFullNamePart);
                while (!streamReader.EndOfStream)
                {
                    entring = false;
                    string fullName = streamReader.ReadLine();
                    for (int i = 0; i < listFullNamePart.Length; i++)
                    {
                        if(fullName== listFullNamePart[i])
                        {
                            entring = true;
                            break;
                        }
                    }
                    if (!entring)
                    {
                        listDeletedFullNamePart.Add(fullName);
                    }
                }
                streamReader.Close();
                // в отдельный метод создать массив полных имен
                if (File.Exists(Constants.FILE_HUMANS_LIST))
                {
                    streamReader = new StreamReader(Constants.FILE_HUMANS_LIST);
                    while (!streamReader.EndOfStream)
                    {
                       listFullName.Add(streamReader.ReadLine());
                    }
                    streamReader.Close();
                }
                // в отдельный метод разбиваеме лист на лист массивов
                for (int i=0;i<listFullName.Count;i++)
                {
                    listFullNameInWords.Add(listFullName[i].Split(' '));
                }
                // в отдельный метод проверяем есть ли совпадения между существующим списком полных имен и после удаления
                int partNameInArry=4;
                if (FmMain.FileNameFullNamePart==Constants.FILE_NAME || FmMain.FileNameFullNamePart == Constants.FILE_NAME_WOOMEN)
                {
                    partNameInArry = 1;
                }
                if (FmMain.FileNameFullNamePart == Constants.FILE_SURNAME || FmMain.FileNameFullNamePart == Constants.FILE_SURNAME_WOOMEN)
                {
                    partNameInArry = 0;
                }
                if (FmMain.FileNameFullNamePart == Constants.FILE_MIDDLENAME || FmMain.FileNameFullNamePart == Constants.FILE_MIDDLENAME_WOOMEN)
                {
                    partNameInArry = 3;
                }
                for (int i=0;i< listFullNameInWords.Count;i++)
                {
                    for (int j = 0; j < listDeletedFullNamePart.Count; j++)
                    {
                        try
                        {
                            if (listFullNameInWords[i][partNameInArry] == listDeletedFullNamePart[j])
                            {
                                listFullNameInWords.RemoveAt(i);
                                listFullName.RemoveAt(i);
                                i--;
                            }
                        }
                        catch { }
                    }
                   
                }
                //отдельный метод записать в файл
                StreamWriter streamWriter = new StreamWriter(Constants.FILE_HUMANS_LIST,false);
                foreach (string person in listFullName)
                {
                    streamWriter.WriteLine(person);
                }
                streamWriter.Close();
                removeFullNamePart();
            }

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
