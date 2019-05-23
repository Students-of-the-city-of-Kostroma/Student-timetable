using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LibOfTimetableOfClasses
{
	/// <summary>
	/// Профили подготовки
	/// </summary>
	public class MTrainingProfile : Model
	{
		/// <summary>
		/// Полное название профиля подготовки
		/// </summary>
		string fullname;
		/// <summary>
		/// Краткое название профиля подготовки
		/// </summary>
		string shortname;
		/// <summary>
		/// Возвращает или задает fullname - Полное название профиля подготовки
		/// </summary>
		public string FullName
		{
			get
			{
				return fullname;
			}
			set
			{
				if (value == null || value == "") throw new Exception("Строка не может быть пустой");
				if (!Regex.IsMatch(value, @"[А-Яа-я\ ]"))
					throw new Exception("Ошибка создания модели. В свойство Полное имя получена строка содержащая недопустимые символы");
				fullname = value;
			}
		}
		/// <summary>
		/// Возвращает или задает shortname - Краткое название профиля подготовки
		/// </summary>
		public string ShortName
		{
			get
			{
				return shortname;
			}
			set
			{
				if (value == null || value == "") throw new Exception("Строка не может быть пустой");
				if (!Regex.IsMatch(value, @"[А-Я]"))
					throw new Exception("Ошибка создания модели. В свойство Короткое имя получена строка содержащая недопустимые символы");
				shortname = value;
			}
		}
		public MTrainingProfile(string fullname, string shortname):base()
		{
			FullName = fullname;
			ShortName = shortname;
		}

		public override string ToString()
		{
			return this.ShortName;
		}
	}
}
