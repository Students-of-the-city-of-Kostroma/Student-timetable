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
				if (value == "") throw new Exception("Пустая строка названия корпуса");
				if (value == null) throw new Exception("Null строка названия корпуса");
				foreach (char s in value)
				{
					if ((s < 'А' || s > 'я') && (s < 'A' || s > 'z') && s != '-' && (s < '0' || s > '9'))
					{
						throw new Exception("Присутствует недопустимый символ в строке названия корпуса");
					}
				}
				if (value.Length>50) throw new Exception("Слишком длинная строка названия корпуса");
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
				if (value == "") throw new Exception("Пустая строка университета");
				if (value == null) throw new Exception("Null строка университета");
				
				foreach (char s in value)
				{
					if ((s < 'А' || s > 'Я'))
					{
						throw new Exception("Присутствует недопустимый символ в строке университета");
					}
				}
				if (value.Length > 10) throw new Exception("Слишком длинная строка университета");
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
				if (value == "") throw new Exception("Пустая строка адреса");
				if (value == null) throw new Exception("Null строка адреса");
				foreach (char s in value)
				{
					if ((s < 'А' || s > 'я')  && s != '-' && s != ',' && s != ' ' && s != '.' && (s < '0' || s > '9'))
					{
						throw new Exception("Присутствует недопустимый символ в строке адреса");
					}
				}
				if (value.Length > 256) throw new Exception("Слишком длинная строка адреса");
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
				if (value == "") throw new Exception("Пустая строка телефона");
				if (value == null) throw new Exception("Null строка телефона");
				foreach (char s in value)
				{
					if ((s < '0' || s > '9'))
					{
						throw new Exception("Присутствует недопустимый символ в строке телефона");
					}
				}
				if (value.Length > 11) throw new Exception("Слишком длинная строка телефона");
				_phone = value;
			}
		}
		public string Comment
		{
			get
			{
				if (_comment != null)
					return _comment;
				else return ("");
			}
			set
			{
				if (value == "") value = null;
				if (value == null) throw new Exception("Null строка примечания");
				foreach (char s in value)
				{
					if ((s < 'А' || s > 'я') && (s < 'A' || s > 'z') && s != '-' && s != ',' && s != ' ' && s != '.' && (s < '0' || s > '9'))
					{
						throw new Exception("Присутствует недопустимый символ в строке примечания");
					}
				}
				if (value.Length > 256) throw new Exception("Слишком длинная строка примечания");
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

