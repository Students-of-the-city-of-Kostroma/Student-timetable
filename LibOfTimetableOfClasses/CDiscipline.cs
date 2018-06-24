using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibOfTimetableOfClasses
{
    /// <summary>
    /// Контроллер для дисциплин
    /// </summary>
    class CDiscipline
    {
        /// <summary>
        /// Список объектов Дисциплина
        /// </summary>
        protected List<MDiscipline> disciplineList = new List<MDiscipline>();
        /// <summary>
        /// Метод удаления дисциплин
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
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
