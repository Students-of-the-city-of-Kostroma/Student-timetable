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
		string _note;
		string _departament;
		string _metodicalDays;
		string _windows;
		string _weekends;

		public string fullName
			{
			get
			{
				return _fullName;
			}
			set
			{
				_fullName = value;
			}
		}

		public string firstName
		{
			get
			{
				if (_firstName != null) return _firstName;
				else return "";
			}
			set
			{
				if (value != "") _firstName = value;
				else _firstName = null;
			}
		}

		public string secondName
		{
			get
			{
				if (_secondName != null) return _secondName;
				else return "";
			}
			set
			{
				if (value != "") _secondName = value;
				else _secondName = null;
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

		public string Note
		{
			get
			{
				return _note;
			}
			set
			{
				_note = value;
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


		public MTeacher(string firstName, string secondName, string patronymic, string note, string departament, string metodicalDays, string windows, string weekends) : base()
		{
			this.firstName = firstName;
			this.secondName = secondName;
			this.patronymic = patronymic;
			Note = note;
			Departament = departament;
			MetodicalDays = metodicalDays;
			Windows = windows;
			Weekends = weekends;
		}

		public MTeacher(string firstName, string secondName, string note, string departament, string metodicalDays, string windows, string weekends) : base()
		{
			this.firstName = firstName;
			this.secondName = secondName;
			this.patronymic = null;
			Note = note;
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
