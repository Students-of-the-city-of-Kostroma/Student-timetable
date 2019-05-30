using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibOfTimetableOfClasses
{
	/// <summary>
	/// Абстракция реадизуюящая основной функционал управления данными
	/// </summary>
	public class Controller : DataTable
	{
		/// <summary>
		/// Создает таблицу с указаным именем
		/// </summary>
		/// <param name="tableName">Имя таблицы</param>

		public Controller(string tableName = "Controller")
			: base(tableName)
		{
			//DataTable table = new DataTable(tableName);
			DataColumn column = new DataColumn();
			column.DataType = typeof(Guid);
			column.ColumnName = "ID";
			column.ReadOnly = true;
			column.Unique = true;
			this.Columns.Add(column);
			DataSet.Tables.Add(this);
		}
		/// <summary>
		/// Удаление экземпляра из таблицы
		/// </summary>
		/// <param name="model">Удаляемый экземпляр</param>
		/// <returns>Вернет истину если удалось изменить экземпляр</returns>
		public bool Delete(Model model);

	}
}
