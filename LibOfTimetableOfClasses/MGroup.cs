using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibOfTimetableOfClasses
{
	/// <summary>
	/// Группа
	/// </summary>
	public class MGroup : Model
	{
		Guid _id;
		ushort _position;
		string _group;
		ushort _semester;
		string _specialty;
		ushort _shift;
		ushort _students;
		ushort _minNumberOfClass;
		ushort _maxNumberOfClass;
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

		public ushort Position
		{
			get
			{
				return _position;
			}
			set
			{
				_position = value;
			}
		}

		public string Group
		{
			get
			{
				return _group;
			}
			set
			{
				_group = value;
			}
		}

		public ushort Semester
		{
			get
			{
				return _semester;
			}
			set
			{
					_semester = value;
			}
		}

		public string Specialty
		{
			get
			{
				return _specialty;
			}
			set
			{
				_specialty = value;
			}
		}

		public ushort Shift
		{
			get
			{
				return _shift;
			}
			set
			{
				_shift = value;
			}
		}

		public ushort Students
		{
			get
			{
				return _students;
			}
			set
			{
				_students = value;
			}
			
		}

		public ushort MinNumberOfClass
		{
			get
			{
				return _minNumberOfClass;
			}
			set
			{
				_minNumberOfClass = value;
			}
		}

		public ushort MaxNumberOfClass
		{
			get
			{
				return _maxNumberOfClass;
			}
			set
			{
				_maxNumberOfClass = value;
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


		/// <summary>
		/// Создает экземпляр
		/// </summary>
		/// <param name="cipher">шифр</param>
		/// <param name="population">численность</param>
		public MGroup(string group, ushort semester, string specialty, ushort shift, ushort students, ushort minNumberOfClass, ushort maxNumberOfClass, string weekends) : base()
		{
			Group = group;
			Semester = semester;
			Shift = shift;
			Specialty = specialty;
			Students = students;
			MinNumberOfClass = minNumberOfClass;
			MaxNumberOfClass = maxNumberOfClass;
			Weekends = weekends;
		}

		public MGroup(Guid id,string group, ushort semester, string specialty, ushort shift, ushort students, ushort minNumberOfClass, ushort maxNumberOfClass, string weekends, ushort position) : base()
		{
			ID = id;
			Position = position;
			Group = group;
			Semester = semester;
			Shift = shift;
			Specialty = specialty;
			Students = students;
			MinNumberOfClass = minNumberOfClass;
			MaxNumberOfClass = maxNumberOfClass;
			Weekends = weekends;
		}

		public MGroup(string group) : base()
		{
			Group = group;
		}


	}
}
