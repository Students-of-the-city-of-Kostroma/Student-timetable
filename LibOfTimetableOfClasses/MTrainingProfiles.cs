using System;
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
		/// Шифр направления
		/// </summary>
		string shiphr;
		/// <summary>
		/// fullname - Полное название профиля подготовки
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
		/// shortname - Краткое название профиля подготовки
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
		/// <summary>
		/// shiphr - Шифр напраления подготовки
		/// </summary>
		public string Shiphr
		{
			get
			{
				return shiphr;
			}
			set
			{
				shiphr = value;
			}
		}
		/// <summary>
		/// Создает экземпляр Профиля подготовки
		/// </summary>
		/// <param name="fullname">Полное название профиля подготовки</param>
		/// <param name="shortname">Краткое название профиля подготовки</param>
		/// <param name="shiphr">Шмфр направления подготовки</param>
		public MTrainingProfile(string fullname, string shortname, string shiphr) :base()
		{
			FullName = fullname;
			ShortName = shortname;
			Shiphr = shiphr;
		}
		/// <summary>
		/// Возвращает string краткое название профиля подготовки
		/// </summary>
		/// <returns></returns>
		public override string ToString()
		{
			return this.ShortName;
		}
	}
}
