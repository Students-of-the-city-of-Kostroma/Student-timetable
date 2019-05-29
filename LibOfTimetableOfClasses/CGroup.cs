using System;
using System.Data;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibOfTimetableOfClasses
{
	public class CGroup : DataTable, IController
	{
		public CGroup() : base("Группа")
		{

			if (Controllers.CGroup != null) throw new Exception("Контроллер уже существует");

			DataColumn column = new DataColumn();
			column.DataType = typeof(string);
			column.ColumnName = "Group";
			column.Unique = true;
			this.Columns.Add(column);

			column = new DataColumn();
			column.DataType = typeof(ushort);
			column.ColumnName = "Semestr";
			this.Columns.Add(column);

			column = new DataColumn();
			column.DataType = typeof(string);
			column.ColumnName = "Specialty";
			this.Columns.Add(column);

			column = new DataColumn();
			column.DataType = typeof(ushort);
			column.ColumnName = "Shift";
			this.Columns.Add(column);

			column = new DataColumn();
			column.DataType = typeof(ushort);
			column.ColumnName = "Students";
			this.Columns.Add(column);

			column = new DataColumn();
			column.DataType = typeof(ushort);
			column.ColumnName = "MinNumberOfClass";
			this.Columns.Add(column);

			column = new DataColumn();
			column.DataType = typeof(ushort);
			column.ColumnName = "MaxNumberOfClass";
			this.Columns.Add(column);

			column = new DataColumn();
			column.DataType = typeof(string);
			column.ColumnName = "Weekends";
			this.Columns.Add(column);
		}


		public bool Delete(Model model)

		{
			MGroup mGroup = (MGroup)model;
			for (int i = 0; i < this.Rows.Count; i++)
			{
				if ((string)this.Rows[i]["Group"] == mGroup.Group)
				{

					this.Rows[i].Delete();

					return true;
				}
			}
			return false;
		}

		private bool isValidKey(MGroup mGroup)
		{
			foreach (DataRow Row in this.Rows)
			{
				if (mGroup.Group == (string)Row["Group"])
					return false;					
			}
			return true;
		}

		public bool Insert(Model model)
		{
			MGroup mGroup = (MGroup)model;

			if (isValidKey(mGroup))
			{
				try
				{

					DataRow newRow = this.NewRow();
					newRow["Group"] = mGroup.Group;
					newRow["Semestr"] = mGroup.Semester;
					newRow["Specialty"] = mGroup.Specialty;
					newRow["Shift"] = mGroup.Shift;
					newRow["Students"] = mGroup.Students;
					newRow["MinNumberOfClass"] = mGroup.MinNumberOfClass;
					newRow["MaxNumberOfClass"] = mGroup.MaxNumberOfClass;
					newRow["Weekends"] = mGroup.Weekends;
					this.Rows.Add(newRow);
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

		public bool Update(Model model)
		{
			MGroup mGroup = (MGroup)model;

				for (int i = 0; i < this.Rows.Count; i++)
				{

					if (mGroup.Group == (string)this.Rows[i]["Group"])
					{
						try
						{
							DataRow newRow = this.Rows[i];
							newRow["Semestr"] = mGroup.Semester;
							newRow["Specialty"] = mGroup.Specialty;
							newRow["Shift"] = mGroup.Shift;
							newRow["Students"] = mGroup.Students;
							newRow["MinNumberOfClass"] = mGroup.MinNumberOfClass;
							newRow["MaxNumberOfClass"] = mGroup.MaxNumberOfClass;
							newRow["Weekends"] = mGroup.Weekends;
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
