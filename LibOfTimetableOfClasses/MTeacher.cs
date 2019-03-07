using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibOfTimetableOfClasses
{
    /// <summary>
    /// Преподаватель
    /// </summary>
    public class MTeacher : Model
    {
        string surname;
        string name;
        string middleName;
        string academicDegree;
        string academicRank;
        byte sizeOfTeachingExperience;

        public string Surname
        {
            get
            {
                return surname;
            }

            set
            {
                surname = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public string MiddleName
        {
            get
            {
                return middleName;
            }

            set
            {
                middleName = value;
            }
        }

        public string AcademicDegree
        {
            get
            {
                return academicDegree;
            }

            set
            {
                academicDegree = value;
            }
        }

        public string AcademicRank
        {
            get
            {
                return academicRank;
            }

            set
            {
                academicRank = value;
            }
        }

        public byte SizeOfTeachingExperience
        {
            get
            {
                return sizeOfTeachingExperience;
            }

            set
            {
                sizeOfTeachingExperience = value;
            }
        }

        public MTeacher(string surname, string name, string middleName, string academicDegree, string academicRank, byte sizeOfTeachingExperience):base()
        {
            Surname = surname;
            Name = name;
            MiddleName = middleName;
            AcademicDegree = academicDegree;
            AcademicRank = academicRank;
            SizeOfTeachingExperience = sizeOfTeachingExperience;
        }
    }
}
