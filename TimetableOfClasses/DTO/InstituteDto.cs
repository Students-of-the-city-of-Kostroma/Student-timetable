using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimetableOfClasses
{
    /// <summary>
    /// Объект с данными из CInstitute (институты)
    /// Используется для получения и отображения списка для выбора института
    /// </summary>
    public class InstituteDto
    {
        /// <summary>
        /// Идентификатор строки
        /// </summary>
        public string ID { get; set; }
        /// <summary>
        /// Полное наименование института
        /// </summary>
        public string FullName { get; set; }

    }
}
