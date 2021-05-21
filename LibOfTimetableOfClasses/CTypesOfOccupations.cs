using System;
using System.Data;
using System.Diagnostics;

namespace LibOfTimetableOfClasses
{
    /// <summary>
    /// Контроллер для объекта Вид занятия
    /// </summary>
    public class CTypesOfOccupations : DataTable, IController
    {
        public CTypesOfOccupations() : base("Вид занятия")
        {
            DataColumn column = new DataColumn();
            column.DataType = typeof(string);
            column.ColumnName = "FullName";
            column.Unique = true;
            Columns.Add(column);

            column = new DataColumn();
            column.DataType = typeof(string);
            column.ColumnName = "ShortName";
            Columns.Add(column);
        }



        public bool Delete(Model model)
        {
            MTypesOfOccupations mTypesofOccupations = (MTypesOfOccupations)model;

            for (int i = 0; i < Rows.Count; i++)
            {
                if ((string)Rows[i]["FullName"] == mTypesofOccupations.FullName
                && (string)Rows[i]["ShortName"] == mTypesofOccupations.ShortName)
                {
                    Rows[i].Delete();
                    return true;
                }
            }
            return false;
        }

        public bool Insert(Model model)
        {
            MTypesOfOccupations mTypesOfOccupations = (MTypesOfOccupations)model;

            if (mTypesOfOccupations.FullName == null || mTypesOfOccupations.ShortName == null)
                return false;

            for (int i = 0; i < Rows.Count; i++)
            {
                if ((string)Rows[i]["FullName"] == mTypesOfOccupations.FullName
                && (string)Rows[i]["ShortName"] == mTypesOfOccupations.ShortName)
                    return false;
            }

            try
            {
                DataRow newRow = NewRow();
                //newRow["ID"] = Guid.NewGuid();
                newRow["FullName"] = mTypesOfOccupations.FullName;
                newRow["ShortName"] = mTypesOfOccupations.ShortName;
                Rows.Add(newRow);
                return true;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                return false;
            }
        }

        public bool Update(Model model)
        {
            MTypesOfOccupations mTypesOfOccupations = (MTypesOfOccupations)model;

            if ((mTypesOfOccupations.FullName == null && mTypesOfOccupations.ShortName == null))
                return false;

            for (int i = 0; i < Rows.Count; i++)
            {
                if ((string)Rows[i]["FullName"] == mTypesOfOccupations.FullName)
                {
                    try
                    {
                        Rows[i].BeginEdit();
                        Rows[i]["ShortName"] = mTypesOfOccupations.ShortName;
                        Rows[i].EndEdit();
                        Rows[i].AcceptChanges();
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
        public bool Update(DataRow row, Model model)
        {
            throw new NotImplementedException();
        }
    }
}
