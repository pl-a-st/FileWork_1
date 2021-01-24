using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileWork_1
{
    class Calculate
    {
        static private Random rnd = new Random();

        public static Gender GenerateGender()
        {
            Gender gender = (Gender)rnd.Next(0, 2);
            return gender;
        }
        public static string SetFileName(Gender gender)
        {
            string fileName = "";
            if (gender == Gender.mail)
            {
                fileName = Constants.FILE_NAME;
            }
            if (gender == Gender.femail)
            {
                fileName = Constants.FILE_NAME_WOOMEN;
            }
            return fileName;
        }
        public static string SetFileSurName(Gender gender)
        {
            string fileSurName = "";
            if (gender == Gender.mail)
            {
                fileSurName = Constants.FILE_SURNAME;
            }
            if (gender == Gender.femail)
            {
                fileSurName = Constants.FILE_SURNAME_WOOMEN;
            }
            return fileSurName;
        }
        public static string SetFileMiddleName(Gender gender)
        {
            string fileMiddeleName = "";
            if (gender == Gender.mail)
            {
                fileMiddeleName = Constants.FILE_MIDDLENAME;
            }
            if (gender == Gender.femail)
            {
                fileMiddeleName = Constants.FILE_MIDDLENAME_WOOMEN;
            }
            return fileMiddeleName;
        }
        public static string SetRandomStringiInList(List<string> listString)
        {
            if (listString.Count == 0)
            {
                return "";
            }
            return listString[rnd.Next(0, listString.Count)];
        }
        public static int SetRandomAge()
        {
            return rnd.Next(18, 80);
        }
        public static int SetRandomSalary()
        {
            return rnd.Next(15000, 150000);
        }
        public static string SetPersonStingForFile(Person person)
        {
            return person.Surname + " " + person.Name + " " + person.Middlename + " " + person.Age + " " + person.Function + " " + person.Salary;
        }
        public static string SetPersonStingForListBox(Person person)
        {
            return person.Surname + " " + person.Name + " " + person.Middlename + ", возраст: " + person.Age + ", должность:" + person.Function + ", зарплата: " + person.Salary;
        }
        public static string SetPersonStingForListBox(string person)
        {
            string[] personString = person.Split(' ');
            if (personString.Length == 6)
            {
                return personString[0] + " " + personString[1] + " " + personString[2] + ", возраст: " + personString[3] + ", должность:" + personString[4] + ", зарплата: " + personString[5];
            }
            return "ошибка записи файла";
        }
    }
}
