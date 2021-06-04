using System;
using System.Data;
using System.Diagnostics;

namespace LibOfTimetableOfClasses
{
    /// <summary>
    /// Таблица со строками, хранящими данные об Ученых степенях
    /// </summary>
    public class CAcademicDegree : DataTable, IController
    {
        /// <summary>
        /// Конструктор таблицы.
        /// Формируются поля таблицы типа DataTable и их свойства.
        /// Уникальность строки в таблице определяется уникальностью поля FullName.
        /// </summary>
        public CAcademicDegree() : base("Учёная степень")
        {
            DataColumn column = new DataColumn
            {
                DataType = typeof(string),
                ColumnName = "FullName",
                Unique = true
            };
            this.Columns.Add(column);

            column = new DataColumn
            {
                DataType = typeof(string),
                ColumnName = "Reduction",
                Unique = true
            };
            this.Columns.Add(column);
        }

        /// <summary>
        /// Метод удаления строки соответствующей переданной модели из таблицы CAcademicDegree.
        /// В таблице CAcademicDegree ищется строка с полями "FullName" и "Reduction" соответсвующим этому же полю модели, 
        /// переданной в качестве параметра.
        ///    В случае успеха поиска удаляется найденная строка. 
        /// </summary>
        public bool Delete(Model model)
        {
            MAcademicDegree mAcademicDegree = (MAcademicDegree)model;
            for (int i = 0; i < this.Rows.Count; i++)
            {
                if ((string)this.Rows[i]["FullName"] == mAcademicDegree.FullName && (string)this.Rows[i]["Reduction"] == mAcademicDegree.Reduction)
                {
                    this.Rows[i].Delete();
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Метод добавления переданной модели MAcademicDegree в таблицу CAcademicDegree
        /// в случае уникальности свойства FullName модели для таблицы CAcademicDegree
        /// </summary>
        public bool Insert(Model model)
        {
            MAcademicDegree mAcademicDegree = (MAcademicDegree)model;

            try
            {
                DataRow newRow = this.NewRow();
                newRow["FullName"] = mAcademicDegree.FullName;
                newRow["Reduction"] = mAcademicDegree.Reduction;
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
        /// Обновление строки в таблице CAcademicDegree из переданной модели MAcademicDegree.
        /// Поиск изменяемой строки CTeacher осуществляется по полю "FullName"
        /// </summary>
        public bool Update(Model model)
        {
            MAcademicDegree mAcademicDegree = (MAcademicDegree)model;
            if ((mAcademicDegree.FullName == null && mAcademicDegree.Reduction == null))
                return false;

            for (int i = 0; i < this.Rows.Count; i++)
            {
                if ((string)this.Rows[i]["Reduction"] == mAcademicDegree.Reduction)
                {
                    try
                    {
                        this.Rows[i].BeginEdit();
                        this.Rows[i]["Reduction"] = mAcademicDegree.Reduction;
                        this.Rows[i]["FullName"] = mAcademicDegree.FullName;
                        this.Rows[i].EndEdit();
                        this.Rows[i].AcceptChanges();
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
