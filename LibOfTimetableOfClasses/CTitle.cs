﻿	using System;
	using System.Collections.Generic;
	using System.Data;
	using System.Diagnostics;
	using System.Linq;
	using System.Text;
	using System.Threading.Tasks;

namespace LibOfTimetableOfClasses
{
	/// <summary>
	/// Контроллер объекта Добавление ученого звания
	/// </summary>


	public class CTitle : DataTable, IController
	{
		public CTitle() : base("Уч.звание")
		{
			DataColumn column = new DataColumn();
			column.DataType = typeof(string);
			column.ColumnName = "Reduction";
			column.Unique = true;
			this.Columns.Add(column);
			
			column = new DataColumn();
			column.DataType = typeof(string);
			column.ColumnName = "FullName";
			column.Unique = true;
			this.Columns.Add(column);

		}

		public bool Delete(Model model)
		{
			MTitle mTitle = (MTitle)model;
			for (int i = 0; i < this.Rows.Count; i++)
			{
				if ((string)this.Rows[i]["FullName"] == mTitle.FullName && (string)this.Rows[i]["Reduction"] == mTitle.Reduction)
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
				MTitle mTitle = (MTitle)model;
				DataRow newRow = this.NewRow();
				newRow["FullName"] = mTitle.FullName;
				newRow["Reduction"] = mTitle.Reduction;
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
			MTitle mTitle = (MTitle)model;
			if ((mTitle.FullName == null && mTitle.Reduction == null))
				return false;


			for (int i = 0; i < this.Rows.Count; i++)
			{
				if ((string)this.Rows[i]["Reduction"] == mTitle.Reduction)
				{
					try
					{
						this.Rows[i].BeginEdit();
						this.Rows[i]["Reduction"] = mTitle.Reduction;
						this.Rows[i]["FullName"] = mTitle.FullName;
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

		public bool Update(DataRow row, Model model)
		{
			throw new NotImplementedException();
		}
	}
}
