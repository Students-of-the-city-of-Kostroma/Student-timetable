using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimetableOfClasses.DTO
{
    /// <summary>
    /// Объект с данными из CTrainingProfile (профиль подготовки университета)
    /// Используется для формирования списка групп 
    /// </summary>
    public class TrainingProfileDto
    {
        /// <summary>
        /// Шифр направления подготовки
        /// </summary>
        public string Code {get; set;}
        /// <summary>
        /// Краткое название профиля подготовки
        /// </summary>
        public string ShortName { get; set; }
    }
}
