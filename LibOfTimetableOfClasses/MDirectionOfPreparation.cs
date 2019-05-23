using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LibOfTimetableOfClasses
{
	public class MDirectionOfPreparation : Model
	{
		/// <summary>
		/// Код направления подготовки
		/// </summary>
		protected string codeOfDP;
		/// <summary>
		/// Название направления подготовки
		/// </summary>
		protected string nameOfDP;
		/// <summary>
		/// Период обучения
		/// </summary>
		protected ushort periodOfStudy;
		/// <summary>
		/// Создает экземпляр направления подготовки
		/// </summary>
		/// <param name="codeOfDP">Код направления подготовки</param>
		/// <param name="nameOfDP">Название направления подготовки</param>
		/// <param name="periodOfStudy">Период обучения</param>
		public MDirectionOfPreparation(string codeOfDP, string nameOfDP, ushort periodOfStudy) : base()
		{
			CodeOfDP = codeOfDP;
			NameOfDP = nameOfDP;
			PeriodOfStudy = periodOfStudy;
		}
		/// <summary>
		/// Возвращает или задает CodeOfDP - код напраления подготовки
		/// </summary>
		public string CodeOfDP
		{
			set
			{
				if  (Regex.IsMatch(value, @"\d{2}.\d{2}.\d{2}", RegexOptions.IgnoreCase))
					codeOfDP = value;
				else throw new ArgumentException("Код не соответствует маске задания кода");
			}
				
			get { return codeOfDP; }
		}
		/// <summary>
		/// Возвращает или задает NameOfDP - название напраления подготовки
		/// </summary>
		public string NameOfDP
		{
			set { nameOfDP = value; }
			get { return nameOfDP; }
		}
		/// <summary>
		/// Возвращает или задает PeriodOfStudy - период обучения
		/// </summary>
		public ushort PeriodOfStudy
		{
			set
			{
				if (value >= 1 && value <= 60)
					periodOfStudy = value;
				else throw new ArgumentException("Значение Периода обучения находится в недопустимом интервале");
			}

			get { return periodOfStudy; }
		}
	}
}
