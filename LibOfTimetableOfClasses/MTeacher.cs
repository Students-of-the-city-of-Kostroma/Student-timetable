using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibOfTimetableOfClasses
{
    public class MTeacher
    {
        string id;
        string surname;
        string name;
        string middleName;
        string academicDegree;
        string academicRank;
        byte sizeOfTeachingExperience;

        public string Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

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

        public MTeacher(string surname, string name, string middleName, string academicDegree, string AcademicRank, byte SizeOfTeachingExperience)
        {
            this.surname = surname;
            this.name = name;
            this.middleName = middleName;
            this.academicDegree = academicDegree;
            this.academicRank = AcademicRank;
            this.sizeOfTeachingExperience = SizeOfTeachingExperience;
        }
    }
}
