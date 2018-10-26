using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibOfTimetableOfClasses
{
    public class CGroup : Controller
    {
        //List<MGroup> groupList = new List<MGroup>();

        public CGroup() : base("Группа")
        {
            throw new NotImplementedException();
        }
        public override bool Delete(Model model)
        {
            DataTable table = Select();

            for (int i = 0; i < table.Rows.Count; i++)
            {
                if ((Guid)table.Rows[i][0] == model.Id)
                {
                    table.Rows[i].Delete();
                    return true;
                }
            }
            return false;
        }

        public override bool Insert(Model model)
        {
            throw new NotImplementedException();
        }

        public override bool Update(Model model)
        {
            throw new NotImplementedException();
        }
    }
}
