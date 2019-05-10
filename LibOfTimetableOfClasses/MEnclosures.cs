using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibOfTimetableOfClasses
{

	/// <summary>
	/// Корпус
	/// </summary>
	public class MEnclosures : Model
	{
		string _name;
		string _university;
		string _address;
		string _phone;
		string _comment;
		
		public string Name
		{
			get
			{
				return _name;
			}
			set
			{
				_name = value;
			}
		}

		public string University
		{
			get
			{
				return _university;
			}
			set
			{
				_university = value;
			}
		}

		public string Address
		{
			get
			{
				return _address;
			}
			set
			{
				_address = value;
			}
		}
		public string Phone
		{
			get
			{
				return _phone;
			}
			set
			{
				_phone = value;
			}
		}
		public string Comment
		{
			get
			{
				return _comment;
			}
			set
			{
				_comment = value;
			}
		}


		/// <summary>
		/// Создает экземпляр
		/// </summary>
		public MEnclosures(string name,string university,string address,string phone,string comment): base()
		{
			Name= name;
			University = university;
			Address = address;
			Phone= phone;
			Comment= comment;
		}

		public MEnclosures(string name, string university) : base()
		{
			Name = name;
			University = university;
		}
	}
}

