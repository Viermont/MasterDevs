﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JavierMontero_M2_P1.Buildings
{
    internal class SportsBuildings
    {
        public string name;
        public char buildingType;
        public float area;
        public int constructionYear;
        public bool wasReformed;
        int[] spaceNumbers = new int[4] { 1, 2, 3, 4 };
        string[] nameSpaces = new string[4] { "Olimpic Swimming Pool", "Training Swimming Pool",
            "Locker room", "Toilets" };
        float[] areaSpaces = new float[4] { 2512.4f, 1425.6f, 142.5f, 26.5f };


        public void Welcome()
        {
            Console.WriteLine("Welcome to the " + name + ".");
        }
        public void Farewell()
        {
            Console.WriteLine("Thank you for visiting the " + name + ". Have a great day!");
        }
        public string ReturnNameSpace(int spaceNumber)
        {
            string toWrite = "In the sports building, space number "
                + spaceNumbers[spaceNumber] + " is the " + nameSpaces[spaceNumber] + ".";
            return toWrite;
        }
        public string ReturnAreaSpace(int spaceNumber)
        {
            string toWrite = "In the science building, " + nameSpaces[spaceNumber]
                + " has " + areaSpaces[spaceNumber] + " m2 of area.";
            return toWrite;
        }
        public void PrintArrays()
        {
            Console.WriteLine("\nThe numbers of the spaces are as follows:");
            for (int i = 0; i < spaceNumbers.Length; i++)
            {
                Console.WriteLine(spaceNumbers[i]);
            }

            Console.WriteLine("\nThe names of the spaces are as follows:");
            for (int i = 0; i < nameSpaces.Length; i++)
            {
                Console.WriteLine(nameSpaces[i]);
            }

            Console.WriteLine("\nThe areas of the spaces are as follows:");
            for (int i = 0; i < areaSpaces.Length; i++)
            {
                Console.WriteLine(areaSpaces[i] + " m2");
            }
        }
        public void PrintClassProperties()
        {
            string buildType;
            string reformed;

            if (buildingType == 'A') buildType = "study buidings";
            else if (buildingType == 'B') buildType = "sports buildings";
            else buildType = "other buildings";

            if (wasReformed == true) reformed = "was reformed";
            else reformed = "hasn't been reformed";

            string classProperties = string.Format("\nThe {0}, which belongs to the group of {1}, " +
                "has an area of {2} m2, was constructed in {3}, and {4}.", name, buildType, area, constructionYear, reformed);
            Console.WriteLine(classProperties);
        }
        public static void PrintFunctionallity()
        {
            Console.WriteLine("This method indicates that it's the end of studybuildings class.\n");
        }
    }
}