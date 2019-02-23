using System;
using System.Data;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibOfTimetableOfClasses
{
    /// <summary>
    /// Контроллер объекта Аудитория.
    /// </summary>
    public class CAuditor : Controller
    {

        public CAuditor() : base("Аудитория")
        {
            DataColumn[] keys = new DataColumn[2];
            DataColumn column = new DataColumn();
            column.DataType = typeof(string);
            column.ColumnName = "number";
            column.ReadOnly = true;
            column.Unique = true;
            table.Columns.Add(column);
            keys[0] = column;

            column = new DataColumn();
            column.DataType = typeof(byte);
            column.ColumnName = "floor";
            column.ReadOnly = true;
            column.Unique = true;
            table.Columns.Add(column);

            column = new DataColumn();
            column.DataType = typeof(string);
            column.ColumnName = "building";
            column.ReadOnly = true;
            column.Unique = true;
            table.Columns.Add(column);
            keys[1] = column;

            column = new DataColumn();
            column.DataType = typeof(int);
            column.ColumnName = "spacious";
            column.ReadOnly = true;
            column.Unique = true;
            table.Columns.Add(column);
            table.PrimaryKey = keys;
        }

        public override bool Insert(Model model)
        {
            MAuditor mAuditor = (MAuditor)model;
            if (mAuditor.Number != null && mAuditor.Building != null)
            {
                for (int i = 0; i < table.Rows.Count; i++)
                    if ((string)table.Rows[i]["Number"] != mAuditor.Number && (string)table.Rows[i]["Building"] != mAuditor.Building)
                    {
                        try
                        {
                            DataRow newRow = table.NewRow();
                            newRow["ID"] = Guid.NewGuid();
                            newRow["Number"] = mAuditor.Number;
                            newRow["Building"] = mAuditor.Building;
                            newRow["Floor"] = mAuditor.Floor;
                            newRow["Spacious"] = mAuditor.Spacious;
                            table.Rows.Add(newRow);
                            return true;
                        }
                        catch (Exception ex)
                        {
                            Debug.WriteLine(ex.Source);
                            return false;
                        }
                    }
                return false;
            }
            return false;
        }

        public override bool Update(Model model)
        {
            MAuditor mAuditor = (MAuditor)model;
            for (int i = 0; i < table.Rows.Count; i++)
            {
                if ((Guid)table.Rows[i]["ID"] == mAuditor.Id && mAuditor.Number != null && mAuditor.Building != null)
                {
                    try
                    {
                        table.Rows[i].BeginEdit();
                        table.Rows[i]["ID"] = mAuditor.Id;
                        table.Rows[i]["Number"] = mAuditor.Number;
                        table.Rows[i]["Floor"] = mAuditor.Floor;
                        table.Rows[i]["Building"] = mAuditor.Building;
                        table.Rows[i]["Spacious"] = mAuditor.Spacious;
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

        public override bool Delete(Model model)
        {
            throw new NotImplementedException();
        }
    }
}
