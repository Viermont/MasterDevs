using JavierMontero_M2_P1.Buildings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JavierMontero_M2_P1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Class Students
            Console.WriteLine("Students class:\n");
            Students student01 = new Students();
            student01.name = "Mike Ramos";
            student01.age = 15;
            student01.gradePointAverage = 7.4f;
            student01.sex = 'm';
            student01.graded = true;
            student01.Passed();
            student01.Failed();
            Console.WriteLine(student01.ReturnMinPassGrade(5));
            Console.WriteLine(student01.ReturnMaxHistGrade(2));
            student01.PrintArrays();
            student01.PrintClassProperties();
            Students.PrintFunctionallity();

            //Class Teachers
            Console.WriteLine("Teachers class:\n");
            Teachers teacher01 = new Teachers();
            teacher01.name = "Rigoberta Paniagua";
            teacher01.age = 55;
            teacher01.averageHistoricalGrade = 6.9f;
            teacher01.sex = 'f';
            teacher01.tenured = false;
            teacher01.Passed();
            teacher01.Failed();
            Console.WriteLine(teacher01.ReturnMinPassGrade(3));
            Console.WriteLine(teacher01.ReturnMaxHistGrade(7));
            teacher01.PrintArrays();
            teacher01.PrintClassProperties();
            Teachers.PrintFunctionallity();

            //Class UniversityStaff
            Console.WriteLine("UniversityStaff class:\n");
            UniversityStaff staff01 = new UniversityStaff();
            staff01.name = "Victoria Summer";
            staff01.age = 62;
            staff01.sex = 'f';
            staff01.workExperience = 15.5f;
            staff01.tenured = true;
            Console.WriteLine(staff01.ReturnPosition(1));
            Console.WriteLine(staff01.ReturnNumberWorkers(4));
            staff01.PrintArrays();
            staff01.PrintClassProperties();
            UniversityStaff.PrintFunctionallity();

            //Class StudyBuildings
            Console.WriteLine("StudyBuildings class:\n");
            Buildings.StudyBuildings Building01 = new Buildings.StudyBuildings();
            Building01.name = "Science building";
            Building01.buildingType = 'A';
            Building01.area = 297.3f;
            Building01.constructionYear = 1967;
            Building01.wasReformed = true;
            Building01.Welcome();
            Building01.Farewell();
            Console.WriteLine(Building01.ReturnNameSpace(5));
            Console.WriteLine(Building01.ReturnAreaSpace(2));
            Building01.PrintArrays();
            Building01.PrintClassProperties();
            Buildings.StudyBuildings.PrintFunctionallity();

            //Class SportsBuildings
            Console.WriteLine("SportsBuildings class:\n");
            Buildings.SportsBuildings Building02 = new Buildings.SportsBuildings();
            Building02.name = "Swimming complex";
            Building02.buildingType = 'B';
            Building02.area = 2785.6f;
            Building02.constructionYear = 2002;
            Building02.wasReformed = false;
            Building02.Welcome();
            Building02.Farewell();
            Console.WriteLine(Building02.ReturnNameSpace(2));
            Console.WriteLine(Building02.ReturnAreaSpace(2));
            Building02.PrintArrays();
            Building02.PrintClassProperties();
            Buildings.SportsBuildings.PrintFunctionallity();

            //Enum Scholarships
            Program.PrintScholarships();

            //Enum ExtracurricularActivities
            Program.PrintExtraActivities();

            //Struct Exams
            Program.PrintExams();

            //Struct Events
            Program.PrintEvents();
        }
        static void PrintScholarships()
        {
            Console.WriteLine("Scholarships enum:");
            Console.WriteLine((int)Scholarships.Academic + " = " + Scholarships.Academic);
            Console.WriteLine((int)Scholarships.Athletic + " = " + Scholarships.Athletic);
            Console.WriteLine((int)Scholarships.NeedBased + " = " + Scholarships.NeedBased);
            Console.WriteLine((int)Scholarships.Minority + " = " + Scholarships.Minority);
        }
        static void PrintExtraActivities()
        {
            Console.WriteLine("\nExtraActivities enum:");
            Console.WriteLine((int)ExtraActivities.StudyClubs + " = " + ExtraActivities.StudyClubs);
            Console.WriteLine((int)ExtraActivities.Sports + " = " + ExtraActivities.Sports);
            Console.WriteLine((int)ExtraActivities.CulturalEvents + " = " + ExtraActivities.CulturalEvents);
            Console.WriteLine((int)ExtraActivities.RoboticsClub + " = " + ExtraActivities.RoboticsClub);
        }
        static void PrintExams()
        {
            Exams exam01 = new Exams();
            exam01.id = 001;
            exam01.course = "Mathematics";
            exam01.date = "05/06/2024";
            Console.WriteLine("\nExams struct:");
            Console.WriteLine(exam01.id + " " + exam01.course + " " + exam01.date);
        }
        static void PrintEvents()
        {
            Events event01 = new Events();
            event01.id = 001;
            event01.name = "Presentation on Bridge Engineering by Susan McPollo";
            event01.description = "Discover the fascinating world of bridge engineering " +
                "as we explore the design and construction of iconic bridges. Join us to " +
                "learn about the innovative solutions and challenges behind these " +
                "architectural wonders.";
            Console.WriteLine("\nEvents struct:");
            Console.WriteLine(event01.id + " " + event01.name + "\n" + event01.description);
        }
    }
}