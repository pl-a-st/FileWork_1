using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace FileWork_1
{
    class Calculate
    {
        static private Random rnd;
        static private StreamReader streamReader;
        public static Gender GenerateGender()
        {
            Gender gender = (Gender)rnd.Next(0, 1);
            return gender;
        }
        public static string SetFileName(Gender gender)
        {
            string fileName="";
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
                fileMiddeleName = Constants.FILE_SURNAME;
            }
            if (gender == Gender.femail)
            {
                fileMiddeleName = Constants.FILE_SURNAME_WOOMEN;
            }
            return fileMiddeleName;
        }
        public static List <string> SetListFullNamePart(string fullNamePart)
        {
            List<string> listFullNamePart = new List<string>();
            while (!streamReader.EndOfStream)
            {
                listFullNamePart.Add(streamReader.ReadLine());
            }
            streamReader.Close();
            return listFullNamePart;
        }
    }
}
