using System;

namespace Day9_ComputeEmpWages
{
    class UC8_ForMultipleCompnies
    {
        public const int isFullTime = 1;
        public const int isPartTime = 2;
        public int ComputeEmpWage(String company, int empRatePerHour, int numberOfWorkingDays, int maxHrsInMonth)
        {
            int empHrs = 0;
            int empWage = 0;
            int totalEmpWage = 0;
            int totalEmpHrs = 0;
            int totalWorkingDays = 0;

            while (totalEmpHrs <= maxHrsInMonth && totalWorkingDays < numberOfWorkingDays)
            {
                totalWorkingDays++;
                Random random = new Random();
                int empAttendance = random.Next(0, 3);
                switch (empAttendance)
                {
                    case isFullTime:
                        empHrs = 8;
                        break;

                    case isPartTime:
                        empHrs = 4;
                        break;

                    default:
                        empHrs = 0;
                        break;
                }

                totalEmpHrs += empHrs;
                Console.WriteLine("Day: " + totalWorkingDays + "Employee Hours: " + empHrs);
            }

            totalEmpWage = totalEmpHrs * empRatePerHour;
            Console.WriteLine("Total Monthly Employee Wage Company: " + company + " is "+ totalEmpWage);
            return totalEmpWage;

        }
    }
}
