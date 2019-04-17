﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibOfTimetableOfClasses
{
	public class CTitle : Controller, IController
	{
		public CTitle() : base("Уч.звание")
		{

			DataColumn[] keys = new DataColumn[2];

			DataColumn column = new DataColumn();
			column.DataType = typeof(string);
			column.ColumnName = "Сокращенная запись уч. звания";
			column.ReadOnly = true;
			column.Unique = true;
			table.Columns.Add(column);
			keys[0] = column;


			column = new DataColumn();
			column.DataType = typeof(string);
			column.ColumnName = "Полная запись уч. звания";
			column.ReadOnly = true;
			table.Columns.Add(column);
			keys[1] = column;
		}

		public override bool Delete(Model model)
		{
			MTitle mTitle = (MTitle)model;
			for (int i = 0; i < table.Rows.Count; i++)
			{
				if ((string)table.Rows[i]["Полная запись уч. звания"] == mTitle.FullName && (string)table.Rows[i]["Сокращенная запись уч. звания"] == mTitle.Reduction)
				{
					table.Rows[i].Delete();
					return true;
				}
			}
			return false;
		}

		public override bool Insert(Model model)
		{
			try
			{
				MTitle mTitle = (MTitle)model;
				DataRow newRow = table.NewRow();
				newRow["Полная запись уч. звания"] = mTitle.FullName;
				newRow["Сокращенная запись уч. звания"] = mTitle.Reduction;
				table.Rows.Add(newRow);
				return true;
			}
			catch (Exception ex)
			{
				Debug.WriteLine(ex.Source);
				return false;
			}
		}

		public override bool Update(Model model)
		{
			MTitle mTitle = (MTitle)model;
			for (int i = 0; i < table.Rows.Count; i++)
			{
				if ((mTitle.FullName != null && mTitle.Reduction != null))
				{
					try
					{
						DataRow newRow = table.Rows[i];
						newRow["Полная запись уч. звания"] = mTitle.FullName;
						newRow["Сокращенная запись уч. звания"] = mTitle.Reduction;
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