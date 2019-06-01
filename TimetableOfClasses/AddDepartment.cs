using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibOfTimetableOfClasses;

namespace TimetableOfClasses
{
    public partial class AddDepartment : Form
    {
        public AddDepartment()
        {
            InitializeComponent();
        }

		/// <summary>
		/// Клик по кнопке "Отмена". Закрывает форму без сохранения изменений
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
        private void СancelClick(object sender, EventArgs e)
        {
			this.Close();
        }

		/// <summary>
		/// Добавление новой кафедры в список
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void CreateAndCloseClick(object sender, EventArgs e) {
			try {
				MDepartment mDepartment = new MDepartment(
					this.shortTitle.Text,
					this.fullTitle.Text,
					this.departmentHead.Text,
					this.institute.Text
				);
				MessageBox.Show("На данный момент функционал добавления кафедры в список ещё не создан.", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
			} catch (FormatException ex) {
				MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		/// <summary>
		/// Обработка события изменения краткого названия кафедры
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ShortTitleTextChanged(object sender, EventArgs e) {
			ValidateHandler(MDepartment.ValidateShortTitle, sender);
		}

		/// <summary>
		/// Обработка события изменения полного названия кафедры
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void FullTitleTextChanged(object sender, EventArgs e) {
			ValidateHandler(MDepartment.ValidateFullTitle, sender);
		}

		/// <summary>
		/// Обработка события изменения завудующего кафедрой
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void DepartmentHeadTextChanged(object sender, EventArgs e) {
			ValidateHandler(MDepartment.ValidateDepartmentHead, sender);
		}

		/// <summary>
		/// Обработка события изменения названия института
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void InstituteTextChanged(object sender, EventArgs e) {
			ValidateHandler(MDepartment.ValidateInstitute, sender);
		}

		/// <summary>
		/// Проверка строки переданной функцией и подсветка в случае ошибки.
		/// Добавляет тултип на поле с указанием ошибки.
		/// </summary>
		/// <param name="validator">Функция валидации строки</param>
		/// <param name="sender">Отправитель события об изменении поля</param>
		private void ValidateHandler(Func<string, bool, string[]> validator, object sender) {
			TextBox tb = sender as TextBox;
			string[] validations = validator(tb.Text, false);
			if (validations != null) {
				tooltip.Show(String.Join("\n", validations), tb);
				tb.BackColor = Color.Coral;
			} else {
				tb.BackColor = SystemColors.Window;
				tooltip.Hide(tb);
			}
		}
	}
}
