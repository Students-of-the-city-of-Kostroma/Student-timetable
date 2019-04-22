using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibOfTimetableOfClasses
{
	public class CUniversity : DataTable, IController
	{
		public CUniversity() : base("ВУЗ")
		{
			DataColumn[] keys = new DataColumn[1];
			DataColumn column = new DataColumn();
			column.DataType = typeof(string);
			column.ColumnName = "INN";
			column.ReadOnly = true;
			this.Columns.Add(column);
			keys[0] = column;

			column = new DataColumn();
			column.DataType = typeof(string);
			column.ColumnName = "ShortName";
			column.ReadOnly = true;
			this.Columns.Add(column);

			column = new DataColumn();
			column.DataType = typeof(string);
			column.ColumnName = "FullName";
			column.ReadOnly = false;
			this.Columns.Add(column);

			column = new DataColumn();
			column.DataType = typeof(string);
			column.ColumnName = "ActualAddress";
			column.ReadOnly = false;
			this.Columns.Add(column);

			column = new DataColumn();
			column.DataType = typeof(string);
			column.ColumnName = "LegalAddress";
			column.ReadOnly = false;
			this.Columns.Add(column);

			column = new DataColumn();
			column.DataType = typeof(string);
			column.ColumnName = "FullNameRector";
			column.ReadOnly = false;
			this.Columns.Add(column);

			column = new DataColumn();
			column.DataType = typeof(string);
			column.ColumnName = "Email";
			column.ReadOnly = false;
			this.Columns.Add(column);

			column = new DataColumn();
			column.DataType = typeof(string);
			column.ColumnName = "Phone";
			column.ReadOnly = false;
			this.Columns.Add(column);

			this.PrimaryKey = keys;
		}


		public bool Delete(Model model)

		{
			MUniversity mUniversity = (MUniversity)model;
			for (int i = 0; i < this.Rows.Count; i++)
			{
				if ((string)this.Rows[i]["INN"] == mUniversity.INN)
				{
					this.Rows[i].Delete();
					return true;
				}
			}
			return false;
		}

		private bool isValidKey(MUniversity mUniversity)
		{
			foreach (DataRow row in this.Rows)
			{
				if ((string)row["INN"] == mUniversity.INN)
					return false;
			}
			return true;
		}

		public bool Insert(Model model)
		{
			MUniversity mUniversity = (MUniversity)model;

			if (isValidKey(mUniversity))
			{
				try
				{

					DataRow newRow = this.NewRow();
					newRow["INN"] = mUniversity.INN;
					newRow["ShortName"] = mUniversity.ShortName;
					newRow["FullName"] = mUniversity.FullName;
					newRow["ActualAddress"] = mUniversity.ActualAddress;
					newRow["LegalAddress"] = mUniversity.LegalAddress;
					newRow["FullNameRector"] = mUniversity.FullName + " " + mUniversity.SurnameRector + " " + mUniversity.MiddleNameRector;
					newRow["Email"] = mUniversity.Email;
					newRow["Phone"] = mUniversity.Phone;
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
			MUniversity mUniversity = (MUniversity)model;
			for (int i = 0; i < this.Rows.Count; i++)
			{
				if ((string)this.Rows[i]["INN"] == mUniversity.INN)
					try
					{
						DataRow newRow = this.Rows[i];
						newRow["ShortName"] = mUniversity.ShortName;
						newRow["FullName"] = mUniversity.FullName;
						newRow["ActualAddress"] = mUniversity.ActualAddress;
						newRow["LegalAddress"] = mUniversity.LegalAddress;
						newRow["FullNameRector"] = mUniversity.FullName + " " + mUniversity.SurnameRector + " " + mUniversity.MiddleNameRector;
						newRow["Email"] = mUniversity.Email;
						newRow["Phone"] = mUniversity.Phone;
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
