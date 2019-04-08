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
			DataColumn[] keys = new DataColumn[6];

			DataColumn column = new DataColumn();
			column = new DataColumn();
			column.DataType = typeof(string);
			column.ColumnName = "FullName";
			table.Columns.Add(column);
			keys[0] = column;

			column = new DataColumn();
			column.DataType = typeof(string);
			column.ColumnName = "Note";
			table.Columns.Add(column);
			keys[1] = column;

			column = new DataColumn();
			column.DataType = typeof(string);
			column.ColumnName = "Departament";
			table.Columns.Add(column);
			keys[2] = column;

			column = new DataColumn();
			column.DataType = typeof(string);
			column.ColumnName = "MetodicalDays";
			table.Columns.Add(column);
			keys[3] = column;

			column = new DataColumn();
			column.DataType = typeof(string);
			column.ColumnName = "Windows";
			table.Columns.Add(column);
			keys[4] = column;

			column = new DataColumn();
			column.DataType = typeof(string);
			column.ColumnName = "Weekends";
			table.Columns.Add(column);
			keys[5] = column;

			table.PrimaryKey = keys;
		}

		bool isValidKey(MTeacher mTeacher)
		{
			foreach(DataRow row in table.Rows)
			{
				if ((string)row["FullName"] == mTeacher.FullName && (string)row["Departament"] == mTeacher.Departament)
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
				if ((string)table.Rows[i]["FullName"] == mTeacher.FullName 
						&& (string)table.Rows[i]["Departament"] == mTeacher.Departament)
					try
					{
						DataRow newRow = table.Rows[i];
						newRow["FullName"] = mTeacher.FullName;
						newRow["Note"] = mTeacher.Note;
						newRow["Departament"] = mTeacher.Departament;
						newRow["MetodicalDays"] = mTeacher.MetodicalDays;
						newRow["Windows"] = mTeacher.Windows;
						newRow["Weekends"] = mTeacher.Weekends;
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
					//Recount(i);
					return true;
				}				
			}
			return false;
		}
	}
}
