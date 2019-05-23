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
	public class MTypesOfOccupations : Model
	{
		/// <summary>
		/// Полное название вида занятий
		/// </summary>
		protected string fullName;
		/// <summary>
		/// Краткое название вида занятий
		/// </summary>
		protected string shortName;
		/// <summary>
		/// Создает экземпляр вида занятий
		/// </summary>
		/// <param name="fullName">Полное название вида занятий</param>
		/// <param name="shortName">Краткое название вида занятий</param>

		public MTypesOfOccupations(string fullName, string shortName) : base()
		{
			FullName = fullName;
			ShortName = shortName;
		}

		/// <summary>
		/// Возвращает или задает значение Name - полное название
		/// </summary>
		public string FullName { set { fullName = value; } get { return fullName; } }

		/// <summary>
		/// Возвращает или задает значение Shortname - краткому названию
		/// </summary>
		public string ShortName { set { shortName = value; } get { return shortName; } }

	}
}


