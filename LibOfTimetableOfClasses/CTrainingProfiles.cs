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
	/// Контроллер класса объекта Профили подготовки
	/// </summary>
	public class CTrainingProfile : DataTable, IController
	{
		public CTrainingProfile() : base("Профиль подготовки")
        {
			DataColumn column = new DataColumn();
			column.DataType = typeof(string);
			column.ColumnName = "Fullname";
			column.Unique = true;
			Columns.Add(column);

			column = new DataColumn();
			column.DataType = typeof(string);
			column.ColumnName = "Shortname";
			Columns.Add(column);
		}

		public bool Delete(Model model)
		{
			MTrainingProfile mTrainingProfile = (MTrainingProfile)model;

			for (int i = 0; i < Rows.Count; i++)
			{
				if ((string)Rows[i]["Fullname"] == mTrainingProfile.FullName
				&& (string)Rows[i]["Shortname"] == mTrainingProfile.ShortName)
				{
					Rows.Remove(Rows[i]);
					return true;
				}
			}
			return false;
		}
		public bool Insert(Model model)
		{
			MTrainingProfile mTrainingProfile = (MTrainingProfile)model;
			if (mTrainingProfile.FullName == null)
				return false;

			try
			{
				DataRow newRow = NewRow();
				newRow["FullName"] = mTrainingProfile.FullName;
				newRow["ShortName"] = mTrainingProfile.ShortName;
				Rows.Add(newRow);
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
			MTrainingProfile mTrainingProfile = (MTrainingProfile)model;

			if (mTrainingProfile.FullName == null)
				return false;

			for (int i = 0; i < Rows.Count; i++)
			{
				if ((string)Rows[i]["FullName"] == mTrainingProfile.FullName)
				{
					try
					{
						Rows[i].BeginEdit();
						Rows[i]["ShortName"] = mTrainingProfile.ShortName;
						Rows[i].EndEdit();
						Rows[i].AcceptChanges();

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
	}
}
