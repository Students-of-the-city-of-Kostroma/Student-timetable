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
		Guid _id;
		ushort _number;
		string _fullname;
		string _note;
		string _departament;
		string _metodicalDays;
		string _windows;
		string _weekends;

		public Guid ID
		{
			get
			{
				return _id;
			}
			set
			{
				_id = value;
			}
		}

		public ushort Number
		{
			get
			{
				return _number;
			}
			set
			{
				_number = value;
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
				_fullname = value;
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


		public MTeacher(string fullname, string note, string departament, string metodicalDays, string windows, string weekends) : base()
		{
			FullName = fullname;
			Note = note;
			Departament = departament;
			MetodicalDays = metodicalDays;
			Windows = windows;
			Weekends = weekends;
		}

		public MTeacher(Guid id, string fullname, string note, string departament, string metodicalDays, string windows, string weekends, ushort number) : base()
		{
			ID = id;
			FullName = fullname;
			Note = note;
			Departament = departament;
			MetodicalDays = metodicalDays;
			Windows = windows;
			Weekends = weekends;
			Number = number;
		}

		public MTeacher(string fullname,string departament) : base()
		{
			FullName = fullname;
			Departament = departament;
		}
	}
}
