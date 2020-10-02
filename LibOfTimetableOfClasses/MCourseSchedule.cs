using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibOfTimetableOfClasses
{
    /// <summary>
    /// Класс определяющий учебное расписание
    /// </summary>
    public class MCourseSchedule : Model
    {
        private Int32 _id;
        private string _discipline;
        private string _classroom;
        private string _dayOfWeek;
        private TimeSpan _startTime;
        private TimeSpan _endTime;

        /// <summary>
        /// Создает экземпляр расписания
        /// </summary>
        /// <param name="ID">Уникальный идентификатор</param>
        /// <param name="discipline">Краткое название предмета(дисциплины)</param>
        /// <param name="classroom">Аудитория</param>
        /// <param name="dayOfWeek">День недели</param>
        /// <param name="startTime">Время начала занятия</param>
        /// <param name="endTime">Время окончания занятия</param>
        public MCourseSchedule(Int32 ID, string discipline, string classroom, string dayOfWeek, TimeSpan startTime, TimeSpan endTime)
        {
            Id = ID;
            Discipline = discipline;
            Classroom = classroom;
            DayOfWeek = dayOfWeek;
            StartTime = startTime;
            EndTime = endTime;
        }

        /// <summary>
        /// Уникальный идентификатор записи
        /// </summary>
        public Int32 Id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }
        
        /// <summary>
        /// Предмет
        /// </summary>
        public string Discipline
        {
            get
            {
                return _discipline;
            }
            set
            {
                _discipline = value;
            }
        }

        /// <summary>
        /// Аудитория
        /// </summary>
        public string Classroom
        {
            get
            {
                return _classroom;
            }
            set
            {
                _classroom = value;
            }
        }

        /// <summary>
        /// День недели
        /// </summary>
        public string DayOfWeek
        {
            get
            {
                return _dayOfWeek;
            }
            set
            {
                _dayOfWeek = value;
            }
        }

        /// <summary>
        /// Начало занятий
        /// </summary>
        public TimeSpan StartTime
        {
            get
            {
                return _startTime;
            }
            set
            {
                _startTime = value;
            }
        }

        /// <summary>
        /// Конец занятий
        /// </summary>
        public TimeSpan EndTime
        {
            get
            {
                return _endTime;
            }
            set
            {
                _endTime = value;
            }
        }
    }
}
