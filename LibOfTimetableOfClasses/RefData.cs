
﻿	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;
	using System.Threading.Tasks;
	using System.Data;

namespace LibOfTimetableOfClasses
{

	/// <summary>
	/// В этом классе храняться все экземпляры контроллеров.
	/// </summary>
	public class RefData
	{
		public static CTeacher CTeacher = new CTeacher();
		public static CAuditor CAuditor = new CAuditor();
		public static CDiscipline CDiscipline = new CDiscipline();
		public static CGroup CGroup = new CGroup();
		public static CTitle CTitle = new CTitle();
		public static СEnclosures СEnclosures = new СEnclosures();
		public static CInstitute CInstitute = new CInstitute();
		public static CUniversity CUniversity = new CUniversity();
    public static CTrainingProfile CTrainingProfile = new CTrainingProfile();
    public static CAcademicDegree CAcademicDegree = new CAcademicDegree();
		public static DataSet dataSet = new DataSet();

		public RefData()
		{
			dataSet.Tables.Add(CUniversity);
			dataSet.Tables.Add(CInstitute);
      dataSet.Tables.Add(CTeacher);
			dataSet.Tables.Add(CAcademicDegree);
			dataSet.Tables.Add(CTitle);
      dataSet.Tables.Add(CGroup);
      
			dataSet.Relations.Add("AcademicDegree-Teacher", CAcademicDegree.Columns["Reduction"], CTeacher.Columns["academicDegree"]);
			dataSet.Relations.Add("CTitle-Teacher", CTitle.Columns["Reduction"], CTeacher.Columns["academicTitle"]);
			dataSet.Relations.Add("Teacher-Institute", CTeacher.Columns["FullName"], CInstitute.Columns["Director"]);
			dataSet.Relations.Add("University-Institute", CUniversity.Columns["FullName"], CInstitute.Columns["University"]);

			dataSet.Tables.Add(CTrainingProfile);
			dataSet.Relations.Add("Group-Training profile",CTrainingProfile.Columns["Shortname"], CGroup.Columns["Specialty"]);
			dataSet.Tables.Add(СEnclosures);
			dataSet.Relations.Add("University-Enclosures", CUniversity.Columns["ShortName"], СEnclosures.Columns["University"]);
		}
  }
}

