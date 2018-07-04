using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimetableOfClasses
{
    public class MGroups : MObject
    {
        protected Guid id;
        protected string cipherr;
        protected byte population;
        public MGroups() : base()
        {
            this.keyValuePairs.Add("Cipher", "");
            this.keyValuePairs.Add("Population", "");
        }
        public MGroups(Guid id, string cipher, byte population) : base(id)
        {
            this.keyValuePairs.Add("Cipher", cipher);
            this.keyValuePairs.Add("Population", population);
        }
    }
}
