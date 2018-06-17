using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibOfTimetableOfClasses
{
    public class MAuditor
    {
        Guid id;
        string number;    // номер аудитории
        byte floor;       // этаж
        string building;  // корпус
        int spacious;     // вместительность

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

        public string Number
        {
            get
            {
                return number;
            }

            set
            {
                number = value;
            }
        }

        public byte Floor
        {
            get
            {
                return floor;
            }

            set
            {
                floor = value;
            }
        }

        public string Building
        {
            get
            {
                return building;
            }

            set
            {
                building = value;
            }
        }

        public int Spacious
        {
            get
            {
                return spacious;
            }

            set
            {
                if (value > 0) spacious = value;
            }
        }
    }
}
