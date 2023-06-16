using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWage
{
    public class PartTimeWage
    {
        public void PartTimeEmp()
        {
            int Wage_Per_Hour = 20;
            int Full_Day_Hours = 8;
            int Part_Time_Hours = 4;
            Random random = new Random();
            int attendent = random.Next(3);
            Console.WriteLine(attendent);
            if (attendent == 0)
            {
                Console.WriteLine("Employee Absent");
                int Absent = attendent * Full_Day_Hours * Wage_Per_Hour;
                Console.WriteLine("Employee wage per day is : " + Absent);
            }
            else if (attendent == 1) 
            {
                Console.WriteLine("Employee Present");
                int Present = attendent * Full_Day_Hours * Wage_Per_Hour;
                Console.WriteLine("Employee wage per day is : " + Present);

            }
            else
            {
                Console.WriteLine("Employee is a Part_Timer");
                int wage = attendent/2 *Wage_Per_Hour * Part_Time_Hours;
                Console.WriteLine("Employee wage per day is :" + wage);
            }
        }
    }
}
