using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CtorExec
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass myc = new MyClass(10);
        }
    }

    class MyClass
    {
        private readonly int firstVar;
        private readonly double secondVar;

        public string UserName;
        public int UserIdNumber;

        private MyClass()
        {
            firstVar = 20;
            secondVar = 30.5;
        }

        //! Use this keyword specify the construct function
        public MyClass(string firstName) : this()
        {
            UserName = firstName;
            UserIdNumber = -1;
        }

        public MyClass(int idNumber) : this()
        {
            UserName = "Anonymous";
            UserIdNumber = idNumber;
        }
    }

    class MyDerivedClass : MyClass
    {
        public int test;
        //! use base keyword to specify the base construct function
        MyDerivedClass() : base(12)
        {
        }
    }
}
