using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LibOfTimetableOfClasses {
	class ValidateUtils {
		/// <summary>
		/// Проверка максимальной длины строки
		/// </summary>
		/// <param name="str">Проверяемая строка</param>
		/// <param name="length">Максимальная длина строки</param>
		/// <param name="errMsgChunk">"Объект", длина которого не может быть больше length.</param>
		/// <returns>Возвратит null, если нет ошибки валидации</returns>
		public static string MaxLength(
			string str,
			uint length,
			string errMsgChunk = "Строка"
		) {
			if (str.Length > length) {
				return $"{errMsgChunk} не может быть длиннее {length} символов!";
			}
			return null;
		}
		/// <summary>
		/// Проверка наличия печатных символов в строке
		/// </summary>
		/// <param name="str">Проверяемая строка</param>
		/// <param name="errMsg">Сообщение об ошибке</param>
		/// <returns>Возвратит null, если нет ошибки валидации</returns>
		public static string NonEmpty(
			string str,
			string errMsg = "Строка не может быть пустой!"
		) {
			if (String.IsNullOrWhiteSpace(str)) {
				return errMsg;
			}
			return null;
		}
		/// <summary>
		/// Проверка наличия заглавной буквы в переданной строке
		/// </summary>
		/// <param name="str">Проверяемая строка</param>
		/// <param name="errMsg">Сообщение об ошибке</param>
		/// <returns>Возвратит null, если нет ошибки валидации</returns>
		public static string FirstCharUpperCase(
			string str,
			string errMsg = "Первый символ должен быть заглавным!"
		) {
			if (NonEmpty(str) != null) {
				return null;
			}
			if ((str[0] + "").ToUpper() != str[0] + "") {
				return errMsg;
			}
			return null;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="str">Проверяемая строка</param>
		/// <param name="errMsg">Сообщение об ошибке</param>
		/// <returns>Возвратит null, если нет ошибки валидации</returns>
		public static string OnlyFirstCharUpperCase(
			string str,
			string errMsg = "Только первый символ должен быть заглавным!"
		) {
			string isEmpty = NonEmpty(str);
			if (isEmpty != null) {
				return null;
			}
			if (FirstCharUpperCase(str) != null) {
				return errMsg;
			}
			string woFirstCharStr = str.Substring(1);
			if (woFirstCharStr.ToLower() != woFirstCharStr) {
				return errMsg;
			}
			return null;
		}

		/// <summary>
		/// Проверяет строку, чтобы каждое слово в ней начиналось с заглавной буквы
		/// </summary>
		/// <param name="str">Проверяемая строка</param>
		/// <param name="separator">Разделитель слов</param>
		/// <param name="errMsg">Сообщение об ошибке</param>
		/// <returns>Возвратит null, если нет ошибки валидации</returns>
		public static string EachWordFirstCharUpperCase(
			string str,
			char separator = ' ',
			string errMsg = "Только первый символ слова должен быть заглавным!"
		) {
			string[] words = str.Split(separator);
			foreach (string word in words) {
				if (word.Length == 0) {
					continue;
				}
				if (OnlyFirstCharUpperCase(word) != null) {
					return errMsg;
				}
			}
			return null;
		}

		/// <summary>
		/// Проверяет строку на отсутствие английский символов
		/// </summary>
		/// <param name="str">Проверяемая строка</param>
		/// <returns>Возвратит null, если нет ошибки валидации</returns>
		public static string OnlyRusChars(string str) {
			if (Regex.IsMatch(str, @"[a-z]", RegexOptions.IgnoreCase)) {
				return "Разрешено использовать только русские символы!";
			}
			return null;
		}

		/// <summary>
		/// Бросить исключение, если строка не null
		/// </summary>
		/// <param name="result"></param>
		public static void ThrowValidation(string result) {
			if (result != null) {
				throw new FormatException(result);
			}
		}

		/// <summary>
		/// Бросить исключение с ближайщей не пройденной валидацией из массива
		/// </summary>
		/// <param name="results"></param>
		public static void ThrowValidationsStack(params string[] results) {
			foreach (string result in results) {
				ThrowValidation(result);
			}
		}

		/// <summary>
		/// Создает массив результатов валидаций по переданным параметрам (или массиву строк)
		/// </summary>
		/// <param name="results">Массив строк с результатами валидаций или результаты валидаций списком параметров</param>
		/// <returns>Возвращает массив строк с результатами валидаций</returns>
		public static string[] ValidationsStack(params string[] results) {
			string[] msgs = { };
			foreach (string result in results) {
				if (result != null) {
					Array.Resize(ref msgs, msgs.Length + 1);
					msgs.SetValue(result, msgs.Length - 1);
				}
			}
			return msgs;
		}

		/// <summary>
		/// Добавляет результат валидации в строковый массив
		/// </summary>
		/// <param name="results">Массив строк с результатами валидаций</param>
		/// <param name="validation">Строка с результатом валидации</param>
		public static void AddValidationToStack(ref string[] results, string validation) {
			if (validation != null) {
				Array.Resize(ref results, results.Length + 1);
				results[results.Length - 1] = validation;
			}
		}
	}
}
