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
                return true;
            }
            catch { return false; }
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
                MDiscipline D = new MDiscipline(name, code);
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

        /// <summary>
        /// Метод возвращающий отсортированные данные
        /// </summary>
        /// <param название строки="columnName"></param>
        /// <param способ="order"></param>
        /// <returns></returns>
        public string[,] GetData(string columnName, bool order)
        {
            int count = -1;
            string[,] DataDisciplines = GetData();

            if (disciplineList.Count != 0)
            {

                for (int j = 0; j < DataDisciplines.GetLength(1); j++)
                {
                    if (columnName == DataDisciplines[0, j]) //Находим и запоминаем сортируемый столбец
                    { count = j; break; }
                }

                if (count != -1) // Если столбец найден
                {
                    if (order)
                    {
                        for (int i = 1; i < DataDisciplines.GetLength(0) - 1; i++)
                        {
                            for (int j = i + 1; j < DataDisciplines.GetLength(0); j++)
                            {
                                int rez = String.Compare(DataDisciplines[i, count], DataDisciplines[j, count]);
                                if (rez < 0)
                                {
                                    string temp;
                                    for (int p = 0; p < DataDisciplines.GetLength(1); p++) // Меняем строки местами
                                    {
                                        temp = DataDisciplines[i, p];
                                        DataDisciplines[i, p] = DataDisciplines[j, p];
                                        DataDisciplines[j, p] = temp;
                                    }
                                }
                            }
                        }

                        return DataDisciplines;
                    }
                    else
                    {
                        for (int i = 1; i < DataDisciplines.GetLength(0) - 1; i++)
                        {
                            for (int j = i + 1; j < DataDisciplines.GetLength(0); j++)
                            {
                                int rez = String.Compare(DataDisciplines[i, count], DataDisciplines[j, count]);
                                if (rez < 0)
                                {
                                    string temp;
                                    for (int p = 0; p < DataDisciplines.GetLength(1); p++) // Меняем строки местами
                                    {
                                        temp = DataDisciplines[i, p];
                                        DataDisciplines[i, p] = DataDisciplines[j, p];
                                        DataDisciplines[j, p] = temp;
                                    }
                                }
                            }
                        }

                        return DataDisciplines;
                    }
                }
                else
                    throw new Exception("Сортируемый столбец указан неверно!");
            }
            else
                return DataDisciplines;
        }
    }
}
