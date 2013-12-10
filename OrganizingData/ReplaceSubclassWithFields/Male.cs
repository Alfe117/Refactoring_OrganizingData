namespace OrganizingData.ReplaceSubclassWithFields
{
    public class Male : Person
    {
        protected override bool IsMale()
        {
            return true;
        }

        public override string GetCode()
        {
            return "M";
        }
    }
}