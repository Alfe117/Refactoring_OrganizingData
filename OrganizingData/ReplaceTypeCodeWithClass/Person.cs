namespace OrganizingData.ReplaceTypeCodeWithClass
{
    public class Person
    {
        public static int O = 0;
        public static int A = 1;
        public static int B = 2;
        public static int AB = 3;

        public Person(int bloodGroup)
        {
            BloodGroup = bloodGroup;
        }

        public int BloodGroup { get; private set; }
    }
}