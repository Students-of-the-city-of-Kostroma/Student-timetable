using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibOfTimetableOfClasses
{
	public class СDirectionOfPreparation : DataTable, IController
	{
		public СDirectionOfPreparation() : base("Направление подготовки")
		{
			DataColumn column = new DataColumn();
			column.DataType = typeof(string);
			column.ColumnName = "CodeOfDP";
			column.Unique = true;
			Columns.Add(column);

			column = new DataColumn();
			column.DataType = typeof(string);
			column.ColumnName = "NameOfDP";
			Columns.Add(column);

			column = new DataColumn();
			column.DataType = typeof(ushort);
			column.ColumnName = "PeriodOfStudy";
			Columns.Add(column);
		}
		public bool Delete(Model model)
		{
			MDirectionOfPreparation mDirectionOfPreparation = (MDirectionOfPreparation)model;

			for (int i = 0; i < Rows.Count; i++)
			{
				if ((string)Rows[i]["CodeOfDP"] == mDirectionOfPreparation.CodeOfDP
				&& (string)Rows[i]["NameOfDP"] == mDirectionOfPreparation.NameOfDP
				&& (ushort)Rows[i]["PeriodOfStudy"] == mDirectionOfPreparation.PeriodOfStudy)
				{
					Rows.Remove(Rows[i]);
					return true;
				}
			}
			return false;
		}
		public bool Insert(Model model)
		{
			MDirectionOfPreparation mDirectionOfPreparation = (MDirectionOfPreparation)model;

			if (mDirectionOfPreparation.CodeOfDP == null || mDirectionOfPreparation.NameOfDP == null)
				return false;

			try
			{
				DataRow newRow = NewRow();
				newRow["CodeOfDP"] = mDirectionOfPreparation.CodeOfDP;
				newRow["NameOfDP"] = mDirectionOfPreparation.NameOfDP;
				newRow["PeriodOfStudy"] = mDirectionOfPreparation.PeriodOfStudy;
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
			MDirectionOfPreparation mDirectionOfPreparation = (MDirectionOfPreparation)model;

			if (mDirectionOfPreparation.CodeOfDP == null || mDirectionOfPreparation.NameOfDP == null)
				return false;

			for (int i = 0; i < Rows.Count; i++)
			{
				if ((string)Rows[i]["CodeOfDP"] == mDirectionOfPreparation.CodeOfDP)
				{
					try
					{
						Rows[i].BeginEdit();
						Rows[i]["NameOfDP"] = mDirectionOfPreparation.NameOfDP;
						Rows[i]["PeriodOfStudy"] = mDirectionOfPreparation.PeriodOfStudy;
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