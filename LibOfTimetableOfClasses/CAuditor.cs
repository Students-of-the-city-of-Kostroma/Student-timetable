using System;
using System.Data;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibOfTimetableOfClasses
{
    /// <summary>
    /// Контроллер объекта Аудитория.
    /// </summary>
    public class CAuditor : Controller
    {

        public CAuditor() : base("Аудитория")
        {
            DataColumn[] keys = new DataColumn[2];
            DataColumn column = new DataColumn();
            column.DataType = typeof(string);
            column.ColumnName = "number";
            column.ReadOnly = true;
            column.Unique = true;
            table.Columns.Add(column);
            keys[1] = column;

            column = new DataColumn();
            column.DataType = typeof(byte);
            column.ColumnName = "floor";
            column.ReadOnly = true;
            column.Unique = true;
            table.Columns.Add(column);

            column = new DataColumn();
            column.DataType = typeof(string);
            column.ColumnName = "building";
            column.ReadOnly = true;
            column.Unique = true;
            table.Columns.Add(column);
            keys[1] = column;

            column = new DataColumn();
            column.DataType = typeof(int);
            column.ColumnName = "spacious";
            column.ReadOnly = true;
            column.Unique = true;
            table.Columns.Add(column);
            table.PrimaryKey = keys;
        }

        public override bool Insert(Model model)
        {
            throw new NotImplementedException();
        }

        public override bool Update(Model model)
        {
            throw new NotImplementedException();
        }

        public override bool Delete(Model model)
        {
            throw new NotImplementedException();
        }
    }
}
