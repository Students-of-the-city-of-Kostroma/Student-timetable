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
	/// Таблица со строками, хранящими данные о разных учебных группах в Университете
	/// </summary>
	public class CGroup : DataTable, IController
	{
		/// <summary>
		/// Конструктор таблицы
		/// Формируются поля таблицы типа DataTable и их свойства.
		/// Уникальность строки в таблице определяется уникальностью поля Group.
		/// </summary>
		public CGroup() : base("Группа")
		{

			if (Controllers.CGroup != null) throw new Exception("Контроллер уже существует");

			DataColumn column = new DataColumn();
			column.DataType = typeof(string);
			column.ColumnName = "Group";
			column.Unique = true;
			this.Columns.Add(column);

			column = new DataColumn();
			column.DataType = typeof(ushort);
			column.ColumnName = "Semestr";
			this.Columns.Add(column);

			column = new DataColumn();
			column.DataType = typeof(string);
			column.ColumnName = "Specialty";
			this.Columns.Add(column);

			column = new DataColumn();
			column.DataType = typeof(ushort);
			column.ColumnName = "Shift";
			this.Columns.Add(column);

			column = new DataColumn();
			column.DataType = typeof(ushort);
			column.ColumnName = "Students";
			this.Columns.Add(column);

			column = new DataColumn();
			column.DataType = typeof(ushort);
			column.ColumnName = "MinNumberOfClass";
			this.Columns.Add(column);

			column = new DataColumn();
			column.DataType = typeof(ushort);
			column.ColumnName = "MaxNumberOfClass";
			this.Columns.Add(column);

			column = new DataColumn();
			column.DataType = typeof(string);
			column.ColumnName = "Weekends";
			this.Columns.Add(column);
		}

		/// <summary>
		/// Метод удаления строки соответствующей переданной модели из таблицы CGroup.
		/// В таблице CGroup ищется строка с полем "Group" соответсвующим этому же полю модели, 
		/// переданной в качестве параметра.
		///	В случае успеха поиска удаляется найденная строка. 
		/// </summary>
		/// <param name="model">Модель, выбранной строки в таблице</param>
		/// <returns>Результат удаления переданной строки из CGroup</returns>
		public bool Delete(Model model)

		{
			MGroup mGroup = (MGroup)model;
			for (int i = 0; i < this.Rows.Count; i++)
			{
				if ((string)this.Rows[i]["Group"] == mGroup.Group)
				{

					this.Rows[i].Delete();

					return true;
				}
			}
			return false;
		}

		/// <summary>
		/// Проверка начилия переданной модели в таблице CGroup
		/// Наличие определяется наличием строки CGroup с полем "Group" соответсвующим свойству "Group" модели mGroup.
		/// </summary>
		/// <param name="mGroup">Проверяеммая модель группы</param>
		/// <returns>Результат проверки наличия(true - не найдено, false - найдено)</returns>
		private bool isValidKey(MGroup mGroup)
		{
			foreach (DataRow Row in this.Rows)
			{
				if (mGroup.Group == (string)Row["Group"])
					return false;					
			}
			return true;
		}


		/// <summary>
		/// Метод вставки переданной модели MGroup в таблицу CGroup
		/// в случае уникальности свойства Group модели для таблицы CGroup
		/// </summary>
		/// <param name="model">Вставляемая в CGroup модель</param>
		/// <returns>Результат вставки</returns>
		public bool Insert(Model model)
		{
			MGroup mGroup = (MGroup)model;

			if (isValidKey(mGroup))
			{
				try
				{

					DataRow newRow = this.NewRow();
					newRow["Group"] = mGroup.Group;
					newRow["Semestr"] = mGroup.Semester;
					newRow["Specialty"] = mGroup.Specialty;
					newRow["Shift"] = mGroup.Shift;
					newRow["Students"] = mGroup.Students;
					newRow["MinNumberOfClass"] = mGroup.MinNumberOfClass;
					newRow["MaxNumberOfClass"] = mGroup.MaxNumberOfClass;
					newRow["Weekends"] = mGroup.Weekends;
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
		/// Обновление свойств строки в таблице CGroup из переданной модели MGroup
		/// Поиск изменяемой строки CGroup осуществляется по полю "Group"
		/// </summary>
		/// <param name="model"></param>
		/// <returns></returns>
		public bool Update(Model model)
		{
			MGroup mGroup = (MGroup)model;

				for (int i = 0; i < this.Rows.Count; i++)
				{

					if (mGroup.Group == (string)this.Rows[i]["Group"])
					{
						try
						{
							DataRow newRow = this.Rows[i];
							newRow["Semestr"] = mGroup.Semester;
							newRow["Specialty"] = mGroup.Specialty;
							newRow["Shift"] = mGroup.Shift;
							newRow["Students"] = mGroup.Students;
							newRow["MinNumberOfClass"] = mGroup.MinNumberOfClass;
							newRow["MaxNumberOfClass"] = mGroup.MaxNumberOfClass;
							newRow["Weekends"] = mGroup.Weekends;
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
