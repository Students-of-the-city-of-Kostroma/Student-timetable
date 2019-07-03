using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibOfTimetableOfClasses
{
	/// <summary>
	/// В этом классе храняться все экземпляры контроллеров.
	/// </summary>
	public class RefData
	{
		public static DataSet DataSet = new DataSet();
		public static CTeacher CTeacher = new CTeacher();
		public static CAuditor CAuditor = new CAuditor();
		public static CDiscipline CDiscipline = new CDiscipline();
		public static CGroup CGroup = new CGroup();
		public static CTitle CTitle = new CTitle();
		public static CTrainingProfile CTrainingProfile = new CTrainingProfile();
		public static CDirectionOfPreparation CDirectionOfPreparation = new CDirectionOfPreparation();
		public static CEnclosures CEnclosures = new CEnclosures();
		public static CUniversity CUniversity = new CUniversity();
		public static CStudyWeek CStudyWeek = new CStudyWeek();
		public static CInstitute CInstitute = new CInstitute();
		public static CAcademicDegree CAcademicDegree = new CAcademicDegree();
		public static CTypesOfOccupations CTypesOfOccupations = new CTypesOfOccupations();
#pragma warning disable IDE0044 // Добавить модификатор только для чтения
#pragma warning disable IDE0052 // Удалить непрочитанные закрытые члены
		private static RefData rd = new RefData();
#pragma warning restore IDE0052 // Удалить непрочитанные закрытые члены
#pragma warning restore IDE0044 // Добавить модификатор только для чтения
		private RefData()
		{
			DataSet.Tables.Add(CTrainingProfile);
			DataSet.Tables.Add(CDirectionOfPreparation);
			DataSet.Tables.Add(CAuditor);
			DataSet.Tables.Add(CEnclosures);
			DataSet.Tables.Add(CUniversity);
			DataSet.Tables.Add(CInstitute);
			DataSet.Tables.Add(CTeacher);
			DataSet.Tables.Add(CAcademicDegree);
			DataSet.Tables.Add(CTitle);
			DataSet.Tables.Add(CGroup);
			DataSet.Tables.Add(CStudyWeek);

			DataSet.Relations.Add("Direction_TrainingProfile", CDirectionOfPreparation.Columns["CodeOfDP"], CTrainingProfile.Columns["Shiphr"]);
			DataSet.Relations.Add("Enclosures-Auditor", CEnclosures.Columns["Name"], CAuditor.Columns["Building"]);
			DataSet.Relations.Add("AcademicDegree-Teacher", CAcademicDegree.Columns["Reduction"], CTeacher.Columns["academicDegree"]);
			DataSet.Relations.Add("CTitle-Teacher", CTitle.Columns["Reduction"], CTeacher.Columns["academicTitle"]);
			DataSet.Relations.Add("Teacher-Institute", CTeacher.Columns["FullName"], CInstitute.Columns["Director"]);
			DataSet.Relations.Add("University-Institute", CUniversity.Columns["FullName"], CInstitute.Columns["University"]);
			DataSet.Relations.Add("Group-Training profile", CTrainingProfile.Columns["Shortname"], CGroup.Columns["Specialty"]);
			DataSet.Relations.Add("University-Enclosures", CUniversity.Columns["FullName"], CEnclosures.Columns["University"]);

        }
	}
}
