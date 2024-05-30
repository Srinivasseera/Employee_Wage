using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Wage
{
    public class Part_Time
    {
        public void Display_Parttime()
        {
            int part_time_wage = 1;
            int is_present = 2;
            Random random = new Random();
            int number = random.Next(0, 3);
            int work_hour = 0;
            int emp_wage = 0;
            int wage_per_hour = 20;
            if (number == part_time_wage)
            {
                emp_wage = 4 * wage_per_hour;
                Console.WriteLine(emp_wage);
            }
            else if (number == is_present)
            {
                emp_wage = 8 * wage_per_hour;
                Console.WriteLine(emp_wage);
            }
            else
            {
                emp_wage = 0 * wage_per_hour;
                Console.WriteLine(emp_wage);
            }

        }
    }

    public class PartTime
    {
        static void Main(string[] args)
        {
            Part_Time part_time = new Part_Time();
            part_time.Display_Parttime();
            Console.ReadLine();

        }

    }
}
