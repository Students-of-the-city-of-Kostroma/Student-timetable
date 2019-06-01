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
				ValidateShortTitle(value, true);
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
				ValidateFullTitle(value, true);
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
				ValidateDepartmentHead(value, true);
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
				ValidateInstitute(value, true);
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
		/// <param name="throwErr">Бросить исключение при отрицательной валидации</param>
		/// <returns>Возвратит null, если нет ошибок валидации</returns>
		public static string[] ValidateShortTitle(string str, bool throwErr = false) {
			// Regex.IsMatch(value, @"\d\d\.\d\d\.\d\d")
			string[] validations = ValidateUtils.ValidationsStack(
				ValidateUtils.NonEmpty(str),
				ValidateUtils.MaxLength(str, 10),
				ValidateUtils.OnlyRusChars(str),
				ValidateUtils.FirstCharUpperCase(str)
			);
			if (validations.Length == 0) {
				return null;
			}
			if (throwErr) {
				ValidateUtils.ThrowValidationsStack(validations);
				return null;
			}
			return ValidateUtils.ValidationsStack(validations);
		}

		/// <summary>
		/// Проверка полного названия кафедры.
		/// </summary>
		/// <param name="str">Полное название кафедры</param>
		/// <param name="throwErr">Бросить исключение при отрицательной валидации</param>
		/// <returns>Возвратит null, если нет ошибок валидации</returns>
		public static string[] ValidateFullTitle(string str, bool throwErr = false) {
			string[] validations = ValidateUtils.ValidationsStack(
				ValidateUtils.NonEmpty(str),
				ValidateUtils.MaxLength(str, 64),
				ValidateUtils.OnlyRusChars(str),
				ValidateUtils.EachWordFirstCharUpperCase(str)
			);
			if (validations.Length == 0) {
				return null;
			}
			if (throwErr) {
				ValidateUtils.ThrowValidationsStack(validations);
				return null;
			}
			return ValidateUtils.ValidationsStack(validations);
		}

		/// <summary>
		/// Проверка ФИО или ФИ заведующего кафедрой.
		/// </summary>
		/// <param name="str">ФИО или ФИ заведующего кафедрой</param>
		/// <param name="throwErr">Бросить исключение при отрицательной валидации</param>
		/// <returns>Возвратит null, если нет ошибок валидации</returns>
		public static string[] ValidateDepartmentHead(string str, bool throwErr = false) {
			string[] validations = ValidateUtils.ValidationsStack(
					ValidateUtils.NonEmpty(str),
					ValidateUtils.OnlyRusChars(str)
				);
			if (validations.Length > 0) {
				return validations;
			}
			string[] strChunks = str.Split(' ');
			if (strChunks.Length < 2 || strChunks[1] == "" || strChunks.Length > 3) {
				ValidateUtils.AddValidationToStack(ref validations, "Заведующий должен иметь фамилию, имя и (не обязательно) отчество!");
				return validations;
			}
			ValidateUtils.AddValidationToStack(ref validations, ValidateUtils.EachWordFirstCharUpperCase(
				strChunks[0], // Surname
				'-',
				"Только первый символ фамилии (фамилии) должен быть заглавным!"
			));
			ValidateUtils.AddValidationToStack(ref validations, ValidateUtils.EachWordFirstCharUpperCase(
				strChunks[1], // Name
				'-',
				"Только первый символ имени (части имени) должен быть заглавным!"
			));
			if (strChunks.Length == 3 && strChunks[2].Length != 0) {
				ValidateUtils.AddValidationToStack(ref validations, ValidateUtils.EachWordFirstCharUpperCase(
					strChunks[2], // Patronomic
					'-',
					"Только первый символ отчества (части отчества) должен быть заглавным!"
				));
			}
			if (validations.Length == 0) {
				return null;
			}
			if (throwErr) {
				ValidateUtils.ThrowValidationsStack(validations);
				return null;
			}
			return validations;
		}

		/// <summary>
		/// Проверка названия института.
		/// </summary>
		/// <param name="str">Название института</param>
		/// <param name="throwErr">Бросить исключение при отрицательной валидации</param>
		/// <returns>Возвратит null, если нет ошибок валидации</returns>
		public static string[] ValidateInstitute(string str, bool throwErr = false) {
			string[] validations = ValidateUtils.ValidationsStack(
				ValidateUtils.NonEmpty(str),
				ValidateUtils.MaxLength(str, 64),
				ValidateUtils.OnlyRusChars(str)//,
				//ValidateUtils.WoFirstCharLowerCase(str)
			);
			if (validations.Length == 0) {
				return null;
			}
			if (throwErr) {
				ValidateUtils.ThrowValidationsStack(validations);
				return null;
			}
			return validations;
		}
	}
}
