using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Diagnostics;

namespace LibOfTimetableOfClasses
{
	public class CTeacher : Controller, IController
	{
		public CTeacher() : base("Учитель")
		{
			DataColumn[] keys = new DataColumn[7];

			DataColumn column = new DataColumn();
			column.DataType = typeof(ushort);
			column.ColumnName = "Number";
			column.ReadOnly = false;
			table.Columns.Add(column);
			keys[0] = column;

			column = new DataColumn();
			column.DataType = typeof(string);
			column.ColumnName = "FullName";
			column.ReadOnly = true;
			table.Columns.Add(column);
			keys[1] = column;

			column = new DataColumn();
			column.DataType = typeof(string);
			column.ColumnName = "Note";
			column.ReadOnly = true;
			table.Columns.Add(column);
			keys[2] = column;

			column = new DataColumn();
			column.DataType = typeof(string);
			column.ColumnName = "Departament";
			column.ReadOnly = true;
			table.Columns.Add(column);
			keys[3] = column;

			column = new DataColumn();
			column.DataType = typeof(string);
			column.ColumnName = "MetodicalDays";
			column.ReadOnly = true;
			table.Columns.Add(column);
			keys[4] = column;

			column = new DataColumn();
			column.DataType = typeof(string);
			column.ColumnName = "Windows";
			column.ReadOnly = true;
			table.Columns.Add(column);
			keys[5] = column;

			column = new DataColumn();
			column.DataType = typeof(string);
			column.ColumnName = "Weekends";
			column.ReadOnly = true;
			table.Columns.Add(column);
			keys[6] = column;

			table.PrimaryKey = keys;
		}

		bool isValidKey(MTeacher mTeacher)
		{
			foreach(DataRow row in table.Rows)
			{
				if ((string)row["FullName"] == mTeacher.FullName && (string)row["Note"] == mTeacher.Note && (string)row["Departament"] == mTeacher.Departament)
					return false;
			}
			return true;
		}
		
		public override bool Insert(Model model)
		{
			MTeacher mTeacher = (MTeacher)model;
			if (isValidKey(mTeacher))
			{
				try
				{
					DataRow newRow = table.NewRow();
					newRow["ID"] = Guid.NewGuid();
					newRow["Number"] = table.Rows.Count + 1;
					newRow["FullName"] = mTeacher.FullName;
					newRow["Note"] = mTeacher.Note;
					newRow["Departament"] = mTeacher.Departament;
					newRow["MetodicalDays"] = mTeacher.MetodicalDays;
					newRow["Windows"] = mTeacher.Windows;
					newRow["Weekends"] = mTeacher.Weekends;
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
			MTeacher mTeacher = (MTeacher)model;
			for (int i = 0; i < table.Rows.Count; i++)
			{
				try
				{
					table.Rows[i].BeginEdit();
					table.Rows[i]["FullName"] = mTeacher.FullName;
					table.Rows[i]["Note"] = mTeacher.Note;
					table.Rows[i]["Departament"] = mTeacher.Departament;
					table.Rows[i]["MetodicalDays"] = mTeacher.MetodicalDays;
					table.Rows[i]["Windows"] = mTeacher.Windows;
					table.Rows[i]["Weekends"] = mTeacher.Weekends;
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

		public override bool Delete(Model model)
		{
			MTeacher mTeacher = (MTeacher)model;
			for (int i = 0; i < table.Rows.Count; i++)
			{
				if ((string)table.Rows[i]["FullName"] == mTeacher.FullName && (string)table.Rows[i]["Departament"] == mTeacher.Departament)
				{
					table.Rows[i].Delete();
					Recount(i);
					return true;
				}				
			}
			return false;
		}

		private void Recount(int k)
		{
			for ( int i = k; i < table.Rows.Count; i++)
			{
				table.Rows[i]["Number"] = (ushort)table.Rows[i]["Number"] - 1;
			}
		}
	}
}
