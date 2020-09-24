using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LibOfTimetableOfClasses
{
    /// <summary>
    /// Класс со свойствами определяющими Нагрузку
    /// </summary>
    public class MAcademicLoad : Model
    {
        const string AllPattern = @"^[А-Яа-я0-9 -.]+$";
        const string CapitalLetterPattern = @"[А-Я0-9]{1}";
        const string OnlyRussianPattern = @"^[А-Яа-я -.]+$";

        string _group;
        string _totalHours;
        string _discipline;
        string _teacher;
        string _occupation;
        string _distributed;


        /// <summary>
        /// свойства group модели AcademicLoad
        /// В случае записи свойства проводятся проверки переданнаго значения:
        /// Строка должна быть: не-null, не более 25 символов, содержать только А-Я, а-я, 0-9 и -, не пустой
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
                    if ((l < 'А' || l > 'я') && (l != '-') && (l > '9' || l < '0')) throw new Exception("Можно использовать только русские буквы ");

                _group = value;
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
        /// свойства discipline модели AcademicLoad
        /// В случае записи свойства проводятся проверки переданнаго значения:
        /// Строка должна быть: не-null, не более 45 символов, содержать только А-Я,а-я, цифры, не пустой, начинаться с заглавной
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
                if (value.Length > 45) throw new Exception("Кол-во символов превышает 45");

                Regex regex = new Regex(AllPattern);
                if (!regex.IsMatch(value))
                {
                    throw new Exception("Дисциплина: Можно использовать только русские буквы, цифры, пробел тире и точку");
                }

                regex = new Regex(CapitalLetterPattern);
                if (!regex.IsMatch(value)) throw new Exception("Дисциплина: Первая буквы должна быть заглавной или цифрой ");

                _discipline = value;
            }
        }

        /// <summary>
        /// свойства teacher модели AcademicLoad
        /// В случае записи свойства проводятся проверки переданнаго значения:
        /// Строка должна быть: не-null, не более 110 символов, содержать только А-Я,а-я, не пустой, начинаться с заглавной.
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
                if (value.Length > 110) throw new Exception("Кол-во символов не превышает 110");

                Regex regex = new Regex(OnlyRussianPattern);
                if (!regex.IsMatch(value))
                {
                    throw new Exception("Преподаватель: Можно использовать только русские буквы, пробел и точку");
                }

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

                Regex regex = new Regex(OnlyRussianPattern);
                if (!regex.IsMatch(value))
                {
                    throw new Exception("Вид занятия: Можно использовать только русские буквы, пробел и точку");
                }

                if (value[0] < 'А' || value[0] > 'Я') throw new Exception("Первая буквы должна быть заглавной ");
                _occupation = value;
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


        /// <summary>
        /// Конструктор класса MAcademicLoad.
        /// </summary>
        /// <param name="group">Группа(поток)</param>
        /// <param name="totalHours">Часов всего</param>
        /// <param name="discipline">Дисциплина</param>
        /// <param name="teacher">Преподаватель</param>
        /// <param name="occupation">Вид занятия</param>
        /// <param name="distributed">Распределено </param>
        public MAcademicLoad(string group, string totalHours, string discipline, string teacher, string occupation, string distributed ) : base()
        {
            this.Group = group;
            this.TotalHours = totalHours;
            this.Discipline = discipline;
            Teacher = teacher;
            Occupation = occupation;
            Distributed = distributed;
        }

    }
}
