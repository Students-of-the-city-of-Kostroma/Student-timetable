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
        public CGroup() : base("Группа")
        {
            throw new NotImplementedException();
        }
        public override bool Delete(Model model)
        {
            MGroup mGroup = (MGroup)model;
            for (int i = 0; i < table.Rows.Count; i++)
            {
                if ((Guid)table.Rows[i]["ID"] == model.Id && mGroup.Cipher == (string)table.Rows[i]["cipher"])
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
