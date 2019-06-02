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

		/// <summary>
		/// Создает экземпляр Аудитории
		/// </summary>
		/// <param name="nameOfAuditor">Название аудитории</param>
		/// <param name="cafedra">Кафедра</param>
		/// <param name="spacious">Вместительность</param>
		/// <param name="building">Корпус</param>
		public MAuditor(string nameOfAuditor, string cafedra, ushort spacious, string building) : base()
		{
			NameOfAuditor = nameOfAuditor;
			Cafedra = cafedra;
			Spacious = spacious;
			Building = building;
		}

		/// <summary>
		/// nameofaud - название аудитории
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
		/// cafedra - кафедру
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
		/// building - корпус
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
		/// spacious - вместительность
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
