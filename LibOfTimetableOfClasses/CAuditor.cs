using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibOfTimetableOfClasses
{
    /// <summary>
    /// Контроллер объекта Аудитория
    /// </summary>
    public class CAuditor
    {
        /// <summary>
        /// Список объектов Аудитория
        /// </summary>
        protected List<MAuditor> auditorList = new List<MAuditor>();

        /// <summary>
        /// Метод добавления объекта Аудитория в список
        /// </summary>
        /// <param номер="number"></param>
        /// <param этаж="floor"></param>
        /// <param корпус="building"></param>
        /// <param вместительность="spacious"></param>
        /// <returns></returns>
        public bool AddAuditor(string number, byte floor, string building, int spacious)
        {
            try
            {
                MAuditor A = new MAuditor();
                A.Id = Guid.NewGuid();
                A.Number = number;
                A.Floor = floor;
                A.Building = building;
                A.Spacious = spacious;
                auditorList.Add(A);
                return true;
            }
            catch { return false; }
        }

        /// <summary>
        /// Метод изменения объекта Аудитория в списке
        /// </summary>
        /// <param идентификатор="ID"></param>
        /// <param номер="number"></param>
        /// <param этаж="floor"></param>
        /// <param корпус="building"></param>
        /// <param вместительность="spacious"></param>
        /// <returns></returns>
        public bool SaveAuditor(Guid ID, string number, byte floor, string building, int spacious)
        {
            foreach (MAuditor A in auditorList)
            {
                if (ID.Equals(A.Id))
                {
                    A.Number = number;
                    A.Floor = floor;
                    A.Building = building;
                    A.Spacious = spacious;
                    return true;
                }
            }
            return false;
        }
    }
}
