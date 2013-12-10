namespace OrganizingData.ReplaceSubclassWithFields
{
    public class FeMale : Person
    {
        protected override bool IsMale()
        {
            return false;
        }

        public override string GetCode()
        {
            return "F";
        }
    }
}