namespace PropertyExample_readonly_property_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.Age = 20;
            Console.WriteLine(student.CanWork);
        }
    }


    //note(guoliang): If use set not often
    class Student
    {
        private int age;
        private bool canWork;

        public bool CanWork {
            get { return canWork; }
        }


        public int Age {
            get { return age; }
            set { 
                age = value; 
                this.CalculateCanWork();
            }
        }

        private void CalculateCanWork()
        {
            if(this.age >= 16)
            {
                canWork = true;
            }
            else
            {
                canWork = false;
            }
        }



    }
}