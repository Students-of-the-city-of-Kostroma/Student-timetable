using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibOfTimetableOfClasses
{
    public interface Controller
    {

        void Insert(Model model);
        void Update(Model model);
        void Delete(Model model);
        string[,] Select();
        string[,] Select(string columnName, bool order);
    }
}
