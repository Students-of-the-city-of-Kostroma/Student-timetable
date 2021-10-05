using System;

namespace LibOfTimetableOfClasses
{
    /// <summary>
    /// Класс со свойствами, определяющими модель Ученой степени
    /// </summary>
    public class MAcademicDegree : Model
    {

        string _fullname;
        string _reduction;
        string _academicDegree;

        public string AcademicDegree
        {
            get
            {
                return _academicDegree;
            }
            set
            {
                if (value == null || value == "") throw new Exception("Строка не может быть пустой");
                _academicDegree = value;
            }
        }

        /// <summary>
        /// Полная запись учёной степени
        /// </summary>
        public string FullName
        {
            get
            {
                return _fullname;
            }
            set
            {
                _fullname = value;
            }
        }

        /// <summary>
        /// Сокращенная запись учёной степени
        /// </summary>
        public string Reduction
        {
            get
            {
                return _reduction;
            }
            set
            {
                _reduction = value;
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