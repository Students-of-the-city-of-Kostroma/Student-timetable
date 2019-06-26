using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LibOfTimetableOfClasses {
	class Validate {
		/// <summary>
		/// Обертка для валидаторов. Упрощает построение очередного метода валидации.
		/// </summary>
		/// <param name="cond">Условие, при котором валидация будет считаться пройденной</param>
		/// <param name="msg">Содержит сообщение об ошибке или null, если ошибки нет</param>
		/// <param name="errMsg">Сообщение об ошибке, которое следует передать</param>
		/// <returns></returns>
		public static bool ResultWrapper(bool cond, out string msg, string errMsg) {
			if (cond) {
				msg = null;
				return true;
			}
			msg = errMsg;
			return false;
		}


		/// <summary>
		/// Проверка наличия печатных символов в строке
		/// </summary>
		/// <param name="str">Проверяемая строка</param>
		/// <param name="msg">Сообщение об ошибке или null</param>
		/// <param name="errMsg">Сообщение об ошибке</param>
		/// <returns>Возвращает true в случае успешной проверки</returns>
		public static bool NonEmpty(
			string str,
			out string msg,
			string errMsg = "Строка не может быть пустой!"
		) {
			return ResultWrapper(!String.IsNullOrWhiteSpace(str), out msg, errMsg);
		}

		/// <summary>
		/// Проверка максимальной длины строки
		/// </summary>
		/// <param name="str">Проверяемая строка</param>
		/// <param name="length">Максимальная длина строки</param>
		/// <param name="msg">Сообщение об ошибке или null</param>
		/// <param name="errMsg">Сообщение об ошибке</param>
		/// <returns>Возвращает true в случае успешной проверки</returns>
		public static bool MaxLength(string str, out string msg, uint length, string errMsg = "") {
			errMsg = errMsg == "" ? $"Строка не может быть длиннее {length} символов!" : errMsg;
			return ResultWrapper(str.Length <= length, out msg, errMsg);
		}

		/// <summary>
		/// Проверка наличия в строке только букв. Также возможно игнорировать некоторые символы.
		/// </summary>
		/// <param name="str">Проверяемая строка</param>
		/// <param name="msg">Сообщение об ошибке или null</param>
		/// <param name="ignoreChars">Регулярное выражение игнорируемых символов</param>
		/// <param name="errMsg">Сообщение об ошибке</param>
		/// <returns>Возвращает true в случае успешной проверки</returns>
		public static bool OnlyLetters(
			string str,
			out string msg,
			string ignoreChars = "",
			string errMsg = "Строка должна содержать только буквы!"
		) {
			if (!NonEmpty(str, out string tmp)) {
				msg = null;
				return false;
			}
			return ResultWrapper(
				Regex.IsMatch(str, $@"^(?:[a-zа-яё]|{ignoreChars})+$", RegexOptions.IgnoreCase),
				out msg,
				errMsg
			);
		}

		/// <summary>
		/// Проверяет строку на отсутствие английский символов
		/// </summary>
		/// <param name="str">Проверяемая строка</param>
		/// <param name="msg">Сообщение об ошибке или null</param>
		/// <param name="errMsg">Сообщение об ошибке</param>
		/// <returns>Возвращает true в случае успешной проверки</returns>
		public static bool OnlyRusLetters(
			string str,
			out string msg,
			string errMsg = "Строка должна содержать только русские символы!"
		) {
			return ResultWrapper(!Regex.IsMatch(str, @"[a-z]", RegexOptions.IgnoreCase), out msg, errMsg);
		}

		/// <summary>
		/// Проверка отсутствия повторяющихся пробелов
		/// </summary>
		/// <param name="str">Проверяемая строка</param>
		/// <param name="msg">Сообщение об ошибке или null</param>
		/// <param name="regex">Проверяемые символы. Регулярное выражение.</param>
		/// <param name="errMsg">Сообщение об ошибке</param>
		/// <returns>Возвращает true в случае успешной проверки</returns>
		public static bool NoRepeatChars(
			string str,
			out string msg,
			string regex = @"\s{2,}",
			string errMsg = "Строка не должна содержать более одного пробела подряд!"
		) {
			return ResultWrapper(!Regex.IsMatch(str, regex), out msg, errMsg);
		}

		/// <summary>
		/// Проверка отсутствия символов по краям строки
		/// </summary>
		/// <param name="str">Проверяемая строка. По умолчанию проверяет отсутствие пробелов по краям</param>
		/// <param name="msg">Сообщение об ошибке или null</param>
		/// <param name="checkedChars">Проверяемые символы. Регулярное выражение.</param>
		/// <param name="errMsg">Сообщение об ошибке</param>
		/// <returns>Возвращает true в случае успешной проверки</returns>
		public static bool NoCharsAround(
			string str,
			out string msg,
			string checkedChars = "",
			string errMsg = "Строка не должа содержать пробелы по краям!"
		) {
			if (checkedChars == "") {
				checkedChars = @"\s";
			}
			return ResultWrapper(!Regex.IsMatch(str, $@"(^{checkedChars}|{checkedChars}$)"), out msg, errMsg);
		}

		/// <summary>
		/// Проверка наличия первой заглавной буквы в переданной строке
		/// </summary>
		/// <param name="str">Проверяемая строка</param>
		/// <param name="msg">Сообщение об ошибке или null</param>
		/// <param name="errMsg">Сообщение об ошибке</param>
		/// <returns>Возвращает true в случае успешной проверки</returns>
		public static bool FirstCharUC(
			string str,
			out string msg,
			string errMsg = "Первый символ строки должен быть в верхнем регистре!"
		) {
			if (!NonEmpty(str, out string tmp)) {
				msg = null;
				return false;
			}
			string fc = str[0].ToString();
			return ResultWrapper(
				Regex.IsMatch(fc, @"[a-zа-яё]", RegexOptions.IgnoreCase) && fc.ToUpper() == fc,
				out msg,
				errMsg
			);
		}

		/// <summary>
		/// Проверка строки на отсутствие заглавных букв
		/// </summary>
		/// <param name="str">Проверяемая строка</param>
		/// <param name="msg">Сообщение об ошибке или null</param>
		/// <param name="ignoreFirstChar">Не проверять первый символ строки</param>
		/// <param name="errMsg">Сообщение об ошибке</param>
		/// <returns>Возвращает true в случае успешной проверки</returns>
		public static bool OnlyLowerCase(
			string str,
			out string msg,
			bool ignoreFirstChar = false,
			string errMsg = "Строка должна быть в нижнем регистре!"
		) {
			if (!NonEmpty(str, out string tmp)) {
				msg = null;
				return false;
			}
			if (ignoreFirstChar) {
				str = str.Substring(1);
			}
			return ResultWrapper(str.ToLower() == str, out msg, errMsg);
		}

		public static bool SpacedComma(
			string str,
			out string msg,
			string errMsg = "В строке требуется пробел после каждой запятой!"
		) {
			return ResultWrapper(!Regex.IsMatch(str, @"\b,\b"), out msg, errMsg);
		}

		/// <summary>
		/// Бросить исключение, если валидация не пройдена
		/// </summary>
		/// <param name="msgs">Строка с ошибкой или null</param>
		public static void ThrowMsg(bool result, string[] msgs) {
			if (!result) {
				if (msgs != null && msgs.Length > 0) {
					throw new FormatException(msgs[0]);
				}
			}
		}

		/// <summary>
		/// Добавляет результат валидации в строковый массив
		/// </summary>
		/// <param name="msgs">Массив строк с результатами валидаций</param>
		/// <param name="result">Строка с результатом валидации</param>
		public static bool AddToArr(ref string[] msgs, string msg) {
			if (msg != null) {
				Array.Resize(ref msgs, msgs.Length + 1);
				msgs[msgs.Length - 1] = msg;
			}
			return msg != null;
		}

		/// <summary>
		/// Добавляет результат валидации в строковый массив
		/// </summary>
		/// <param name="msgs">Массив строк с результатами валидаций</param>
		/// <param name="msg">Результат метода валидации</param>
		/// <param name="result">Строка с результатом валидации</param>
		public static bool AddToArr(ref string[] msgs, bool result, string msg) {
			if (!result && msg != null) {
				Array.Resize(ref msgs, msgs.Length + 1);
				msgs[msgs.Length - 1] = msg;
			}
			return !result && msg != null;
		}
	}
}
