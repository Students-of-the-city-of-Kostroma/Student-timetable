using System;
using System.Collections.Generic;
using System.Data;

namespace LibOfTimetableOfClasses
{
    class ColumnGenerator: DataTable
    {
        public static DataColumn AddColumnsID(DataColumn column)
        {
            column.Unique = true;
            column.AutoIncrement = true;
            column.AutoIncrementSeed = 1;
            column.AutoIncrementStep = 1;
            return column;
        }
    }
}
