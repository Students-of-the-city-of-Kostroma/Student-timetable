using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibOfTimetableOfClasses
{
    public class MGroup
    {
        Guid id;
        /// <summary>
        /// шифр
        /// </summary>
        string cipher;
        /// <summary>
        /// численность
        /// </summary>
        byte population;
        /// <summary>
        /// Возвращает или задает идентификатор id
        /// </summary>
        public Guid Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }
        /// <summary>
        /// Возвращает или задает cipher
        /// </summary>
        public string Сipher
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
        /// Возвращает или задает population
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
