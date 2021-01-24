using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileWork_1
{
    public enum Gender
    {
        mail,
        femail
    }
    public class Person
    {
        public Gender Gender
        { get; private set; }
        public string Name
        { get; private set; }
        public string Surname
        { get; private set; }
        public string Middlename
        { get; private set; }
        public int Age
        { get; private set; }
        public string Function
        { get; private set; }
        public int Salary
        { get; private set; }
        public Person (string surname, string name, string middlename, int age, string function, int salary, Gender gender)
        {
            Surname = surname;
            Name = name;
            Middlename = middlename;
            Age = age;
            Function = function;
            Salary = salary;
            Gender = gender;
        }
        public void SetSurname(string surname)
        {Surname = surname;}
        public void SetName(string name)
        { Name = name; }
        public void SetMiddlename(string middlename)
        { Middlename = middlename; }
        public void SetAge(int age)
        { Age = age; }
        public void SetFunction(string function)
        { Function = function; }
        public void SetSalary(int salary)
        { Salary = salary; }
    }
}
