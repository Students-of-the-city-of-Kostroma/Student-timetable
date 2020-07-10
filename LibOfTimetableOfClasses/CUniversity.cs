using System;
using System.Data;
using System.Diagnostics;

namespace LibOfTimetableOfClasses
{
    public class CUniversity : DataTable, IController
    {
        /// <summary>
        /// Контроллер для объекта ВУЗ
        /// </summary>
        public CUniversity() : base("ВУЗ")
        {
            DataColumn[] keys = new DataColumn[1];
            DataColumn column = new DataColumn
            {
                DataType = typeof(string),
                ColumnName = "INN",
                Unique = true
            };
            this.Columns.Add(column);
            keys[0] = column;

            column = new DataColumn
            {
                DataType = typeof(string),
                ColumnName = "ShortName"
            };
            this.Columns.Add(column);

            column = new DataColumn
            {
                DataType = typeof(string),
                ColumnName = "FullName",
                Unique = true
            };
            this.Columns.Add(column);

            column = new DataColumn
            {
                DataType = typeof(string),
                ColumnName = "ActualAddress"
            };
            this.Columns.Add(column);

            column = new DataColumn
            {
                DataType = typeof(string),
                ColumnName = "LegalAddress"
            };
            this.Columns.Add(column);

            column = new DataColumn
            {
                DataType = typeof(string),
                ColumnName = "FullNameRector"
            };
            this.Columns.Add(column);

            column = new DataColumn
            {
                DataType = typeof(string),
                ColumnName = "Email",
                Unique = true
            };
            this.Columns.Add(column);

            column = new DataColumn
            {
                DataType = typeof(string),
                ColumnName = "Phone",
                Unique = true
            };
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

        /// <summary>
        /// Метод добавления строки ВУЗа в таблицу
        /// </summary>
        /// <param name="model">Модель с данными</param>
        /// <returns>Если добавление прошло успешно, то истина, иначе ложь</returns>
        public bool Insert(Model model)
        {
            MUniversity mUniversity = (MUniversity)model;

            try
            {

                DataRow newRow = this.NewRow();
                newRow["INN"] = mUniversity.INN;
                newRow["ShortName"] = mUniversity.ShortName;
                newRow["FullName"] = mUniversity.FullName;
                newRow["ActualAddress"] = mUniversity.ActualAddress;
                newRow["LegalAddress"] = mUniversity.LegalAddress;
                newRow["FullNameRector"] = mUniversity.SurnameRector + " " + mUniversity.NameRector + " " + mUniversity.MiddleNameRector;
                newRow["Email"] = mUniversity.Email;
                newRow["Phone"] = mUniversity.Phone;
                this.Rows.Add(newRow);
                return true;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                return false;
            }
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
                        Debug.WriteLine(ex.Message);
                        return false;
                    }
            }
            return false;
        }
    }
}