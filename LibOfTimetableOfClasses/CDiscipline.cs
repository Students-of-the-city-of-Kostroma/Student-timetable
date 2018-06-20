using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibOfTimetableOfClasses
{
    public class CDiscipline
    {
        List<MDiscipline> disciplineList = new List<MDiscipline>();

        public bool AddDiscipline(string name, string code)
        {
            try
            {
                MDiscipline D = new MDiscipline();
                D.Id = Guid.NewGuid();
                D.Name = name;
                D.Code = code;
                disciplineList.Add(D);
                return true;
            }
            catch { return false; }
        }
    }
}
