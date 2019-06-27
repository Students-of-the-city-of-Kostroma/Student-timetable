using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LibOfTimetableOfClasses {
	/// <summary>
	/// Модель кафедры
	/// </summary>
	public class MDepartment: Model {
		protected string shortTitle;
		protected string fullTitle;
		protected string departmentHead;
		protected string institute;

		/// <summary>
		/// Краткое название
		/// </summary>
		public string ShortTitle {
			get {
				return this.shortTitle;
			}
			set {
				Validate.ThrowMsg(ValidateShortTitle(value, out string[] res), res);
				this.shortTitle = value;
			}
		}

		/// <summary>
		/// Полное название
		/// </summary>
		public string FullTitle {
			get {
				return this.fullTitle;
			}
			set {
				Validate.ThrowMsg(ValidateFullTitle(value, this.shortTitle, out string[] res), res);
				this.fullTitle = value;
			}
		}

		/// <summary>
		/// Заведующий кафедрой
		/// </summary>
		public string DepartmentHead {
			get {
				return this.departmentHead;
			}
			set {
				Validate.ThrowMsg(ValidateDepartmentHead(value, out string[] res), res);
				this.departmentHead = value;
			}
		}

		/// <summary>
		/// Институт
		/// </summary>
		public string Institute {
			get {
				return this.institute;
			}
			set {
				Validate.ThrowMsg(ValidateInstitute(value, out string[] res), res);
				this.institute = value;
			}
		}

		public MDepartment(string shortTitle, string fullTitle, string departmentHead, string institute) {
			this.ShortTitle = shortTitle;
			this.FullTitle = fullTitle;
			this.DepartmentHead = departmentHead;
			this.Institute = institute;
		}

		/// <summary>
		/// Проверка краткого названия кафедры.
		/// </summary>
		/// <param name="str">Краткое название кафедры</param>
		/// <param name="results">Массив ошибок валидации или null</param>
		/// <returns>Возвратит true, если нет ошибок валидации</returns>
		public static bool ValidateShortTitle(string str, out string[] results) {
			// Regex.IsMatch(value, @"\d\d\.\d\d\.\d\d")
			results = BasicValidations(str);
			string res = null;
			Validate.AddToArr(ref results, Validate.MaxLength(str, out res, 10), res);
			Validate.AddToArr(ref results, Validate.FirstCharUC(str, out res), res);
			Validate.AddToArr(ref results, Validate.OnlyLetters(str, out res, "-", "Строка может содержать только буквы или тире!"), res);
			return ResultHelper(ref results);
		}

		/// <summary>
		/// Проверка полного названия кафедры.
		/// </summary>
		/// <param name="str">Полное название кафедры</param>
		/// <param name="shortTitle">Краткое название кафедры</param>
		/// <param name="results">Массив ошибок валидации или null</param>
		/// <returns>Возвратит true, если нет ошибок валидации</returns>
		public static bool ValidateFullTitle(string str, string shortTitle, out string[] results) {
			results = BasicValidations(str);
			string res;
			if (Validate.AddToArr(ref results, str.Length >= shortTitle.Length, "Полное название кафедры не может быть меньше или равно по длине краткому!")) {
				Validate.AddToArr(ref results, Validate.MaxLength(str, out res, 64), res);
			}
			Validate.AddToArr(ref results, Validate.FirstCharUC(str, out res), res);
			Validate.AddToArr(ref results, ValidateOnlyLettersCustom(str, out res), res);
			Validate.AddToArr(ref results, ValidateWordsCase(str, out res), res);
			return ResultHelper(ref results);
		}

		/// <summary>
		/// Проверка ФИО или ФИ заведующего кафедрой.
		/// </summary>
		/// <param name="str">ФИО или ФИ заведующего кафедрой</param>
		/// <param name="results">Массив ошибок валидации или null</param>
		/// <returns>Возвратит true, если нет ошибок валидации</returns>
		public static bool ValidateDepartmentHead(string str, out string[] results) {
			results = BasicValidations(str);
			string res = null;
			Validate.AddToArr(ref results, Validate.OnlyLetters(str, out res, @"[ -]", "Строка может содержать только буквы, пробелы или тире!"), res);
			if (results.Length > 0) {
				return false;
			}
			string[] words = str.Split(' ');
			if(Validate.AddToArr(ref results, words.Length > 1 && words.Length < 4, "Заведующий кафедрой должен иметь фамилию, имя и (не обязательно) отчество!")) {
				return false;
			}
			Validate.AddToArr(ref results, ValidateDashedWord(
				words[0],
				out res,
				"Первый символ фамилии (части фамилии) должен быть в верхнем регистре!",
				"Только первый символ фамилии (части фамилии) должен быть в верхнем регистре!"

			), res);
			Validate.AddToArr(ref results, ValidateDashedWord(
				words[1],
				out res,
				"Первый символ имени (части имени) должен быть в верхнем регистре!",
				"Только первый символ имени (части имени) должен быть в верхнем регистре!"

			), res);
			if (words.Length == 3) {
				Validate.AddToArr(ref results, ValidateDashedWord(
					words[2],
					out res,
					"Первый символ отчества (части отчества) должен быть в верхнем регистре!",
					"Только первый символ отчества (части отчества) должен быть в верхнем регистре!"

				), res);
			}
			return ResultHelper(ref results);
		}

		/// <summary>
		/// Проверка названия института.
		/// </summary>
		/// <param name="str">Название института</param>
		/// <param name="results">Массив ошибок валидации или null</param>
		/// <returns>Возвратит true, если нет ошибок валидации</returns>
		public static bool ValidateInstitute(string str, out string[] results) {
			results = BasicValidations(str);
			string res = null;
			Validate.AddToArr(ref results, Validate.MaxLength(str, out res, 64), res);
			Validate.AddToArr(ref results, Validate.FirstCharUC(str, out res), res);
			Validate.AddToArr(ref results, ValidateOnlyLettersCustom(str, out res), res);
			Validate.AddToArr(ref results, ValidateWordsCase(str, out res), res);
			return ResultHelper(ref results);
		}

		private static bool ValidateWordsCase(string str, out string msg) {
			foreach (string word in str.Split(' ')) {
				if (!Validate.OnlyLowerCase(word, out msg, true, "Слова должны быть в нижнем регистре (допускается первая заглавная буква)!")) {
					return false;
				}
			}
			msg = null;
			return true;
		}

		/// <summary>
		/// Проверка строки, разделенной тире
		/// </summary>
		/// <param name="str">Проверяемая строка</param>
		/// <param name="msg">Отдаваемое сообщение об ошибке или null</param>
		/// <param name="errMsgFirstCharUP">Сообщение об отсутствии первой заглавной буквы</param>
		/// <param name="errMsgOnlyFirstCharUP">Сообщение о наличии заглавных букв не в начале слова</param>
		/// <returns>Результат проверки</returns>
		private static bool ValidateDashedWord(string str, out string msg, string errMsgFirstCharUP, string errMsgOnlyFirstCharUP) {
			foreach (string wordChunk in str.Split('-')) {
				if (Validate.FirstCharUC(wordChunk, out msg, errMsgFirstCharUP)) {
					if (!Validate.OnlyLowerCase(wordChunk, out msg, true, errMsgOnlyFirstCharUP)) {
						return false;
					}
				} else {
					return false;
				}
			}
			msg = null;
			return true;
		}

		private static bool ValidateOnlyLettersCustom(string str, out string msg) {
			if (Validate.OnlyLetters(str, out msg, @"[ ,-]", "Строка может содержать только буквы, пробелы, тире или запятые!")) {
				return Validate.SpacedComma(str, out msg);
			}
			return false;
		}

		private static bool ResultHelper(ref string[] results) {
			if (results == null || results.Length == 0) {
				results = null;
				return true;
			}
			return false;
		}

		private static string[] BasicValidations(string str) {
			string[] results = { };
			string res = null;
			if (Validate.AddToArr(ref results, Validate.NonEmpty(str, out res), res)) {
				return results;
			}
			Validate.AddToArr(ref results, Validate.OnlyRusLetters(str, out res), res);
			if (Validate.AddToArr(ref results, Validate.NoCharsAround(str, out res, @"\B", "Строка не должна содержать пробелы или спец. символы по краям!"), res)) {
				return results;
			}
			Validate.AddToArr(ref results, Validate.NoRepeatChars(str, out res, @"(?!,\s)[ ,-]{2,}", "Строка не должна содержать повторяющихся (или чередующихся) пробелов, запятых, тире!"), res);
			return results;
		}		
	}
}
