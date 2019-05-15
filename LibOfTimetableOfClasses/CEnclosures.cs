using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Diagnostics;

namespace LibOfTimetableOfClasses
{
	public class СEnclosures : DataTable, IController
	{
		public СEnclosures() : base("Корпус")
		{
			if (Controllers.СEnclosures != null) throw new Exception("Контроллер уже существует");

			DataColumn[] keys = new DataColumn[2];
			DataColumn column = new DataColumn();
			column.DataType = typeof(string);
			column.ColumnName = "Name";
			column.ReadOnly = true;
			this.Columns.Add(column);
			keys[0] = column;
			
			column = new DataColumn();
			column.DataType = typeof(string);
			column.ColumnName = "University";
			this.Columns.Add(column);
			keys[1] = column;

			column = new DataColumn();
			column.DataType = typeof(string);
			column.ColumnName = "Address";
			column.ReadOnly = false;
			this.Columns.Add(column);

			column = new DataColumn();
			column.DataType = typeof(string);
			column.ColumnName = "Phone";
			column.ReadOnly = false;
			this.Columns.Add(column);

			column = new DataColumn();
			column.DataType = typeof(string);
			column.ColumnName = "Comment";
			column.ReadOnly = false;
			this.Columns.Add(column);

			this.PrimaryKey = keys;
		}


		public bool Delete(Model model)

		{
			MEnclosures mEnclosures = (MEnclosures)model;
			for (int i = 0; i < this.Rows.Count; i++)
			{
				if ((string)this.Rows[i]["Name"] == mEnclosures.Name && (string)this.Rows[i]["University"] == mEnclosures.University)
				{
					this.Rows[i].Delete();
					return true;
				}
			}
			return false;
		}

		private bool isValidKey(MEnclosures mEnclosures)
		{
			foreach (DataRow row in this.Rows)
			{
				if ((string)row["Name"] == mEnclosures.Name && (string)row["University"] == mEnclosures.University)
					return false;
			}
			return true;
		}

		public bool Insert(Model model)
		{
			MEnclosures mEnclosures = (MEnclosures)model;

			if (isValidKey(mEnclosures))
			{
				try
				{

					DataRow newRow = this.NewRow();
					newRow["Name"] = mEnclosures.Name;
					newRow["University"] = mEnclosures.University;
					newRow["Address"] = mEnclosures.Address;
					newRow["Phone"] = mEnclosures.Phone;
					newRow["Comment"] = mEnclosures.Comment;
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
			MEnclosures mEnclosures = (MEnclosures)model;
			for (int i = 0; i < this.Rows.Count; i++)
			{
				if ((string)this.Rows[i]["Name"] == mEnclosures.Name && (string)this.Rows[i]["University"] == mEnclosures.University)
					try
					{
						DataRow newRow = this.Rows[i];
						newRow["Address"] = mEnclosures.Address;
						newRow["Phone"] = mEnclosures.Phone;
						newRow["Comment"] = mEnclosures.Comment;
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
