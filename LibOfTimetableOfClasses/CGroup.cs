using System;
using System.Data;
using System.Diagnostics;
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
            DataColumn[] keys = new DataColumn[1];
            DataColumn column = new DataColumn();
            column.DataType = typeof(byte);
            column.ColumnName = "population";
            column.ReadOnly = true;
            column.Unique = true;
            table.Columns.Add(column);

            column = new DataColumn();
            column.DataType = typeof(string);
            column.ColumnName = "cipher";
            column.ReadOnly = true;
            column.Unique = true;
            table.Columns.Add(column);
            keys[0] = column;
            table.PrimaryKey = keys;
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
            MGroup mGroup = (MGroup)model;
            for (int i = 0; i < table.Rows.Count; i++)
            {
                if ((Guid)table.Rows[i]["ID"] == model.Id && mGroup.Cipher != null)
                {
                    try
                    {
                        table.Rows[i].BeginEdit();
                        table.Rows[i]["cipher"] = mGroup.Cipher;
                        table.Rows[i]["population"] = mGroup.Population;
                        table.Rows[i].EndEdit();
                        table.Rows[i].AcceptChanges();
                        return true;
                    }
                    catch (Exception ex)
                    {
                        Debug.WriteLine(ex.Source);
                        return false;
                    }
                }
            }
            return false;
        }
    }
}
