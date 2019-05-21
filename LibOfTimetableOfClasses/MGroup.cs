using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibOfTimetableOfClasses
{
	/// <summary>
	/// Группа
	/// </summary>
	public class MGroup : Model
	{
		string _group;
		ushort _semester;
		string _specialty;
		ushort _shift;
		ushort _students;
		ushort _minNumberOfClass;
		ushort _maxNumberOfClass;
		string _weekends;

		/// <summary>
		/// R/W свойства Group модели MGroup
		/// В случае записи свойства проводятся проверки переданнаго значения:
		/// Проверка нулевой строки, проверка длины строки, проверка допустимости введенных символов
		/// Строка должна быть: не-null, не более 25 символов, содержать только А-Я,а-я, 1-9, -
		/// Наименование группы(Семантически)
		/// </summary>
		public string Group
		{
			get
			{
				return _group;
			}
			set
			{
				if (value == null || value == "") throw new Exception("Строка(группа) не может быть пустой");
				if (value.Length > 25) throw new Exception("Максимальная длина названия группы 25");
				foreach (char l in value)
				{
					if ((l < 'А' || l > 'я') && (l > '9' || l < '0') && (l != '-')) throw new Exception("Можно использовать только русские буквы, цифры и тире!");
				}
				_group = value;
			}
		}

		/// <summary>
		/// R/W свойства Semester модели MGroup. 
		/// Число должно быть в пределах от 1 до 10
		/// Семестр текущей группы(Семантически)
		/// </summary>
		public ushort Semester
		{
			get
			{
				return _semester;
			}
			set
			{
				if (value < 1 && value > 10) throw new Exception("Номер семестра находится не в диапазоне от 1 до 10");
				_semester = value;
			}
		}


		/// <summary>
		/// R/W свойства Specialty модели MGroup. 
		/// Специальность текущей группы(Семантически)
		/// </summary>
		public string Specialty
		{
			get
			{
				return _specialty;
			}
			set
			{
				_specialty = value;
			}
		}

		/// <summary>
		/// R/W свойства Shift модели MGroup. 
		/// Число должно быть в пределах от 1 до 2
		/// Смена текущей группы(Семантически)
		/// </summary>
		public ushort Shift
		{
			get
			{
				return _shift;
			}
			set
			{
				if (value < 1 && value > 2) throw new Exception("Порядок смены находится не в диапазоне от 1 до 2");
				_shift = value;
			}
		}

		/// <summary>
		/// R/W свойства Students модели MGroup. 
		/// Число должно быть в пределах от 1 до 50
		/// Количество студентов в текущей группе(Семантически)
		/// </summary>
		public ushort Students
		{
			get
			{
				return _students;
			}
			set
			{
				if (value < 1 && value > 50) throw new Exception("Кол-во судентов не в диапазоне от 1 до 50");
				_students = value;
			}
			
		}

		/// <summary>
		/// R/W свойства MinNumberOfClass модели MGroup. 
		/// Число должно быть в пределах от 0 до 6
		/// Минимальное количество пар в день(Семантически)
		/// </summary>
		public ushort MinNumberOfClass
		{
			get
			{
				return _minNumberOfClass;
			}
			set
			{
				if (value < 0 && value > 6) throw new Exception("Пар/день min не в диапазоне от 0 до 6");
				_minNumberOfClass = value;
			}
		}


		/// <summary>
		/// R/W свойства MaxNumberOfClass модели MGroup. 
		/// Число должно быть в пределах от 1 до 6
		/// Максимальное количество пар в день(Семантически)
		/// </summary>
		public ushort MaxNumberOfClass
		{
			get
			{
				return _maxNumberOfClass;
			}
			set
			{
				if (value < 1 && value > 6) throw new Exception("Пар/день max не в диапазоне от 1 до 6");
				_maxNumberOfClass = value;
			}
		}


		/// <summary>
		/// R/W свойства Weekends модели MGroup. 
		/// Требования: символы A-Я, а-я, " ", ","; заглавные буквы для слов отделяемых по ", "
		/// Выходные(Семантически)
		/// </summary>
		public string Weekends
		{
			get
			{
				return _weekends;
			}
			set
			{
				if (value == null || value == "") throw new Exception("Строка(выходные) не может быть пустой");
				foreach (char l in value)
				{
					if ((l < 'А' || l > 'я')  && (l !=' ') && (l != ',')) throw new Exception("Можно использовать только русские буквы, пробелы и запятые !");
				}
				string[] mas = value.Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries);

				foreach (string k in mas)
				{
					if (k[0] < 'А' || k[0] > 'Я') throw new Exception("Первые буквы каждого слова должны быть заглавными !");
					for (int i = 1; i < k.Length; i++)
						if (k[i] < 'а' || k[i] > 'я') throw new Exception("Все буквы, кроме первой буквы слова, не могут быть заглавными !");
				}
				_weekends = value;
			}
		}


		/// <summary>
		/// Конструктор класса MGroup.
		/// </summary>
		/// <param name="group">Название группы</param>
		/// <param name="semester">Текущий семестр</param>
		/// <param name="specialty">Специальность для заданной группы</param>
		/// <param name="shift">Смена</param>
		/// <param name="students">Количество студентов</param>
		/// <param name="minNumberOfClass">Минимальное количество пар</param>
		/// <param name="maxNumberOfClass">Максимальное количество пар</param>
		/// <param name="weekends">Дни определенные как выходные</param>
		public MGroup(string group, ushort semester, string specialty, ushort shift, ushort students, ushort minNumberOfClass, ushort maxNumberOfClass, string weekends) : base()
		{
			if (maxNumberOfClass < minNumberOfClass) throw new Exception("Пар/день max должен быть больше пар/день min");
			Group = group;
			Semester = semester;
			Shift = shift;
			Specialty = specialty;
			Students = students;
			MinNumberOfClass = minNumberOfClass;
			MaxNumberOfClass = maxNumberOfClass;
			Weekends = weekends;
		}

		/// <summary>
		/// Конструктор для создания такой MGroup, которую можно было бы передать параметром
		/// в методы контроллера которые основаны на проверке уникальности
		/// </summary>
		/// <param name="group">Название группы</param>
		public MGroup(string group) : base()
		{
			Group = group;
		}

	}
}
