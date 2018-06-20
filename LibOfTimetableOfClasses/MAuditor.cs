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
        /// <summary>
        /// номер аудитории
        /// </summary>
        string number; 
        /// <summary>
        /// этаж
        /// </summary>     
        byte floor;
        /// <summary>
             /// корпус
             /// </summary>                 
        string building;
        /// <summary>
        /// вместительность аудитории
        /// </summary>
        int spacious;     

        /// <summary>
        /// Возвращает или задает идентификатор id
        /// </summary>
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

        /// <summary>
        /// Возвращает или задает number - номер аудитории
        /// </summary>
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

        /// <summary>
        /// Возвращает или задает floor - этаж
        /// </summary>
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

        /// <summary>
        /// Возвращает или задает building - корпус
        /// </summary>
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

        /// <summary>
        /// Возвращает или задает spacious - вместительность
        /// </summary>
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
