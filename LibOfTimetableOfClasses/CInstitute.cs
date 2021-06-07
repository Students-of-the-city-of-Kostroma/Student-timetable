using System;
using System.Data;
using System.Diagnostics;

namespace LibOfTimetableOfClasses
{
    /// <summary>
    /// Создаёт экзампляр контроллера для сущности Институт
    /// </summary>
    public class CInstitute : DataTable, IController
    {
        public CInstitute() : base("Institute")
        {
            DataColumn[] keys = new DataColumn[4];

            DataColumn column = new DataColumn
            {
                DataType = typeof(string),
                ColumnName = "ShortName",
                Unique = true
            };
            this.Columns.Add(column);
            keys[0] = column;

            column = new DataColumn
            {
                DataType = typeof(string),
                ColumnName = "FullName"
            };
            this.Columns.Add(column);
            keys[1] = column;

            column = new DataColumn
            {
                DataType = typeof(string),
                ColumnName = "Director"
            };
            this.Columns.Add(column);
            keys[2] = column;

            column = new DataColumn
            {
                DataType = typeof(string),
                ColumnName = "University"
            };
            this.Columns.Add(column);
            keys[3] = column;
        }

        public bool Delete(Model model)
        {
            MInstitute mInstitute = (MInstitute)model;
            for (int i = 0; i < this.Rows.Count; i++)
            {
                if ((string)this.Rows[i]["ShortName"] == mInstitute.ShortName
                    && (string)this.Rows[i]["FullName"] == mInstitute.FullName
                    && (string)this.Rows[i]["Director"] == mInstitute.Director
                    && (string)this.Rows[i]["University"] == mInstitute.VUS)
                {
                    this.Rows[i].Delete();
                    return true;
                }
            }
            return false;
        }

        public bool Insert(Model model)
        {
            try
            {
                MInstitute mInstitute = (MInstitute)model;
                DataRow newRow = this.NewRow();
                newRow["ShortName"] = mInstitute.ShortName;
                newRow["FullName"] = mInstitute.FullName;
                newRow["Director"] = mInstitute.Director;
                newRow["University"] = mInstitute.VUS;
                this.Rows.Add(newRow);
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
            MInstitute mInstitute = (MInstitute)model;
            if (mInstitute.ShortName == null
                && mInstitute.FullName == null
                && mInstitute.Director == null
                && mInstitute.VUS == null)
                return false;

            for (int i = 0; i < this.Rows.Count; i++)
            {
                if ((string)this.Rows[i]["ShortName"] == mInstitute.ShortName)
                {
                    try
                    {
                        this.Rows[i].BeginEdit();
                        this.Rows[i]["ShortName"] = mInstitute.ShortName;
                        this.Rows[i]["FullName"] = mInstitute.FullName;
                        this.Rows[i]["Director"] = mInstitute.Director;
                        this.Rows[i]["University"] = mInstitute.VUS;
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
