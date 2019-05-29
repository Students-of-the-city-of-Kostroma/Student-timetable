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
	/// Таблица со строками, хранящими данные о разных направлениях подготовки Университета.
	/// </summary>
	public class CDirectionOfPreparation : DataTable, IController
	{
		/// <summary>
		/// Конструктор таблицы
		/// Формируются поля таблицы типа DataTable и их свойства.
		/// Уникальность строки в таблице определяется уникальностью поля CodeOfDP
		/// </summary>
		public CDirectionOfPreparation() : base("Направление подготовки")
		{
			DataColumn column = new DataColumn();
			column.DataType = typeof(string);
			column.ColumnName = "CodeOfDP";
			column.Unique = true;
			Columns.Add(column);

			column = new DataColumn();
			column.DataType = typeof(string);
			column.ColumnName = "NameOfDP";
			Columns.Add(column);

			column = new DataColumn();
			column.DataType = typeof(ushort);
			column.ColumnName = "PeriodOfStudy";
			Columns.Add(column);
		}
		/// <summary>
		/// Метод удаления строки соответствующей переданной модели из таблицы CDirectionOfPreparation.
		/// В таблице CDirectionOfPreparation ищется строка с полем "NameOfDP" соответсвующим этому же полю модели, 
		/// переданной в качестве параметра.
		///	В случае успеха поиска удаляется найденная строка.
		/// </summary>
		/// <param name="model">Модель, хранящая выбранную строку в таблице</param>
		/// <returns>Результат удаления переданной строки из CDirectionOfPreparation</returns>
		public bool Delete(Model model)
		{
			MDirectionOfPreparation mDirectionOfPreparation = (MDirectionOfPreparation)model;

			for (int i = 0; i < Rows.Count; i++)
			{
				if ((string)Rows[i]["CodeOfDP"] == mDirectionOfPreparation.CodeOfDP
				&& (string)Rows[i]["NameOfDP"] == mDirectionOfPreparation.NameOfDP
				&& (ushort)Rows[i]["PeriodOfStudy"] == mDirectionOfPreparation.PeriodOfStudy)
				{
					Rows.Remove(Rows[i]);
					return true;
				}
			}
			return false;
		}
		/// <summary>
		/// Метод вставки переданной модели MDirectionOfPreparation в таблицу CDirectionOfPreparation
		/// в случае уникальности поля CodeOfDP
		/// </summary>
		/// <param name="model">Модель хранящая добавляемую запись таблицы</param>
		/// <returns>Результат вставки</returns>
		public bool Insert(Model model)
		{
			MDirectionOfPreparation mDirectionOfPreparation = (MDirectionOfPreparation)model;

			if (mDirectionOfPreparation.CodeOfDP == null || mDirectionOfPreparation.NameOfDP == null)
				return false;

			try
			{
				DataRow newRow = NewRow();
				newRow["CodeOfDP"] = mDirectionOfPreparation.CodeOfDP;
				newRow["NameOfDP"] = mDirectionOfPreparation.NameOfDP;
				newRow["PeriodOfStudy"] = mDirectionOfPreparation.PeriodOfStudy;
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
		/// Обновление свойств строки в таблице CDirectionOfPreparation из переданной модели MDirectionOfPreparation
		/// Поиск изменяемой строки CAuditor CDirectionOfPreparation по полю "NameOfDP"
		/// </summary>
		/// <param name="model">Модель хранящая обновляемую запись таблицы</param>
		/// <returns>Результат обновления</returns>
		public bool Update(Model model)
		{
			MDirectionOfPreparation mDirectionOfPreparation = (MDirectionOfPreparation)model;

			if (mDirectionOfPreparation.CodeOfDP == null || mDirectionOfPreparation.NameOfDP == null)
				return false;

			for (int i = 0; i < Rows.Count; i++)
			{
				if ((string)Rows[i]["CodeOfDP"] == mDirectionOfPreparation.CodeOfDP)
				{
					try
					{
						Rows[i].BeginEdit();
						Rows[i]["NameOfDP"] = mDirectionOfPreparation.NameOfDP;
						Rows[i]["PeriodOfStudy"] = mDirectionOfPreparation.PeriodOfStudy;
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
		/// Какая-то заглушка
		/// </summary>
		public bool Update(DataRow row, Model model)
		{
			throw new NotImplementedException();
		}
	}
}