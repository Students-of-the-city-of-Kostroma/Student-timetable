using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibOfTimetableOfClasses
{
    public abstract class Model
    {
        private Guid id;
        /// <summary>
        /// Возвращает или задает значение ID
        /// </summary>
        public Guid Id { get => id; set => id = value; }
        public Model()
        {
            Id = Guid.NewGuid();
        }
    }
}
