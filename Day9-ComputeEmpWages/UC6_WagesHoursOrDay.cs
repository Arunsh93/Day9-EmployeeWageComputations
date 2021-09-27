using System;

namespace Day9_ComputeEmpWages
{
    class UC6_WagesForHourOrDay
    {
        //Constants
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;
        public const int EMP_RATE_PER_HOUR = 20;
        public const int NUMBER_OF_WORKING_DAYS = 20;
        public const int MAX_HOURS_IN_MONTH = 100;
        public static void CalculateWagesForHourOrDay()
        {
            //Variables
            int EmpHrs = 0;
            int TotalEmpHours = 0;
            int TotalEmpWages = 0;
            int TotalWorkingDays = 0;

            while (TotalEmpHours <= MAX_HOURS_IN_MONTH && TotalWorkingDays < NUMBER_OF_WORKING_DAYS)
            {
                TotalWorkingDays++;
                Random random = new Random();
                int CheckEmp = random.Next(0, 3);

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

                TotalEmpHours += EmpHrs;
                Console.WriteLine("Days: " + TotalWorkingDays + " Employee Hours: " + EmpHrs);
            }

            TotalEmpWages = TotalEmpHours * EMP_RATE_PER_HOUR;
            Console.WriteLine("Total Employee Wages in Month : " + TotalEmpWages);
        }
    }
}
