﻿	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;
	using System.Threading.Tasks;

namespace LibOfTimetableOfClasses
{
    /// <summary>
    /// В этом классе храняться все экземпляры контроллеров.
    /// </summary>
    public static class Controllers
    {
        public static CTeacher CTeacher = new CTeacher();
        public static CAuditor CAuditor = new CAuditor();
        public static CDiscipline CDiscipline = new CDiscipline();
	      public static CAcademicDegree CAcademicDegree = new CAcademicDegree();
        public static CGroup CGroup = new CGroup();
	      public static CTrainingProfile CTrainingProfile = new CTrainingProfile();
	      public static CTitle CTitle = new CTitle();
        public static СEnclosures СEnclosures = new СEnclosures();
        public static CInstitute CInstitute = new CInstitute();
	      public static CUniversity CUniversity = new CUniversity();
	  }

}
