using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibOfTimetableOfClasses
{
    class CDiscipline
    {
        List<MDiscipline> disciplineList = new List<MDiscipline>();

        public bool DeleteDiscipline(Guid ID)
        {
            try
            {
                int i = disciplineList.FindIndex(x => x.Id.ToString() == ID.ToString());
                disciplineList.Remove(disciplineList[i]);
                return true;
            }
            catch { return false; }
        }
    }
}
