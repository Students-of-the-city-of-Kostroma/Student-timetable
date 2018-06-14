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
                MTeacher ETeacher = new MTeacher(surname, name, middleName, academicDegree, academicRank, sizeOfTeachingExperience);
                teacherList.Add(ETeacher);
                return true;
            }
            catch { return false; }
        }

        public bool SaveTeacher(string ID, string surname, string name, string middleName, string academicDegree, string AcademicRank, byte SizeOfTeachingExperience)
        {

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
