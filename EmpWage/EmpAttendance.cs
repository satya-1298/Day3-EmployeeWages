using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWage
{
    public class EmpAttendance
    {
        public void Check()
        {
            
            Random random = new Random();
            int attendent=random.Next(2);
            Console.WriteLine(attendent);
            if(attendent == 0) 
            {
                Console.WriteLine("Employee Absent");

            }
            else
            {
                Console.WriteLine("Employee Present");

            }
        }
    }
}
