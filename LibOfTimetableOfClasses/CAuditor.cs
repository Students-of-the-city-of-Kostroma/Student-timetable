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
    public class CAuditor :DataTable,IController
    {

        public CAuditor() : base("Аудитория")
        {
            DataColumn[] keys = new DataColumn[2];
            DataColumn column = new DataColumn();
            column.DataType = typeof(string);
			column.ColumnName = "NameOfAuditor";
            column.Unique = false;
            Columns.Add(column);
            keys[0] = column;

            column = new DataColumn();
			column.DataType = typeof(string);
			column.ColumnName = "Cafedra";
            column.Unique = false;
            Columns.Add(column);

            column = new DataColumn();
			column.DataType = typeof(ushort);
			column.ColumnName = "Spacious";
            column.Unique = false;
            Columns.Add(column);

			column = new DataColumn();
			column.DataType = typeof(byte);
			column.ColumnName = "Building";
            column.Unique = false;
            Columns.Add(column);
			keys[1] = column;
			PrimaryKey = keys;
        }

        public  bool Insert(Model model)
        {
            MAuditor mAuditor = (MAuditor)model;
			if (mAuditor.NameOfAuditor == null)
				return false;

			try
			{
				DataRow newRow = NewRow();
				//newRow["ID"] = Guid.NewGuid();
				newRow["NameOfAuditor"] = mAuditor.NameOfAuditor;
				newRow["Cafedra"] = mAuditor.Cafedra;
				newRow["Spacious"] = mAuditor.Spacious;
				newRow["Building"] = mAuditor.Building;
				Rows.Add(newRow);
				return true;
			}
			catch (Exception ex)
			{
				Debug.WriteLine(ex.Source);
				return false;
			}
        }

        public  bool Update(Model model)
        {
            MAuditor mAuditor = (MAuditor)model;

			if (mAuditor.NameOfAuditor == null)
				return false;

			for (int i = 0; i < Rows.Count; i++)
            {
				if ((string)Rows[i]["NameOfAuditor"] == mAuditor.NameOfAuditor
					&& (byte)Rows[i]["Building"] == mAuditor.Building)
				{
					try
					{
						Rows[i].BeginEdit();
						Rows[i]["Cafedra"] = mAuditor.Cafedra;
						Rows[i]["Spacious"] = mAuditor.Spacious;
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

        public  bool Delete(Model model)
        {
			MAuditor mAuditor = (MAuditor)model;

			for (int i = 0; i < Rows.Count; i++)
			{
				if ((string)Rows[i]["NameOfAuditor"] == mAuditor.NameOfAuditor 
					&& (byte)Rows[i]["Building"] == mAuditor.Building)
				{
					Rows.Remove(Rows[i]);
					return true;
				}
			}
			return false;
		}
    }
}
