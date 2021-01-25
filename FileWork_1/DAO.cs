using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;


namespace FileWork_1
{
    class DAO
    {
        static private StreamReader streamReader;
        static private StreamWriter StreamWriter;
        /// <summary>
        /// Возращает List<string> из указанного файла, при неудаче зачтения файла возвращает пустой List
        /// </summary>
        /// <param name="filePath">Адрес файла</param>
        /// <returns></returns>
        public static List<string> SetListStringFromFile(string filePath)
        {
            List<string> ListStringFromFile = new List<string>();
            if (File.Exists(filePath))
            {
                streamReader = new StreamReader(filePath);
                while (!streamReader.EndOfStream)
                {
                    ListStringFromFile.Add(streamReader.ReadLine());
                }
                streamReader.Close();
                return ListStringFromFile;
            }
            else
            {
                FmMain.CallMessageBox("Не удалось зачитать файл: " + filePath);
                return ListStringFromFile;
            }
        }
        /// <summary>
        /// Записывает строчку в файл, дополняя его
        /// </summary>
        /// <param name="addingString">строка для записи</param>
        /// <param name="filePath">адрес файла</param>
        public static void AddStringInToFile(string addingString,string filePath)
        {
            StreamWriter = new StreamWriter(filePath,true);
            try
            {
                StreamWriter.WriteLine(addingString);
            }
            catch
            {
                FmMain.CallMessageBox("Не удалось сделать запись в файл: " + filePath);
            }
            StreamWriter.Close();
        }
        /// <summary>
        /// Записывает List перосн в файл, затирая его содержание
        /// </summary>
        /// <param name="listPerson"> Лист персон</param>
        /// <param name="filePath">адрес файла</param>
        public static void WriteListInToFile(List<Person> listPerson,string filePath)
        {
            StreamWriter = new StreamWriter(filePath,false);
            foreach (Person person in listPerson)
            {
                string stringPerson = Calculate.SetPersonStingForFile(person);
                try
                {
                    StreamWriter.WriteLine(stringPerson);
                }
                catch
                {
                    FmMain.CallMessageBox("Не удалось сделать запись в файл: " + filePath);
                }
            }
            StreamWriter.Close();
        }
    }
}
