using System.Data;

namespace LibOfTimetableOfClasses
{
    /// <summary>
    /// Абстракция реадизуюящая основной функционал управления данными
    /// </summary>
    public abstract class Controller
    {
        /// <summary>
        /// Общий ресурс для хранения таблиц
        /// </summary>
        public static DataSet DataSet = new DataSet();
        /// <summary>
        /// Таблица с данными
        /// </summary>
        protected DataTable table;
        /// <summary>
        /// Создает таблицу с указаным именем
        /// </summary>
        /// <param name="tableName">Имя таблицы</param>
        public Controller(string tableName = "Controller")
        {
            table = new DataTable(tableName);
            DataSet.Tables.Add(table);
        }
        /// <summary>
        /// Добавление экземпляра в таблицу
        /// </summary>
        /// <param name="model">Добавляемый экземпляр</param>
        /// <returns>Вернет истину если удалось добавить экземпляр</returns>
        public abstract bool Insert(Model model);
        /// <summary>
        /// Изменение экземпляра в таблице
        /// </summary>
        /// <param name="model">Изменяемый экземпляр</param>
        /// <returns>Вернет истину если удалось изменить экземпляр</returns>
        public abstract bool Update(Model model);
        /// <summary>
        /// Удаление экземпляра из таблицы
        /// </summary>
        /// <param name="model">Удаляемый экземпляр</param>
        /// <returns>Вернет истину если удалось изменить экземпляр</returns>
        public abstract bool Delete(Model model);
        /// <summary>
        /// Возвращает таблицу
        /// </summary>
        /// <returns></returns>
        public DataTable Select()
        {
            return table;
        }
        /// <summary>
        /// Возвращает отсортироыванную таблицу по одному столбцу
        /// </summary>
        /// <param name="columnName">Имя столбца</param>
        /// <param name="order">порядок сортировки true-ASC false-DESC</param>
        /// <returns></returns>
        public DataTable Select(string columnName, bool order)
        {
            table.DefaultView.Sort = columnName + " " + ((order) ? "ASC" : "DESC");
            return table;
        }
        public static bool TableCompare(DataTable table1, DataTable table2)
        {
            DataTable dt;
            dt = GetDifferentRecords(table1, table2);

            if (dt.Rows.Count == 0)
                return true;
            else
                return false;
        }
        private static DataTable GetDifferentRecords(DataTable table1, DataTable table2)
        {
            //Create Empty Table     
            DataTable ResultDataTable = new DataTable("ResultDataTable");

            //use a Dataset to make use of a DataRelation object     
            using (DataSet ds = new DataSet())
            {
                //Add tables     
                ds.Tables.AddRange(new DataTable[] { table1.Copy(), table2.Copy() });

                //Get Columns for DataRelation     
                DataColumn[] firstColumns = new DataColumn[ds.Tables[0].Columns.Count];
                for (int i = 0; i < firstColumns.Length; i++)
                {
                    firstColumns[i] = ds.Tables[0].Columns[i];
                }

                DataColumn[] secondColumns = new DataColumn[ds.Tables[1].Columns.Count];
                for (int i = 0; i < secondColumns.Length; i++)
                {
                    secondColumns[i] = ds.Tables[1].Columns[i];
                }

                //Create DataRelation     
                DataRelation r1 = new DataRelation(string.Empty, firstColumns, secondColumns, false);
                ds.Relations.Add(r1);

                DataRelation r2 = new DataRelation(string.Empty, secondColumns, firstColumns, false);
                ds.Relations.Add(r2);

                //Create columns for return table     
                for (int i = 0; i < table1.Columns.Count; i++)
                {
                    ResultDataTable.Columns.Add(table1.Columns[i].ColumnName, table2.Columns[i].DataType);
                }

                //If FirstDataTable Row not in SecondDataTable, Add to ResultDataTable.     
                ResultDataTable.BeginLoadData();
                foreach (DataRow parentrow in ds.Tables[0].Rows)
                {
                    DataRow[] childrows = parentrow.GetChildRows(r1);
                    if (childrows == null || childrows.Length == 0)
                        ResultDataTable.LoadDataRow(parentrow.ItemArray, true);
                }

                //If SecondDataTable Row not in FirstDataTable, Add to ResultDataTable.     
                foreach (DataRow parentrow in ds.Tables[1].Rows)
                {
                    DataRow[] childrows = parentrow.GetChildRows(r2);
                    if (childrows == null || childrows.Length == 0)
                        ResultDataTable.LoadDataRow(parentrow.ItemArray, true);
                }
                ResultDataTable.EndLoadData();
            }
            return ResultDataTable;
        }
    }
}
