using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeSchedulerSystem
{/// <summary>
/// 自定义异常
/// </summary>
    internal class ParameterException:Exception
    {
        string Msg;
        public ParameterException(string mes)
        {
            this.Msg = mes;
        }
        public override string Message => this.Msg;
    }
}
