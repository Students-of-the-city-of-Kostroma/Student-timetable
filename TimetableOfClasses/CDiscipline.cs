using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimetableOfClasses
{
    public class CDiscipline : CObject
    {
        public override string[] GetColumnNames()
        {
            return (this.objList.Count > 0) ? this.objList[0].GetColumnNames() : (new MDiscipline()).GetColumnNames();
        }
    }
}
