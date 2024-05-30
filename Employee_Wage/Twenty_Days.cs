using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Wage
{

    public class Wage_Month
    {
        public void Calculate_Wage_Month()
        {
            const int part_time_wage = 1;
            const int is_present = 2;
            const int wage_per_hour = 20;
            const int no_of_days = 20;
            int emp_wage = 0;
            int total_wage = 0;
            for (int i = 0; i < no_of_days; i++)
            {
                Random random = new Random();
                int number = random.Next(0, 3);
                switch (number)
                {

                    case part_time_wage:
                        emp_wage = 4 * wage_per_hour;
                        total_wage += emp_wage;
                        break;
                    case is_present:
                        emp_wage = 8 * wage_per_hour;
                        total_wage += emp_wage;
                        break;
                    default:
                        emp_wage = 0 * wage_per_hour;
                        total_wage += emp_wage;
                        break;


                }
            }
            Console.Write("the total wage for a month is :");
            Console.Write(total_wage);
        }

    }

    public class Twenty_Days
    {
        static void Main(string[] args)
        {
            Wage_Month t1 = new Wage_Month();
            t1.Calculate_Wage_Month();
            Console.ReadLine();

        }
    }
}
