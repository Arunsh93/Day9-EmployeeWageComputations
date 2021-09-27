using System;

namespace Day9_ComputeEmpWages
{
    class UC1_PresentOrAbsent
    {
        public void CheckEmp()
        {
            int is_Full_Time = 1;
            Random random = new Random();
            int result = random.Next(0, 2);

            if (result == is_Full_Time)
            {
                Console.WriteLine("Employee is Present");
            }
            else
            {
                Console.WriteLine("Employee is Absent");
            }
        }
    }
}
