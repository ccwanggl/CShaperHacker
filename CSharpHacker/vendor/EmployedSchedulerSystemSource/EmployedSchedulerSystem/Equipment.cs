using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeSchedulerSystem
{

   interface IEquipmentScheduler
    {
      string GetDisplay();
    }
    /// <summary>
    /// 设备的基类
    /// </summary>
    public class Equipment: IEquipmentScheduler
    {
 
        public string Name { get; set; }
        public double Price { get; set; }
        public string Model { get; set; }

        public virtual string GetDisplay()
        {
          return this.ToString();
        }
    }

    public class PC:Equipment
    {
        public string Display { get; set; }
        public override string GetDisplay() => $"{Name}({Display})";
      
    }
    public class Printer : Equipment
    {
        public override string GetDisplay() => $"{Name}({Model})";
    }
    public class NoteBook : Equipment
    {
        public override string GetDisplay() => $"{Name}({Price})";
    }
}
