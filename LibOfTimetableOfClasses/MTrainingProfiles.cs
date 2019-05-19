﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibOfTimetableOfClasses
{
	/// <summary>
	/// Профили подготовки
	/// </summary>
	public class MTrainingProfile : Model
	{
		/// <summary>
		/// Полное название профиля подготовки
		/// </summary>
		string fullname;
		/// <summary>
		/// Краткое название профиля подготовки
		/// </summary>
		string shortname;
		/// <summary>
		/// Возвращает или задает fullname - Полное название профиля подготовки
		/// </summary>
		public string FullName
		{
			get
			{
				return fullname;
			}
			set
			{
				fullname = value;
			}
		}
		/// <summary>
		/// Возвращает или задает shortname - Краткое название профиля подготовки
		/// </summary>
		public string ShortName
		{
			get
			{
				return shortname;
			}
			set
			{
				shortname = value;
			}
		}
		public MTrainingProfile(string fullname, string shortname):base()
		{
			FullName = fullname;
			ShortName = shortname;
		}

		public override string ToString()
		{
			return this.ShortName;
		}
	}
}
