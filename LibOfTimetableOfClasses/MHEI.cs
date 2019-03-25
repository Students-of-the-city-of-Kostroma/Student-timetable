using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibOfTimetableOfClasses
{
    public class MHEI: Model
	{
		string fullName;
		string abbreviatedName;
		string rector;
		string phone;
		string email;
		
		public MHEI(string fullName, string abbreviatedName, string rector, string phone, string email): base ()
		{
			FullName = fullName;
			AbbreviatedName = abbreviatedName;
			Rector = rector;
			Phone = phone;
			Email = email;
		}
		public string FullName
		{
			get
			{
				return fullName;
			}
			set
			{
				if (value != "" && value != null)
					fullName = value;
				else
				throw new AggregateException("Все значения должны быть заполнены");
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
				if (value != "" && value != null)
					abbreviatedName = value;
				else
				throw new AggregateException("Все значения должны быть заполнены");
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
				if (value != "" && value != null)
					rector = value;
				else
					throw new AggregateException("Все значения должны быть заполнены");
			}
		}
		public string Phone
		{
			get
			{
				return phone;
			}
			set
			{
				if (value != "" && value != null)
					phone = value;
				else
					throw new AggregateException("Все значения должны быть заполнены");
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
				if (value != "" && value != null)
					email = value;
				else
					throw new AggregateException("Все значения должны быть заполнены");
			}
		}

	}
}
