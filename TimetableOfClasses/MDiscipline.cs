using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimetableOfClasses
{
    public class MDiscipline : MObject
    {
        protected Guid id;
        protected string name;
        protected string code;
        public MDiscipline() : base()
        {
            this.keyValuePairs.Add("Name", "");
            this.keyValuePairs.Add("Code", "");
        }
        public MDiscipline(Guid id, string name, string code) : base(id)
        {
            this.keyValuePairs.Add("Name", name);
            this.keyValuePairs.Add("Code", code);
        }
    }
}
