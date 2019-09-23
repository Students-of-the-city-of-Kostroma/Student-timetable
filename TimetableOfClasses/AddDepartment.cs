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
        private ToolTip shortTitleTooltip = new ToolTip();
        private ToolTip fullTitleTooltip = new ToolTip();
        private ToolTip departmentHeadTooltip = new ToolTip();
        private ToolTip instituteTooltip = new ToolTip();

        private bool shortTitleValidated = false;
        private bool fullTitleValidated = false;
        private bool departmentHeadValidated = false;
        private bool instituteValidated = false;

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
        /// <param name="s"></param>
        /// <param name="e"></param>
        private void CreateAndCloseClick(object s, EventArgs e) {
            if (!this.shortTitleValidated || !this.fullTitleValidated || !this.departmentHeadValidated || !this.instituteValidated) {
                MessageBox.Show("Пожалуйста корректно заполните поля формы.", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try {
                MDepartment mDepartment = new MDepartment(
                    this.shortTitle.Text,
                    this.fullTitle.Text,
                    this.departmentHead.Text,
                    this.institute.Text
                );
                MessageBox.Show("Форма успешно заполнена!\nНа данный момент функционал добавления кафедры в список еще не реализован.", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } catch {
                MessageBox.Show("Пожалуйста корректно заполните поля формы.", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Обработка события изменения краткого названия кафедры
        /// </summary>
        /// <param name="s"></param>
        /// <param name="e"></param>
        private void ShortTitleTextChanged(object s, EventArgs e) {
            bool v = ValidateHandler(MDepartment.ValidateShortTitle((s as TextBox).Text, out string[] res), res, s, this.shortTitleTooltip);
            this.shortTitleValidated = v;
        }

        /// <summary>
        /// Обработка события изменения полного названия кафедры
        /// </summary>
        /// <param name="s"></param>
        /// <param name="e"></param>
        private void FullTitleTextChanged(object s, EventArgs e) {
            bool v = ValidateHandler(MDepartment.ValidateFullTitle((s as TextBox).Text, shortTitle.Text, out string[] res), res, s, this.fullTitleTooltip);
            this.fullTitleValidated = v;
        }

        /// <summary>
        /// Обработка события изменения завудующего кафедрой
        /// </summary>
        /// <param name="s"></param>
        /// <param name="e"></param>
        private void DepartmentHeadTextChanged(object s, EventArgs e) {
            bool v = ValidateHandler(MDepartment.ValidateDepartmentHead((s as TextBox).Text, out string[] res), res, s, this.departmentHeadTooltip);
            this.departmentHeadValidated = v;
        }

        /// <summary>
        /// Обработка события изменения названия института
        /// </summary>
        /// <param name="s"></param>
        /// <param name="e"></param>
        private void InstituteTextChanged(object s, EventArgs e) {
            bool v = ValidateHandler(MDepartment.ValidateInstitute((s as TextBox).Text, out string[] res), res, s, this.instituteTooltip);
            this.instituteValidated = v;
        }

        /// <summary>
        /// Проверка строки переданным результатом валидации и подсветка в случае ошибки.
        /// Добавляет тултип на поле с указанием ошибки.
        /// </summary>
        /// <param name="validator">Результат валидации</param>
        /// <param name="msgs">Массив сообщений об ошибках</param>
        /// <param name="sender">Отправитель события об изменении поля</param>
        /// <param name="tooltip">Прикрепленный tooltip</param>
        /// <returns>Успешность проверки</returns>
        private bool ValidateHandler(bool validator, string[] msgs, object sender, ToolTip tooltip) {
            TextBox tb = sender as TextBox;
            if (!validator) {
                tooltip.ToolTipTitle = "Ошибка!";
                tooltip.ToolTipIcon = ToolTipIcon.Error;
                tooltip.SetToolTip(tb, String.Join("\n", msgs));
                tb.BackColor = Color.Coral;
                return false;
            }
            tb.BackColor = SystemColors.Window;
            tooltip.ToolTipTitle = null;
            tooltip.ToolTipIcon = ToolTipIcon.None;
            tooltip.SetToolTip(tb, null);
            tooltip.Hide(tb);
            return true;
        }
    }
}
