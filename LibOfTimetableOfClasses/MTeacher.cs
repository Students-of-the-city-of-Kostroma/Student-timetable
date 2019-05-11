using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibOfTimetableOfClasses
{

	/// <summary>
	/// Преподаватель
	/// </summary>
	public class MTeacher : Model
	{
		string _fullName;
		string _patronymic;
		string _secondName;
		string _firstName;
		string _academicDegree;
		string _departament;
		string _metodicalDays;
		string _windows;
		string _weekends;

		public string firstName
		{
			get
			{
				return _firstName;
			}
			set
			{
				_firstName = value;
			}
		}

		public string secondName
		{
			get
			{
				return _secondName;
			}
			set
			{
				_secondName = value;
			}
		}

		public string patronymic
		{
			get
			{
				if (_patronymic != null) return _patronymic;
				else return "";
			}
			set
			{
				if (value != "") _patronymic = value;
				else _patronymic = null;
			}
		}
		public string Departament
		{
			get
			{
				return _departament;
			}
			set
			{
				_departament = value;
			}
		}

		public string AcademicDegree
		{
			get
			{
				return _academicDegree;
			}
			set
			{
				_academicDegree = value;
			}
		}

		public string MetodicalDays
		{
			get
			{
				return _metodicalDays;
			}
			set
			{
				_metodicalDays = value;
			}
		}

		public string Windows
		{
			get
			{
				return _windows;
			}
			set
			{
				_windows = value;
			}
		}

		public string Weekends
		{
			get
			{
				return _weekends;
			}
			set
			{
				_weekends = value;
			}
		}


		public MTeacher(string firstName, string secondName, string patronymic, string academicDegree, string departament, string metodicalDays, string windows, string weekends) : base()
		{
			this.firstName = firstName;
			this.secondName = secondName;
			this.patronymic = patronymic;
			AcademicDegree = academicDegree;
			Departament = departament;
			MetodicalDays = metodicalDays;
			Windows = windows;
			Weekends = weekends;
		}

		public MTeacher(string firstName, string secondName, string academicDegree, string departament, string metodicalDays, string windows, string weekends) : base()
		{
			this.firstName = firstName;
			this.secondName = secondName;
			this.patronymic = null;
			AcademicDegree = academicDegree;
			Departament = departament;
			MetodicalDays = metodicalDays;
			Windows = windows;
			Weekends = weekends;
		}

		public MTeacher(string firstName, string secondName, string patronymic, string departament) : base()
		{
			this.firstName = firstName;
			this.secondName = secondName;
			this.patronymic = patronymic;
			Departament = departament;
		}
	}
}
