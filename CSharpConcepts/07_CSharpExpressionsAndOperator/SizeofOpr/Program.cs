using System;

namespace SizeofOpr
{
    // NOTE: Used in buitin type more offen
    internal class Program
    {
        static void Main(string[] args)
        {
            unsafe
            {
               int x = sizeof(Student) ;
               Console.WriteLine(x);
            }
        }

    }
    struct Student{
        int ID;
        long Score;
    }
}
