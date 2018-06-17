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
        string cipher;
        byte population;
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
