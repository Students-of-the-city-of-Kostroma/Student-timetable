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
	/// Таблица со строками, хранящими данные об Ученых степенях
	/// </summary>
	public class CAcademicDegree : DataTable, IController
	{
		/// <summary>
		/// Конструктор таблицы.
		/// Формируются поля таблицы типа DataTable и их свойства.
		/// Уникальность строки в таблице определяется уникальностью поля FullName.
		/// </summary>
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

		/// <summary>
		/// Метод удаления строки соответствующей переданной модели из таблицы CAcademicDegree.
		/// В таблице CAcademicDegree ищется строка с полями "FullName" и "Reduction" соответсвующим этому же полю модели, 
		/// переданной в качестве параметра.
		///	В случае успеха поиска удаляется найденная строка. 
		/// </summary>
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

		/// <summary>
		/// Проверка начилия переданной модели в таблице CAcademicDegree.
		/// Наличие определяется наличием строки с полем "FullName" соответсвующим данным модели mAcademicDegree.
		/// </summary>
		private bool isValidKey(MAcademicDegree mAcademicDegree)
		{
			foreach (DataRow Row in this.Rows)
			{
				if (mAcademicDegree.FullName == (string)Row["FullName"])
					return false;
			}
			return true;
		}

		/// <summary>
		/// Метод добавления переданной модели MAcademicDegree в таблицу CAcademicDegree
		/// в случае уникальности свойства FullName модели для таблицы CAcademicDegree
		/// </summary>
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

		/// <summary>
		/// Обновление строки в таблице CAcademicDegree из переданной модели MAcademicDegree.
		/// Поиск изменяемой строки CTeacher осуществляется по полю "FullName"
		/// </summary>
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
	}
}

