using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibOfTimetableOfClasses
{
    /// <summary>
    /// Аудитория
    /// </summary>
    public class MAuditor : Model
    {

		/// <summary>
		/// аудитория
		/// </summary>
		string nameOfAuditor;
		/// <summary>
		/// кафедра
		/// </summary>     
		string cafedra;
		/// <summary>
		/// вместительность аудитории
		/// </summary>
		ushort spacious;
		/// <summary>
		/// корпус
		/// </summary>                 
		string building;


		public MAuditor(string nameOfAuditor, string cafedra, ushort spacious, string building) : base()
		{
			NameOfAuditor = nameOfAuditor;
			Cafedra = cafedra;
			Spacious = spacious;
			Building = building;
		}

		/// <summary>
		/// Возвращает или задает nameofaud - название аудитории
		/// </summary>
		public string NameOfAuditor
		{
			get
			{
				return nameOfAuditor;
			}

			set
			{
				nameOfAuditor = value;
			}
		}

		/// <summary>
		/// Возвращает или задает cafedra - кафедру
		/// </summary>
		public string Cafedra
		{
			get
			{
				return cafedra;
			}

			set
			{
				cafedra = value;
			}
		}

		/// <summary>
		/// Возвращает или задает building - корпус
		/// </summary>
		public string Building
		{
			get
			{
				return building;
			}

			set
			{
				building = value;
			}
		}

		/// <summary>
		/// Возвращает или задает spacious - вместительность
		/// </summary>
		public ushort Spacious
		{
			get
			{
				return spacious;
			}

			set
			{
				spacious = value;
			}
		}
	}
}
