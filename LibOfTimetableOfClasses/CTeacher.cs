using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace LibOfTimetableOfClasses
{
    public class CTeacher : Controller
    {
        public CTeacher() : base("Учитель")
        {
            DataColumn[] keys = new DataColumn[3];
            DataColumn column = new DataColumn();
            column.DataType = typeof(string);
            column.ColumnName = "Surname";
            column.ReadOnly = true;
            table.Columns.Add(column);
            keys[0] = column;

            column = new DataColumn();
            column.DataType = typeof(string);
            column.ColumnName = "Name";
            column.ReadOnly = true;
            table.Columns.Add(column);
            keys[1] = column;

            column = new DataColumn();
            column.DataType = typeof(string);
            column.ColumnName = "MiddleName";
            column.ReadOnly = true;
            table.Columns.Add(column);
            keys[2] = column;
            table.PrimaryKey = keys;

            column = new DataColumn();
            column.DataType = typeof(string);
            column.ColumnName = "AcademicDegree";
            column.ReadOnly = true;
            table.Columns.Add(column);

            column = new DataColumn();
            column.DataType = typeof(string);
            column.ColumnName = "AcademicRank";
            column.ReadOnly = true;
            table.Columns.Add(column);

            column = new DataColumn();
            column.DataType = typeof(byte);
            column.ColumnName = "SizeOfTeachingExperience";
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
