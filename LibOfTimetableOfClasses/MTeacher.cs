using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibOfTimetableOfClasses
{

	/// <summary>
	/// Преподаватель
	/// </summary>
	public class MTeacher : Model
	{
		string _patronymic;
		string _secondName;
		string _firstName;
		string _note;
		string _departament;
		string _metodicalDays;
		string _windows;
		string _weekends;

		public string firstName
		{
			get
			{
				return _firstName;
			}
			set
			{
				if(value == null || value == " ") throw new Exception("Строка не может быть пустой");
				if (value.Length > 25) throw new Exception("Кол-во символов превышает 25");
				char[] tmpMass = value.ToCharArray();

				foreach (char l in tmpMass)
					if (l < 'А' || l > 'я') throw new Exception("Можно использовать только русские буквы !");

				if (tmpMass[0] < 'А' || tmpMass[0] > 'Я') throw new Exception("Первая буквы должна быть заглавной !");
				for (int i = 1; i < tmpMass.Length; i++)
					if (tmpMass[i] < 'а' || tmpMass[i] > 'я') throw new Exception("Все буквы, кроме первой, не могут быть заглавными !");
				_firstName = value;
			}
		}

		public string secondName
		{
			get
			{
				return _secondName;
			}
			set
			{
				if (value == null || value == " ") throw new Exception("Строка не может быть пустой");
				if (value.Length > 50) throw new Exception("Кол-во символов превышает 50");
				char[] tmpMass = value.ToCharArray();
				foreach (char l in tmpMass)
					if (l < 'А' || l > 'я') throw new Exception("Можно использовать только русские буквы !");

				if (tmpMass[0] < 'А' || tmpMass[0] > 'Я') throw new Exception("Первая буквы должна быть заглавной !");
				for (int i = 1; i < tmpMass.Length; i++)
					if (tmpMass[i] < 'а' || tmpMass[i] > 'я') throw new Exception("Все буквы, кроме первой, не могут быть заглавными !");
				_secondName = value;
			}
		}

		public string patronymic
		{
			get
			{
				if (_patronymic != null) return _patronymic;
				else return "";
			}
			set
			{
				if (value.Length > 30) throw new Exception("Кол-во символов превышает 30");

				char[] tmpMass = value.ToCharArray();
				foreach (char l in tmpMass)
					if (l < 'А' || l > 'я') throw new Exception("Можно использовать только русские буквы !");

				if (tmpMass[0] < 'А' || tmpMass[0] > 'Я') throw new Exception("Первая буквы должна быть заглавной !");
				for (int i = 1; i < tmpMass.Length; i++)
					if (tmpMass[i] < 'а' || tmpMass[i] > 'я') throw new Exception("Все буквы, кроме первой, не могут быть заглавными !");

				if (value != "") _patronymic = value;
				else _patronymic = null;
			}
		}
		public string Departament
		{
			get
			{
				return _departament;
			}
			set
			{
				if (value == null || value == " ") throw new Exception("Строка не может быть пустой");

				char[] tmpMass = value.ToCharArray();
				foreach (char l in tmpMass)
					if (l < 'А' || l > 'Я') throw new Exception("Можно использовать только русские, заглавные буквы !");

				

				_departament = value;
			}
		}

		public string Note
		{
			get
			{
				if (_note != null) return _note;
				else return "";
			}
			set
			{
				if (value.Length > 25) throw new Exception("Кол-во символов превышает 25");

				char[] tmpMass = value.ToCharArray();
				foreach (char l in tmpMass)
					if ((l < 'A' || l > 'z') && (l < 'А' || l > 'я') && l != '-' && l != ' ' && l != ',' && (l < '0' || l > '9') && l != '.') throw new Exception("Недопустимые символы !");
				if (tmpMass.Length>0)
				if (tmpMass[0] < 'А' || tmpMass[0] > 'Я') throw new Exception("Первая буквы должна быть заглавной !");

				if (value != "") _note = value;
				else _note = null;
			}
		}

		public string MetodicalDays
		{
			get
			{
				return _metodicalDays;
			}
			set
			{
				char[] tmpMass = value.ToCharArray();
				foreach (char l in tmpMass)
					if ((l < 'А' || l > 'я') && l != ' ' && l != ',') throw new Exception("Недопустимые символы !");

				if (value.IndexOf(",") > 0)
				{
					char p;
					if (value[0] < 'А' || value[0] > 'Я') throw new Exception("Первая буква слова должна быть заглавная");

					for (int i = 0; i < value.Length; i++)
					{
						if (value[i] == ',')
						{
							if (value[i+2] < 'А' || value[i+2] > 'Я') throw new Exception("Названия дней должны начинаться с заглавной буквы");
						}
					}
					_metodicalDays = value;
				}
				else
					if(value[0]< 'А'||value[0]>'Я') throw new Exception("Первая буква слова должна быть заглавная");

				_metodicalDays = value;
			}
		}

		public string Windows
		{
			get
			{
				if (_windows != null) return _windows;
				else return "";
			}
			set
			{
				char[] tmpMass = value.ToCharArray();
				foreach (char l in tmpMass)
					if ((l < 'А' || l > 'я') && l != ' ' && l != ',') throw new Exception("Недопустимые символы !");

				if (value != "") _windows = value;
				else _windows = null;

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
				char[] tmpMass = value.ToCharArray();
				foreach (char l in tmpMass)
					if ((l < 'А' || l > 'я') && l != ' ' && l != ',') throw new Exception("Недопустимые символы !");
				_weekends = value;
			}
		}


		public MTeacher(string firstName, string secondName, string patronymic, string note, string departament, string metodicalDays, string windows, string weekends) : base()
		{
			this.firstName = firstName;
			this.secondName = secondName;
			this.patronymic = patronymic;
			Note = note;
			Departament = departament;
			MetodicalDays = metodicalDays;
			Windows = windows;
			Weekends = weekends;
		}

		public MTeacher(string firstName, string secondName, string note, string departament, string metodicalDays, string windows, string weekends) : base()
		{
			this.firstName = firstName;
			this.secondName = secondName;
			this.patronymic = null;
			Note = note;
			Departament = departament;
			MetodicalDays = metodicalDays;
			Windows = windows;
			Weekends = weekends;
		}

		public MTeacher(string firstName, string secondName, string patronymic, string departament) : base()
		{
			this.firstName = firstName;
			this.secondName = secondName;
			this.patronymic = patronymic;
			Departament = departament;
		}
	}
}
