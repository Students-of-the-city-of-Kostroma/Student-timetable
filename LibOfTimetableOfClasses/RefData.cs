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
		public static СEnclosures СEnclosures = new СEnclosures();
		public static CUniversity CUniversity = new CUniversity();
		public RefData()
		{
			DataSet.Tables.Add(СEnclosures);
			DataSet.Tables.Add(CUniversity);
			DataSet.Relations.Add("Group_TrainingProfile",
				CUniversity.Columns["ShortName"],
				СEnclosures.Columns["University"]);
		}
	}
}
