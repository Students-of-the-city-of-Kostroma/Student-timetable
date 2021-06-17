using System;
using System.Data;
using System.Diagnostics;

namespace LibOfTimetableOfClasses
{
    /// <summary>
    /// Таблица со строками, хранящими данные о разных профилях подготовки Университета.
    /// </summary>
    public class CTrainingProfile : ColumnGenerator, IController
    {
        /// <summary>
        /// Конструктор таблицы
        /// Формируются поля таблицы типа DataTable и их свойства.
        /// Уникальность строки в таблице определяется уникальностью полей Fullname и Shortname
        /// </summary>
        public CTrainingProfile() : base("Профиль подготовки")
        {
            AddColumns("Fullname", typeof(string), true);
            AddColumns("Shortname", typeof(string), false);
            AddColumns("Shiphr", typeof(string), false);
        }
        /// <summary>
        /// Метод удаления строки соответствующей переданной модели из таблицы CTrainingProfile.
        /// В таблице CTrainingProfile ищется строка с полем "Fullname" соответсвующим этому же полю модели, 
        /// переданной в качестве параметра.
        ///    В случае успеха поиска удаляется найденная строка.
        /// </summary>
        /// <param name="model">Модель, хранящая выбранную строку в таблице</param>
        /// <returns>Результат удаления переданной строки из CTrainingProfile</returns>
        public bool Delete(Model model)
        {
            MTrainingProfile mTrainingProfile = (MTrainingProfile)model;

            for (int i = 0; i < Rows.Count; i++)
            {
                if (Rows[i].RowState == DataRowState.Deleted)
                    continue;
                if ((string)Rows[i]["Fullname"] == mTrainingProfile.FullName
                && (string)Rows[i]["Shortname"] == mTrainingProfile.ShortName
                && (string)Rows[i]["Shiphr"] == mTrainingProfile.Shiphr)
                {
                    Rows.Remove(Rows[i]);
                    return true;
                }
            }
            return false;
        }
        /// <summary>
        /// Метод вставки переданной модели MTrainingProfile в таблицу CTrainingProfile
        /// в случае уникальности поля Fullname
        /// </summary>
        /// <param name="model">Модель хранящая добавляемую запись таблицы</param>
        /// <returns>Результат вставки</returns>
        public bool Insert(Model model)
        {
            MTrainingProfile mTrainingProfile = (MTrainingProfile)model;
            if (mTrainingProfile.FullName == null)
                return false;

            try
            {
                DataRow newRow = NewRow();
                newRow["FullName"] = mTrainingProfile.FullName;
                newRow["ShortName"] = mTrainingProfile.ShortName;
                newRow["Shiphr"] = mTrainingProfile.Shiphr;
                Rows.Add(newRow);
                return true;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                return false;
            }
        }
        /// <summary>
        /// Обновление свойств строки в таблице CTrainingProfile из переданной модели MTrainingProfile
        /// Поиск изменяемой строки CTrainingProfile осуществляется по полю "FullName"
        /// </summary>
        /// <param name="model">Модель хранящая обновляемую запись таблицы</param>
        /// <returns>Результат обновления</returns>
        public bool Update(Model model)
        {
            MTrainingProfile mTrainingProfile = (MTrainingProfile)model;

            if (mTrainingProfile.FullName == null)
                return false;

            for (int i = 0; i < Rows.Count; i++)
            {
                if (Rows[i].RowState == DataRowState.Deleted)
                    continue;
                if ((string)Rows[i]["FullName"] == mTrainingProfile.FullName)
                {
                    try
                    {
                        Rows[i].BeginEdit();
                        Rows[i]["ShortName"] = mTrainingProfile.ShortName;
                        Rows[i]["Shiphr"] = mTrainingProfile.Shiphr;
                        Rows[i].EndEdit();
                        Rows[i].AcceptChanges();

                        return true;
                    }
                    catch (Exception ex)
                    {
                        Debug.WriteLine(ex.Message);
                        return false;
                    }
                }
            }
            return false;
        }
    }
}
