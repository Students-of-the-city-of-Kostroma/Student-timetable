﻿	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;
	using System.Threading.Tasks;

	namespace LibOfTimetableOfClasses
	{

		/// <summary>
		/// Уч. звание
		/// </summary>
		public class MTitle : Model
		{

			/// <summary>
			/// Полная запись ученого звания
			/// </summary>
			string _fullname;

			/// <summary>
			/// Сокращенная запись ученого звания
			/// </summary>
			string _reduction;
		

			public string FullName
			{
				get
				{
					return _fullname;
				}
				set
				{
				if (value[0] == '.') throw new Exception("Точка ставится после слова");
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
				if (value[0] == '.') throw new Exception("Точка ставится после слова");
				_reduction = value;
				}
			}

			/// <summary>
			/// Создание экземпляра уч. звания
			/// </summary>
			public MTitle(string fullname, string reduction) : base()
			{
				FullName = fullname;
				Reduction = reduction;
			}
		}
	}
