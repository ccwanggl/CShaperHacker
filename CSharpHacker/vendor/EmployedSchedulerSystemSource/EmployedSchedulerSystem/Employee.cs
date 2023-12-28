using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeSchedulerSystem
{
    /// <summary>
    /// 员工的基类
    /// </summary>
    public class Employee
    {

        public static List<Employee> GetAlLEmplioyees()
        {
            NameListService nameListService = new ();
            return nameListService.GetAlLEmplioyees();

        }
        public int ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public double Salary { get; set; }
        public Job Job { get; set; }
        public Employee(int id, string name, int age, double salary)
        {
            this.ID = id;
            this.Name = name;
            this.Age = age;
            this.Salary = salary;

        }

        public Employee()
        {

        }
    }
    public class Designer : Employee
    {

    
        public int MenberID { get; set; }
        public int Bonus { get; set; }//奖金
       public  Equipment  Equipments;

        public Status StatusT { get; set; } = Status.FREE;


        public Designer(int id, string name, int age, double salary) : base(id, name, age, salary)
        {
        }

        public Designer()
        {
        }
    }

    public class Architect : Employee
    {
      
        public int MenberID { get; set; }
        public int Bonus { get; set; }				//奖金
        public int Stocks { get; set; }			//股票

        public Equipment Equipments;                //设备
        public Status StatusT { get; set; } = Status.FREE;


       
        public Architect()
        {
        }
    }

    public class Programer : Employee
    {

        public Status StatusT { get; set; } = Status.FREE; 
        public int MenberID { get; set; }
        public Equipment Equipments { get; set; }




		public Programer() {

        }
        
        /*D 姓名,年龄,工资,职位,状态,奖金,股票 领用设备*/

    }
}
