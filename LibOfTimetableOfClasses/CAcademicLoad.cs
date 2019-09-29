using System;
using System.Data;
using System.Diagnostics;

namespace LibOfTimetableOfClasses
{
    /// <summary>
    /// Таблица со строками, хранящими данные об Академической нагрузке
    /// </summary>
    public class CAcademicLoad : DataTable
    {
        /// <summary>
        /// Конструктор таблицы.
        /// Формируются поля таблицы типа DataTable и их свойства.
        /// Уникальность строки в таблице определяется уникальностью поля Group.
        /// </summary>
        public CAcademicLoad() : base("Нагрузка")
        {
            DataColumn column = new DataColumn
            {
                DataType = typeof(string),
                ColumnName = "Group",
                Unique = true
            };
            this.Columns.Add(column);

            column = new DataColumn
            {
                DataType = typeof(string),
                ColumnName = "HoursAll"
            };

            column = new DataColumn
            {
                DataType = typeof(string),
                ColumnName = "DistributedHours"
            };
            this.Columns.Add(column);

            

            column = new DataColumn
            {
                DataType = typeof(string),
                ColumnName = "Discipline"
            };
            this.Columns.Add(column);
            
            column = new DataColumn
            {
                DataType = typeof(string),
                ColumnName = "Professor"
            };
            this.Columns.Add(column);

            column = new DataColumn
            {
                DataType = typeof(string),
                ColumnName = "KindOfLesson"
            };
            this.Columns.Add(column);
        }
        /// <summary>
        /// Удаляет запись из таблицы данных об академической нагрузке
        /// В таблице CAcademicLoad ищется строка с полем "Group" соответсвующим этому же полю модели, 
        /// переданной в качестве параметра.
        /// В случае успеха поиска удаляется найденная строка. 
        /// </summary>
        public bool Delete(Model model)
        {
            MAcademicLoad mAcademicLoad = (MAcademicLoad)model;

            for (int i = 0; i < this.Rows.Count; i++)
            {
                if ((string)this.Rows[i]["Group"] == mAcademicLoad.Group)
                {
                    this.Rows[i].Delete();
                    return true;
                }
            }
            return false;
        }
        public override bool Insert(Model model)
        {

        }
        public override bool Update(Model model)
        {
            
        }
    }
}
