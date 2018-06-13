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

        public bool SaveTeacher(Guid ID, string surname, string name, string middleName, string academicDegree, string AcademicRank, byte SizeOfTeachingExperience)
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
                    teacherList[i].AcademicRank = AcademicRank;
                    teacherList[i].SizeOfTeachingExperience = SizeOfTeachingExperience;
                    return true;
                }
            }
            else return false;
        }

        public bool DeleteTeacher(string ID)
        {

        }

        public string[,] GetData()
        {

        }

        public string[,] GetSortedData(string columnName, bool order)
        {

        }
    }
}
