namespace OrganizingData.ChangeReferenceToValue
{
    public class Currency
    {
        private readonly string code;

        public Currency(string code)
        {
            this.code = code;
        }

        public string Code
        {
            get { return code; }
        }
    }
}