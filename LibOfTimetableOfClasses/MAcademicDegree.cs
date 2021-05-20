using System;

namespace LibOfTimetableOfClasses
{
    /// <summary>
    /// Класс со свойствами, определяющими модель Ученой степени
    /// </summary>
    public class MAcademicDegree : Model
    {

        string _fullname; //Полное имя
        string _reduction; //Сокращённая учёная степень
        string _academicDegree; //Учёная степень

        public string AcademicDegree //Свойство для учёной степени
        {
            get
            {
                return _academicDegree; //Получение степени
            }
            set
            {
                if (value == null || value == "") throw new Exception("Строка не может быть пустой"); //Проверка на корректность полученной строки
                _academicDegree = value; //Добавление в учёную степень полученных данных
            }
        }

        /// <summary>
        /// Полная запись учёной степени
        /// </summary>
        public string FullName //Свойство для имени
        {
            get
            {
                return _fullname; //получение имени
            }
            set
            {
                _fullname = value; //добавление имени
            }
        }

        /// <summary>
        /// Сокращенная запись учёной степени
        /// </summary>
        public string Reduction //Свойство для сокращённой учёной степени
        {
            get
            {
                return _reduction; //получение
            }
            set
            {
                _reduction = value; //добавление
            }
        }

        /// <summary>
        /// Создание экземпляра учёной степени
        /// </summary> 
        public MAcademicDegree(string fullname, string reduction) : base()
        {
            FullName = fullname;
            Reduction = reduction;
        }
    }
}

