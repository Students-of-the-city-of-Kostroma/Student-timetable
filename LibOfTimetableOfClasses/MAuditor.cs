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
    public class MAuditor
    {
        /// <summary>
        /// Перечисление полей объекта модели Аудитория
        /// </summary>
        public enum Keys { Id = 0, Number = 1, Floor = 2, Building = 3, Spacious = 4 }
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
        /// Конструктор иницциализирующий экземпляр объекта Аудитория
        /// </summary>
        /// <param name="number">номер аудитории</param>
        /// <param name="floor">этаж</param>
        /// <param name="building">корпус</param>
        /// <param name="spacious">вместительность аудитории</param>
        public MAuditor(string number, byte floor, string building, int spacious)
        {
            id = Guid.NewGuid();
            Number = number;
            Floor = floor;
            Building = building;
            Spacious = spacious;
        }

        /// <summary>
        /// Возвращает значение перечисления
        /// </summary>
        /// <param ключ="key"></param>
        /// <returns></returns>
        public object this[Keys key]
        {
            get
            {
                switch (key)
                {
                    case Keys.Id: return Id;
                    case Keys.Number: return Number;
                    case Keys.Floor: return Floor;
                    case Keys.Building: return Building;
                    case Keys.Spacious: return Spacious;
                    default: return null;
                }
            }
        }

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
