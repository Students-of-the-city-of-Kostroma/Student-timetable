using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

		public string ShortName
		{
			get
			{
				return _shortname;
			}
			set
			{
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
				_director = value;
			}
		}

		public MInstitute(string fullname, string shortname, string director) : base()
		{
			FullName = fullname;
			ShortName = shortname;
			Director = director;
		}
	}
}
