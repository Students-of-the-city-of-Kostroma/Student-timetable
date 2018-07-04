using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimetableOfClasses
{
    public class MAuditor : MObject
    {
        protected Guid id;
        protected string number;
        protected byte floor;
        protected string building;
        protected int spacious;
        public MAuditor() : base()
        {
            this.keyValuePairs.Add("Number", "");
            this.keyValuePairs.Add("Floor", "");
            this.keyValuePairs.Add("Building", "");
            this.keyValuePairs.Add("Spacious", "");
        }
        public MAuditor(Guid id, string number, byte floor, string building, int spacious) : base(id)
        {
            this.keyValuePairs.Add("Number", number);
            this.keyValuePairs.Add("Floor", floor);
            this.keyValuePairs.Add("Building", building);
            this.keyValuePairs.Add("Spacious", spacious);
        }
    }
}
