using System;
using System.Collections.Generic;

namespace Indexer
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Student student = new Student();

            student["Math"] = 100;
            var mathScore = student["Math"];
            Console.WriteLine(mathScore);
        }
    }

    internal class Student
    {
        private Dictionary<string, int> _scoreDictionary = new Dictionary<string, int>();

        public int? this[string subject] {
            get 
            { 
                /* return the specified index here */ 
                if(_scoreDictionary.TryGetValue(subject, out var item))
                {
                    return item;
                }
                else
                {
                    return null;
                }
            }

            set 
            {
                if(value.HasValue == false )
                {
                    throw new Exception("null value");
                }
                /* set the specified index to value here */
                if (_scoreDictionary.ContainsKey(subject))
                {
                    _scoreDictionary[subject] = value.Value;
                }
                else
                {
                    _scoreDictionary.Add(subject, value.Value);
                }
            }
        }
    }
}
