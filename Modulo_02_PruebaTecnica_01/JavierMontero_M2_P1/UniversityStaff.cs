using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JavierMontero_M2_P1
{
    internal class UniversityStaff
    {
        public string name;
        public int age;
        public char sex;
        public float workExperience;
        public bool tenured;
        string[] positions = new string[5] { "Researcher", "Administrative Secretary",
            "Librarian", "Janitor", "Coach" };
        int[] numberWorkers = new int[5] { 2, 4, 2, 1, 2 };
        float[] salary = new float[5] { 1852.25f, 1457.14f, 1325.87f, 1568.13f, 725.53f };
        public void GetTernured()
        {
            Console.WriteLine("You get ternured, Congratulations!");
        }
        public void IsNotTenuredYet()
        {
            Console.WriteLine("You haven't been tenured yet, work hard!");
        }
        public string ReturnPosition(int numPosition)
        {
            string toWrite = "There are " + numberWorkers[numPosition] +
                " workers in the position of  " + positions[numPosition] + ".";
            return toWrite;
        }
        public string ReturnNumberWorkers(int numPosition)
        {
            string toWrite = "The salary in the position of " +
                positions[numPosition] + " is " + salary[numPosition] + " $ per month.";
            return toWrite;
        }
        public void PrintArrays()
        {
            Console.WriteLine("\nThe positions in the University staff " +
                "are as follows:");
            for (int i = 0; i < positions.Length; i++)
            {
                Console.WriteLine(positions[i]);
            }

            Console.WriteLine("\nThe number of workers in each position " +
                "are as follows:");
            for (int i = 0; i < numberWorkers.Length; i++)
            {
                Console.WriteLine(numberWorkers[i]);
            }

            Console.WriteLine("\nThe salary in each position " +
                "are as follows:");
            for (int i = 0; i < salary.Length; i++)
            {
                Console.WriteLine(salary[i] + " $ per month");
            }
        }
        public void PrintClassProperties()
        {
            string stringSex;
            string isTernured;

            if (sex == 'm') stringSex = "male";
            else if (sex == 'f') stringSex = "female";
            else stringSex = "other";

            if (tenured == true) isTernured = "is ternured";
            else isTernured = "is not ternured";

            string classProperties = string.Format("\nThe University staff {0}, who is " +
                "{1} years old, {2} and with a work experience of {3} years, {4}.", name,
                age, stringSex, workExperience, isTernured);
            Console.WriteLine(classProperties);
        }
        public static void PrintFunctionallity()
        {
            Console.WriteLine("This method indicates that it's the end of universitystaff class.\n");
        }
    }
}
