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
			if (Controllers.CTeacher != null) throw new Exception("Контроллер уже существует");

			DataColumn column = new DataColumn();
			column = new DataColumn();
			column.DataType = typeof(string);
			column.ColumnName = "FullName";
			column.Unique = true;
			this.Columns.Add(column);

			column = new DataColumn();
			column.DataType = typeof(string);
			column.ColumnName = "AcademicDegree";
			this.Columns.Add(column);

			column = new DataColumn();
			column.DataType = typeof(string);
			column.ColumnName = "AcademicTitle";
			this.Columns.Add(column);

			column = new DataColumn();
			column.DataType = typeof(string);
			column.ColumnName = "Departament";
			this.Columns.Add(column);
			
			column = new DataColumn();
			column.DataType = typeof(string);
			column.ColumnName = "MetodicalDays";
			this.Columns.Add(column);
			
			column = new DataColumn();
			column.DataType = typeof(string);
			column.ColumnName = "Windows";
			this.Columns.Add(column);

			column = new DataColumn();
			column.DataType = typeof(string);
			column.ColumnName = "Weekends";
			this.Columns.Add(column);
		}

		bool isValidKey(MTeacher mTeacher)
		{
			foreach(DataRow row in this.Rows)
			{
				string fullName = mTeacher.SecondName + " " + mTeacher.FirstName + " " + mTeacher.Patronymic;
				if ((string)row["FullName"] == fullName )
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
					string fullName = mTeacher.SecondName + " " + mTeacher.FirstName + " " + mTeacher.Patronymic;
					DataRow newRow = this.NewRow();
					newRow["FullName"] = fullName;
					newRow["AcademicDegree"] = mTeacher.AcademicDegree;
					newRow["AcademicTitle"] = mTeacher.AcademicTitle;
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
			string fullName = mTeacher.SecondName + " " + mTeacher.FirstName + " " + mTeacher.Patronymic;
			for (int i = 0; i < this.Rows.Count; i++)
			{
				if ((string)this.Rows[i]["FullName"] == fullName)
					try
					{
						DataRow newRow = this.Rows[i];
						newRow["AcademicDegree"] = mTeacher.AcademicDegree;
						newRow["AcademicTitle"] = mTeacher.AcademicTitle;
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
			string fullName = mTeacher.SecondName + " " + mTeacher.FirstName + " " + mTeacher.Patronymic;
			for (int i = 0; i < this.Rows.Count; i++)
			{
				if ((string)this.Rows[i]["FullName"] == fullName && (string)this.Rows[i]["Departament"] == mTeacher.Departament)
				{
					this.Rows[i].Delete();
					//Recount(i);
					return true;
				}				
			}
			return false;
		}

	}
}
