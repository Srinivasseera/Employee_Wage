using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Wage
{

    public class Cal_Hundred
    {
        const int part_time = 1;
        const int full_time = 2;
        int wage_per_hour = 20;
        int working_days = 40;
        int total_hours = 100;
        public void Cal_Wage()
        {
            int total_hours_day = 0;
            int tot_wage = 0;
            int total_days = 0;
            while (total_days <= working_days - 1)
            {
                total_days++;
                Random random = new Random();
                int number = random.Next(0, 3);
                switch (number)
                {
                    case part_time:
                        total_hours_day = 4 * wage_per_hour;
                        tot_wage += total_hours_day;
                        break;
                    case full_time:
                        total_hours_day = 8 * wage_per_hour;
                        tot_wage += total_hours_day;
                        break;
                    default:
                        total_hours_day = 0 * wage_per_hour;
                        tot_wage += total_hours_day;
                        break;

                }
            }
            Console.WriteLine(tot_wage);
        }
    }

    public class Hundered_Hours
    {
        static void Main(string[] args)
        {
            Cal_Hundred cal_Hundred = new Cal_Hundred();
            cal_Hundred.Cal_Wage();

        }
    }
}

