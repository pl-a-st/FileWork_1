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
        /// <summary>
        /// Определяет в какой комбобокс записать текущий, назначенный файл
        /// </summary>
        private void AddFullNamePartInComboBox()
        {
            if (FmMain.FileNameFullNamePart == Program.fmMain.FileNames)
            {
                FmMain.WriteCombobox(Program.fmMain.FileNames, Program.fmMain.GetCbName());
                Program.fmMain.GetCbName().Text = textBox1.Text;
            }
            if (FmMain.FileNameFullNamePart == Program.fmMain.FileSurnames)
            {
                FmMain.WriteCombobox(Program.fmMain.FileSurnames, Program.fmMain.GetCbSurname());
                Program.fmMain.GetCbSurname().Text = textBox1.Text;
            }
            if (FmMain.FileNameFullNamePart == Program.fmMain.FileMiddlenames)
            {
                FmMain.WriteCombobox(Program.fmMain.FileMiddlenames, Program.fmMain.GetCbMiddleName());
                Program.fmMain.GetCbMiddleName().Text = textBox1.Text;
            }
        }
        /// <summary>
        /// Отправляет часть полного имени в соответствующий файл
        /// </summary>
        /// <param name="textBoxText">часть имени для записи в файл</param>
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

        private void textBox1_Enter(object sender, EventArgs e)
        {
            btnAddFullNamePart.PerformClick();
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter && textBox1.Text!="")
            {
                btnAddFullNamePart.PerformClick();
            }
            if (e.KeyCode==Keys.Escape)
            {
                btnCancel.PerformClick();
            }
        }
    }
}