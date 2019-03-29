using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Diagnostics;

namespace LibOfTimetableOfClasses
{
    public class CTeacher : Controller,IController
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
			MTeacher mTeacher = (MTeacher)model;
			//проверяем на наличие в таблице записи с таким ключом
			for (int i = 0; i < table.Rows.Count; i++)
			{
				if (mTeacher.Surname == (string)table.Rows[i]["Surname"] &&
					mTeacher.Name == (string)table.Rows[i]["Name"] &&
					mTeacher.MiddleName == (string)table.Rows[i]["MiddleName"] &&
					mTeacher.SizeOfTeachingExperience == (byte)table.Rows[i]["SizeOfTeachingExperience"])
				{
					//в таблице уже есть запись с таким ключом
					return false;
				}
			}

			try
            {
                
                DataRow newRow = table.NewRow();
                newRow["ID"] = Guid.NewGuid();
                newRow["Surname"] = mTeacher.Surname;
                newRow["Name"] = mTeacher.Name;
                newRow["MiddleName"] = mTeacher.MiddleName;
                newRow["AcademicDegree"] = mTeacher.AcademicDegree;
                newRow["AcademicRank"] = mTeacher.AcademicRank;
                newRow["SizeOfTeachingExperience"] = mTeacher.SizeOfTeachingExperience;
                table.Rows.Add(newRow);
                return true;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Source);
                return false;
            }
        }

        public override bool Update(Model model)
        {
            MTeacher mTeacher = (MTeacher)model;
            for (int i = 0; i < table.Rows.Count; i++)
            {
                if ((Guid)table.Rows[i]["ID"] == model.Id && mTeacher.MiddleName != null && mTeacher.Name != null && mTeacher.Surname != null && mTeacher.AcademicDegree != null && mTeacher.AcademicRank != null)
                {
                    try
                    {
                        table.Rows[i].BeginEdit();
                        table.Rows[i]["Surname"] = mTeacher.Surname;
                        table.Rows[i]["Name"] = mTeacher.Name;
                        table.Rows[i]["MiddleName"] = mTeacher.MiddleName;
                        table.Rows[i]["AcademicDegree"] = mTeacher.AcademicDegree;
                        table.Rows[i]["AcademicRank"] = mTeacher.AcademicRank;
                        table.Rows[i]["SizeOfTeachingExperience"] = mTeacher.SizeOfTeachingExperience;
                        table.Rows[i].EndEdit();
                        table.Rows[i].AcceptChanges();
                        return true;
                    }
                    catch (Exception ex)
                    {
                        Debug.WriteLine(ex.Source);
                        return false;
                    }
                }
            }
            return false;
        }

        public override bool Delete(Model model)
        {
            MTeacher mTeacher = (MTeacher)model;
            for (int i = 0; i < table.Rows.Count; i++)
            {
                if ((Guid)table.Rows[i]["ID"] == model.Id && mTeacher.Surname == (string)table.Rows[i]["Surname"] && mTeacher.Name == (string)table.Rows[i]["Name"] && mTeacher.MiddleName == (string)table.Rows[i]["MiddleName"])
                {
                    table.Rows[i].Delete();
                    return true;
                }
            }
            return false;
        }
    }
}
