using System;
using System.Data;
using System.Diagnostics;

namespace LibOfTimetableOfClasses
{
    /// <summary>
    /// Таблица со строками, хранящими данные об Академической нагрузке
    /// </summary>
    public class CAcademicLoad : DataTable, IController
    {
        /// <summary>
        /// Конструктор таблицы.
        /// Формируются поля таблицы типа DataTable и их свойства.
        /// Уникальность строки в таблице определяется уникальностью поля Group.
        /// </summary>
        public CAcademicLoad()
            : base("Нагрузка")
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

        public bool Delete(Model model)
        {
            throw new NotImplementedException();
        }

        public bool Insert(Model model)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Обновление свойств строки в таблице из переданной модели MAcademicLoad
        /// Поиск изменяемой строки осуществляется по полю "Group"
        /// </summary>
        /// <param name="model">Модель MAcademicLoad хранящая обновляемую запись таблицы</param>
        /// <returns>Результат обновления</returns>
        public bool Update(Model model)
        {
            MAcademicLoad mAcademic = (MAcademicLoad)model;

            if (mAcademic.Group == null)
                return false;

            for (int i = 0; i < Rows.Count; i++)
            {
                if ((string)Rows[i]["Group"] == mAcademic.Group)
                {
                    try
                    {
                        Rows[i].BeginEdit();
                        Rows[i]["Discipline"] = mAcademic.Discipline;
                        Rows[i]["DistributedHours"] = mAcademic.Distributed;
                        Rows[i]["KindOfLesson"] = mAcademic.Occupation;
                        Rows[i]["Professor"] = mAcademic.Teacher;
                        Rows[i]["HoursAll"] = mAcademic.TotalHours;
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
    }
}