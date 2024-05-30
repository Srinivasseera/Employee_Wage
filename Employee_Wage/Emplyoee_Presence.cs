using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Wage
{
    public class Employee
    {
        public void Print_Presence()
        {
            int Is_Present = 1;
            Random random = new Random();
            int number = random.Next(0, 2);

            if (number == Is_Present)
            {
                Console.WriteLine("employee is present");


            }
            else
            {
                Console.WriteLine("employee is absent");
            }
        }
    }


    public class Employee_Presence
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.Print_Presence();
       
        }
    }
}
