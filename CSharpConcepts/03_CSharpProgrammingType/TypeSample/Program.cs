using System;
using System.Reflection;
using System.Windows.Forms;

namespace TypeSample
{
    internal class Program
    {
        // NOTE: 反射时应用
        private static void Main()
        {
            Type myType = typeof(Form);

            PropertyInfo[] pInfo = myType.GetProperties();
            MethodInfo[] mInfo = myType.GetMethods();

            //var pInfo = myType.GetProperties();
            //var mInfo = myType.GetMethods();

            Console.WriteLine(pInfo.GetType().Name);
            Console.WriteLine(mInfo.GetType().Name);

            Console.WriteLine("===============================");

            foreach(var m in pInfo)
            {
                Console.WriteLine(m.Name);
            }
            
            Console.WriteLine();

            foreach(var m in mInfo)
            {
                Console.WriteLine(m.Name);
            }
        }
    }
}
