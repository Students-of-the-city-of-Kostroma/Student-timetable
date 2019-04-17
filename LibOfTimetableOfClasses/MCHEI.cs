using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibOfTimetableOfClasses
{
	/// <summary>
	/// ВУЗ
	/// </summary>
	class MCHEI:Model
	{
		string fullName;
		string abbreviatedName;
		string rector;
		int phone;
		string email;
		

		public string FullName
		{
			get
			{
				return fullName;
			}

			set
			{
				fullName = value;
			}
		}

		public string AbbreviatedName
		{
			get
			{
				return abbreviatedName;
			}

			set
			{
				abbreviatedName = value;
			}
		}

		public string Rector
		{
			get
			{
				return rector;
			}

			set
			{
				rector = value;
			}
		}

		public int Phone
		{
			get
			{
				return phone;
			}

			set
			{
				if(value>=0) phone = value;
			}
		}

		public string Email
		{
			get
			{
				return email;
			}

			set
			{
				email = value;
			}
		}



		public MCHEI(string fullName, string abbreviatedName, string rector, int phone, string email) : base()
		{
			FullName = fullName;
			AbbreviatedName = abbreviatedName;
			Rector = rector;
			Phone = phone;
			Email = email;
		}


	}
}

