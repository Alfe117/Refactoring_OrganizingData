using System;

namespace OrganizingData.ReplaceTypeCodeWithStateOrStrategy
{
    public class Employee
    {
        public const int ENGINEER = 0;
        public const int SALESMAN = 1;
        public const int MANAGER = 2;

        public Employee(int type)
        {
            Type = type;
        }

        public int Type { get; private set; }

        public int PayAmount(int monthlySalary, int commission, int bonus)
        {
            switch (Type)
            {
                case ENGINEER:
                    return monthlySalary;
                case SALESMAN:
                    return monthlySalary + commission;
                case MANAGER:
                    return monthlySalary + bonus;
                default:
                    throw new Exception();
            }
        }
    }
}