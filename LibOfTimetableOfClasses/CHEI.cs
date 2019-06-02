using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Diagnostics;

namespace LibOfTimetableOfClasses
{/// <summary>
/// ВУЗ
/// </summary>
	public class CHEI : DataTable, IController
	{
		public CHEI() : base("ВУЗ")
		{
			DataColumn[] keys = new DataColumn[5];
			DataColumn column = new DataColumn();
			column.DataType = typeof(string);
			column.ColumnName = "FullName";
			column.ReadOnly = true;
			Columns.Add(column);
			keys[0] = column;
			PrimaryKey = keys;

			column = new DataColumn();
			column.DataType = typeof(string);
			column.ColumnName = "AbbreviatedName";
			column.ReadOnly = true;
			Columns.Add(column);
			keys[1] = column;

			column = new DataColumn();
			column.DataType = typeof(string);
			column.ColumnName = "Rector";
			column.ReadOnly = true;
			Columns.Add(column);
			keys[2] = column;

			column = new DataColumn();
			column.DataType = typeof(int);
			column.ColumnName = "Phone";
			column.ReadOnly = true;
			Columns.Add(column);

			column = new DataColumn();
			column.DataType = typeof(string);
			column.ColumnName = "Email";
			column.ReadOnly = true;
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

		public bool Update(DataRow row, Model model)
		{
			throw new NotImplementedException();
		}
	}
}
