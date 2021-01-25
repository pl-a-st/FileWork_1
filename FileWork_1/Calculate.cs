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
            return person.Surname + "\t" + person.Name + "\t" + person.Middlename + "\t" + person.Age + "\t" + person.Function + "\t" + person.Salary + "\t" + Convert.ToInt32(person.Gender);
        }
        public static string SetPersonStingForListBox(Person person)
        {
            return person.Surname + " " + person.Name + " " + person.Middlename + ", возраст: " + person.Age + ", должность:" + person.Function + ", зарплата: " + person.Salary;
        }
        /// <summary>
        /// Создает строку для записи в ListBox из строки с разделителем Tab. Если в строке 
        /// число полей отличается от числа записей конструктора возвращает "ошибка записи файла".
        /// </summary>
        /// <param name="person">Cтрока с разделителем Tab</param>
        /// <returns></returns>
        public static string SetPersonStringForListBox(string person)
        {
            string[] personString = person.Split('\t');
            if (personString.Length == Person.PERSONS_ATTRIBUTE_COUNT)
            {
                return personString[0] + " " + personString[1] + " " + personString[2] + ", возраст: " + personString[3] + ", должность: " + personString[4] + ", зарплата: " + personString[5];
            }
            return "ошибка записи файла";
        }
        /// <summary>
        /// Создает экземпляр Person из строки с разделителем Tab. Если в строке число полей 
        /// отилчается от числа свойств  определнных конструктором класса Person, 
        /// то возвращает пустой экземпляр
        /// </summary>
        /// <param name="personString">строка для создания экземпляра</param>
        /// <returns></returns>
        public static Person CreatePersonFromString(string personString)
        {
            string[] listPerson = personString.Split('\t');
            if (listPerson.Length == Person.PERSONS_ATTRIBUTE_COUNT)
            {
                Gender gender;
                gender = (Gender)Convert.ToInt32(listPerson[5]);
                return new Person(listPerson[0], listPerson[1], listPerson[2], Convert.ToInt32(listPerson[3]), listPerson[4], Convert.ToInt32(listPerson[5]), gender);
            }
            return new Person();
        }
    }
}
