using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TypeSample
{
    internal class Program
    {
        //NOTE: 反射时应用
        static void Main(string[] args)
        {
            Type myType = typeof(Form);

            PropertyInfo[] pInfo = myType.GetProperties();
            MethodInfo[] mInfo = myType.GetMethods();

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
