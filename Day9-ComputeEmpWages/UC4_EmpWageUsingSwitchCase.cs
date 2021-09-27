using System;

namespace Day9_ComputeEmpWages
{
    class UC4_EmpWageUsingSwitchCase
    {
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;
        public const int EMP_RATE_PER_HOUR = 20;
        public void EmpWageUsingSwitchCase()
        {
            //Variables
            int EmpHrs = 0;
            int EmpWage = 0;

            //Random Function
            Random random = new Random();
            int CheckEmp = random.Next(0, 3);
            Console.WriteLine("Random Number : " + CheckEmp);

            //Using Switch Case
            switch (CheckEmp)
            {
                case IS_PART_TIME:
                    EmpHrs = 4;
                    break;

                case IS_FULL_TIME:
                    EmpHrs = 8;
                    break;

                default:
                    EmpHrs = 0;
                    break;
            }

            EmpWage = EmpHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("Employee Wage is : " + EmpWage);
        }
    }
}
