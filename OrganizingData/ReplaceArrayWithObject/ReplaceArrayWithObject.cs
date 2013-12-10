using System;

namespace OrganizingData.ReplaceArrayWithObject
{
    public class ReplaceArrayWithObject
    {
        private readonly string[] row;

        public ReplaceArrayWithObject(string[] row)
        {
            this.row = row;
        }

        public string Name
        {
            get { return row[0]; }
        }

        public int Wins
        {
            get { return Int32.Parse(row[1]); }
        }
    }
}