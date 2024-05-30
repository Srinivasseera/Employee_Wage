
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Wage
{
    public class Using_Switch
    {

        public void Display()
        {
            const int part_time_wage = 1;
            const int is_present = 2;
            const int wage_per_hour = 20;
            Random random = new Random();
            int number = random.Next(0, 3);
            //int work_hour = 0;
            int emp_wage = 0;

            switch (number)
            {
                case part_time_wage:
                    emp_wage = 4 * wage_per_hour;
                    Console.WriteLine(emp_wage);
                    break;
                case is_present:
                    emp_wage = 8 * wage_per_hour;
                    Console.WriteLine(emp_wage);
                    break;
                default:
                    emp_wage = 0 * wage_per_hour;
                    Console.WriteLine(emp_wage);
                    break;

            }
        }
    }

    public class UsingSwitchCase
    {
        static void Main(string[] args)
        {
            Using_Switch using_Switch = new Using_Switch();
            using_Switch.Display();
           
        }
    }
}
