using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibOfTimetableOfClasses
{

	/// <summary>
	/// Класс со свойствами определяющими преподавателя
	/// </summary>
	public class MTeacher : Model
	{
		string _patronymic;
		string _secondName;
		string _firstName;
		string _academicDegree;
		string _academicTitle;
		string _departament;
		string _metodicalDays;
		string _windows;
		string _weekends;

		/// <summary>
		/// R/W свойства FirstName модели MTeacher
		/// В случае записи свойства проводятся проверки переданнаго значения:
		/// Строка должна быть: не-null, не более 25 символов, содержать только А-Я,а-я, не пустой, начинаться с заглавной
		/// Имя преподавателя(Семантически)
		/// </summary>
		public string FirstName
		{
			get
			{
				return _firstName;
			}
			set
			{
				if (value == null || value == "") throw new Exception("Строка не может быть пустой");
				if (value.Length > 25) throw new Exception("Кол-во символов превышает 25");

				foreach (char l in value)
					if (l < 'А' || l > 'я') throw new Exception("Можно использовать только русские буквы !");

				if (value[0] < 'А' || value[0] > 'Я') throw new Exception("Первая буквы должна быть заглавной !");

				for (int i = 1; i < value.Length; i++)
					if (value[i] < 'а' || value[i] > 'я') throw new Exception("Все буквы, кроме первой, не могут быть заглавными !");
				_firstName = value;
			}
		}

		/// <summary>
		/// R/W свойства SecondName модели MTeacher
		/// В случае записи свойства проводятся проверки переданнаго значения:
		/// Строка должна быть: не-null, не более 50 символов, содержать только А-Я,а-я, не пустой, начинаться с заглавной
		/// Фамилия преподавателя(Семантически)
		/// </summary>
		public string SecondName
		{
			get
			{
				return _secondName;
			}
			set
			{
				if (value == null || value == "") throw new Exception("Строка не может быть пустой");
				if (value.Length > 50) throw new Exception("Кол-во символов превышает 50");

				foreach (char l in value)
					if (l < 'А' || l > 'я') throw new Exception("Можно использовать только русские буквы !");

				if (value[0] < 'А' || value[0] > 'Я') throw new Exception("Первая буквы должна быть заглавной !");
				for (int i = 1; i < value.Length; i++)
					if (value[i] < 'а' || value[i] > 'я') throw new Exception("Все буквы, кроме первой, не могут быть заглавными !");
				_secondName = value;
			}
		}

		/// <summary>
		/// R/W свойства Patronymic модели MTeacher
		/// Строка должна быть: не более 30 символов, содержать только А-Я,а-я, начинаться с заглавной
		/// Отчество преподавателя(Семантически)
		/// </summary>
		public string Patronymic
		{
			get
			{
				if (_patronymic != null) return _patronymic;
				else return "";
			}
			set
			{
				if (value == "" || value == null)
				{
					_patronymic = null;
					return;
				}

				if (value.Length > 30) throw new Exception("Кол-во символов превышает 30");
        
					foreach (char l in value)
						if (l < 'А' || l > 'я') throw new Exception("Можно использовать только русские буквы !");

					if (value[0] < 'А' || value[0] > 'Я') throw new Exception("Первая буквы должна быть заглавной !");
					for (int i = 1; i < value.Length; i++)
						if (value[i] < 'а' || value[i] > 'я') throw new Exception("Все буквы, кроме первой, не могут быть заглавными !");
				 _patronymic = value;
			}
		}

		/// <summary>
		/// R/W свойства Departament модели MTeacher
		/// Строка должна быть: не-null, не более 10 символов, содержать только А-Я, не пустой
		/// Кафедра преподавателя(Семантически)
		/// </summary>
		public string Departament
		{
			get
			{
				return _departament;
			}
			set
			{
				if (value == null || value == "") throw new Exception("Строка не может быть пустой");
				if (value.Length > 10) throw new Exception("Кол-во символов превышает 10");

				foreach (char l in value)
					if (l < 'А' || l > 'Я') throw new Exception("Можно использовать только русские, заглавные буквы !");



				_departament = value;
			}
		}

		/// <summary>
		/// R/W свойства AcademicDegree модели MTeacher
		/// Строка должна быть: не-null, не более 25символов, содержать только А-Я,а-я,-, ,,,0-9,., начинаться с заглавной
		/// Ученая степень преподавателя(Семантически)
		/// </summary>
		public string AcademicDegree
		{
			get
			{
				if (_academicDegree != null) return _academicDegree;
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

				if (value != "") _academicDegree = value;
				else _academicDegree = null;
			}
		}

		/// <summary>
		/// R/W свойства AcademicTitle модели MTeacher
		/// Строка должна быть: не более 25 символов, содержать только А-Я,а-я,-, ,,,0-9,., начинаться с заглавной
		/// Учёное звание преподавателя(Семантически)
		/// </summary>
		public string AcademicTitle
		{
			get
			{
				if (_academicTitle != null) return _academicTitle;
				else return "";
			}
			set
			{
				if (value == "" || value == null)
				{
					_academicTitle = null;
					return;
				}
				if (value.Length > 25) throw new Exception("Кол-во символов превышает 25");

				foreach (char l in value)
					if ((l < 'A' || l > 'z') && (l < 'А' || l > 'я') && l != '-' && l != ' ' && l != ',' && (l < '0' || l > '9') && l != '.') throw new Exception("Недопустимые символы !");
				if (value.Length > 0)
					if (value[0] < 'А' || value[0] > 'Я') throw new Exception("Первая буквы должна быть заглавной !");
				if (value != "") _academicTitle = value;
				else _academicTitle = null;
			}
		}

		/// <summary>
		/// R/W свойства MetodicalDays модели MTeacher
		/// Строка должна быть: не-null, не более 70 символов, содержать только А-Я,а-я, ,,, начинаться с заглавной, не пустой, после запятой пробел, названия дней начинаться с заглавной буквы
		/// Методические дни преподавателя(Семантически)
		/// </summary>
		public string MetodicalDays
		{
			get
			{
				return _metodicalDays;
			}
			set
			{
				if (value == null || value == "") throw new Exception("Строка не может быть пустой");
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

		/// <summary>
		/// R/W свойства Windows модели MTeacher
		/// Строка должна быть: не более 70 символов, содержать только А-Я,а-я, ,,, начинаться с заглавной, после запятой пробел, названия дней начинаться с заглавной буквы
		/// Окна преподавателя(Семантически)
		/// </summary>
		public string Windows
		{
			get
			{
				if (_windows != null) return _windows; 
				else return "";
			}
			set
			{

				if (value == "" || value == null)
				{
					_windows = null;
					return;
				}
				if (value.Length > 70) throw new Exception("Кол-во символов превышает 70");

				foreach (char l in value)
					if ((l < 'А' || l > 'я') && l != ' ' && l != ',') throw new Exception("Недопустимые символы !");

				CapitalizationCheck(value);
				 _windows = value;

			}
		}

		/// <summary>
		/// R/W свойства Weekends модели MTeacher
		/// Строка должна быть: не-null, не более 70 символов, содержать только А-Я,а-я, ,,, начинаться с заглавной, не пустой, после запятой пробел, названия дней начинаться с заглавной буквы
		/// Выходные преподавателя(Семантически)
		/// </summary>
		public string Weekends
		{
			get
			{
				return _weekends;
			}
			set
			{
				if (value == null || value == "") throw new Exception("Строка не может быть пустой");
				if (value.Length > 70) throw new Exception("Кол-во символов превышает 70");

				foreach (char l in value)
					if ((l < 'А' || l > 'я') && l != ' ' && l != ',') throw new Exception("Недопустимые символы !");

				CapitalizationCheck(value);

				_weekends = value;
			}
		}

		/// <summary>
		/// Конструктор класса MTeacher с отчеством.
		/// </summary>
		/// <param name="firstName">Имя преподавателя</param>
		/// <param name="secondName">Фамилия преподавателя</param>
		/// <param name="patronymic">Отчество преподавателя</param>
		/// <param name="academicDegree">Ученая степень преподавателя</param>
		/// <param name="academicTitle">Ученое звание преподавателя</param>
		/// <param name="departament">Департамент преподавателя</param>
		/// <param name="metodicalDays">Методические дни преподавателя</param>
		/// <param name="windows">Окна преподавателя</param>
		/// <param name="weekends">Выходные преподавателя</param>
		public MTeacher(string firstName, string secondName, string patronymic, string academicDegree, string academicTitle, string departament, string metodicalDays, string windows, string weekends) : base()
		{
			this.FirstName = firstName;
			this.SecondName = secondName;
			this.Patronymic = patronymic;
			AcademicDegree = academicDegree;
			AcademicTitle = academicTitle;
			Departament = departament;
			MetodicalDays = metodicalDays;
			Windows = windows;
			Weekends = weekends;
		}

		/// <summary>
		/// Конструктор класса MTeacher без отчества.
		/// </summary>
		/// <param name="firstName">Имя преподавателя</param>
		/// <param name="secondName">Фамилия преподавателя</param>
		/// <param name="academicDegree">Ученая степень преподавателя</param>
		/// <param name="academicTitle">Ученое звание преподавателя</param>
		/// <param name="departament">Департамент преподавателя</param>
		/// <param name="metodicalDays">Методические дни преподавателя</param>
		/// <param name="windows">Окна преподавателя</param>
		/// <param name="weekends">Выходные преподавателя</param>
		public MTeacher(string firstName, string secondName, string academicDegree, string academicTitle, string departament, string metodicalDays, string windows, string weekends) : base()
		{
			this.FirstName = firstName;
			this.SecondName = secondName;
			this.Patronymic = null;
			AcademicDegree = academicDegree;
			AcademicTitle = academicTitle;
			Departament = departament;
			MetodicalDays = metodicalDays;
			Windows = windows;
			Weekends = weekends;
		}
	}
}
