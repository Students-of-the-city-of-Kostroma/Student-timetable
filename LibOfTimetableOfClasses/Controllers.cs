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
		public static CAcademicDegree CAcademicDegree = new CAcademicDegree();
        public static CGroup CGroup = new CGroup();
		public static CTrainingProfile CTrainingProfile = new CTrainingProfile();
		public static CTitle CTitle = new CTitle();
        public static СEnclosures СEnclosures = new СEnclosures();
		public static CUniversity CUniversity = new CUniversity();

		public static DataSet dataSet = new DataSet();

		public Controllers()
		{
			dataSet.Tables.Add(CTeacher);
			dataSet.Tables.Add(CAcademicDegree);
			dataSet.Tables.Add(CTitle);

			//ForeignKeyConstraint idKeyRestraint = new ForeignKeyConstraint(dataSet.Tables["CAcademicDegree"].Columns["Reduction"],dataSet.Tables["CTeacher"].Columns["academicDegree"]);

			//idKeyRestraint.DeleteRule = Rule.SetNull;
			//idKeyRestraint.UpdateRule = Rule.Cascade;

			//dataSet.Tables["Reduction"].Constraints.Add(idKeyRestraint);
			//dataSet.EnforceConstraints = true;

			dataSet.Relations.Add("AcademicDegree-Teacher", CAcademicDegree.Columns["Reduction"], CTeacher.Columns["academicDegree"]);
			dataSet.Relations.Add("CTitle-Teacher", CTitle.Columns["Reduction"], CTeacher.Columns["academicTitle"]);

			//ForeignKeyConstraint foreignKey = new ForeignKeyConstraint(CAcademicDegree.Columns["Reduction"], CTeacher.Columns["academicDegree"])
			//{
			//	ConstraintName = "AcademicDegreeTeacherForeignKey",
			//	DeleteRule = Rule.SetNull,
			//	UpdateRule = Rule.Cascade
			//};
			//// добавляем внешний ключ в dataset
			//dataSet.Tables[CTeacher].Constraints.Add(foreignKey);
			//// применяем внешний ключ
			//dataSet.EnforceConstraints = true;

		}

	}

}
