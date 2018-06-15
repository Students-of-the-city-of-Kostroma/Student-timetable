using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibOfTimetableOfClasses
{
    public class MTeacher
    {
        public enum Keys { Id=0, Surname=1, Name=2, MiddleName=3, AcademicDegree=4, AcademicRank=5, SizeOfTeachingExperience=6 }
        Guid id;
        string surname;
        string name;
        string middleName;
        string academicDegree;
        string academicRank;
        byte sizeOfTeachingExperience;

        public object this[Keys key]
        {
            get
            {
                switch (key)
                {
                    case Keys.Id: return Id;
                    case Keys.Surname: return Surname;
                    case Keys.Name: return Name;
                    case Keys.MiddleName: return MiddleName;
                    case Keys.AcademicDegree: return AcademicDegree;
                    case Keys.AcademicRank: return AcademicRank;
                    case Keys.SizeOfTeachingExperience: return SizeOfTeachingExperience;
                    default: return null;
                }
            }
        }

        public Guid Id
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
    }
}
