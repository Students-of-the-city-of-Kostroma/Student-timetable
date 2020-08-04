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
            this.Columns.Add(column);

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
        
        /// <summary>
        ///  Метод вставки переданной модели MAcademicLoad в таблицу
        /// </summary>
        /// <param name="model">Модель MAcademicLoad хранящая новую запись таблицы</param>
        /// <returns>Результат обновления</returns>
        public bool Insert(Model model)
        {
            MAcademicLoad mAcademic = (MAcademicLoad)model;

            try
            {
                DataRow newRow = NewRow();
                newRow["Group"] = mAcademic.Group;
                newRow["Discipline"] = mAcademic.Discipline;
                newRow["DistributedHours"] = mAcademic.Distributed;
                newRow["KindOfLesson"] = mAcademic.Occupation;
                newRow["Professor"] = mAcademic.Teacher;
                newRow["HoursAll"] = mAcademic.TotalHours;
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
            }
            return false;
        }
    }
} 