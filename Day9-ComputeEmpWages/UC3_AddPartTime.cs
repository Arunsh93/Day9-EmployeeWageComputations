using System;

namespace Day9_ComputeEmpWages
{
    class UC3_AddPartTime
    {
        public void AddPartTimeEmp()
        {
            //Constants
            int IS_PART_TIME = 1;
            int IS_FULL_TIME = 2;
            int EMP_RATE_PER_HOUR = 20;

            //Variables
            int EmpHrs = 0;
            int EmpWage = 0;

            //Random Function
            Random random = new Random();
            int CheckEmp = random.Next(0, 3);
            Console.WriteLine("Random Number : " + CheckEmp);

            //Computations
            if (CheckEmp == IS_PART_TIME)
            {
                EmpHrs = 4;
            }
            else if (CheckEmp == IS_FULL_TIME)
            {
                EmpHrs = 8;
            }
            else
            {
                EmpHrs = 0;
            }

            EmpWage = EmpHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("Employee Wage is : " + EmpWage);
        }

    }
}
