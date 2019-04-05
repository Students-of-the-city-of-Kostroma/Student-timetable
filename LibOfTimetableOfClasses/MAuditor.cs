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
		/// номер аудитории
		/// </summary>
		string number;
		/// <summary>
		/// этаж
		/// </summary>     
		byte floor;
		/// <summary>
		/// корпус
		/// </summary>                 
		string building;
		/// <summary>
		/// вместительность аудитории
		/// </summary>
		int spacious;

		/// <summary>
		/// Конструктор иницциализирующий экземпляр объекта Аудитория
		/// </summary>
		/// <param name="number">номер аудитории</param>
		/// <param name="floor">этаж</param>
		/// <param name="building">корпус</param>
		/// <param name="spacious">вместительность аудитории</param>
		public MAuditor(string number, byte floor, string building, int spacious) : base()
		{
			Number = number;
			Floor = floor;
			Building = building;
			Spacious = spacious;
		}

		/// <summary>
		/// Возвращает или задает number - номер аудитории
		/// </summary>
		public string Number
		{
			get
			{
				return number;
			}

			set
			{
				number = value;
			}
		}

		/// <summary>
		/// Возвращает или задает floor - этаж
		/// </summary>
		public byte Floor
		{
			get
			{
				return floor;
			}

			set
			{
				floor = value;
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
		public int Spacious
		{
			get
			{
				return spacious;
			}

			set
			{
				if (value > 0) spacious = value;
			}
		}
	}
}
