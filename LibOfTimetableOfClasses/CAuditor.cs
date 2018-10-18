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
        /// <param name="number">номер</param>
        /// <param name="floor">этаж</param>
        /// <param name="building">корпус</param>
        /// <param name="spacious">вместительность</param>
        /// <returns></returns>
        public bool AddAuditor(string number, byte floor, string building, int spacious)
        {
            try
            {
                MAuditor A = new MAuditor(number, floor, building, spacious);
                auditorList.Add(A);
                return true;
            }
            catch { return false; }
        }
        /// <summary>
        /// Метод удаления объекта Аудитория из списка
        /// </summary>
        /// <param name="ID">идентификатор</param>
        /// <returns></returns>
        public bool DeleteAutidor(Guid ID)
        {
            try
            {
                for (int i = 0; i < auditorList.Count; i++)
                {
                    if (ID.Equals(auditorList[i].Id))
                    {
                        auditorList.RemoveAt(i);
                        return true;
                    }
                }
                return false;
            }
            catch { return false; }
        }

        /// <summary>
        /// Метод изменения объекта Аудитория в списке
        /// </summary>
        /// <param name="ID">идентификатор</param>
        /// <param name="number">номер</param>
        /// <param name="floor">этаж</param>
        /// <param name="building">корпус</param>
        /// <param name="spacious">вместительность</param>
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
        /// <summary>
        /// Метод получения данных о списке объектов Аудитория
        /// </summary>
        /// <returns></returns>
        public string[,] GetData()
        {
            string[,] DataAuditors = new string[auditorList.Count + 1, sizeof(MAuditor.Keys)];

            for (int j = 0; j < DataAuditors.GetLength(1); j++)
                DataAuditors[0, j] = ((MAuditor.Keys)j).ToString();

            for (int i = 1; i < DataAuditors.GetLength(0); i++)
                for (int j = 0; j < DataAuditors.GetLength(1); j++)
                    DataAuditors[i, j] = auditorList[i - 1][(MAuditor.Keys)j].ToString();
            return DataAuditors;
        }
    }
}
