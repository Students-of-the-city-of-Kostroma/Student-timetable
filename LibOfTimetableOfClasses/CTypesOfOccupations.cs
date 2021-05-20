using System;
using System.Data;
using System.Diagnostics;

namespace LibOfTimetableOfClasses
{
    /// <summary>
    /// Контроллер для объекта Вид занятия
    /// </summary>
    public class CTypesOfOccupations : DataTable, IController
    {
        public CTypesOfOccupations() : base("Вид занятия")
        {
            DataColumn column = new DataColumn(); //Создание таблицы
            column.DataType = typeof(string); // Стоблцы имеют формат строки
            column.ColumnName = "FullName"; // Имя стоблца Ф.И.О
            column.Unique = true; //Уникальный пользователь
            Columns.Add(column); //Дабавление в таблицу

            column = new DataColumn(); //Создание нового обекта типа столбца
            column.DataType = typeof(string); //Стоблцы имеют формат строки
            column.ColumnName = "ShortName";// Имя стоблца Ф.И
            Columns.Add(column); //Дабавление в таблицу
        }



        public bool Delete(Model model) //Булевское удаление 
        {
            MTypesOfOccupations mTypesofOccupations = (MTypesOfOccupations)model; //отделение инициализации данных класса

            for (int i = 0; i < Rows.Count; i++) //проверяем строки
            {
                if ((string)Rows[i]["FullName"] == mTypesofOccupations.FullName 
                && (string)Rows[i]["ShortName"] == mTypesofOccupations.ShortName) //Проверка на корректность строки
                {
                    Rows[i].Delete(); //Удаление строки при истине
                    return true;
                }
            }
            return false;
        }

        public bool Insert(Model model)//добавление 
        {
            MTypesOfOccupations mTypesOfOccupations = (MTypesOfOccupations)model;//отделение инициализации данных класса

            if (mTypesOfOccupations.FullName == null || mTypesOfOccupations.ShortName == null) //Проверка на существование объекта
                return false;

            for (int i = 0; i < Rows.Count; i++)//проверяем строки
            {
                if ((string)Rows[i]["FullName"] == mTypesOfOccupations.FullName
                && (string)Rows[i]["ShortName"] == mTypesOfOccupations.ShortName) //если строки присутвуют не нужно удаление 
                    return false;
            }

            try
            {
                DataRow newRow = NewRow(); //Новая строка
                //newRow["ID"] = Guid.NewGuid();
                newRow["FullName"] = mTypesOfOccupations.FullName;// новая строка с Ф.И.О
                newRow["ShortName"] = mTypesOfOccupations.ShortName;// новая строка с Ф.И
                Rows.Add(newRow);//дабавление
                return true;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);//если не корректные данные выводим ошибку
                return false;
            }
        }

        public bool Update(Model model)//обновление
        {
            MTypesOfOccupations mTypesOfOccupations = (MTypesOfOccupations)model;//отделение инициализации данных класса

            if ((mTypesOfOccupations.FullName == null && mTypesOfOccupations.ShortName == null)) //Проверка на существование объекта
                return false;

            for (int i = 0; i < Rows.Count; i++) //проверяем строки
            {
                if ((string)Rows[i]["FullName"] == mTypesOfOccupations.FullName) //Проверка на полное имя
                {
                    try
                    {
                        Rows[i].BeginEdit(); //Старт изменения
                        Rows[i]["ShortName"] = mTypesOfOccupations.ShortName; //проверка на существование короткого имени
                        Rows[i].EndEdit();// конец изменений
                        Rows[i].AcceptChanges(); //Принятие изменений
                        return true;
                    }
                    catch (Exception ex)
                    {
                        Debug.WriteLine(ex.Message); //если не корректные данные выводим ошибку
                        return false;
                    }
                }
            }
            return false;
        }
        public bool Update(DataRow row, Model model) //корректность Update
        {
            throw new NotImplementedException(); //создание новой ошибки
        }
    }
}
