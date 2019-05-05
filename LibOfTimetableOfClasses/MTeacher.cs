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

		public string FirstName
		{
			get
			{
				return _firstName;
			}
			set
			{
				if (value == null || value == " ") throw new Exception("Строка не может быть пустой");
				if (value.Length > 25) throw new Exception("Кол-во символов превышает 25");

				foreach (char l in value)
					if (l < 'А' || l > 'я') throw new Exception("Можно использовать только русские буквы !");

				if (value[0] < 'А' || value[0] > 'Я') throw new Exception("Первая буквы должна быть заглавной !");

				for (int i = 1; i < value.Length; i++)
					if (value[i] < 'а' || value[i] > 'я') throw new Exception("Все буквы, кроме первой, не могут быть заглавными !");
				_firstName = value;
			}
		}

		public string SecondName
		{
			get
			{
				return _secondName;
			}
			set
			{
				if (value == null || value == " ") throw new Exception("Строка не может быть пустой");
				if (value.Length > 50) throw new Exception("Кол-во символов превышает 50");

				foreach (char l in value)
					if (l < 'А' || l > 'я') throw new Exception("Можно использовать только русские буквы !");

				if (value[0] < 'А' || value[0] > 'Я') throw new Exception("Первая буквы должна быть заглавной !");
				for (int i = 1; i < value.Length; i++)
					if (value[i] < 'а' || value[i] > 'я') throw new Exception("Все буквы, кроме первой, не могут быть заглавными !");
				_secondName = value;
			}
		}

		public string Patronymic
		{
			get
			{
				if (_patronymic != null) return _patronymic;
				else return "";
			}
			set
			{
				if (value != "")
				{
					if (value.Length > 30) throw new Exception("Кол-во символов превышает 30");

					foreach (char l in value)
						if (l < 'А' || l > 'я') throw new Exception("Можно использовать только русские буквы !");

					if (value[0] < 'А' || value[0] > 'Я') throw new Exception("Первая буквы должна быть заглавной !");
					for (int i = 1; i < value.Length; i++)
						if (value[i] < 'а' || value[i] > 'я') throw new Exception("Все буквы, кроме первой, не могут быть заглавными !");
				}
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
				if (value.Length > 10) throw new Exception("Кол-во символов превышает 10");

				foreach (char l in value)
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
				if (value == null) throw new Exception("Строка не может быть null");
				if (value.Length > 25) throw new Exception("Кол-во символов превышает 25");

				foreach (char l in value)
					if ((l < 'A' || l > 'z') && (l < 'А' || l > 'я') && l != '-' && l != ' ' && l != ',' && (l < '0' || l > '9') && l != '.') throw new Exception("Недопустимые символы !");
				if (value.Length > 0)
					if (value[0] < 'А' || value[0] > 'Я') throw new Exception("Первая буквы должна быть заглавной !");

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
				if (value == null || value == " ") throw new Exception("Строка не может быть пустой");
				if (value.Length > 70) throw new Exception("Кол-во символов превышает 70");

				foreach (char l in value)
					if ((l < 'А' || l > 'я') && l != ' ' && l != ',') throw new Exception("Недопустимые символы !");

				CapitalizationCheck(value);

				_metodicalDays = value;
			}
		}

		private void CapitalizationCheck(string value)
		{
			if (value[0] < 'А' || value[0] > 'Я') throw new Exception("Первая буква слова должна быть заглавная");

			for (int i = 1; i < value.Length; i++)
			{
				if (value[i] == ',')
				{
					if (value[i + 1] != ' ') throw new Exception("После запятой должен идти пробел");
					else if (value[i + 2] < 'А' || value[i + 2] > 'Я') throw new Exception("Названия дней должны начинаться с заглавной буквы");
				}
				if (value[i] == ' ')
				{
					if (value[i + 1] < 'А' || value[i + 1] > 'Я') throw new Exception("Названия дней должны начинаться с заглавной буквы");
				}
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

				if (value == null) throw new Exception("Строка не может быть пустой");
				if (value.Length > 70) throw new Exception("Кол-во символов превышает 70");

				foreach (char l in value)
					if ((l < 'А' || l > 'я') && l != ' ' && l != ',') throw new Exception("Недопустимые символы !");

				CapitalizationCheck(value);

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
				if (value == null || value == " ") throw new Exception("Строка не может быть пустой");
				if (value.Length > 70) throw new Exception("Кол-во символов превышает 70");

				foreach (char l in value)
					if ((l < 'А' || l > 'я') && l != ' ' && l != ',') throw new Exception("Недопустимые символы !");

				CapitalizationCheck(value);

				_weekends = value;
			}
		}


		public MTeacher(string firstName, string secondName, string patronymic, string note, string departament, string metodicalDays, string windows, string weekends) : base()
		{
			this.FirstName = firstName;
			this.SecondName = secondName;
			this.Patronymic = patronymic;
			Note = note;
			Departament = departament;
			MetodicalDays = metodicalDays;
			Windows = windows;
			Weekends = weekends;
		}

		public MTeacher(string firstName, string secondName, string note, string departament, string metodicalDays, string windows, string weekends) : base()
		{
			this.FirstName = firstName;
			this.SecondName = secondName;
			this.Patronymic = null;
			Note = note;
			Departament = departament;
			MetodicalDays = metodicalDays;
			Windows = windows;
			Weekends = weekends;
		}

		public MTeacher(string firstName, string secondName, string patronymic, string departament) : base()
		{
			this.FirstName = firstName;
			this.SecondName = secondName;
			this.Patronymic = patronymic;
			Departament = departament;
		}
	}
}
