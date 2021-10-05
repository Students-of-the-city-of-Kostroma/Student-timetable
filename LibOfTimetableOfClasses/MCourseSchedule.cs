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
        private int? _id;
        private int? _academicId;
        private string _building;
        private string _classroom;
        private string _dayOfWeek;
        private TimeSpan _startTime;
        private TimeSpan _endTime;

        /// <summary>
        /// Создает экземпляр расписания
        /// </summary>
        /// <param name="ID">Уникальный идентификатор</param>
        /// <param name="academicId">Идентификатор академической загрузки</param>
        /// <param name="building">Корпус</param>
        /// <param name="classroom">Аудитория</param>
        /// <param name="dayOfWeek">День недели</param>
        /// <param name="startTime">Время начала занятия</param>
        /// <param name="endTime">Время окончания занятия</param>
        public MCourseSchedule(int? ID, int? academicId, string building, string classroom, string dayOfWeek, TimeSpan startTime, TimeSpan endTime)
        {
            Id = ID;
            AcademicId = academicId;
            Building = building;
            Classroom = classroom;
            DayOfWeek = dayOfWeek;
            StartTime = startTime;
            EndTime = endTime;
        }

        /// <summary>
        /// Уникальный идентификатор записи
        /// Может принимать значение null для новой модели
        /// </summary>
        public int? Id
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
        /// Идентификатор академической загрузки (ссылка на значение из таблицы академической загрузки)
        /// </summary>
        public int? AcademicId
        {
            get
            {
                return _academicId;
            }
            set
            {
                _academicId = value;
            }
        }

        /// <summary>
        /// Корпус
        /// </summary>
        public string Building
        {
            get
            {
                return _building;
            }
            set
            {
                _building = value;
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
