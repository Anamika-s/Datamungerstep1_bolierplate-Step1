using System;

namespace ClassLibrary1
{
    public class Class1
    {
        public string[] Task1(string input)
        {
            
            string[] array = input.Split(" ");
            ////string stringBeforeChar = input.Substring(0, input.IndexOf("where"));

            return array;

        }

        public string Task2(string input)
        {
            string[] array = input.Split(" ");
            return array[3];
        }

        public string Task3(string input)
        {
            string array = input.Substring(0, input.IndexOf("where")).Trim();
            return array;
        }
    }
}
