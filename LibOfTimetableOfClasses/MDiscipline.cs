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
        /// Перечисление полей объекта модели Дисциплина
        /// </summary>
        public enum Keys { Id = 0, Name = 1, Code = 2 }

        /// <summary>
        /// Название дисциплины
        /// </summary>
        string name;
        /// <summary>
        /// Код дисциплины
        /// </summary>
        string code;
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
        /// Возвращает значение перечисления
        /// </summary>
        /// <param ключ="key"></param>
        /// <returns></returns>
        public object this[Keys key]
        {
            get
            {
                switch (key)
                {
                    case Keys.Id: return Id;
                    case Keys.Name: return Name;
                    case Keys.Code: return Code;
                    default: return null;
                }
            }
        }



        /// <summary>
        /// Возвращает или задает значение Name - название
        /// </summary>
        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        /// <summary>
        /// Возвращает или задает значение Code - код
        /// </summary>
        public string Code
        {
            get
            {
                return code;
            }

            set
            {
                code = value;
            }
        }

        
    }
}
