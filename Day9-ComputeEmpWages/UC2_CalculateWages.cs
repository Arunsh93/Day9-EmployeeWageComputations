using System;

namespace Day9_ComputeEmpWages
{
    class UC2_CalculateWages
    {
        public void DailyWages()
        {
            //Variables
            int is_Full_Time = 1;
            int Emp_Rate_Per_Hour = 20;
            int empHrs = 8;
            int empWages = 0;

            //Random Function
            Random random = new Random();
            int result = random.Next(0, 2);

            //Computation
            if (result == is_Full_Time)
            {
                Console.WriteLine("Employee is Present");
                empWages = empHrs * Emp_Rate_Per_Hour;
                Console.WriteLine("Employee Wages : " + empWages);
            }
            else
            {
                Console.WriteLine("Employee is Absent");
            }
        }
    }
}
