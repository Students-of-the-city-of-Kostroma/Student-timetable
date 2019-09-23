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
        string _group;
        string _discipline;
        string _teacher;
        string _occupation;
        string _totalHours;
        string _distributed;


        /// <summary>
        /// свойства group модели AcademicLoad
        /// В случае записи свойства проводятся проверки переданнаго значения:
        /// Строка должна быть: не-null, не более 25 символов, содержать только А-Я,а-я, не пустой, начинаться с заглавной
        /// Группа
        /// </summary>
        public string Group
        {
            get
            {
                return _group;
            }
            set
            {
                if (value == null || value == "") throw new Exception("Строка не может быть пустой");
                if (value.Length > 25) throw new Exception("Кол-во символов превышает 25");

                foreach (char l in value)
                    if (l < 'А' || l > 'я') throw new Exception("Можно использовать только русские буквы ");

                if (value[0] < 'А' || value[0] > 'Я') throw new Exception("Первая буквы должна быть заглавной ");
                _group = value;
            }
        }

        /// <summary>
        /// свойства discipline модели AcademicLoad
        /// В случае записи свойства проводятся проверки переданнаго значения:
        /// Строка должна быть: не-null, не более 25 символов, содержать только А-Я,а-я, не пустой, начинаться с заглавной
        /// Дисциплина
        /// </summary>
        public string Discipline
        {
            get
            {
                return _discipline;
            }
            set
            {
                if (value == null || value == "") throw new Exception("Строка не может быть пустой");
                if (value.Length > 25) throw new Exception("Кол-во символов превышает 25");

                foreach (char l in value)
                    if (l < 'А' || l > 'я') throw new Exception("Можно использовать только русские буквы ");

                if (value[0] < 'А' || value[0] > 'Я') throw new Exception("Первая буквы должна быть заглавной ");
                _discipline = value;
            }
        }

        /// <summary>
        /// свойства teacher модели AcademicLoad
        /// В случае записи свойства проводятся проверки переданнаго значения:
        /// Строка должна быть: не-null, не более 25 символов, содержать только А-Я,а-я, не пустой, начинаться с заглавной
        /// Преподаватель
        /// </summary>
        public string Teacher
        {
            get
            {
                return _teacher;
            }
            set
            {
                if (value == null || value == "") throw new Exception("Строка не может быть пустой");
                if (value.Length > 25) throw new Exception("Кол-во символов не превышает 25");

                foreach (char l in value)
                    if (l < 'А' || l > 'я') throw new Exception("Можно использовать только русские буквы ");

                if (value[0] < 'А' || value[0] > 'Я') throw new Exception("Первая буквы должна быть заглавной");
                _teacher = value;
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
        /// свойства TotalHours модели AcademicLoad
        /// В случае записи свойства проводятся проверки переданнаго значения:
        /// Строка должна быть: не-null, не более 25 символов, содержать только А-Я,а-я, не пустой, начинаться с заглавной
        /// Всего часов
        /// </summary>
        public string TotalHours
        {
            get
            {
                return _totalHours;
            }
            set
            {
                if (value == null || value == "") throw new Exception("Строка не может быть пустой");
                foreach (char l in value)
                    if (l < '0' || l > '9') throw new Exception("Можно использовать только цифры ");

                _totalHours = value;
            }
        }

        /// <summary>
        /// свойства distributed модели AcademicLoad
        /// В случае записи свойства проводятся проверки переданнаго значения:
        /// Строка должна быть: не-null, не более 25 символов, содержать только А-Я,а-я, не пустой, начинаться с заглавной
        /// Распределено
        /// </summary>

        public string Distributed
        {
            get
            {
                return _distributed;
            }
            set
            {
                if (value == null || value == "") throw new Exception("Строка не может быть пустой");
                foreach (char l in value)
                    if (l < '0' || l > '9') throw new Exception("Можно использовать только цифры ");

                _distributed = value;
            }
        }
    }
}
