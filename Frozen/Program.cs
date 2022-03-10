using System;
using System.Collections.Generic;
using System.IO;

namespace Frozen
{
    class Program
    {
        class SecretSanta
        {
            string name;
            string gift;

            public SecretSanta(string _name, string _gift)
            {
                name = _name;
                gift = _gift;
            }

            //getters for SecretSanta
            public string Name
            {
                get { return name; }
            }

            public string Gift
            {
                get { return gift; }
            }

        }
        static void Main(string[] args)
        {
            List<SecretSanta> myFrozen = new List<SecretSanta>();
            string[] frozenFromFile = GetDataFromFile();

            foreach (string line in frozenFromFile)
            {
                string[] frozenArray = line.Split(new char[] { '/' }, StringSplitOptions.RemoveEmptyEntries);
                Console.WriteLine($"{frozenArray[0]} wants {frozenArray[1]}");
                Console.WriteLine();
            }

            foreach (SecretSanta frozenFromList in myFrozen)
            {
                Console.WriteLine($"Name --> {frozenFromList.Name}. Gift --> {frozenFromList.Gift}.");
            }
        }

        public static void DisplayElementsFromArray(string[] someArray)
        {
            foreach (string element in someArray)
            {
                Console.WriteLine($"String from array: {element}");
            }
        }

        public static string[] GetDataFromFile()
        {
            string filePath = @"C:\Users\...\samples\frozen.txt";
            string[] dataFromFile = File.ReadAllLines(filePath);

            return dataFromFile;
        }
    }
    
}
