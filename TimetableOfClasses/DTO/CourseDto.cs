using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimetableOfClasses
{
    /// <summary>
    /// Объект с данными из CDirectionOfPreparation (направление подгтовки)
    /// Используется для получения и отображения списка для выбора направления подготовки
    /// </summary>
    public class CourseDto
    {
        /// <summary>
        /// Идентификатор строки в списке
        /// </summary>
        public string ID { get; set; }
        /// <summary>
        /// Наименование направления подготовки
        /// </summary>
        public string NameOfDP { get; set; }
        /// <summary>
        /// Сокращенное название института, реализующего направление подготовки
        /// </summary>
        public string InstituteShortName { get; set; }
    }
}
