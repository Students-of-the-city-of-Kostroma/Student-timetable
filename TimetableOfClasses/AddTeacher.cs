using LibOfTimetableOfClasses;
using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace TimetableOfClasses
{
    public partial class AddTeacher : Form
    {
        private MTeacher Lehrer;

        public AddTeacher()
        {
            InitializeComponent();
            firstName.Text = "Иван";
            secondName.Text = "Иванов";
            patronymic.Text = "Иванович";
            department.Text = "ФАСТ";
            metodDays.Text = "Пн, Вт";
            windows.Text = "Ср, Чт, Пт";
            weekends.Text = "Сб, Вс";
        }

        private bool isEmpty(string[] strArgs)
        {
            foreach (var cur in strArgs)
            {
                if (cur.Length == 0)
                {
                    return true;
                }
            }
            return false;
        }

        private void message()
        {
            MessageBox.Show("Заполните все пустые строки", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public AddTeacher(MTeacher mTeacher)
        {
            InitializeComponent();
            this.Text = "Изменение преподавателя";
            checkPatronymic.Enabled = false;
            #region(FullName)

            firstName.Text = mTeacher.FirstName;
            firstName.Enabled = false;

            secondName.Text = mTeacher.SecondName;
            secondName.Enabled = false;

            patronymic.Text = mTeacher.Patronymic;
            patronymic.Enabled = false;

            #endregion

            academicDegree.Text = mTeacher.AcademicDegree;

            academicTitle.Text = mTeacher.AcademicTitle;

            department.Text = mTeacher.Departament;

            metodDays.Text = mTeacher.MetodicalDays;

            windows.Text = mTeacher.Windows;

            weekends.Text = mTeacher.Weekends;

            Lehrer = mTeacher;

        }

        private void createAndClose_Click(object sender, EventArgs e)
        {
            try
            {
                Logs.GetInfo("Click button Save in AddTeacher");
                if (!isEmpty(new string[] { secondName.Text, firstName.Text, academicDegree.Text, academicTitle.Text, department.Text, metodDays.Text, weekends.Text }))
                {
                    if (Add())
                    {
                        Close();
                    }
                    else MessageBox.Show("Невозможно добавить этого преподавателя", "Попробуйте снова");
                }
                else message();
            }
            catch (Exception ex)
            {
                Logs.GetError(ex);
            }
        }

        private bool Add()
        {
            try
            {
                if (Lehrer == null)
                {
                    MTeacher Prepodavatel = new MTeacher(firstName.Text, secondName.Text, patronymic.Text, academicDegree.Text, academicTitle.Text, department.Text, metodDays.Text, windows.Text, weekends.Text);
                    return Program.refData.CTeacher.Insert(Prepodavatel);
                }
                else
                {
                    Lehrer.FirstName = firstName.Text;
                    Lehrer.SecondName = secondName.Text;
                    Lehrer.Patronymic = patronymic.Text;
                    Lehrer.AcademicDegree = academicDegree.Text;
                    Lehrer.AcademicTitle = academicTitle.Text;
                    Lehrer.Departament = department.Text;
                    Lehrer.MetodicalDays = metodDays.Text;
                    Lehrer.Windows = windows.Text;
                    Lehrer.Weekends = weekends.Text;
                    return Program.refData.CTeacher.Update(Lehrer);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Заполнены не все поля или заполнены некорректно", "Ошибка", MessageBoxButtons.OK);
                return false;
            }
        }

        /// <summary>
        /// Здесь должны быть комментарии
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddTeacher_Load(object sender, EventArgs e)
        {

        }

        private void SelectionOfLetters1(object sender, EventArgs e)
        {
            TextBox R = sender as TextBox;
            R.Text = Regex.Replace(R.Text, "[^а-яА-Я ]", "");
            R.Text = Regex.Replace(R.Text, "[, ]+", ", ");

            if (R.Text.Length > 2)
            {
                if (R.Text.IndexOf(", ") == 0)
                    R.Text = R.Text.Substring(1);
                if (R.Text.LastIndexOf(", ") == R.Text.Length - 1)
                    R.Text = R.Text.Remove(R.Text.Length - 1);
                R.Text = R.Text.ToLower();
                R.Text = PeriodLetterToUpper(R.Text);
            }

        }

        private void SelectionOfLetters2(object sender, EventArgs e)
        {
            TextBox R = sender as TextBox;
            R.Text = Regex.Replace(R.Text, "[^а-яА-Я ]", "");
            R.Text = Regex.Replace(R.Text, "[ ]+", " ");
            if (R.Text.Length > 2)
            {
                if (R.Text.IndexOf(" ") == 0)
                    R.Text = R.Text.Substring(1);
                if (R.Text.LastIndexOf(" ") == R.Text.Length - 1)
                    R.Text = R.Text.Remove(R.Text.Length - 1);
                R.Text = R.Text.ToLower();
                R.Text = FirstLetterToUpper(R.Text);
            }
            if (R.Text.Length == 1)
            {
                R.Text = R.Text.ToLower();
                R.Text = FirstLetterToUpper(R.Text);
            }

        }

        private void SelectionOfLetters3(object sender, EventArgs e)
        {
            TextBox R = sender as TextBox;
            R.Text = Regex.Replace(R.Text, "[^а-яА-Я ]", "");
            R.Text = Regex.Replace(R.Text, "[ ]+", " ");

            if (R.Text.Length > 2)
            {
                if (R.Text.IndexOf(" ") == 0)
                    R.Text = R.Text.Substring(1);
                if (R.Text.LastIndexOf(" ") == R.Text.Length - 1)
                    R.Text = R.Text.Remove(R.Text.Length - 1);
                R.Text = R.Text.ToUpper();
            }

        }

        private void SelectionOfLetters4(object sender, EventArgs e)
        {
            TextBox R = sender as TextBox;
            R.Text = Regex.Replace(R.Text, "[^0-9а-яА-Я-, ]", "");
            R.Text = Regex.Replace(R.Text, "[ ]+", " ");

            if (R.Text.Length > 2)
            {
                if (R.Text.IndexOf(" ") == 0)
                    R.Text = R.Text.Substring(1);
                if (R.Text.LastIndexOf(" ") == R.Text.Length - 1)
                    R.Text = R.Text.Remove(R.Text.Length - 1);
                R.Text = R.Text.ToLower();
                R.Text = FirstLetterToUpper(R.Text);
            }

        }

        private static string FirstLetterToUpper(string str)
        {
            if (str.Length > 0)
            {
                if (str.IndexOf("-") > 0)
                {
                    return Char.ToUpper(str[0]) + str.Substring(1, str.IndexOf("-")) + Char.ToUpper(str[str.IndexOf("-") + 1]) + str.Substring(str.IndexOf("-") + 2);
                }
                else
                    return Char.ToUpper(str[0]) + str.Substring(1);
            }
            return "";
        }

        private static string PeriodLetterToUpper(string str)
        {
            if (str.Length > 0)
            {
                if (str.IndexOf(",") > 0)
                {
                    char p;
                    str = Char.ToUpper(str[0]) + str.Substring(1);
                    for (int i = 0; i < str.Length; i++)
                    {
                        if (str[i] == ',')
                        {
                            p = Char.ToUpper(str[i + 2]);
                            str = str.Remove(i + 2, 1);
                            str = str.Insert(i + 2, "" + p);
                        }
                    }
                    return str;
                }
                else
                    return Char.ToUpper(str[0]) + str.Substring(1);
            }
            return "";
        }



        private void KeyPress1(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if ((l < 'А' || l > 'я') && l != '\b')
            {
                e.Handled = true;
            }
        }

        private void KeyPress2(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if ((l < 'A' || l > 'z') && (l < 'А' || l > 'я') && l != '\b' && l != '-' && l != ' ' && l != ',' && (l < '0' || l > '9') && l != '.')
            {
                e.Handled = true;
            }
        }

        private void KeyPress3(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if ((l < 'А' || l > 'я') && l != '\b' && l != ' ')
            {
                e.Handled = true;
            }
            e.Handled = false;
        }

        private void B_Сancel_Click(object sender, EventArgs e)
        {
            try
            {
                Logs.GetInfo("Click button Cancel in AddTeacher");
                Close();
            }
            catch (Exception ex)
            {
                Logs.GetError(ex);
            }
        }

        private void fieldChanged(object sender, EventArgs e)
        {
            TextBox R = sender as TextBox;
            if (R.TextLength == 0)
                R.BackColor = Color.Red;
            else
                R.BackColor = Color.White;

            //ComboBox T = sender as ComboBox;
            //if (T.SelectedItem == null)
            //    T.BackColor = Color.Red;
            //else
            //    T.BackColor = Color.White;

        }

        private void checkPatronymic_CheckedChanged(object sender, EventArgs e)
        {
            if (checkPatronymic.Checked)
            {
                patronymic.Text = "";
                patronymic.Enabled = false;
            }
            else
            {
                patronymic.Enabled = true;
            }
        }

        private void SelectAD_Click(object sender, EventArgs e)
        {
            CreateFormForEditAndChoiceAD();
        }

        private void SelectAT_Click(object sender, EventArgs e)
        {
            CreateFormForEditAndChoiceAT();
        }

        private void CreateFormForEditAndChoiceAT()
        {
            AcademicTitle selectAT = new AcademicTitle(true);
            selectAT.Owner = this;
            selectAT.FormClosed += SelectAT_FormClosed;
            selectAT.Show();
        }

        private void SelectAT_FormClosed(object sender, FormClosedEventArgs e)
        {
            string reduction = (sender as AcademicTitle).ChoseReductionAcademicTitle;
            if (reduction != null)
                academicTitle.Text = reduction;
        }

        private void CreateFormForEditAndChoiceAD()
        {
            AcademicDegree selectAD = new AcademicDegree(true);
            selectAD.Owner = this;
            selectAD.FormClosed += SelectAD_FormClosed;
            selectAD.Show();
        }

        private void SelectAD_FormClosed(object sender, FormClosedEventArgs e)
        {
            string reduction = (sender as AcademicDegree).ChoseReductionAcademicDegree;
            if (reduction != null)
                academicDegree.Text = reduction;
        }

        private void AddTeacher_Shown(object sender, EventArgs e)
        {
            if (Program.refData.CAcademicDegree.Rows.Count == 0)
            {
                var resultNotification = MessageBox.Show("В созависимом справочнике Академические степени отсутствуют записи. " +
                    "Отрыть форму для редкатирования справочника Академические степени?",
                    "Отсутствие записей в созависимом справочнике", MessageBoxButtons.YesNo);
                if (resultNotification == DialogResult.Yes)
                    CreateFormForEditAndChoiceAD();
            }

            if (Program.refData.CTitle.Rows.Count == 0)
            {
                var resultNotification = MessageBox.Show("В созависимом справочнике Академические звания отсутствуют записи. " +
                    "Отрыть форму для редкатирования справочника Академические звания?",
                    "Отсутствие записей в созависимом справочнике", MessageBoxButtons.YesNo);
                if (resultNotification == DialogResult.Yes)
                    CreateFormForEditAndChoiceAT();
            }
        }
    }
}