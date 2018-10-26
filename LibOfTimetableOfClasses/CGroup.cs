using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibOfTimetableOfClasses
{
    public class CGroup : Controller
    {
        List<MGroup> groupList = new List<MGroup>();

        public CGroup() : base("Группа")
        {
            throw new NotImplementedException();
        }
        public override bool Delete(Model model)
        {
            foreach (MGroup m in groupList)
            {
                if(m.Id == model.Id)
                {
                    groupList.Remove(m);
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
