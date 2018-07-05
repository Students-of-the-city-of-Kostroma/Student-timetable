using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibOfTimetableOfClasses
{
    public class CTeacher
    {
        List <MTeacher> teacherList = new List <MTeacher>();

        public int Count
        {
            get
            {
                return teacherList.Count;
            }
        }

        public bool AddTeacher(string surname, string name, string middleName, string academicDegree, string academicRank, byte sizeOfTeachingExperience)
        {
            try
            {
                MTeacher T = new MTeacher(surname, name, middleName, academicDegree, academicRank, sizeOfTeachingExperience);

                teacherList.Add(T);
                return true;
            }
            catch { return false; }
        }

        public bool SaveTeacher(Guid ID, string surname, string name, string middleName, string academicDegree, string academicRank, byte sizeOfTeachingExperience)
        {
            if (teacherList.Count > 0)
            {
                int i = 0;
                while (!ID.Equals(teacherList[i].Id) || i < teacherList.Count) i++;
                if ((i == teacherList.Count - 1) && (!ID.Equals(teacherList[i].Id))) return false;
                else
                {
                    teacherList[i].Surname = surname;
                    teacherList[i].Name = name;
                    teacherList[i].MiddleName = middleName;
                    teacherList[i].AcademicDegree = academicDegree;
                    teacherList[i].AcademicRank = academicRank;
                    teacherList[i].SizeOfTeachingExperience = sizeOfTeachingExperience;
                    return true;
                }
            }
            else return false;
        }

        public bool DeleteTeacher(Guid ID)
        {
            if (teacherList.Count > 0)
            {
                int i = 0;
                while (!ID.Equals(teacherList[i].Id) && i < teacherList.Count-1) i++;
                if ((i == teacherList.Count - 1) && (!ID.Equals(teacherList[i].Id))) return false;
                else
                {
                    teacherList.RemoveAt(i);
                    return true;
                }
            }
            else return false;
        }

        public string[,] GetData()
        {
            string[,] DataTeachers = new string[teacherList.Count + 1, sizeof(MTeacher.Keys)];
            //формируем заголовок таблицы
            for (int j = 0; j < DataTeachers.GetLength(1); j++)
                DataTeachers[0, j] = ((MTeacher.Keys)j).ToString();
            //заполняем таблицу
            for (int i = 1; i < DataTeachers.GetLength(0); i++)
                for (int j = 0; j < DataTeachers.GetLength(1); j++)
                    DataTeachers[i, j] = teacherList[i - 1][(MTeacher.Keys)j].ToString();
            return DataTeachers;
        }

        /// <summary>
        /// Возвращает отсортированный двумерный массив строк, содержащий данные из teacherlist
        /// </summary>
        /// <param name="columnName">Сортируемая колонка</param>
        /// <param name="order">true => сортировка по возрастанию, false => сортировка по убыванию </param>
        /// <returns>Двумерный массив строк</returns>
        public string[,] GetData(string columnName, bool order)
        {
            int count = -1;
            string[,] DataTechers = GetData();

            if (teacherList.Count != 0)
            {

                for (int j = 0; j < DataTechers.GetLength(1); j++)
                {
                    if (columnName == DataTechers[0, j]) //Находим и запоминаем сортируемый столбец
                    { count = j; break; }
                }

                if (count != -1) // Если столбец найден
                {
                    if (order)
                    {
                        for (int i = 1; i < DataTechers.GetLength(0) - 1; i++)
                        {
                            for (int j = i + 1; j < DataTechers.GetLength(0); j++)
                            {
                                int rez = String.Compare(DataTechers[i, count], DataTechers[j, count]);
                                if (rez < 0)
                                {
                                    string temp;
                                    for (int p = 0; p < DataTechers.GetLength(1); p++) // Меняем строки местами
                                    {
                                        temp = DataTechers[i, p];
                                        DataTechers[i, p] = DataTechers[j, p];
                                        DataTechers[j, p] = temp;
                                    }
                                }
                            }
                        }

                        return DataTechers;
                    }
                    else
                    {
                        for (int i = 1; i < DataTechers.GetLength(0) - 1; i++)
                        {
                            for (int j = i + 1; j < DataTechers.GetLength(0); j++)
                            {
                                int rez = String.Compare(DataTechers[i, count], DataTechers[j, count]);
                                if (rez < 0)
                                {
                                    string temp;
                                    for (int p = 0; p < DataTechers.GetLength(1); p++) // Меняем строки местами
                                    {
                                        temp = DataTechers[i, p];
                                        DataTechers[i, p] = DataTechers[j, p];
                                        DataTechers[j, p] = temp;
                                    }
                                }
                            }
                        }

                        return DataTechers;
                    }
                }
                else
                    throw new Exception("Сортируемый столбец указан неверно!");
            }
            else
                return DataTechers;
        }
    }
}
