using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimetableOfClasses
{
    public abstract class CObject : ICObject
    {
        protected List<MObject> objList = new List<MObject>();
        public void Add(MObject mObject)
        {
            int index = objList.FindIndex(x => x["ID"].Equals(mObject["ID"]));
            if (index == -1) objList.Add(mObject);
            else throw new Exception("Объект с этим идентификатором уже существует");
        }
        public abstract string[] GetColumnNames();
        public object[,] GetData()
        {
            string[] columnNames = GetColumnNames();
            object[,] data = new object[objList.Count + 1, columnNames.Length];
            //формируем заголовок таблицы
            for (int j = 0; j < data.GetLength(1); j++)
                data[0, j] = columnNames[j];
            //заполняем таблицу
            for (int i = 1; i < data.GetLength(0); i++)
                for (int j = 0; j < data.GetLength(1); j++)
                    data[i, j] = objList[i - 1][columnNames[j]];
            return data;
        }
    }
}
