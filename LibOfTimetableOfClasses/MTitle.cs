	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;
	using System.Threading.Tasks;

	namespace LibOfTimetableOfClasses
	{

		/// <summary>
		/// Уч. звание
		/// </summary>
		public class MTitle : Model
		{
			string _fullname;
			string _reduction;
			int _code;

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
			public int Code
			{
				get
				{
					return _code;
				}
				set
				{
					_code = value;
				}
			}

		public MTitle(string fullname, string reduction, int code) : base()
			{
				FullName = fullname;
				Reduction = reduction;
				Code = code;
			}
		}
	}
