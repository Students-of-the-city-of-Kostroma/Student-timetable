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
		protected string fullname;
		/// <summary>
		/// Краткое название дисциплины
		/// </summary>
		protected string shortname;
		/// <summary>
		/// Цикл дисциплин
		/// </summary>
		protected string cycleofdis;
		/// <summary>
		/// Создает экземпляр дисциплины
		/// </summary>
		/// <param name="fullname">Полное название дисциплины</param>
		/// <param name="chortname">Краткое название дисциплины</param>
		/// <param name="cycleofdis">Цикл дисциплин</param>
		public MDiscipline(string fullname, string shortname, string cycleofdis) : base()
		{
			Fullname = fullname;
			Shortname = shortname;
			CycleofDis = cycleofdis;

		}

		/// <summary>
		/// Возвращает или задает значение Name - полное название
		/// </summary>
		public string Fullname { set { fullname = value; } get { return fullname; } }

		/// <summary>
		/// Возвращает или задает значение Shortname - краткому названию
		/// </summary>
		public string Shortname { set { shortname = value; } get { return shortname; } }
		/// <summary>
		/// 
		/// </summary>
		public string CycleofDis { set { cycleofdis = value; } get { return cycleofdis; } }
	}
}