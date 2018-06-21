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

        public bool AddTeacher(string surname, string name, string middleName, string academicDegree, string academicRank, byte sizeOfTeachingExperience)
        {
            try
            {
                  MTeacher T = new MTeacher();
                  T.Id = Guid.NewGuid();
                  T.Name = name;
                  T.MiddleName = middleName;
                  T.Surname = surname;
                  T.SizeOfTeachingExperience = SizeOfTeachingExperience;
                  T.AcademicDegree = academicDegree;
                  T.AcademicRank = AcademicRank;
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
            if (teacherList.Count != 0)
            {
                string[,] s = new string[teacherList.Count + 1, sizeof(MTeacher.Keys)];
                
                for (int j = 0; j < s.GetLength(1); j++) // Заполнение первой строки заголовками
                    s[0, j] = ((MTeacher.Keys)j).ToString();

                int count = 1;
                foreach (MTeacher m in teacherList)  //Заполняем двумерный массив строк
                {
                    s[count, 0] = (m.Id).ToString();
                    s[count, 1] = m.Surname;
                    s[count, 2] = m.Name;
                    s[count, 3] = m.MiddleName;
                    s[count, 4] = m.AcademicDegree;
                    s[count, 5] = m.AcademicRank;
                    s[count, 6] = Convert.ToString(m.SizeOfTeachingExperience);
                    count++;
                }

                for (int j = 0; j < s.GetLength(1); j++)
                {
                    if (columnName == s[0, j]) //Находим и запоминаем сортируемый столбец
                        count = j;
                }

                if (order)
                {
                    for (int j = 1; j < s.GetLength(0); j++)
                    {
                        for (int i = 1; i < s.GetLength(0) - 1; i++)
                        {
                            int rez = String.Compare(s[i, count], s[i + 1, count]);
                            if (rez < 0) // Если ... , то сверху вниз в порядке убывания
                            {
                                string peremen = s[i, count];
                                s[i, count] = s[i + 1, count]; // Меняем текущий с последующим
                                s[i + 1, count] = peremen;
                            }
                        }
                    }
                    
                    return s;
                }
                else
                {
                    for (int j = 1; j < s.GetLength(0); j++)
                    {
                        for (int i = 1; i < s.GetLength(0); i++)
                        {
                            int rez = String.Compare(s[i, count], s[i + 1, count]);
                            if (rez > 0) // Если ... , то сверху вниз в порядке возрастания
                            {
                                string peremen = s[i, count];
                                s[i, count] = s[i + 1, count]; // Меняем текущий с последующим
                                s[i + 1, count] = peremen;
                            }
                        }
                    }
                    return s;
                }
            }
            else // Если techearlist пуст
            {
                string[,] s = new string[,] { };
                return s; // Вернём пустой массив
            }
        }
    }
}
