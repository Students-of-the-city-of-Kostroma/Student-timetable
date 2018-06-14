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
            throw new Exception();
        }

        public bool SaveTeacher(string ID, string surname, string name, string middleName, string academicDegree, string AcademicRank, byte SizeOfTeachingExperience)
        {
            throw new Exception();
        }

        public bool DeleteTeacher(Guid ID)
        {
            if (teacherList.Count > 0)
            {
                int i = 0;
                while (!ID.Equals(teacherList[i].Id) || i < teacherList.Count) i++;
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
            throw new Exception();
        }

        public string[,] GetSortedData(string columnName, bool order)
        {
            throw new Exception();
        }
    }
}
