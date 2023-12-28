using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeSchedulerSystem
{
    public class NameListService
    {

        //员工列表
       public List<Employee> EmployeesList { get; }
        int index;
        public NameListService()
        {
            //初始化员工列表
            EmployeesList = new();


            foreach (string[] employ in Data.EMPLOYEES)
            {
                int equid = 0;
                Equipment equ = new();
                if (Data.EQUIPMENTS[index].Length != 0)
                    equid = int.Parse(Data.EQUIPMENTS[index][0]);
                switch (equid)
                {

                    case Data.PC: equ = new PC { Name = Data.EQUIPMENTS[index][1], Display = Data.EQUIPMENTS[index][2] }; break;
                    case Data.NOTEBOOK: equ = new NoteBook { Name = Data.EQUIPMENTS[index][1], Price = double.Parse(Data.EQUIPMENTS[index][2]) }; break;
                    case Data.PRINTER: equ = new Printer { Name = Data.EQUIPMENTS[index][1], Model = Data.EQUIPMENTS[index][2] }; break;
                    default: break;
                }


                /*D 姓名,年龄,工资,职位,状态,奖金,股票 领用设备*/

                switch (int.Parse(employ[0]))
                {
                    case Data.EMPLOYEE:

                        EmployeesList.Add(new Employee
                        {
                            ID = int.Parse(employ[1]),
                            Name = employ[2],
                            Age = int.Parse(employ[3]),
                            Salary = double.Parse(employ[4]),
                            Job=Job.None
                        });
                    
                        break;
                    case Data.PROGRAMER:

                        EmployeesList.Add(new Programer()
                        {
                            ID = int.Parse(employ[1]),
                            Name = employ[2],
                            Age = int.Parse(employ[3]),
                            Salary = double.Parse(employ[4]),
                            Equipments = equ,
                            Job=Job.程序员,
                       
                            


                        });
                        break;
                    case Data.DESIGNER:

                        EmployeesList.Add(new Designer()
                        {
                            ID = int.Parse(employ[1]),
                            Name = employ[2],
                            Age = int.Parse(employ[3]),
                            Salary = double.Parse(employ[4]),
                            Equipments = equ,
                            Bonus = int.Parse(employ[5]),
                            Job=Job.设计师,
                            

                        });
                        break;
                    case Data.ARCHITECT:

                        EmployeesList.Add(new Architect()
                        {
                            ID = int.Parse(employ[1]),
                            Name = employ[2],
                            Age = int.Parse(employ[3]),
                            Salary = double.Parse(employ[4]),
                            Equipments = equ,
                            Bonus = int.Parse(employ[5]),
                            Stocks = int.Parse(employ[6]),
                            Job=Job.框架师,
                           
                        });

                        break;

                }


                index++;




            };



        }


        /// <summary>
        /// 获取所有员工
        /// </summary>
        /// <returns></returns>
        public  List<Employee> GetAlLEmplioyees()
        {

            return EmployeesList;

        }

        /// <summary>
        /// 获取单个员工 
        /// </summary>
        /// <param name="EmplioyeID">员工ID</param>
        /// <returns></returns>
        /// <exception cref="ParameterException"></exception>
        public  Employee GetEmplioyees(int EmplioyeID)
        {
            Employee? employee = EmployeesList.Find(item => item.ID == EmplioyeID);
            if (employee == null) throw new ParameterException("找不到指定的员工");
            return employee;

        }


    }


    public enum Status
    {
        VOCATION,
        FREE  ,
        BUSY  ,
        
    }
    public enum Job
    {
        None,
        程序员,
        框架师,
        设计师

    }

}
