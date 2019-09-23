using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibOfTimetableOfClasses
{
    /// <summary>
    /// Класс со свойствами определяющими Нагрузку
    /// </summary>
    public class MAcademicLoad : Model
    {
        string _Group;
        string _Discipline;
        string _Teacher;
        string _TotalHours;
        string _occupation;
        string _Distributed;


        /// <summary>
        /// свойства group модели AcademicLoad
        /// В случае записи свойства проводятся проверки переданнаго значения:
        /// Строка должна быть: не-null, не более 25 символов, содержать только А-Я,а-я, не пустой, начинаться с заглавной
        /// Группа
        /// </summary>
        public string group
        {
            get
            {
                return _Group;
            }
            set
            {
                if (value == null || value == "") throw new Exception("Строка не может быть пустой");
                if (value.Length > 25) throw new Exception("Кол-во символов превышает 25");

                foreach (char l in value)
                    if (l < 'А' || l > 'я') throw new Exception("Можно использовать только русские буквы ");

                if (value[0] < 'А' || value[0] > 'Я') throw new Exception("Первая буквы должна быть заглавной ");
                _Group = value;
            }
        }

        /// <summary>
        /// свойства occupation модели AcademicLoad
        /// В случае записи свойства проводятся проверки переданнаго значения:
        /// Строка должна быть: не-null, не более 25 символов, содержать только А-Я,а-я, не пустой, начинаться с заглавной
        /// Вид занятия
        /// </summary>
        public string Occupation
        {
            get
            {
                return _occupation;
            }
            set
            {
                if (value == null || value == "") throw new Exception("Строка не может быть пустой");
                if (value.Length > 25) throw new Exception("Кол-во символов превышает 25");

                foreach (char l in value)
                    if (l < 'А' || l > 'я') throw new Exception("Можно использовать только русские буквы ");

                if (value[0] < 'А' || value[0] > 'Я') throw new Exception("Первая буквы должна быть заглавной ");
                _occupation = value;
            }
        }

        /// <summary>
        /// свойства discipline модели AcademicLoad
        /// В случае записи свойства проводятся проверки переданнаго значения:
        /// Строка должна быть: не-null, не более 25 символов, содержать только А-Я,а-я, не пустой, начинаться с заглавной
        /// Дисциплина
        /// </summary>
        public string discipline
        {
            get
            {
                return _Discipline;
            }
            set
            {
                if (value == null || value == "") throw new Exception("Строка не может быть пустой");
                if (value.Length > 25) throw new Exception("Кол-во символов превышает 25");

                foreach (char l in value)
                    if (l < 'А' || l > 'я') throw new Exception("Можно использовать только русские буквы ");

                if (value[0] < 'А' || value[0] > 'Я') throw new Exception("Первая буквы должна быть заглавной ");
                _Discipline = value;
            }
        }

        /// <summary>
        /// свойства teacher модели AcademicLoad
        /// В случае записи свойства проводятся проверки переданнаго значения:
        /// Строка должна быть: не-null, не более 25 символов, содержать только А-Я,а-я, не пустой, начинаться с заглавной
        /// Преподаватель
        /// </summary>
        public string teacher
        {
            get
            {
                return _Teacher;
            }
            set
            {
                if (value == null || value == "") throw new Exception("Строка не может быть пустой");
                if (value.Length > 25) throw new Exception("Кол-во символов не превышает 25");

                foreach (char l in value)
                    if (l < 'А' || l > 'я') throw new Exception("Можно использовать только русские буквы ");

                if (value[0] < 'А' || value[0] > 'Я') throw new Exception("Первая буквы должна быть заглавной");
                _Teacher = value;
            }
        }

        /// <summary>
        /// свойства TotalHours модели AcademicLoad
        /// В случае записи свойства проводятся проверки переданнаго значения:
        /// Строка должна быть: не-null, не более 25 символов, содержать только А-Я,а-я, не пустой, начинаться с заглавной
        /// Всего часов
        /// </summary>
        public string totalHours
        {
            get
            {
                return _TotalHours;
            }
            set
            {
                if (value == null || value == "") throw new Exception("Строка не может быть пустой");
                foreach (char l in value)
                    if (l < '0' || l > '9') throw new Exception("Можно использовать только цифры ");

                _TotalHours = value;
            }
        }

        /// <summary>
        /// свойства distributed модели AcademicLoad
        /// В случае записи свойства проводятся проверки переданнаго значения:
        /// Строка должна быть: не-null, не более 25 символов, содержать только А-Я,а-я, не пустой, начинаться с заглавной
        /// Распределено
        /// </summary>

        public string distributed
        {
            get
            {
                return _Distributed;
            }
            set
            {
                if (value == null || value == "") throw new Exception("Строка не может быть пустой");
                foreach (char l in value)
                    if (l < '0' || l > '9') throw new Exception("Можно использовать только цифры ");

                _Distributed = value;
            }
        }
    }
}
