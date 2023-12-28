using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeSchedulerSystem
{
    internal class Data
    {

		//常量区
        public const int EMPLOYEE = 10;
        public const int PROGRAMER = 11;
        public const int DESIGNER = 12;
        public const int ARCHITECT = 13;

        public const int PC = 21;
        public const int NOTEBOOK = 22;
        public const int PRINTER = 23;

		//初始化数据库中的数据 该数组和EQUIPMENTS一一对应
		public static readonly  String[][] EMPLOYEES=new string[][] {
		        new string[] {"10","1","马云","22","3000"},
				new string[]  { "13","2","马化腾","32","18000","15000","2000"},
				new string[]  { "11","3","李彦宏","23","7000"},
				new string[]  { "11","4","刘强东","24","7300"},
				new string[]   { "12","5","雷军","28","10000","5000"},
				new string[]  { "11","6","任志强","22","6800"},
				new string[]  { "12","7","柳传志","729","10800","5200"},
				new string[]  { "13","8","杨元庆","30","19800","15000","2500"},
				new string[]  { "12","9","史玉柱","26","9800","5500"},
				new string[]  { "11","10","丁磊","21","6600"},
				new string[]  { "11","11","张朝阳","25","7100"},
				new string[] { "12","12","杨致远","27","9600","4800"}
		
};
		//初始化数据库中的数据 该数组和EMPLOYEES一一对应
		public static readonly String[][] EQUIPMENTS=new string[][]{
new String[]{},
new String[]{"22","联想T4","6000"},
new String[]{"21","戴尔","NEC 17寸",},
new String[]{"21","戴尔","三星17寸"},
new String[]{"23","佳能2900","激光"},
new String[]{"21","华硕","三星17寸"},
new String[]{"21","华硕","三星17寸"},
new String[]{"23","爱普生20k","针式"},
new String[]{"22","惠普m6","5800"},
new String[]{"21","戴尔","NEC 17寸"},
new String[]{"21","华硕","三星17寸"},
new String[]{"22","惠普m6","5000"}
};


    }
}
