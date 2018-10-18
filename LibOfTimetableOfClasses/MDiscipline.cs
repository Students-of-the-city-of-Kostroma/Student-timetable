using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibOfTimetableOfClasses
{
    /// <summary>
    /// Дисциплина
    /// </summary>
     public class MDiscipline : Model
    {
        /// <summary>
        /// Название дисциплины
        /// </summary>
        protected string name;
        /// <summary>
        /// Код дисциплины
        /// </summary>
        protected string code;
        /// <summary>
        /// Создает экземпляр дисциплины
        /// </summary>
        /// <param name="name">Название дисциплины</param>
        /// <param name="code">Код дисциплины</param>
        public MDiscipline(string name, string code):base()
        {
            Name = name;
            Code = code;
        }

        /// <summary>
        /// Возвращает или задает значение Name - название
        /// </summary>
        public string Name { set => name = value; get => name; }

        /// <summary>
        /// Возвращает или задает значение Code - код
        /// </summary>
        public string Code { set => code = value; get => code; }
    }
}
