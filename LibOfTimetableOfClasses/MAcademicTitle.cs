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
		public class MAcademicTitle : Model
		{
			string _fullname;
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

			public MAcademicTitle(string fullname, string reduction) : base()
			{
				FullName = fullname;
				Reduction = reduction;
			}
		}
	}
