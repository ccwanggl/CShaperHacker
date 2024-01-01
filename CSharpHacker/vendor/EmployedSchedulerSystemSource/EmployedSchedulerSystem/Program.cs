
using EmployedSchedulerSystem;
using EmployeeSchedulerSystem;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;
using System;
/* 全局变量 */

Team team = new("fightingTeam");

/* 界面初始化区 */

consoleSet();//console设置

displayMeau();//显示菜单




#region 函数定义

/// <summary>
///  console设置
/// </summary>
void consoleSet()
{

   
    Console.BackgroundColor = ConsoleColor.White;
    Console.Title = "人员调度系统";//设置窗口标题
    Console.ForegroundColor = ConsoleColor.Black; //设置前景色，即字体颜色
    Console.BufferHeight = 600;
    Console.BufferWidth = 800;
}

///显示菜单
void displayMeau()
{
    Console.Clear();
    Console.WriteLine("-----------------------------员工调度系统----------------------------------------");


  
    //表态 头
    Console.WriteLine(
                "ID".PadLeft(1, ' ') +
                "姓名".PadLeft(5, ' ') +
                "年龄".PadLeft(5, ' ') +
                "工资".PadLeft(11, ' ') +
                 "职位".PadLeft(11, ' ') +
                "状态".PadLeft(11, ' ') +
                 "奖金".PadLeft(11, ' ') +
                "股票".PadLeft(11, ' ') +
                 "领用设备".PadLeft(11, ' ')
                );

    
    foreach (var employee in Employee.GetAlLEmplioyees())
    {

        /*ID 姓名,年龄,工资,职位,状态,奖金,股票 领用设备*/


        switch (employee.Job)
        {
            case Job.None:
                Console.WriteLine($"{employee.ID}".PadLeft(1, ' ') +
                    $"{employee.Name}".PadLeft(5, ' ') +
                    $"{employee.Age}".PadLeft(5, ' ') +
                    $"{employee.Salary:c}".PadLeft(11, ' '));

                break;
            case Job.程序员:
                Programer programer = (Programer)employee;
                Console.WriteLine(
                    $"{programer.ID}".PadLeft(1, ' ') +
                    $"{programer.Name}".PadLeft(5, ' ') +
                    $"{programer.Age,5}" +
                     $"{programer.Salary,11:c}" +
                    $"{programer.Job,11}" +
                    $"{Enum.GetName(programer.StatusT),11}" +
                     " ".PadLeft(11, ' ') +
                    " ".PadLeft(11, ' ') +
                     $"{programer.Equipments.GetDisplay(),21}"
                   );

                break;
            case Job.设计师:
                Designer designer = (Designer)employee;
                Console.WriteLine(
                    $"{designer.ID}".PadLeft(1, ' ') +
                    $"{designer.Name}".PadLeft(5, ' ') +
                    $"{designer.Age,5}" +
                     $"{designer.Salary,11:c}" +
                    $"{designer.Job,11}" +
                    $"{Enum.GetName(designer.StatusT),11}" +
                     $"{designer.Bonus,16:C}" +
                       " ".PadLeft(11, ' ') +
                     $"{designer.Equipments.GetDisplay(),21}"
                   );

                break;
            case Job.框架师:
                Architect architect = (Architect)employee;
                Console.WriteLine(
                    $"{architect.ID}".PadLeft(1, ' ') +
                    $"{architect.Name}".PadLeft(5, ' ') +
                    $"{architect.Age,5}" +
                     $"{architect.Salary,11:c}" +
                    $"{architect.Job,11}" +
                    $"{Enum.GetName(architect.StatusT),11}" +
                       $"{architect.Bonus,16:C}" +
                         $"{architect.Stocks,12 }" +
                     $"{architect.Equipments.GetDisplay(),21}"
                   );

                break;


        }
    }
    
    ChoiceAction();// 选择操作
}

/// <summary>
/// 选择操作
/// </summary>
void ChoiceAction()
{
    Console.WriteLine("--------------------------------------------------------------------------------");
    Console.WriteLine("1-团队列表  2-添加团队成员 3-删除团队成员 4-退出  请选择（1-4）：");
again:
    char kyechar = Console.ReadKey(true).KeyChar;
    switch (kyechar)
    {
        case '1':
            displaTeamMenbers(); displayMeau(); break;
        case '2':
            addTeamMembers(); displayMeau(); break;
        case '3':
            delTeamMembers(); displayMeau(); break;
        case '4':
            Exit(); break;

        default: Console.WriteLine("输入错误重新输入:"); goto again;
    }
}

