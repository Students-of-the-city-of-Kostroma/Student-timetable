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
    public class CDiscipline : DataTable,IController
    {
        public CDiscipline() : base("Дисциплина")
        {
            DataColumn column = new DataColumn();
            column.DataType = typeof(string);
            column.ColumnName = "Fullname";
            column.Unique = true;
            Columns.Add(column);

			column = new DataColumn();
			column.DataType = typeof(string);
			column.ColumnName = "Shortname";
			Columns.Add(column);

			column = new DataColumn();
			column.DataType = typeof(string);
			column.ColumnName = "CycleofDiscipline";
			Columns.Add(column);
		}

        public bool Delete(Model model)
        {
            MDiscipline mDiscipline = (MDiscipline)model;
			
            for (int i = 0; i < Rows.Count; i++)
            {
                if ((string)Rows[i]["Fullname"] == mDiscipline.Fullname 
				&& (string)Rows[i]["Shortname"] == mDiscipline.Shortname 
				&& (string)Rows[i]["CycleofDiscipline"] == mDiscipline.CycleofDiscipline)
				{
                    Rows[i].Delete();
                    return true;
                }
            }
            return false;
        }

        public bool Insert(Model model)
        {
			MDiscipline mDiscipline = (MDiscipline)model;
			
			if (mDiscipline.Fullname == null || mDiscipline.Shortname == null)
				return false;
				
			for (int i = 0; i < Rows.Count; i++)
            {
                if ((string)Rows[i]["Fullname"] == mDiscipline.Fullname 
				&& (string)Rows[i]["Shortname"] == mDiscipline.Shortname)
					return false;
            }
			
			try
            {
                DataRow newRow = NewRow();
                //newRow["ID"] = Guid.NewGuid();
                newRow["Fullname"] = mDiscipline.Fullname;
				newRow["Shortname"] = mDiscipline.Shortname;
				newRow["CycleofDiscipline"] = mDiscipline.CycleofDiscipline;
				Rows.Add(newRow);
                return true;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Source);
                return false;
            }
        }

        public bool Update(Model model)
        {
            MDiscipline mDiscipline = (MDiscipline)model;

			if ((mDiscipline.Fullname == null && mDiscipline.Shortname == null && mDiscipline.CycleofDiscipline == null))
				return false;

			for (int i = 0; i < Rows.Count; i++)
            {
				if ((string)Rows[i]["Fullname"] == mDiscipline.Fullname)
				{
					try
					{
						Rows[i].BeginEdit();
						Rows[i]["Shortname"] = mDiscipline.Shortname;
						Rows[i]["CycleofDiscipline"] = mDiscipline.CycleofDiscipline;
						Rows[i].EndEdit();
						Rows[i].AcceptChanges();
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

		public bool Update(DataRow row, Model model)
		{
			throw new NotImplementedException();
		}
	}
}
