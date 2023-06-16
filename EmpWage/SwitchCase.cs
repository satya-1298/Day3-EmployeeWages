using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWage
{
    public class SwitchCase
    {
        public void EmpWages()
        {
            int wage = 0;
            int Wage_Per_Hour = 20;
            int Full_Day_Hours = 8;
            int Part_Time_Hours = 4;
            Random random = new Random();
            int attendent = random.Next(1,3);
            Console.WriteLine(attendent);
            switch(attendent) 
            {
                case 1:
                    Console.WriteLine("Full_Timer");
                    wage = Full_Day_Hours * Wage_Per_Hour;
                    break;
                case 2:
                    Console.WriteLine("Part_Timer");
                    wage = Part_Time_Hours * Wage_Per_Hour;
                    break;

            }
            Console.WriteLine("Daily Wages of Employee : "+wage);
        }
    }
}
