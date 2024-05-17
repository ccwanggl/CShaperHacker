using System;
namespace UserDefinedTypeClass
{
    internal class Student
    {

		// NOTE: 字段
		private string name;
		private uint age;
		
		// NOTE: 属性
        public string Name 
		{ 
			get 
			{
				return name;
			}
			set
			{
				name = value;
			}
			
		}
        public uint Age 
		{ 
			get{
				return age;
			}
			set
			{
				age = value;
			}
		}

        public Student(string name, uint age)
       {
           Name = name;
           Age = age;
       }
    }

    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        public static void Main()
        {
            Student stu = new Student("Guoliang", 10);
            Console.WriteLine("Name:{0}", stu.Name);
            Console.WriteLine("Age:{0}", stu.Age);

        }

    }
}
