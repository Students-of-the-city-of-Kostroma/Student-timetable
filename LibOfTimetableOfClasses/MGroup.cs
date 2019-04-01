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
		string _group;
		ushort _semester;
		string _specialty;
		ushort _shift;
		short _students;
		ushort _minNumberOfClass;
		ushort _maxNumberOfClass;
		string _weekends;

		public string Group
		{
			get; set;
		}

		public ushort Semester
		{
			get; set;
		}

		public string Specialty
		{
			get; set;
		}

		public ushort Shift
		{
			get; set;
		}

		public short Students
		{
			get;set;
		}

		public ushort MinNumberOfClass
		{
			get;set;
		}

		public ushort MaxNumberOfClass
		{
			get; set;
		}

		public string Weekends
		{
			get; set;
		}


		/// <summary>
		/// Создает экземпляр
		/// </summary>
		/// <param name="cipher">шифр</param>
		/// <param name="population">численность</param>
		public MGroup(string group,ushort semester,string specialty,ushort shift,short students,ushort minNumberOfClass,ushort maxNumberOfClass,string weekends):base()
        {
			Group = group;
			Semester = semester;
			Shift = shift;
			Students = students;
			MinNumberOfClass = minNumberOfClass;
			MaxNumberOfClass = maxNumberOfClass;
			Weekends = weekends;
        }
		
        
    }
}
