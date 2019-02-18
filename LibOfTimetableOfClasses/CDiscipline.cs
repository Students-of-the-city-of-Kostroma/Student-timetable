using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibOfTimetableOfClasses
{
    /// <summary>
    /// Контроллер для объекта Дисциплина
    /// </summary>
    public class CDiscipline : Controller
    {
        public CDiscipline() : base("Дисциплина")
        {
            DataColumn column = new DataColumn();
            column.DataType = typeof(string);
            column.ColumnName = "Name";
            column.ReadOnly = true;
            column.Unique = true;
            table.Columns.Add(column);

            column = new DataColumn();
            column.DataType = typeof(string);
            column.ColumnName = "Code";
            column.ReadOnly = true;
            table.Columns.Add(column);
        }

        public override bool Delete(Model model)
        {
            throw new NotImplementedException();
        }

        public override bool Insert(Model model)
        {
            try
            {
                MDiscipline mDiscipline = (MDiscipline)model;
                DataRow newRow = table.NewRow();
                newRow["ID"] = Guid.NewGuid();
                newRow["Name"] = mDiscipline.Name;
                newRow["Code"] = mDiscipline.Code;
                table.Rows.Add(newRow);
                return true;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Source);
                return false;
            }
        }

        public override bool Update(Model model)
        {
            MGroup mDiscipline = (MGroup)model;
            for (int i = 0; i < table.Rows.Count; i++)
            {
                if ((Guid)table.Rows[i]["ID"] == mDiscipline.Id)
                {
                    if ((mDiscipline.Population != 0 && mDiscipline.Cipher != null ))
                    {
                        try
                        {
                            table.Rows[i].BeginEdit();
                            table.Rows[i]["ID"] = mDiscipline.Id;
                            table.Rows[i]["Population"] = mDiscipline.Population;
                            table.Rows[i]["Cipher"] = mDiscipline.Cipher;
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
            }
            return false;
        }
    }
}