/// <summary>
/// 显示团队成员
/// </summary>
void displaTeamMenbers()
{
   
    Console.WriteLine("-----------------------------团队成员----------------------------------------");



    //表态 头
    Console.WriteLine(
                "ID/Mid".PadLeft(1, ' ') +
                "姓名".PadLeft(5, ' ') +
                "年龄".PadLeft(5, ' ') +
                "工资".PadLeft(11, ' ') +
                "职位".PadLeft(11, ' ') +
                "状态".PadLeft(11, ' ') +
                "奖金".PadLeft(11, ' ') +
                "股票".PadLeft(11, ' ') +
                "领用设备".PadLeft(11, ' ')
                );


    foreach (var keyvalue in team.GetTeamMenbers())
    {
        Employee employee = keyvalue.Value;
        /*ID 姓名,年龄,工资,职位,状态,奖金,股票 领用设备*/


        switch (employee.Job)
        {
            case Job.None:
                Console.WriteLine($"{employee.ID}".PadLeft(1, ' ') +
                    $"{employee.Name}".PadLeft(5, ' ') +
                    $"{employee.Age}".PadLeft(5, ' ') +
                    $"{employee.Salary:c}".PadLeft(11, ' '));

                break;
            case Job.程序员:
                Programer programer = (Programer)employee;
                Console.WriteLine(
                    $"{programer.ID}/{programer.MenberID}".PadLeft(1, ' ') +
                    $"{programer.Name}".PadLeft(5, ' ') +
                    $"{programer.Age,5}" +
                     $"{programer.Salary,11:c}" +
                    $"{programer.Job,11}" +
                    $"{Enum.GetName(programer.StatusT),11}" +
                     " ".PadLeft(11, ' ') +
                    " ".PadLeft(11, ' ') +
                     $"{programer.Equipments.GetDisplay(),21}"
                   );

                break;
            case Job.设计师:
                Designer designer = (Designer)employee;
                Console.WriteLine(
                    $"{designer.ID}/{designer.MenberID}".PadLeft(1, ' ') +
                    $"{designer.Name}".PadLeft(5, ' ') +
                    $"{designer.Age,5}" +
                     $"{designer.Salary,11:c}" +
					$"{designer.Job,11}" +
					$"{Enum.GetName(designer.StatusT),11}" +
                     $"{designer.Bonus,16:C}" +
                       " ".PadLeft(11, ' ') +
                     $"{designer.Equipments.GetDisplay(),21}"
                   );

                break;
            case Job.框架师:
                Architect architect = (Architect)employee;
                Console.WriteLine(
                    $"{architect.ID}/{architect.MenberID}".PadLeft(1, ' ') +
                    $"{architect.Name}".PadLeft(5, ' ') +
                    $"{architect.Age,5}" +
                     $"{architect.Salary,11:c}" +
                    $"{architect.Job,11}" +
                    $"{Enum.GetName(architect.StatusT),11}" +
                       $"{architect.Bonus,16:C}" +
                         $"{architect.Stocks,12 }" +
                     $"{architect.Equipments.GetDisplay(),21}"
                   );

                break;


        }
    }
    Console.WriteLine("按回车继续。。。");
    while (Console.ReadKey(true).Key != ConsoleKey.Enter) ;
}





/// <summary>
/// 添加团队成员
/// </summary>
void addTeamMembers()
{
    Console.WriteLine("");
    Console.WriteLine("");
    Console.WriteLine("----------------------添加成员----------------------");
importagain:
    Console.Write("请输入要添加的员工ID:");
    int id;
    try
    {
          id = int.Parse(Console.ReadLine());
    }
    catch (Exception)
    {
        id = -1;
    }
    finally
    {
    
    }

    string mes;
    try
    {

       mes = team.AddTeamMembers(id);
    }catch(Exception e)
    {
     Console.WriteLine("添加失败，原因"+e.Message.ToString());
        Console.WriteLine("按回车继续。。。");
        while (Console.ReadKey(true).Key != ConsoleKey.Enter) ;
        goto importagain;
    }
   
    Console.WriteLine(mes);
    Console.WriteLine("按回车继续。。。");
    while (Console.ReadKey(true).Key != ConsoleKey.Enter) ;


}

/// <summary>
/// 删除团队成员
/// </summary>
void delTeamMembers()
{
    delagain:
    Console.Write("请输入要移除的团队成员MID:");
    int id;
    string Mid ;
    do
    
   
    {
        Mid = Console.ReadLine();
    } while (Mid == null|| Mid =="");
    try
    {
       
        id = int.Parse(Mid);

    }catch (Exception )
    {
        id = -1;
    }
  
    Console.Write("你确定要删除吗？（Y/N）:");
    ConsoleKey consoleKey;


    do { consoleKey = Console.ReadKey(true).Key; }
    while (!(consoleKey == ConsoleKey.Y) &&!(consoleKey == ConsoleKey.N));
    if(consoleKey == ConsoleKey.N) goto delagain; 
    try
    {

      Console.WriteLine( team.RemoveTeamMember(id));
  
    }catch (Exception e)
    {
      Console.WriteLine("删除失败，原因是"+e.Message.ToString());
        goto delagain;
    }

    Console.WriteLine("按回车继续。。。");
    while (Console.ReadKey(true).Key != ConsoleKey.Enter) ;


}

/// <summary>
/// 退出调度系统
/// </summary>
void Exit()
{
    Console.Clear();
    Console.WriteLine("退出了 调度系统");

}


#endregion
Console.ReadLine();
