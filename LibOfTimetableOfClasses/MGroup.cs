using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibOfTimetableOfClasses
{
    /// <summary>
    /// Группа
    /// </summary>
    public class MGroup : Model
    {

        string cipher;
        /// <summary>
        /// численность
        /// </summary>
        byte population;
        /// <summary>
        /// Создает экземпляр
        /// </summary>
        /// <param name="cipher">шифр</param>
        /// <param name="population">численность</param>
        public MGroup(string cipher, byte population):base()
        {
            Cipher = cipher;
            Population = population;
        }
		
        /// <summary>
        /// Возвращает или задает шифр группы
        /// </summary>
        public string Cipher
        {
            get
            {
                return cipher;
            }

            set
            {
                cipher = value;
            }
        }
        /// <summary>
        /// Возвращает или задает численность группы
        /// </summary>
        public byte Population
        {
            get
            {
                return population;
            }

            set
            {
                population = value;
            }
        }
    }
}
