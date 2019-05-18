using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace LibOfTimetableOfClasses
{
	/// <summary>
	/// Модель учёной степени
	/// </summary>

	public class MAcademicDegree : Model
	{

		/// <summary>
		/// Полная запись учёной степени
		/// </summary>
		string _fullname;

		/// <summary>
		/// Сокращенная запись учёной степени
		/// </summary>
		string _reduction;
		string _academicDegree;

		public string AcademicDegree
		{
			get
			{
				return _academicDegree;
			}
			set
			{
				if (value == null || value == "") throw new Exception("Строка не может быть пустой");
				_academicDegree = value;
			}
		}

		public string FullName
		{
			get
			{
				return _fullname;
			}
			set
			{
				if (value[0] == '.')
					throw new Exception("Точка ставится после слова");
				if (!Regex.IsMatch(value, @"[А-Яа-я\-\' ']"))
					throw new Exception("Поле Полное название института содержит недопустимые символы");
				if (value.Length > 25)
					throw new Exception("Недопустимое количество символов");
				_fullname = value;
			}
		}

		public string Reduction
		{
			get
			{
				return _reduction;
			}
			set
			{
				if (value[0] == '.')
					throw new Exception("Точка ставится после слова");
				if (!Regex.IsMatch(value, @"[А-Яа-я\-\' ']"))
					throw new Exception("Поле Полное название института содержит недопустимые символы");
				_reduction = value;
				if (value.Length > 25)
					throw new Exception("Недопустимое количество символов");
			}
		}

		/// <summary>
		/// Создание экземпляра учёной степени
		/// </summary> 
		public MAcademicDegree(string fullname, string reduction) : base()
		{
			FullName = fullname;
			Reduction = reduction;
		}

		public MAcademicDegree(string academicDegree) : base()
		{
			AcademicDegree = academicDegree;
		}
	}
}

