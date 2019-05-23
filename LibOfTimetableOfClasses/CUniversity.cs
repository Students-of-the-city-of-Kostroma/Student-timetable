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
		/// <summary>
		/// Контроллер для объекта ВУЗ
		/// </summary>
		public CUniversity() : base("ВУЗ")
		{

			if (Controllers.CUniversity != null) throw new Exception("Контроллер уже существует");

			DataColumn[] keys = new DataColumn[1];
			DataColumn column = new DataColumn();
			column.DataType = typeof(string);
			column.ColumnName = "INN";
			this.Columns.Add(column);
			keys[0] = column;

			column = new DataColumn();
			column.DataType = typeof(string);
			column.ColumnName = "ShortName";
			this.Columns.Add(column);

			column = new DataColumn();
			column.DataType = typeof(string);
			column.ColumnName = "FullName";
			this.Columns.Add(column);

			column = new DataColumn();
			column.DataType = typeof(string);
			column.ColumnName = "ActualAddress";
			this.Columns.Add(column);

			column = new DataColumn();
			column.DataType = typeof(string);
			column.ColumnName = "LegalAddress";
			this.Columns.Add(column);

			column = new DataColumn();
			column.DataType = typeof(string);
			column.ColumnName = "FullNameRector";
			this.Columns.Add(column);

			column = new DataColumn();
			column.DataType = typeof(string);
			column.ColumnName = "Email";
			this.Columns.Add(column);

			column = new DataColumn();
			column.DataType = typeof(string);
			column.ColumnName = "Phone";
			this.Columns.Add(column);

			this.PrimaryKey = keys;
		}

		/// <summary>
		/// Метод удаления строки ВУЗа из таблицы
		/// </summary>
		/// <param name="model">Модель с данными</param>
		/// <returns>Если удаление прошло успешно, то истина, иначе ложь</returns>
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
		/// <summary>
		/// Метод добавления строки ВУЗа в таблицу
		/// </summary>
		/// <param name="model">Модель с данными</param>
		/// <returns>Если добавление прошло успешно, то истина, иначе ложь</returns>
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
					newRow["FullNameRector"] =  mUniversity.SurnameRector + " " + mUniversity.NameRector + " " + mUniversity.MiddleNameRector;
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
		/// <summary>
		/// Метод обновления информации строки ВУЗа в таблице
		/// </summary>
		/// <param name="model">Модель с данными</param>
		/// <returns>Если изменение прошло успешно, то истина, иначе ложь</returns>
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
						newRow["FullNameRector"] = mUniversity.SurnameRector + " " + mUniversity.NameRector + " " + mUniversity.MiddleNameRector;
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
