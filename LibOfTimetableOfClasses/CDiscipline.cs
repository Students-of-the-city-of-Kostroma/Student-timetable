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

        public bool SaveDiscipline(Guid ID, string name, string code)
        {
            if (disciplineList.Count > 0)
            {
                int i = 0;
                while (!ID.Equals(disciplineList[i].Id) || i < disciplineList.Count) i++;
                if ((i == disciplineList.Count - 1) && (!ID.Equals(disciplineList[i].Id))) return false;
                else
                {
                    disciplineList[i].Name = name;
                    disciplineList[i].Code = code;
                    return true;
                }
             }
            else return false;
        }
    }
}
