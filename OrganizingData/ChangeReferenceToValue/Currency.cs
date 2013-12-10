using System.Collections.Generic;
using System.Linq;

namespace OrganizingData.ChangeReferenceToValue
{
    public class Currency
    {
        private readonly string code;
        private static readonly List<string> Units = new List<string> { "USD", "CNY"};

        public Currency(string code)
        {
            this.code = code;
        }

        public string Code
        {
            get { return code; }
        }

        public static string Get(string unit)
        {
            return Units.FirstOrDefault(u => u.Equals(unit));
        }
    }
}