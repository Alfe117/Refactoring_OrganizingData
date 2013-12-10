namespace OrganizingData.EncapsulateCollection
{
    public class Course
    {
        private readonly string courseName;
        private readonly bool isAdvantaged;

        public Course(string courseName, bool isAdvantaged)
        {
            this.courseName = courseName;
            this.isAdvantaged = isAdvantaged;
        }

        public string CourseName
        {
            get { return courseName; }
        }

        public bool IsAdvantaged
        {
            get { return isAdvantaged; }
        }
    }
}