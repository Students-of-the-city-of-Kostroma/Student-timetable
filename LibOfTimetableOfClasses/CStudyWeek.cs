using System;
using System.Data;
using System.Diagnostics;

namespace LibOfTimetableOfClasses
{
    public class CStudyWeek : DataTable, IController
    {
        public CStudyWeek() : base("Учебная неделя")
        {
            DataColumn column = new DataColumn
            {
                DataType = typeof(string),
                ColumnName = "Number",
                Unique = true
            };
            this.Columns.Add(column);

            column = new DataColumn
            {
                DataType = typeof(string),
                ColumnName = "Name"
            };
            this.Columns.Add(column);
        }

        public bool Insert(Model model)
        {
            MStudyWeek mStudyWeek = (MStudyWeek)model;
            try
            {
                DataRow newRow = this.NewRow();
                newRow["Number"] = mStudyWeek.Number.ToString();
                newRow["Name"] = mStudyWeek.Name;
                this.Rows.Add(newRow);
                return true;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Source);
                return false;
            }
        }

        public bool Update(Model model)
        {
            MStudyWeek mStudyWeek = (MStudyWeek)model;
            for (int i = 0; i < this.Rows.Count; i++)
            {
                if (this.Rows[i]["Number"].ToString() == mStudyWeek.Number.ToString())
                    try
                    {
                        DataRow newRow = this.Rows[i];
                        newRow["Number"] = mStudyWeek.Number.ToString();
                        newRow["Name"] = mStudyWeek.Name;
                        return true;
                    }
                    catch (Exception ex)
                    {
                        Debug.WriteLine(ex.Source);
                        return false;
                    }
            }
            return false;
        }


        public bool Delete(Model model)
        {
            MStudyWeek mStudyWeek = (MStudyWeek)model;
            for (int i = 0; i < this.Rows.Count; i++)
            {
                if (this.Rows[i]["Number"].ToString() == mStudyWeek.Number.ToString())
                {
                    this.Rows[i].Delete();
                    return true;
                }
            }
            return false;
        }

    }
}
