using EmployeeSchedulerSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployedSchedulerSystem
{
    public class Team
    {
      private  string Name;
        public Team(string name)
        {
            this.Name = name;
        }


        //KeyValuePair<int, Employee> 包括 成员id 和员工.主要为了用list的find功能检索数据.
        List<KeyValuePair<int, Employee>> menberList=  new ();
        NameListService nameListService = new ();
        int maxteamMenberID = 0;
        //框架师最多1名

       
        public string AddTeamMembers(int id)
        {
            Employee? employee = nameListService.EmployeesList.Find(item => item.ID == id);
            Employee? teammeber = menberList.Find(itme => itme.Value.ID == id).Value ;
            if (id < 1 || employee == null)
            {
             
                throw new ParameterException("输入的ID不存在");
            }
            else if (teammeber != null)
            {
             
             throw new ParameterException("该成员已经在本开发团队中");
            }
            else if (menberList.Count >=6)
            {

                throw new ParameterException("团队成员已满！");
            }
            else
            {

                switch (employee.Job)
                {
                    
                    case Job.程序员:
                        Programer programer = (Programer)employee;
                        if(programer.StatusT==Status.VOCATION) throw new ParameterException("该员正在休假，无法添加！");
                        if (programer.MenberID != 0) throw new   ParameterException("该员工已是某个开发团队的成员") ;

                        if (menberList.FindAll(itme => itme.Value.Job == Job.程序员).Count >= 3) throw new ParameterException("团队中至多只能有三名程序员!");
                  
                        programer.MenberID = ++maxteamMenberID;
                        menberList.Add(new(maxteamMenberID, programer));
                        
                        break;
                case Job.框架师:

                        Architect  architect = (Architect)employee;

                        if (architect.MenberID != 0) throw new ParameterException("该员工已是某个开发团队的成员");
                        if (architect.StatusT == Status.VOCATION) throw new ParameterException("该员正在休假，无法添加！");
                        if (menberList.FindAll(itme => itme.Value.Job == Job.框架师).Count >= 1) throw new ParameterException("团队中至多只能有一名架构师!");
                        
                            architect.MenberID = ++maxteamMenberID;
                        
                        menberList.Add(new(maxteamMenberID, architect));
                        break;
                    case Job.设计师:
                        Designer designer = (Designer)employee;
                        if (designer.MenberID != 0) throw new ParameterException("该员工已是某个开发团队的成员");
                        if (designer.StatusT == Status.VOCATION) throw new ParameterException("该员正在休假，无法添加！");
                        if (menberList.FindAll(itme => itme.Value.Job == Job.设计师).Count >= 2) throw new ParameterException("团队中至多只能有两名设计师!");
              
                            designer.MenberID = ++maxteamMenberID;
                       
                        menberList.Add(new(maxteamMenberID, designer));


                        break;
                    default: throw new ParameterException("该成员不是开发人员，无法添加！");


                }



              

                return "添加成功";
            }


         
           
          


        }
        /// <summary>
        /// 根据团队成员id删除
        /// </summary>
        /// <param name="Menberid">团队成员id</param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public string RemoveTeamMember(int MemberId)
        {
           
            Employee? teammeber = menberList.Find(item => item.Key == MemberId).Value;
            if (MemberId < 1  )
            {

                throw new Exception("输入的ID不存在");
            }
            if(teammeber == null)
            {
                throw new Exception("本团队中没有该成员");
            }
            switch (teammeber.Job)
            {
                case Job.框架师:
                   ( (Architect)teammeber).MenberID=0;
                    break;
                case Job.设计师:
                    ((Designer)teammeber).MenberID = 0;
                    break;
                case Job.程序员:
                    ((Programer)teammeber).MenberID = 0;
                    break;
                default:break;
            }
            return menberList.Remove(menberList.Find(item => item.Key == MemberId)) ? "已将该成员移除本团队": "删除失败";
            
        }
        public List<KeyValuePair<int, Employee>> GetTeamMenbers()
        {
            return menberList;
        }


    }
}
