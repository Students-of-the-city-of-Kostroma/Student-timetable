using System;
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
	public class CAcademicDegree : DataTable, IController
	{
		public CAcademicDegree() : base("Учёная степень")
		{

			DataColumn column = new DataColumn();
			column = new DataColumn();
			column.DataType = typeof(string);
			column.ColumnName = "FullName";
			column.Unique = true;
			this.Columns.Add(column);


			column = new DataColumn();
			column.DataType = typeof(string);
			column.ColumnName = "Reduction";
			column.Unique = true;
			this.Columns.Add(column);

		}

		public bool Delete(Model model)
		{
			MAcademicDegree mAcademicDegree = (MAcademicDegree)model;
			for (int i = 0; i < this.Rows.Count; i++)
			{
				if ((string)this.Rows[i]["FullName"] == mAcademicDegree.FullName && (string)this.Rows[i]["Reduction"] == mAcademicDegree.Reduction)
				{
					this.Rows[i].Delete();
					return true;
				}
			}
			return false;
		}

		private bool isValidKey(MAcademicDegree mAcademicDegree)
		{
			foreach (DataRow Row in this.Rows)
			{
				if (mAcademicDegree.FullName == (string)Row["FullName"])
					return false;
			}
			return true;
		}

		public bool Insert(Model model)
		{
			MAcademicDegree mAcademicDegree = (MAcademicDegree)model;

			if (isValidKey(mAcademicDegree))
			{
				try
				{
		
					DataRow newRow = this.NewRow();
					newRow["FullName"] = mAcademicDegree.FullName;
					newRow["Reduction"] = mAcademicDegree.Reduction;
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
			MAcademicDegree mAcademicDegree = (MAcademicDegree)model;
			if ((mAcademicDegree.FullName == null && mAcademicDegree.Reduction == null))
				return false;

			for (int i = 0; i < this.Rows.Count; i++)
			{
				if ((string)this.Rows[i]["Reduction"] == mAcademicDegree.Reduction)
				{
					try
					{
						this.Rows[i].BeginEdit();
						this.Rows[i]["Reduction"] = mAcademicDegree.Reduction;
						this.Rows[i]["FullName"] = mAcademicDegree.FullName;
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

