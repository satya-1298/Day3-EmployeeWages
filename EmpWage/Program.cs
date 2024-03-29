﻿using System;
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
            //UC1
            EmpAttendance empAttendance = new EmpAttendance();
            empAttendance.Check();
            Console.WriteLine("\n");
            //UC2
            DailyEmpWage dailyEmpWage = new DailyEmpWage();
            dailyEmpWage.Display();
            Console.WriteLine("\n");

            //UC3
            PartTimeWage partTimeWage = new PartTimeWage();
            partTimeWage.PartTimeEmp();
            Console.WriteLine("\n");
            //UC4
            SwitchCase switchCase = new SwitchCase();
            switchCase.EmpWages();
            Console.WriteLine("\n");
            //UC5
            EmpMonthWages empMonthWages = new EmpMonthWages();  
            empMonthWages.MontlyWage();
            Console.ReadLine();
        }
    }
}
