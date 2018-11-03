using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;

namespace LibOfTimetableOfClasses
{
    public class CTeacher : Controller
    {
        public CTeacher() : base("Учитель")
        {
            DataColumn column = new DataColumn();
            column.DataType = typeof(string);
            column.ColumnName = "Surname";
            column.ReadOnly = true;
            table.Columns.Add(column);

            column = new DataColumn();
            column.DataType = typeof(string);
            column.ColumnName = "Name";
            column.ReadOnly = true;
            table.Columns.Add(column);

            column = new DataColumn();
            column.DataType = typeof(string);
            column.ColumnName = "MiddleName";
            column.ReadOnly = true;
            table.Columns.Add(column);
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
