using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWage
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Program");
            
            EmpAttendance empAttendance = new EmpAttendance();
            empAttendance.Check();
            Console.WriteLine("\n");
            DailyEmpWage dailyEmpWage = new DailyEmpWage();
            dailyEmpWage.Display();

            Console.ReadLine();
        }
    }
}
