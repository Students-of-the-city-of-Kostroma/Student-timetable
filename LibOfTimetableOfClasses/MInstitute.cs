using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibOfTimetableOfClasses
{

	/// <summary>
	/// Институт
	/// </summary>
	public class MInstitute : Model
	{
		string _fullname;
		string _shortname;
		string _director;
		string _VUS;

		
		public string FullName
		{
			get
			{
				return _fullname;
			}
			set
			{
				if (value == null)
					throw new Exception("Поле Полное название института пустое");
				if (!Regex.IsMatch(value, @"[А-Яа-я\-\' ']"))
					throw new Exception("Поле Полное название института содержит недопустимые символы");
				if (value.Length > 50)
					throw new Exception("Слишком длинное значение (не более 50)");
				if (value.Length <= 1)
					throw new Exception("Слишком короткое значение");
				

				_fullname = value;
			}
		}

		public string VUS
		{
			get
			{
				return _VUS;
			}
			set
			{
				if (value == null)
					throw new Exception("Поле ВУЗ пустое");
				_VUS = value;
			}
		}

		public string ShortName
		{
			get
			{
				return _shortname;
			}
			set
			{
				if (value == null || value == "")
					throw new Exception("Поле Короткое название иннститута пустое");
				if (!Regex.IsMatch(value, @"[А-Я]"))
					throw new Exception("Поле Короткое назавание института содержит недопустимые символы");
				if (value.Length < 1 || value.Length > 10)
					throw new Exception("Поле Короткое название института недопустимой длины");
				_shortname = value;
			}
		}

		public string Director
		{
			get
			{
				return _director;
			}
			set
			{

				if (value == null || value == "")
					throw new Exception("Поле Директор пустое");
				if (!Regex.IsMatch(value, @"[а-яА-Я\-\' ']"))
					throw new Exception("Поле Директор содержит недопустимые символы");
				_director = value;
			}
		}

		public MInstitute(string fullname, string shortname, string director, string vus) : base()
		{
			FullName = fullname;
			ShortName = shortname;
			Director = director;
			VUS = vus;
		}
	}
}
