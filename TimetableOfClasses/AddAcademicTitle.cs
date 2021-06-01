using LibOfTimetableOfClasses;
using System;
using System.ComponentModel;
using System.Data;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace TimetableOfClasses
{
    public partial class AddAcademicTitle : Form
    {
        public AddAcademicTitle()
        {
            InitializeComponent();
            update = false;
        }
        bool update = false;
        public AddAcademicTitle(MTitle mTitle)
        {
            InitializeComponent();
            this.Text = "Изменение уч. звания";
            this.btCreateAndClean.Visible = false;
            this.btCreateAndClose.Text = "Изменить";
            this.Reduction.Enabled = false;
            FullName.Text = mTitle.FullName;
            Reduction.Text = mTitle.Reduction;
            update = true;
        }

        private void btCreateAndClose_Click(object sender, EventArgs e)
        {
            try
            {
                if ((Reduction.Text.Length != 0) && (FullName.Text.Length != 0))
                {
                    if (isNumberDontContains(Reduction.Text) && isNumberDontContains(FullName.Text))
                    {
                        if (update)
                        {
                            MTitle Title = new MTitle(FullName.Text, Reduction.Text);
                            Program.refData.CTitle.Update(Title);
                            FullName.Text = "";
                            Reduction.Text = "";
                            Close();
                        }
                        else
                        {
                            MTitle Title = new MTitle(FullName.Text, Reduction.Text);
                            if (!Program.refData.CTitle.Insert(Title))
                            {
                                MessageBox.Show("Невозможно добавить это уч. звание", "Попробуйте снова");
                                return;
                            }
                            FullName.Text = "";
                            Reduction.Text = "";
                            Close();
                        }
                    }
                    else MessageBox.Show("Можно вводить только буквы и знаки: точка и тире", "Попробуйте снова");
                }
                else MessageBox.Show("Невозможно добавить это уч. звание", "Попробуйте снова");
            }
            catch (DeletedRowInaccessibleException)
            {
                MessageBox.Show("Невозможно получить доступ к удаленной информации строки через данную строку", "Ошибка");
            }
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        static bool isNumberDontContains(string input)
        {
            foreach (char c in input)
                if (Char.IsNumber(c) || Char.IsPunctuation(c) || Char.IsSymbol(c))
                {
                    if (c == '.' || c == '-')
                        continue;
                    return false;
                }
            return true;
        }

        private void Reduction_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (((TextBox)sender).Text.Length == 1)
                ((TextBox)sender).Text = ((TextBox)sender).Text.ToUpper();
            ((TextBox)sender).Select(((TextBox)sender).Text.Length, 0);
        }

        private void FullName_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (((TextBox)sender).Text.Length == 1)
                ((TextBox)sender).Text = ((TextBox)sender).Text.ToUpper();
            ((TextBox)sender).Select(((TextBox)sender).Text.Length, 0);
        }

        private void Reduction_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(Reduction.Text))
                errorProvider1.SetError(Reduction, "Пустое поле");

            if (!Regex.IsMatch(Reduction.Text, @"[А-Яа-я\-\' ']"))
                errorProvider1.SetError(Reduction, "Можно вводить только силволы русского алфавита и тире");

            if (Reduction.Text.Length > 25)
                errorProvider1.SetError(Reduction, "Слишком длинное значение (не более 25)");

            if (Reduction.Text.Length <= 1)
                errorProvider1.SetError(Reduction, "Слишком короткое значение");
        }
        private void FullName_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(FullName.Text))
                errorProvider1.SetError(FullName, "Пустое поле");
                
            if (!Regex.IsMatch(FullName.Text, @"[А-Яа-я\-\' ']"))
                errorProvider1.SetError(FullName, "Можно вводить только силволы русского алфавита и тире");

            if (FullName.Text.Length > 25)
                errorProvider1.SetError(FullName, "Слишком длинное значение (не более 25)");

            if (FullName.Text.Length <= 1)
                errorProvider1.SetError(FullName, "Слишком короткое значение");
        }
    }
}
