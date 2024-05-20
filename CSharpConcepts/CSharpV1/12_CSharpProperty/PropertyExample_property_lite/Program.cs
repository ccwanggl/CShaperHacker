using System;

namespace PropertyExample_property_lite
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Student student = new Student();
                student.Age = 100;
                Console.WriteLine(student.Age);
            }
            catch (Exception ex)
            {
                throw new OverflowException("Age overflow");
            }
        }
    }

    class Student
    {
        private int age;		// NOTE: Camel   eg: firstField 
        public int Age         // NOTE: Pascal  eg: FirstField
		{ 
			get => age;
			set
			{
				if(value >0 && value <= 100) 
					age = value;
			} 
		}
    }
}
