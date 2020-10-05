using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimetableOfClasses
{
    /// <summary>
    /// Объект с данными из CGroup (Группы)
    /// Используется для получения и отображения списка с выбором групп 
    /// </summary>
    public class GroupDto
    {
        /// <summary>
        ///  Идентификатор строки в списке
        /// </summary>
        public string ID { get; set; }
        /// <summary>
        /// Наименование группы
        /// </summary>
        public string Group { get; set; }
        /// <summary>
        /// Специальность
        /// </summary>
        public string Speciality { get; set; }
        /// <summary>
        /// Шифр профиля подготовки
        /// </summary>
        public string Code { get; set; }
    }
}
