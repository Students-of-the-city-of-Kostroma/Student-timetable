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
		protected string codeOfDP;
		protected string nameOfDP;
		protected ushort periodOfStudy;

		public MDirectionOfPreparation(string codeOfDP, string nameOfDP, ushort periodOfStudy) : base()
		{
			CodeOfDP = codeOfDP;
			NameOfDP = nameOfDP;
			PeriodOfStudy = periodOfStudy;
		}

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
		public string NameOfDP
		{
			set { nameOfDP = value; }
			get { return nameOfDP; }
		}
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
