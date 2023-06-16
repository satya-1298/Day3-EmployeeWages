using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWage
{
    public class DailyEmpWage
    {
        public void Display()
        {
            int Wage_Per_Hour = 20;
            int Full_Day_Hours = 8;
            Random random = new Random();
            int attendent = random.Next(2);
            Console.WriteLine(attendent);
            if (attendent == 0)
            {
                Console.WriteLine("Employee Absent");
                int Absent = attendent * Full_Day_Hours * Wage_Per_Hour;
                Console.WriteLine("Employee wage per day is : " + Absent);
            }
            else
            {
                Console.WriteLine("Employee Present");
                int Present = attendent * Full_Day_Hours * Wage_Per_Hour;
                Console.WriteLine("Employee wage per day is : " + Present);

            }
        }
    }
}
