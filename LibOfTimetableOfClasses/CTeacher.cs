using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Diagnostics;

namespace LibOfTimetableOfClasses
{
	public class CTeacher : DataTable, IController
	{
		public CTeacher() : base("Учитель")
		{
			DataColumn[] keys = new DataColumn[6];

			DataColumn column = new DataColumn();
			column = new DataColumn();
			column.DataType = typeof(string);
			column.ColumnName = "FullName";
			this.Columns.Add(column);
			keys[0] = column;

			column = new DataColumn();
			column.DataType = typeof(string);
			column.ColumnName = "Note";
			this.Columns.Add(column);
			keys[1] = column;

			column = new DataColumn();
			column.DataType = typeof(string);
			column.ColumnName = "Departament";
			this.Columns.Add(column);
			keys[2] = column;

			column = new DataColumn();
			column.DataType = typeof(string);
			column.ColumnName = "MetodicalDays";
			this.Columns.Add(column);
			keys[3] = column;

			column = new DataColumn();
			column.DataType = typeof(string);
			column.ColumnName = "Windows";
			this.Columns.Add(column);
			keys[4] = column;

			column = new DataColumn();
			column.DataType = typeof(string);
			column.ColumnName = "Weekends";
			this.Columns.Add(column);
			keys[5] = column;

			this.PrimaryKey = keys;
		}

		bool isValidKey(MTeacher mTeacher)
		{
			foreach(DataRow row in this.Rows)
			{
				if ((string)row["FullName"] == mTeacher.FullName && (string)row["Departament"] == mTeacher.Departament)
					return false;
			}
			return true;
		}
		
		public bool Insert(Model model)
		{
			MTeacher mTeacher = (MTeacher)model;
			if (isValidKey(mTeacher))
			{
				try
				{
					DataRow newRow = this.NewRow();
					newRow["FullName"] = mTeacher.FullName;
					newRow["Note"] = mTeacher.Note;
					newRow["Departament"] = mTeacher.Departament;
					newRow["MetodicalDays"] = mTeacher.MetodicalDays;
					newRow["Windows"] = mTeacher.Windows;
					newRow["Weekends"] = mTeacher.Weekends;
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
			MTeacher mTeacher = (MTeacher)model;
			for (int i = 0; i < this.Rows.Count; i++)
			{
				if ((string)this.Rows[i]["FullName"] == mTeacher.FullName 
						&& (string)this.Rows[i]["Departament"] == mTeacher.Departament)
					try
					{
						DataRow newRow = this.Rows[i];
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
		

		public bool Delete(Model model)
		{
			MTeacher mTeacher = (MTeacher)model;
			for (int i = 0; i < this.Rows.Count; i++)
			{
				if ((string)this.Rows[i]["FullName"] == mTeacher.FullName && (string)this.Rows[i]["Departament"] == mTeacher.Departament)
				{
					this.Rows[i].Delete();
					//Recount(i);
					return true;
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
