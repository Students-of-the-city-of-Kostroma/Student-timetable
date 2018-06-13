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

        public bool AddTeacher(string surname, string name, string middleName, string academicDegree, string AcademicRank, byte SizeOfTeachingExperience)
        {

        }

        public bool SaveTeacher(string ID, string surname, string name, string middleName, string academicDegree, string AcademicRank, byte SizeOfTeachingExperience)
        {

        }

        public bool DeleteTeacher(string ID)
        {

        }

        public string[,] GetData()
        {
            string[,] DataTeachers = new string[teacherList.Count, 7];
            for (int i =0; i < teacherList.Count; i++)
                for (int j = 0; j < 7; j++)
                {
                    switch (j)
                    {
                        case 0:
                            DataTeachers[i, j] = teacherList[i].Id;
                            break;

                        case 1:
                            DataTeachers[i, j] = teacherList[i].Surname;
                            break;

                        case 2:
                            DataTeachers[i, j] = teacherList[i].Name;
                            break;

                        case 3:
                            DataTeachers[i, j] = teacherList[i].MiddleName;
                            break;

                        case 4:
                            DataTeachers[i, j] = teacherList[i].AcademicDegree;
                            break;

                        case 5:
                            DataTeachers[i, j] = teacherList[i].AcademicRank;
                            break;

                        case 6:
                            DataTeachers[i, j] = teacherList[i].SizeOfTeachingExperience.ToString();
                            break;
                    }
                }
            return DataTeachers;
        }

        public string[,] GetSortedData(string columnName, bool order)
        {

        }
    }
}
