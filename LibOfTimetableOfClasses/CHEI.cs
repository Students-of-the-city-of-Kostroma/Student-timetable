using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Diagnostics;

namespace LibOfTimetableOfClasses
{
	/// <summary>
	/// ВУЗ
	/// </summary>
	public class CHEI : DataTable, IController
	{
		public CHEI() : base("ВУЗ")
		{
			DataColumn[] keys = new DataColumn[5];
			DataColumn column = new DataColumn
			{
				DataType = typeof(string),
				ColumnName = "FullName",
				ReadOnly = true
			};
			Columns.Add(column);
			keys[0] = column;
			PrimaryKey = keys;

			column = new DataColumn
			{
				DataType = typeof(string),
				ColumnName = "AbbreviatedName",
				ReadOnly = true
			};
			Columns.Add(column);
			keys[1] = column;

			column = new DataColumn
			{
				DataType = typeof(string),
				ColumnName = "Rector",
				ReadOnly = true
			};
			Columns.Add(column);
			keys[2] = column;

			column = new DataColumn
			{
				DataType = typeof(int),
				ColumnName = "Phone",
				ReadOnly = true
			};
			Columns.Add(column);

			column = new DataColumn
			{
				DataType = typeof(string),
				ColumnName = "Email",
				ReadOnly = true
			};
			Columns.Add(column);

		}

		public bool Delete(Model model)
		{
			throw new NotImplementedException();
		}

		public bool Insert(Model model)
		{
			try
			{
				MCHEI mCHEI = (MCHEI)model;
				DataRow newRow = NewRow();
				newRow["FullName"] = mCHEI.FullName;
				newRow["AbbreviatedName"] = mCHEI.AbbreviatedName;
				newRow["Rector"] = mCHEI.Rector;
				newRow["Phone"] = mCHEI.Phone;
				newRow["Email"] = mCHEI.Email;
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
			throw new NotImplementedException();
		}
	}
}
