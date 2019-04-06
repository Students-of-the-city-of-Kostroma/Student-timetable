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
    public class CAuditor : Controller,IController
    {

        public CAuditor() : base("Аудитория")
        {
            DataColumn[] keys = new DataColumn[2];
            DataColumn column = new DataColumn();
            column.DataType = typeof(string);
			column.ColumnName = "NameOfAuditor";
			column.ReadOnly = true;
            column.Unique = true;
            table.Columns.Add(column);
            keys[0] = column;

            column = new DataColumn();
			column.DataType = typeof(string);
			column.ColumnName = "Cafedra";
			column.ReadOnly = true;
            column.Unique = true;
            table.Columns.Add(column);

            column = new DataColumn();
			column.DataType = typeof(ushort);
			column.ColumnName = "Spacious";
			column.ReadOnly = true;
            column.Unique = true;
            table.Columns.Add(column);
			keys[1] = column;

			column = new DataColumn();
			column.DataType = typeof(byte);
			column.ColumnName = "Building";
			column.ReadOnly = true;
            column.Unique = true;
            table.Columns.Add(column);
			keys[1] = column;
			table.PrimaryKey = keys;
        }

        public override bool Insert(Model model)
        {
            MAuditor mAuditor = (MAuditor)model;
			if (mAuditor.NameOfAuditor == null)
				return false;

			 for (int i = 0; i < table.Rows.Count; i++)
				 if ((string)table.Rows[i]["NameOfAuditor"] == mAuditor.NameOfAuditor)
					  return false;

			try
			{
				DataRow newRow = table.NewRow();
				newRow["ID"] = Guid.NewGuid();
				newRow["NameOfAuditor"] = mAuditor.NameOfAuditor;
				newRow["Cafedra"] = mAuditor.Cafedra;
				newRow["Spacious"] = mAuditor.Spacious;
				newRow["Building"] = mAuditor.Building;
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
            MAuditor mAuditor = (MAuditor)model;
			
            for (int i = 0; i < table.Rows.Count; i++)
            {
                if ((Guid)table.Rows[i]["ID"] == mAuditor.Id && mAuditor.NameOfAuditor != null)
				{
                    try
                    {
                        table.Rows[i].BeginEdit();
                        table.Rows[i]["NameOfAuditor"] = mAuditor.NameOfAuditor;
						table.Rows[i]["Cafedra"] = mAuditor.Cafedra;
						table.Rows[i]["Spacious"] = mAuditor.Spacious;
						table.Rows[i]["Building"] = mAuditor.Building;
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
			MAuditor mAuditor = (MAuditor)model;

			for (int i = 0; i < table.Rows.Count; i++)
			{
				if ((string)table.Rows[i]["NameOfAuditor"] == mAuditor.NameOfAuditor && (byte)table.Rows[i]["Building"] == mAuditor.Building)
				{
					table.Rows[i].Delete();
					return true;
				}
			}
			return false;
		}
	}
}
