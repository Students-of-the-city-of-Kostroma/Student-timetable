﻿ using System;
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
			DataColumn[] keys = new DataColumn[8];

			DataColumn column = new DataColumn();
			
			column = new DataColumn();
			column.DataType = typeof(string);
			column.ColumnName = "Group";
			table.Columns.Add(column);
			keys[0] = column;

			column = new DataColumn();
			column.DataType = typeof(ushort);
			column.ColumnName = "Semestr";
			table.Columns.Add(column);
			keys[1] = column;

			column = new DataColumn();
			column.DataType = typeof(string);
			column.ColumnName = "Specialty";
			table.Columns.Add(column);
			keys[2] = column;

			column = new DataColumn();
			column.DataType = typeof(ushort);
			column.ColumnName = "Shift";
			table.Columns.Add(column);
			keys[3] = column;

			column = new DataColumn();
			column.DataType = typeof(ushort);
			column.ColumnName = "Students";
			table.Columns.Add(column);
			keys[4] = column;

			column = new DataColumn();
			column.DataType = typeof(ushort);
			column.ColumnName = "MinNumberOfClass";
			table.Columns.Add(column);
			keys[5] = column;

			column = new DataColumn();
			column.DataType = typeof(ushort);
			column.ColumnName = "MaxNumberOfClass";
			table.Columns.Add(column);
			keys[6] = column;

			column = new DataColumn();
			column.DataType = typeof(string);
			column.ColumnName = "Weekends";
			table.Columns.Add(column);
			keys[7] = column;

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
					return true;
				}
			}
			return false;
		}

		private bool isValidKey(MGroup mGroup)
		{
			foreach (DataRow Row in table.Rows)
			{
				if (mGroup.Group == (string)Row["Group"])
				{
					if (mGroup.Specialty == (string)Row["Specialty"])
					{
						if (mGroup.Semester == (ushort)Row["Semestr"])
							return false;
					}
					else return false;
				}		
			}
			return true;
		}


		public override bool Insert(Model model)
		{
			MGroup mGroup = (MGroup)model;

			if (isValidKey(mGroup))
			{
				try
				{
					DataRow newRow = table.NewRow();
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

					if (mGroup.Group == (string)table.Rows[i]["Group"] 
					&& mGroup.Specialty == (string)table.Rows[i]["Specialty"]
					&& mGroup.Semester == (ushort) table.Rows[i]["Semestr"])
					{
						try
						{
							DataRow newRow = table.Rows[i];
							newRow["Group"] = mGroup.Group;
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
