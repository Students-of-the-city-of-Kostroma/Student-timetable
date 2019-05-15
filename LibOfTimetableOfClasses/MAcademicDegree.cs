using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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


		public string FullName
		{
			get
			{
				return _fullname;
			}
			set
			{
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
				_reduction = value;
			}
		}

		/// <summary>
		/// Создание экземпляра учёной степени
		/// </summary>
		/// 
		public MAcademicDegree(string fullname, string reduction) : base()
		{
			FullName = fullname;
			Reduction = reduction;
		}
	}
}

