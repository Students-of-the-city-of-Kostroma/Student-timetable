using System;
using System.Data;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibOfTimetableOfClasses
{
	/// <summary>
	/// Таблица со строками, хранящими данные о разных аудиториях Университета.
	/// </summary>
	public class CAuditor : DataTable, IController
	{
		/// <summary>
		/// Конструктор таблицы
		/// Формируются поля таблицы типа DataTable и их свойства.
		/// Уникальность строки в таблице определяется уникальностью поля NameOfAuditor
		/// </summary>
		public CAuditor() : base("Аудитория")
		{
			DataColumn[] keys = new DataColumn[2];
			DataColumn column = new DataColumn
			{
				DataType = typeof(string),
				ColumnName = "NameOfAuditor",
				Unique = false
			};
			Columns.Add(column);
			keys[0] = column;

			column = new DataColumn
			{
				DataType = typeof(string),
				ColumnName = "Cafedra",
				Unique = false
			};
			Columns.Add(column);

			column = new DataColumn
			{
				DataType = typeof(ushort),
				ColumnName = "Spacious",
				Unique = false
			};
			Columns.Add(column);

			column = new DataColumn
			{
				DataType = typeof(string),
				ColumnName = "Building",
				Unique = false
			};
			Columns.Add(column);
			keys[1] = column;
			PrimaryKey = keys;
		}
		/// <summary>
		/// Метод вставки переданной модели MAuditor в таблицу CAuditor
		/// в случае уникальности поля NameOfAuditor
		/// </summary>
		/// <param name="model">Модель хранящая добавляемую запись таблицы</param>
		/// <returns>Результат вставки</returns>
		public bool Insert(Model model)
		{
			MAuditor mAuditor = (MAuditor)model;
			if (mAuditor.NameOfAuditor == null)
				return false;

			try
			{
				DataRow newRow = NewRow();
				newRow["NameOfAuditor"] = mAuditor.NameOfAuditor;
				newRow["Cafedra"] = mAuditor.Cafedra;
				newRow["Spacious"] = mAuditor.Spacious;
				newRow["Building"] = mAuditor.Building;
				Rows.Add(newRow);
				return true;
			}
			catch (Exception ex)
			{
				Debug.WriteLine(ex.Source);
				return false;
			}
		}
		/// <summary>
		/// Обновление свойств строки в таблице CAuditor из переданной модели MAuditor
		/// Поиск изменяемой строки CAuditor осуществляется по полю "NameOfAuditor"
		/// </summary>
		/// <param name="model">Модель хранящая обновляемую запись таблицы</param>
		/// <returns>Результат обновления</returns>
		public bool Update(Model model)
		{
			MAuditor mAuditor = (MAuditor)model;

			if (mAuditor.NameOfAuditor == null)
				return false;

			for (int i = 0; i < Rows.Count; i++)
			{
				if ((string)Rows[i]["NameOfAuditor"] == mAuditor.NameOfAuditor)
				
				{
					try
					{
						Rows[i].BeginEdit();
						Rows[i]["Cafedra"] = mAuditor.Cafedra;
						Rows[i]["Spacious"] = mAuditor.Spacious;
						Rows[i].EndEdit();
						Rows[i].AcceptChanges();

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
		/// <summary>
		/// Метод удаления строки соответствующей переданной модели из таблицы CAuditor.
		/// В таблице CAuditor ищется строка с полем "NameOfAuditor" соответсвующим этому же полю модели, 
		/// переданной в качестве параметра.
		///	В случае успеха поиска удаляется найденная строка.
		/// </summary>
		/// <param name="model">Модель, хранящая выбранную строку в таблице</param>
		/// <returns>Результат удаления переданной строки из CAuditor</returns>
		public bool Delete(Model model)
		{
			MAuditor mAuditor = (MAuditor)model;

			for (int i = 0; i < Rows.Count; i++)
			{
				if ((string)Rows[i]["NameOfAuditor"] == mAuditor.NameOfAuditor)
			
				{
					Rows.Remove(Rows[i]);
					return true;
				}
			}
			return false;
		}
	}
}
