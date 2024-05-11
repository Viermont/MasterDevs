using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JavierMontero_M2_P1
{
    public class Teachers
    {
        public string name;
        public int age;
        public char sex;
        public float averageHistoricalGrade;
        public bool tenured;
        string[] courses = new string[8] { "Mathematics", "English", "Science",
            "History", "Art", "Physical Education", "Computer Science", "Music" };
        int[] minimumAdmissionGrade = new int[8] { 5, 5, 5, 5, 5, 5, 5, 5 };
        float[] maximumHistoricalGrade = new float[10] { 8.5f, 8.3f, 9.3f, 9.9f,
            8.9f, 9.9f, 8.4f, 9.6f, 8.8f, 8.9f };
        public void Passed()
        {
            Console.WriteLine("The student passes, Congratulations!");
        }
        public void Failed()
        {
            Console.WriteLine("The student gets failed, They must try again!");
        }
        public string ReturnMinPassGrade(int course)
        {
            string toWrite = "The minimum admission grade to access the "
                + courses[course] + " subject is " + minimumAdmissionGrade[course] + ".";
            return toWrite;
        }
        public string ReturnMaxHistGrade(int course)
        {
            string toWrite = "The maximum historical grade in the " + courses[course]
                + " is " + maximumHistoricalGrade[course] + ".";
            return toWrite;
        }
        public void PrintArrays()
        {
            Console.WriteLine("\nThe subjects are as follows:");
            for (int i = 0; i < courses.Length; i++)
            {
                Console.WriteLine(courses[i]);
            }

            Console.WriteLine("\nThe minimum admission grade to access the subjects " +
                "are as follows:");
            for (int i = 0; i < minimumAdmissionGrade.Length; i++)
            {
                Console.WriteLine(minimumAdmissionGrade[i]);
            }

            Console.WriteLine("\nThe maximum historical grades in subjects are as " +
                "follows:");
            for (int i = 0; i < maximumHistoricalGrade.Length; i++)
            {
                Console.WriteLine(maximumHistoricalGrade[i]);
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

            string classProperties = string.Format("\nThe teacher {0}, who is {1} years old," +
                " {2} and with an average historical grade of {3}, {4}.", name,
                age, stringSex, averageHistoricalGrade, isTernured);
            Console.WriteLine(classProperties);
        }
        public static void PrintFunctionallity()
        {
            Console.WriteLine("This method indicates that it's the end of profesors class.\n");
        }
    }
}
