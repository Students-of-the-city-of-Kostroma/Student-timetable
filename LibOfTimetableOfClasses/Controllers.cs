	using System;
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
	public class Controllers
	{
		public static CTeacher CTeacher = new CTeacher();
		public static CAuditor CAuditor = new CAuditor();
		public static CDiscipline CDiscipline = new CDiscipline();
		public static CGroup CGroup = new CGroup();
		public static CTitle CTitle = new CTitle();
		public static СEnclosures СEnclosures = new СEnclosures();
		public static CInstitute CInstitute = new CInstitute();
		public static CUniversity CUniversity = new CUniversity();

		public static DataSet dataSet = new DataSet();

		public Controllers()
		{
			dataSet.Tables.Add(CUniversity);
			dataSet.Tables.Add(CInstitute);
			dataSet.Tables.Add(CTeacher);
			dataSet.Relations.Add("Teacher-Institute", CTeacher.Columns["FullName"], CInstitute.Columns["Director"]);
			dataSet.Relations.Add("University-Institute", CUniversity.Columns["FullName"], CInstitute.Columns["University"]);
	
			dataSet.Tables.Add(CGroup);
			dataSet.Tables.Add(CTrainingProfile);
			dataSet.Relations.Add("Group-Training profile",CTrainingProfile.Columns["Shortname"], CGroup.Columns["Specialty"]);
			dataSet.Tables.Add(СEnclosures);
			dataSet.Tables.Add(CUniversity);
			dataSet.Relations.Add("University-Enclosures", CUniversity.Columns["ShortName"], СEnclosures.Columns["University"]);
		}
	}
}
