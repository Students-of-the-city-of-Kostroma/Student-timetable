using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibOfTimetableOfClasses
{
    /// <summary>
    /// Дисциплина
    /// </summary>
     public class MDiscipline : Model
    {
		/// <summary>
		/// Полное название дисциплины
		/// </summary>
		protected string fullName;
		/// <summary>
		/// Краткое название дисциплины
		/// </summary>
		protected string shortName;
		/// <summary>
		/// Цикл дисциплин
		/// </summary>
		protected string cycleOfDiscipline;
		/// <summary>
		/// Создает экземпляр дисциплины
		/// </summary>
		/// <param name="fullName">Полное название дисциплины</param>
		/// <param name="shortName">Краткое название дисциплины</param>
		/// <param name="cycleOfDiscipline">Цикл дисциплин</param>
		public MDiscipline(string fullName, string shortName, string cycleOfDiscipline) : base()
		{
			Fullname = fullName;
			Shortname = shortName;
			CycleofDiscipline = cycleOfDiscipline;

		}

		/// <summary>
		/// Возвращает или задает значение Name - полное название
		/// </summary>
		public string Fullname { set { fullName = value; } get { return fullName; } }

		/// <summary>
		/// Возвращает или задает значение Shortname - краткому названию
		/// </summary>
		public string Shortname { set { shortName = value; } get { return shortName; } }
		/// <summary>
		/// 
		/// </summary>
		public string CycleofDiscipline { set { cycleOfDiscipline = value; } get { return cycleOfDiscipline; } }
	}
}