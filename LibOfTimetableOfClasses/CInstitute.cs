using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibOfTimetableOfClasses
{
	public class CInstitute : Controller, IController
	{
		public CInstitute() : base("Институт")
		{
			DataColumn[] keys = new DataColumn[3];

			DataColumn column = new DataColumn();
			column.DataType = typeof(string);
			column.ColumnName = "Краткое название института";
			column.Unique = true;
			table.Columns.Add(column);
			keys[0] = column;

			column = new DataColumn();
			column.DataType = typeof(string);
			column.ColumnName = "Полное название института";
			column.Unique = true;
			table.Columns.Add(column);
			keys[1] = column;

			column = new DataColumn();
			column.DataType = typeof(string);
			column.ColumnName = "Директор института";
			column.Unique = true;
			table.Columns.Add(column);
			keys[2] = column;

		}

		public override bool Delete(Model model)
		{
			MInstitute mInstitute = (MInstitute)model;
			for (int i = 0; i < table.Rows.Count; i++)
			{
				if ((string)table.Rows[i]["Краткое название института"] == mInstitute.ShortName
					&& (string)table.Rows[i]["Полное название института"] == mInstitute.FullName
					&& (string)table.Rows[i]["Директор института"] == mInstitute.Director)
				{
					table.Rows[i].Delete();
					return true;
				}
			}
			return false;
		}

		public override bool Insert(Model model)
		{
			try
			{
				MInstitute mInstitute = (MInstitute)model;
				DataRow newRow = table.NewRow();
				newRow["Краткое название института"] = mInstitute.ShortName;
				newRow["Полное название института"] = mInstitute.FullName;
				newRow["Директор института"] = mInstitute.Director;

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
			MInstitute mInstitute = (MInstitute)model;
			if (mInstitute.ShortName == null
				&& mInstitute.FullName == null
				&& mInstitute.Director == null)
				return false;

			for (int i = 0; i < this.table.Rows.Count; i++)
			{
				if ((string)this.table.Rows[i]["Краткое название института"] == mInstitute.ShortName)
				{
					try
					{
						this.table.Rows[i].BeginEdit();
						this.table.Rows[i]["Краткое название института"] = mInstitute.ShortName;
						this.table.Rows[i]["Полное название института"] = mInstitute.FullName;
						this.table.Rows[i]["Директор института"] = mInstitute.Director;
						this.table.Rows[i].EndEdit();
						this.table.Rows[i].AcceptChanges();
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
