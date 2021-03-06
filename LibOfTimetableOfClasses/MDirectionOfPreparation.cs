﻿using System;
using System.Text.RegularExpressions;

namespace LibOfTimetableOfClasses
{
    public class MDirectionOfPreparation : Model
    {
        /// <summary>
        /// Код направления подготовки
        /// </summary>
        protected string codeOfDP;
        /// <summary>
        /// Название направления подготовки
        /// </summary>
        protected string nameOfDP;
        /// <summary>
        /// Период обучения
        /// </summary>
        protected ushort periodOfStudy;
        /// <summary>
        /// Сокращенное название института, к которому относится направление подготовки
        /// </summary>
        protected string instituteShortName;
        
        /// <summary>
        /// Создает экземпляр направления подготовки
        /// </summary>
        /// <param name="codeOfDP">Код направления подготовки</param>
        /// <param name="nameOfDP">Название направления подготовки</param>
        /// <param name="periodOfStudy">Период обучения</param>
        /// <param name="instituteShortName">Сокращенное название института, к которому относится направление подготовки</param>
        public MDirectionOfPreparation(string codeOfDP, string nameOfDP, ushort periodOfStudy, string instituteShortName) : base()
        {
            CodeOfDP = codeOfDP;
            NameOfDP = nameOfDP;
            PeriodOfStudy = periodOfStudy;
            InstituteShortName = instituteShortName;
        }

        /// <summary>
        /// codeOfDP - код напраления подготовки
        /// </summary>
        public string CodeOfDP
        {
            set
            {
                if (Regex.IsMatch(value, @"\d{2}.\d{2}.\d{2}", RegexOptions.IgnoreCase))
                    codeOfDP = value;
                else throw new ArgumentException("Код не соответствует маске задания кода");
            }

            get { return codeOfDP; }
        }
        /// <summary>
        /// nameOfDP - название напраления подготовки
        /// </summary>
        public string NameOfDP
        {
            set { nameOfDP = value; }
            get { return nameOfDP; }
        }
        /// <summary>
        /// periodOfStudy - период обучения
        /// </summary>
        public ushort PeriodOfStudy
        {
            set
            {
                if (value >= 1 && value <= 60)
                    periodOfStudy = value;
                else throw new ArgumentException("Значение Периода обучения находится в недопустимом интервале");
            }

            get { return periodOfStudy; }
        }

        /// <summary>
        /// Сокращенное название института, к которому относится направление подготовки
        /// </summary>
        public string InstituteShortName
        {
            get
            {
                return instituteShortName;
            }
            set
            {
                if (value == null || value == "")
                    throw new Exception("Поле сокращенное название иннститута пустое");
                instituteShortName = value;
            }
        }
    }
}
