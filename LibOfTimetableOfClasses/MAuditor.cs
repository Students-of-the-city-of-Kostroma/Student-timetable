using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibOfTimetableOfClasses
{
    /// <summary> 
    /// Аудитория 
    /// </summary> 
    public class MAuditor : Model
    {

        /// <summary> 
        /// аудитория 
        /// </summary> 
        string nameOfAuditor;
        /// <summary> 
        /// идентифактор 
        /// </summary> 
        Guid id;
        /// <summary> 
        /// кафедра 
        /// </summary> 
        string cafedra;
        /// <summary> 
        /// вместительность аудитории 
        /// </summary> 
        ushort spacious;
        /// <summary> 
        /// корпус 
        /// </summary> 
        byte building;
        /// <summary> 
        /// Создает экземпляр Аудитории 
        /// </summary>
        /// <param name="nameOfAuditor">Название аудитории</param> 
        /// <param name="id">Уникальный идентификатор</param> 
        /// <param name="cafedra">Кафедра</param> 
        /// <param name="spacious">Вместительность</param> 
        /// <param name="building">Корпус</param>
        public MAuditor(string nameOfAuditor, string cafedra, ushort spacious, byte building) : base()
        {
            Id = Guid.NewGuid();
            NameOfAuditor = nameOfAuditor;
            Cafedra = cafedra;
            Spacious = spacious;
            Building = building;
        }

        /// <summary> 
        /// nameofaud - название аудитории 
        /// </summary> 
        public string NameOfAuditor
        {
            get
            {
                return nameOfAuditor;
            }

            set
            {
                nameOfAuditor = value;
            }
        }

        /// <summary> 
        /// cafedra - кафедру 
        /// </summary> 
        public string Cafedra
        {
            get
            {
                return cafedra;
            }

            set
            {
                cafedra = value;
            }
        }

        /// <summary> 
        /// building - корпус 
        /// </summary> 
        public byte Building
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
        /// spacious - вместительность 
        /// </summary> 
        public ushort Spacious
        {
            get
            {
                return spacious;
            }

            set
            {
                spacious = value;
            }
        }

        /// <summary> 
        /// Id - уникальный иденнтификатор 
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
    }
}