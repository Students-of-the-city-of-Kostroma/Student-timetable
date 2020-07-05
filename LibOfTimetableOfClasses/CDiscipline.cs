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
	/// Таблица со строками, хранящими данные о разных дисциплинах Университета.
	/// </summary>
	public class CDiscipline : DataTable,IController
    {
		/// <summary>
		/// Конструктор таблицы
		/// Формируются поля таблицы типа DataTable и их свойства.
		/// Уникальность строки в таблице определяется уникальностью поля Fullname
		/// </summary>
		public CDiscipline() : base("Дисциплина")
        {
			DataColumn column = new DataColumn
			{
				DataType = typeof(string),
				ColumnName = "Fullname",
				Unique = true
			};
			Columns.Add(column);

			column = new DataColumn
			{
				DataType = typeof(string),
				ColumnName = "Shortname"
			};
			Columns.Add(column);

			column = new DataColumn
			{
				DataType = typeof(string),
				ColumnName = "CycleofDiscipline"
			};
			Columns.Add(column);
		}
		/// <summary>
		/// Метод удаления строки соответствующей переданной модели из таблицы CDiscipline.
		/// В таблице CDiscipline ищется строка с полем "Fullname" соответсвующим этому же полю модели, 
		/// переданной в качестве параметра.
		///	В случае успеха поиска удаляется найденная строка.
		/// </summary>
		/// <param name="model">Модель, хранящая выбранную строку в таблице</param>
		/// <returns>Результат удаления переданной строки из CDiscipline</returns>
		public bool Delete(Model model)
        {
            MDiscipline mDiscipline = (MDiscipline)model;
			
            for (int i = 0; i < Rows.Count; i++)
            {
                if ((string)Rows[i]["Fullname"] == mDiscipline.Fullname 
				&& (string)Rows[i]["Shortname"] == mDiscipline.Shortname 
				&& (string)Rows[i]["CycleofDiscipline"] == mDiscipline.CycleofDiscipline)
				{
					Rows.Remove(Rows[i]);
					return true;
                }
            }
            return false;
        }
		/// <summary>
		/// Метод вставки переданной модели MDiscipline в таблицу CDiscipline
		/// в случае уникальности поля Fullname
		/// </summary>
		/// <param name="model">Модель хранящая добавляемую запись таблицы</param>
		/// <returns>Результат вставки</returns>
		public bool Insert(Model model)
        {
			MDiscipline mDiscipline = (MDiscipline)model;
			
			if (mDiscipline.Fullname.Length == mDiscipline.Shortname.Length || mDiscipline.Fullname == null || mDiscipline.Shortname == null)
				return false;
				
			for (int i = 0; i < Rows.Count; i++)
            {
                if ((string)Rows[i]["Fullname"] == mDiscipline.Fullname 
				&& (string)Rows[i]["Shortname"] == mDiscipline.Shortname)
					return false;
            }
			
			try
            {
                DataRow newRow = NewRow();
                //newRow["ID"] = Guid.NewGuid();
                newRow["Fullname"] = mDiscipline.Fullname;
				newRow["Shortname"] = mDiscipline.Shortname;
				newRow["CycleofDiscipline"] = mDiscipline.CycleofDiscipline;
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
		/// Обновление свойств строки в таблице CDiscipline из переданной модели MDiscipline
		/// Поиск изменяемой строки CAuditor осуществляется по полю "Fullname"
		/// </summary>
		/// <param name="model">Модель хранящая обновляемую запись таблицы</param>
		/// <returns>Результат обновления</returns>
		public bool Update(Model model)
        { // 0
            MDiscipline mDiscipline = (MDiscipline)model; // 1

			if ((mDiscipline.Fullname == null && mDiscipline.Shortname == null && mDiscipline.CycleofDiscipline == null)) // 2
				return false; // 3

			for (int i = 0; i < Rows.Count; i++) // 4
            {
				if ((string)Rows[i]["Fullname"] == mDiscipline.Fullname) // 5
				{
					
						Rows[i].BeginEdit(); // 6
						Rows[i]["Shortname"] = mDiscipline.Shortname; // 7
						Rows[i]["CycleofDiscipline"] = mDiscipline.CycleofDiscipline; // 8
						Rows[i].EndEdit(); // 9
						Rows[i].AcceptChanges(); // 10
						return true; // 11
					
				}
            }
            return false; // 12
        } // 13
	}
}
