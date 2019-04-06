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
    public class CDiscipline : Controller,IController
    {
        public CDiscipline() : base("Дисциплина")
        {
            DataColumn column = new DataColumn();
            column.DataType = typeof(string);
            column.ColumnName = "Fullname";
            column.ReadOnly = true;
            column.Unique = true;
            table.Columns.Add(column);

			column = new DataColumn();
			column.DataType = typeof(string);
			column.ColumnName = "Shortname";
			column.ReadOnly = true;
			table.Columns.Add(column);

			column = new DataColumn();
			column.DataType = typeof(string);
			column.ColumnName = "CycleofDiscipline";
			column.ReadOnly = true;
			table.Columns.Add(column);
		}

        public override bool Delete(Model model)
        {
            MDiscipline mDiscipline = (MDiscipline)model;
			
            for (int i = 0; i < table.Rows.Count; i++)
            {
                if ((string)table.Rows[i]["Fullname"] == mDiscipline.Fullname 
				&& (string)table.Rows[i]["Shortname"] == mDiscipline.Shortname 
				&& (string)table.Rows[i]["CycleofDiscipline"] == mDiscipline.CycleofDiscipline)
				{
                    table.Rows[i].Delete();
                    return true;
                }
            }
            return false;
        }

        public override bool Insert(Model model)
        {
			MDiscipline mDiscipline = (MDiscipline)model;
			
			if (mDiscipline.Fullname == null || mDiscipline.Shortname == null)
				return false;
				
			for (int i = 0; i < table.Rows.Count; i++)
            {
                if ((string)table.Rows[i]["Fullname"] == mDiscipline.Fullname 
				&& (string)table.Rows[i]["Shortname"] == mDiscipline.Shortname)
					return false;
            }
			
			try
            {
                DataRow newRow = table.NewRow();
                newRow["ID"] = Guid.NewGuid();
                newRow["Fullname"] = mDiscipline.Fullname;
				newRow["Shortname"] = mDiscipline.Shortname;
				newRow["CycleofDiscipline"] = mDiscipline.CycleofDiscipline;
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
            MDiscipline mDiscipline = (MDiscipline)model;

			if ((mDiscipline.Fullname == null && mDiscipline.Shortname == null && mDiscipline.CycleofDiscipline == null))
				return false;

			for (int i = 0; i < table.Rows.Count; i++)
            {
				if ((string)table.Rows[i]["Fullname"] == mDiscipline.Fullname)
				{
					try
					{
						table.Rows[i].BeginEdit();
						table.Rows[i]["Fullname"] = mDiscipline.Fullname;
						table.Rows[i]["Shortname"] = mDiscipline.Shortname;
						table.Rows[i]["CycleofDis"] = mDiscipline.CycleofDiscipline;
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
