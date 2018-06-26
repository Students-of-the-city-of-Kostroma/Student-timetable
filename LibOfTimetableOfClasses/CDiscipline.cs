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
            }
        }
        /// <summary>
        /// Метод изменения объекта дисциплины
        /// </summary>
        /// <param идентификатор="ID"></param>
        /// <param название="name"></param>
        /// <param код="code"></param>
        /// <returns></returns>
        public bool SaveDiscipline(Guid ID, string name, string code)
        {
            foreach (MDiscipline D in disciplineList)
                {
                    if (ID.Equals(D.Id))
                    {
                        D.Name = name;
                        D.Code = code;
                        return true;
                    }
                }
            return false;
        }

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
        /// <summary>
        /// Метод вернуть данные
        /// </summary>
        /// <returns></returns>
        public string[,] GetData()
        {
            string[,] DataDisciplines = new string[disciplineList.Count + 1, sizeof(MDiscipline.Keys)];

            for (int j = 0; j < DataDisciplines.GetLength(1); j++)
                DataDisciplines[0, j] = ((MDiscipline.Keys)j).ToString();

            for (int i = 1; i < DataDisciplines.GetLength(0); i++)
                for (int j = 0; j < DataDisciplines.GetLength(1); j++)
                    DataDisciplines[i, j] = disciplineList[i - 1][(MDiscipline.Keys)j].ToString();
            return DataDisciplines;
        }
    }
}
