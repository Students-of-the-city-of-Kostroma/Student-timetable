using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibOfTimetableOfClasses
{
    /// <summary>
    /// Контроллер для объекта Дисциплина
    /// </summary>
    public class CDiscipline
    {
        /// <summary>
        /// Список объектов Дисциплина
        /// </summary>
        List<MDiscipline> disciplineList = new List<MDiscipline>();

        /// <summary>
        /// Метод добавить дисциплину
        /// </summary>
        /// <param название="name"></param>
        /// <param код="code"></param>
        /// <returns></returns>
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
