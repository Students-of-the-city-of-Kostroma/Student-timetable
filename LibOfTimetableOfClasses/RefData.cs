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
    public class RefData
    {
		public static DataSet dataSet = new DataSet();
        public static CTeacher CTeacher = new CTeacher();
        public static CAuditor CAuditor = new CAuditor();
        public static CDiscipline CDiscipline = new CDiscipline();
		public static CAcademicDegree CAcademicDegree = new CAcademicDegree();
        public static CGroup CGroup = new CGroup();

		public static CTrainingProfile CTrainingProfile = new CTrainingProfile();
		public static CTitle CTitle = new CTitle();
        public static СEnclosures СEnclosures = new СEnclosures();
		public static CUniversity CUniversity = new CUniversity();

		public RefData()
		{
			dataSet.Tables.Add(CTeacher);
			dataSet.Tables.Add(CAcademicDegree);
			dataSet.Tables.Add(CTitle);
			dataSet.Relations.Add("AcademicDegree-Teacher", CAcademicDegree.Columns["Reduction"], CTeacher.Columns["academicDegree"]);
			dataSet.Relations.Add("CTitle-Teacher", CTitle.Columns["Reduction"], CTeacher.Columns["academicTitle"]);
      
      dataSet.Tables.Add(CGroup);
			dataSet.Tables.Add(CTrainingProfile);
			dataSet.Relations.Add("Group-Training profile",CTrainingProfile.Columns["Shortname"], CGroup.Columns["Specialty"]);
			dataSet.Tables.Add(СEnclosures);
			dataSet.Tables.Add(CUniversity);
			dataSet.Relations.Add("University-Enclosures", CUniversity.Columns["FullName"], СEnclosures.Columns["University"]);
		}

	  }
}
