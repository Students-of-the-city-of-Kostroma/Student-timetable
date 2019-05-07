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
	public class MTitle : Model
	{
		/// <summary>
		/// Название дисциплины
		/// </summary>
		protected string name;
		/// <summary>
		/// Код дисциплины
		/// </summary>
		protected string reduction;
		/// <summary>
		/// Создает экземпляр дисциплины
		/// </summary>
		/// <param name="name">Название дисциплины</param>
		/// <param name="reduction">Код дисциплины</param>
		public MTitle(string name, string reduction) : base()
		{
			Name = name;
			Reduction = reduction;
		}

		/// <summary>
		/// Возвращает или задает значение Name - название
		/// </summary>
		public string Name { set { name = value; } get { return name; } }

		/// <summary>
		/// Возвращает или задает значение Code - код
		/// </summary>
		public string Reduction { set { reduction = value; } get { return reduction; } }
	}
}