using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Wage
{
    public class Employee_Daily
    {
        public void Print_Daily_Wage()
        {
            int is_present = 1;
            int wage_per_hour = 20;
            Random random = new Random();
            int number = random.Next(0, 2);
            int work_hour = 0;
            int emp_wage = 0;
            if (number == is_present)
            {
                emp_wage = 8 * wage_per_hour;
                Console.Write("the total wage is :");
                Console.Write(emp_wage);
            }
            else
            {
                work_hour = 0;
                Console.WriteLine("the total wage is :");
                Console.Write(work_hour);
            }
        }
    }




    public class Employee_Daily_Wage
    {
        static void Main(string[] args)
        {


            Employee_Daily employee_daily_wage = new Employee_Daily();
            //Console.WriteLine(w1.Wage);
            employee_daily_wage.Print_Daily_Wage();
            Console.ReadLine();

        }
    }
}
