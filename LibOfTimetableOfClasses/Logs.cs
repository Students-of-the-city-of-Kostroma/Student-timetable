using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LibOfTimetableOfClasses
{
	static public class Logs
	{
		/// <summary>
		/// Поле info класса Logs
		/// </summary>
		static string info;
		/// <summary>
		/// Поле error класса Logs
		/// </summary>
		static string error;

		/// <summary>
		/// Метод получает ошибку
		/// </summary>
		static public void GetError(Exception ex)
		{
			error = string.Format("  [HResult: {0}]  [Data: {1}]  [TargetSite.DeclaringType: {2}]  [TargetSite.Name: {3}]  [Message: {4}]", ex.HResult, ex.Data, ex.TargetSite.DeclaringType, ex.TargetSite.Name, ex.Message);
		}

		/// <summary>
		/// Метод получает информацию о дествии пользователя
		/// и выводит в файл Logs.txt
		/// </summary>
		static public void SetInfo(string _info)
		{
			string path = @"Logs.txt";
			info = _info;
			string time = string.Format("{0:dd.MM.yyy HH:mm:ss.fff}", DateTime.Now );

			using (FileStream file = new FileStream(path, FileMode.Append))
			using (StreamWriter stream = new StreamWriter(file))
				stream.WriteLine("INFO | " + time + " | " + info + " " + error);
		}
	}
}
