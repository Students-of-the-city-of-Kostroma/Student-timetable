using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibOfTimetableOfClasses
{
	public class CInstitute : DataTable, IController
	{
		public CInstitute() : base("Институт")
		{
			DataColumn[] keys = new DataColumn[4];

			DataColumn column = new DataColumn();

			column.DataType = typeof(string);
			column.ColumnName = "Краткое название института";
			column.Unique = true;
			this.Columns.Add(column);
			keys[0] = column;

			column = new DataColumn();
			column.DataType = typeof(string);
			column.ColumnName = "Полное название института";
			this.Columns.Add(column);
			keys[1] = column;

			column = new DataColumn();
			column.DataType = typeof(string);
			column.ColumnName = "Директор института";
			this.Columns.Add(column);
			keys[2] = column;

			column = new DataColumn();
			column.DataType = typeof(string);
			column.ColumnName = "ВУЗ";
			this.Columns.Add(column);
			keys[3] = column;

		}

		public bool Delete(Model model)
		{
			MInstitute mInstitute = (MInstitute)model;
			for (int i = 0; i < this.Rows.Count; i++)
			{
				if ((string)this.Rows[i]["Краткое название института"] == mInstitute.ShortName
					&& (string)this.Rows[i]["Полное название института"] == mInstitute.FullName
					&& (string)this.Rows[i]["Директор института"] == mInstitute.Director
					&& (string)this.Rows[i]["ВУЗ"] == mInstitute.VUS)
				{
					this.Rows[i].Delete();
					return true;
				}
			}
			return false;
		}

		public bool Insert(Model model)
		{
			try
			{
				MInstitute mInstitute = (MInstitute)model;
				DataRow newRow = this.NewRow();
				newRow["Краткое название института"] = mInstitute.ShortName;
				newRow["Полное название института"] = mInstitute.FullName;
				newRow["Директор института"] = mInstitute.Director;
				newRow["ВУЗ"] = mInstitute.VUS;
				this.Rows.Add(newRow);
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
			MInstitute mInstitute = (MInstitute)model;
			if (mInstitute.ShortName == null
				&& mInstitute.FullName == null
				&& mInstitute.Director == null
				&& mInstitute.VUS == null)
				return false;

			for (int i = 1; i < this.Rows.Count; i++)
			{
				if ((string)this.Rows[i]["Краткое название института"] == mInstitute.ShortName)
				{
					try
					{
						this.Rows[i].BeginEdit();
						this.Rows[i]["Краткое название института"] = mInstitute.ShortName;
						this.Rows[i]["Полное название института"] = mInstitute.FullName;
						this.Rows[i]["Директор института"] = mInstitute.Director;
						this.Rows[i]["ВУЗ"] = mInstitute.VUS;
						this.Rows[i].EndEdit();
						this.Rows[i].AcceptChanges();
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
