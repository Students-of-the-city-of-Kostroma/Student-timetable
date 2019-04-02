using System;
using System.Data;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibOfTimetableOfClasses
{
	public class CGroup : Controller, IController
	{
		public CGroup() : base("Группа")
		{
			DataColumn[] keys = new DataColumn[9];

			DataColumn column = new DataColumn();
			column.DataType = typeof(ushort);
			column.ColumnName = "Position";
			column.ReadOnly = false;
			column.Unique = true;
			table.Columns.Add(column);
			keys[0] = column;

			column = new DataColumn();
			column.DataType = typeof(string);
			column.ColumnName = "Group";
			column.Caption = "Группа";
			column.ReadOnly = true;
			column.Unique = true;
			table.Columns.Add(column);
			keys[1] = column;

			column = new DataColumn();
			column.DataType = typeof(ushort);
			column.ColumnName = "Semestr";
			column.Caption = "Семестр";
			column.ReadOnly = true;
			column.Unique = true;
			table.Columns.Add(column);
			keys[2] = column;

			column = new DataColumn();
			column.DataType = typeof(ushort);
			column.ColumnName = "Specialty";
			column.Caption = "Направление подготовки";
			column.ReadOnly = true;
			column.Unique = true;
			table.Columns.Add(column);
			keys[3] = column;

			column = new DataColumn();
			column.DataType = typeof(ushort);
			column.ColumnName = "Shift";
			column.Caption = "Семестр";
			column.ReadOnly = true;
			column.Unique = true;
			table.Columns.Add(column);
			keys[4] = column;

			column = new DataColumn();
			column.DataType = typeof(ushort);
			column.ColumnName = "Students";
			column.Caption = "Студентов";
			column.ReadOnly = true;
			column.Unique = true;
			table.Columns.Add(column);
			keys[5] = column;

			column = new DataColumn();
			column.DataType = typeof(ushort);
			column.ColumnName = "MinNumberOfClass";
			column.Caption = "Пар/день min";
			column.ReadOnly = true;
			column.Unique = true;
			table.Columns.Add(column);
			keys[6] = column;

			column = new DataColumn();
			column.DataType = typeof(ushort);
			column.ColumnName = "MaxNumberOfClass";
			column.Caption = "Пар/день max";
			column.ReadOnly = true;
			column.Unique = true;
			table.Columns.Add(column);
			keys[7] = column;

			column = new DataColumn();
			column.DataType = typeof(string);
			column.ColumnName = "Weekends";
			column.Caption = "Выходные";
			column.ReadOnly = true;
			column.Unique = true;
			table.Columns.Add(column);
			keys[8] = column;

			table.PrimaryKey = keys;
		}
		public override bool Delete(Model model)
		{
			MGroup mGroup = (MGroup)model;
			for (int i = 0; i < table.Rows.Count; i++)
			{
				if ((string)table.Rows[i]["Group"] == mGroup.Group)
				{
					table.Rows[i].Delete();
					Recount(i);
					return true;
				}
			}
			return false;
		}

		private void Recount(int pos)
		{
			for(int i = pos; i < table.Rows.Count; i++)
			{
				table.Rows[i]["Position"] = (ushort)table.Rows[i]["Position"] - 1;
			}
		}

		public override bool Insert(Model model)
		{
			MGroup mGroup = (MGroup)model;

			for (int i = 0; i <= table.Rows.Count; i++)
			{
				try
				{
					DataRow newRow = table.NewRow();
					newRow["ID"] = Guid.NewGuid();
					newRow["Position"] = table.Rows.Count+1;
					newRow["Group"] = mGroup.Group;
					newRow["Semestr"] = mGroup.Semester;
					newRow["Specialty"] = mGroup.Specialty;
					newRow["Shift"] = mGroup.Shift;
					newRow["Students"] = mGroup.Students;
					newRow["MinNumberOfClass"] = mGroup.MinNumberOfClass;
					newRow["MaxNumberOfClass"] = mGroup.MaxNumberOfClass;
					newRow["Weekends"] = mGroup.Weekends;
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

		public override bool Update(Model model)
		{
			MGroup mGroup = (MGroup)model;
			for (int i = 0; i < table.Rows.Count; i++)
			{

				try
				{
					table.Rows[i].BeginEdit();
					table.Rows[i]["Group"] = mGroup.Group;
					table.Rows[i]["Semestr"] = mGroup.Semester;
					table.Rows[i]["Specialty"] = mGroup.Specialty;
					table.Rows[i]["Shift"] = mGroup.Shift;
					table.Rows[i]["Students"] = mGroup.Students;
					table.Rows[i]["MinNumberOfClass"] = mGroup.MinNumberOfClass;
					table.Rows[i]["MaxNumberOfClass"] = mGroup.MaxNumberOfClass;
					table.Rows[i]["Weekends"] = mGroup.Weekends;
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
			return false;
		}
	}
}
