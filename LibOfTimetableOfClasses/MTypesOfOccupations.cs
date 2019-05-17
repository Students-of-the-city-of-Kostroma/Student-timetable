using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibOfTimetableOfClasses
{
    /// <summary>
    /// Вид занятий
    /// </summary>
    public class MTypesOfOccupations : Model
    {
        string _fullName;
        string _shortName;

        public string FullName
        {
            get
            {
                return _fullName;
            }
            set
            {
                _fullName = value;
            }
        }

        public string ShortName
        {
            get
            {
                return _shortName;
            }
            set
            {
                _shortName = value;
            }
        }

        public MTypesOfOccupations(string fullname, string shortname) : base()
        {
            FullName = fullname;
            ShortName = shortname;
        }
    }
}
