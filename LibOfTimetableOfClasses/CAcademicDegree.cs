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
	/// Контроллер Добавления учёной степени
	/// </summary>
	/// 
	public class CAcademicDegree : Controller, IController
	{
		public CAcademicDegree() : base("Учёная степень")
		{

			DataColumn[] keys = new DataColumn[2];

			DataColumn column = new DataColumn();
			column.DataType = typeof(string);
			column.ColumnName = "Сокращенная запись учёной степени";
			column.Unique = true;
			table.Columns.Add(column);
			keys[0] = column;


			column = new DataColumn();
			column.DataType = typeof(string);
			column.ColumnName = "Полная запись учёной степени";
			column.Unique = true;
			table.Columns.Add(column);
			keys[1] = column;
		}

		public override bool Delete(Model model)
		{
			MAcademicDegree mAcademicDegree = (MAcademicDegree)model;
			for (int i = 0; i < table.Rows.Count; i++)
			{
				if ((string)table.Rows[i]["Полная запись учёной степени"] == mAcademicDegree.FullName && (string)table.Rows[i]["Сокращенная запись учёной степени"] == mAcademicDegree.Reduction)
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
				MAcademicDegree MAcademicDegree = (MAcademicDegree)model;
				DataRow newRow = table.NewRow();
				newRow["Полная запись учёной степени"] = MAcademicDegree.FullName;
				newRow["Сокращенная запись учёной степени"] = MAcademicDegree.Reduction;
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
			MAcademicDegree MAcademicDegree = (MAcademicDegree)model;
			if ((MAcademicDegree.FullName == null && MAcademicDegree.Reduction == null))
				return false;

			for (int i = 0; i < this.table.Rows.Count; i++)
			{
				if ((string)this.table.Rows[i]["Сокращенная запись учёной степени"] == MAcademicDegree.Reduction)
				{
					try
					{
						this.table.Rows[i].BeginEdit();
						this.table.Rows[i]["Сокращенная запись учёной степени"] = MAcademicDegree.Reduction;
						this.table.Rows[i]["Полная запись учёной степени"] = MAcademicDegree.FullName;
						this.table.Rows[i].EndEdit();
						this.table.Rows[i].AcceptChanges();
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

