namespace OrganizingData.ReplaceTypeCodeWithSubclasses
{
    public class Employee
    {
        public static int ENGINEER = 0;
        public static int SALESMAN = 1;
        public static int MANAGER = 2;

        public Employee(int type)
        {
            Type = type;
        }

        public int Type { get; private set; }
    }
}