using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibOfTimetableOfClasses
{
    interface IController
    {
        bool Delete(Model model);
        bool Insert(Model model);
        bool Update(Model model);
	}
}
