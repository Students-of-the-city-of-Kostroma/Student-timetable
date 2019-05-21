using System;
using System.Collections.Generic;
using System.Data;
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
		public static DataSet DataSet = new DataSet();
		public static CTeacher CTeacher = new CTeacher();
        public static CAuditor CAuditor = new CAuditor();
        public static CDiscipline CDiscipline = new CDiscipline();
        public static CGroup CGroup = new CGroup();
		public static CTitle CTitle = new CTitle();
		public static CTrainingProfile CTrainingProfile = new CTrainingProfile();
		public static CDirectionOfPreparation CDirectionOfPreparation = new CDirectionOfPreparation();
		public static СEnclosures СEnclosures = new СEnclosures();
		public static CUniversity CUniversity = new CUniversity();
		public Controllers()
		{
			DataSet.Tables.Add(CTrainingProfile);
			DataSet.Tables.Add(CDirectionOfPreparation);
			DataSet.Relations.Add("Direction_TrainingProfile",
				CDirectionOfPreparation.Columns["CodeOfDP"],
				CTrainingProfile.Columns["Shiphr"]);
			DataSet.Tables.Add(CAuditor);
			DataSet.Tables.Add(СEnclosures);
			DataSet.Relations.Add("Enclosures-Auditor", СEnclosures.Columns["Name"], CAuditor.Columns["Building"]);
		}
	}
}
