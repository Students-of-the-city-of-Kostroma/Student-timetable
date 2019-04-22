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
	public class MUniversity : Model
	{
		string _inn;
		string _shortName;
		string _fullName;
		string _actualAddress;
		string _legalAddress;
		string _nameRector;
		string _surnameRector;
		string _middleNameRector;
		string _email;
		string _phone;

		public string INN
		{
			get
			{
				return _inn;
			}
			set
			{
				_inn = value;
			}
		}

		public string ShortName
		{
			get
			{
				return _shortName;
			}
			set
			{
				_shortName = value;
			}
		}

		public string FullName
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
		public string ActualAddress
		{
			get
			{
				return _actualAddress;
			}
			set
			{
				_actualAddress = value;
			}
		}
		public string LegalAddress
		{
			get
			{
				return _legalAddress;
			}
			set
			{
				_legalAddress = value;
			}
		}

		public string NameRector
		{
			get
			{
				return _nameRector;
			}
			set
			{
				_nameRector = value;
			}
		}

		public string SurnameRector
		{
			get
			{
				return _surnameRector;
			}
			set
			{
				_surnameRector = value;
			}
		}

		public string MiddleNameRector
		{
			get
			{
				return _middleNameRector;
			}
			set
			{
				_middleNameRector = value;
			}
		}
		public string Email
		{
			get
			{
				return _email;
			}
			set
			{
				_email = value;
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

		/// <summary>
		/// Создает экземпляр
		/// </summary>
		public MUniversity(string inn,string shortName,string fullName,string actualAddress,string legalAddress,string nameRector,string surnameRector,string middleNameRector,string email,string phone) : base()
		{
			INN = inn;
			ShortName = shortName;
			FullName = fullName;
			ActualAddress = actualAddress;
			LegalAddress = legalAddress;
			NameRector = nameRector;
			SurnameRector = surnameRector;
			MiddleNameRector = middleNameRector;
			Email = email;
			Phone = phone;
		}

		public MUniversity(string inn) : base()
		{
			INN = inn;
		}
	}
}
