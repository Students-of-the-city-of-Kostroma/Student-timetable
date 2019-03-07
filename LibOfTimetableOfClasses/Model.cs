using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibOfTimetableOfClasses
{
    /// <summary>
    /// Хранит только идентификатор
    /// </summary>
    public abstract class Model
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        protected Guid id;
        /// <summary>
        /// Идентификатор
        /// </summary>
        public Guid Id { get { return id; } }
        /// <summary>
        /// Инициализирует идентификатор
        /// </summary>
        public Model()
        {
            id = Guid.NewGuid();
        }
    }
}
