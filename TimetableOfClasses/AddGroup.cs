﻿using LibOfTimetableOfClasses;
using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace TimetableOfClasses
{
    public partial class AddGroup : Form
    {
        private MGroup group;
        public string shortNameSpec;

        public AddGroup()
        {
            InitializeComponent();
            tbNameGroup.Text = "00-ААаа-0а";
            tbVixodnie.Text = "Воскресенье";
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

        public AddGroup(MGroup mGroup)
        {
            InitializeComponent();

            tbNameGroup.Text = mGroup.Group;
            tbNameGroup.Enabled = false;

            nudSemest.Value = mGroup.Semester;

            cbSpec.Text = mGroup.Specialty;

            nudSmena.Value = mGroup.Shift;

            nudCountStudents.Value = mGroup.Students;

            nudMinPar.Value = mGroup.MinNumberOfClass;

            nudMaxPar.Value = mGroup.MaxNumberOfClass;

            tbVixodnie.Text = mGroup.Weekends;

            this.Text = "Изменение группы";
            group = mGroup;
        }

        private void B_Сancel_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void createAndClose_Click(object sender, EventArgs e)
        {
            string[] args = new string[] { tbNameGroup.Text, tbVixodnie.Text };
            if (!isEmpty(args))
            {
                if (Add())
                {
                    Close();
                }
            }
            else message();
        }

        private bool Add()
        {
            string errors = "";
            if (cbSpec.Text.Length < 1)
            {
                errors = "Выберите направление подготовки";
            }


            ushort semest, smena, countStudents, minPar, maxPar;
            if (ushort.TryParse(nudSemest.Value.ToString(), out semest) && semest <= 10 && semest > 0)
                if (ushort.TryParse(nudSmena.Value.ToString(), out smena) && smena <= 2 && smena > 0)
                    if (ushort.TryParse(nudCountStudents.Value.ToString(), out countStudents))
                        if (ushort.TryParse(nudMinPar.Value.ToString(), out minPar))
                            if (ushort.TryParse(nudMaxPar.Value.ToString(), out maxPar))
                                if (nudMaxPar.Value >= nudMinPar.Value)
                                    if (group == null)
                                    {
                                        MGroup Group = new MGroup(tbNameGroup.Text, semest, cbSpec.Text, smena, countStudents, minPar, maxPar, tbVixodnie.Text);
                                        if (RefData.CGroup.Insert(Group))
                                            return true;
                                        else errors = "Невозможно добавить эту группу";
                                    }
                                    else
                                    {
                                        group.Group = tbNameGroup.Text;
                                        group.Semester = semest;
                                        group.Specialty = cbSpec.Text;
                                        group.Shift = smena;
                                        group.Students = countStudents;
                                        group.MinNumberOfClass = minPar;
                                        group.MaxNumberOfClass = maxPar;
                                        group.Weekends = tbVixodnie.Text;
                                        if (RefData.CGroup.Update(group))
                                            return true;
                                        else errors = "Невозможно так изменить эту группу";
                                    }
                                else errors = "Введите корректное максимальное количество пар!";
                            else errors = "Введите корректное минимальное количество пар!";
                        else errors = "Введите корректное количество студентов!";
                    else errors = "Введите корректную смену! (1-2)";
                else errors = "Введите корректный семестр! (1-10)";
            if (errors != "") MessageBox.Show(errors, "Попробуйте еще раз");
            return false;
        }

        private void KeyPress1(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if ((l < 'А' || l > 'я') && l != '\b' && l != '-' && (l < '0' || l > '9'))
            {
                e.Handled = true;
            }
        }

        private void KeyPress2(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if ((l < 'А' || l > 'я') && l != '\b' && l != ' ' && l != '-')
            {
                e.Handled = true;
            }
        }

        private void KeyPress3(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if ((l < 'А' || l > 'я') && l != '\b' && l != ' ' && l != ',')
            {
                e.Handled = true;
            }
        }

        private void KeyPress4(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if ((l < '0' || l > '9') && l != '\b')
            {
                e.Handled = true;
            }
        }

        private void SelectionOfLetters1(object sender, EventArgs e)
        {
            string pattern = @"^[0-9]{2}-[А-Я]{1,2}[а-я]{2}-[0-9]{1}[а-я]{0,1}$";
            Regex regex = new Regex(pattern, RegexOptions.IgnorePatternWhitespace);

            TextBox R = sender as TextBox;

            if (!regex.IsMatch(R.Text))
            {
                R.Text = "00-ААаа-0а";
            }

        }

        private void SelectionOfLetters2(object sender, EventArgs e)
        {
            TextBox R = sender as TextBox;
            R.Text = Regex.Replace(R.Text, "[^а-яА-Я-, ]", "");

            while (R.Text.IndexOf("-") == 0)
                R.Text = R.Text.Substring(1);
            while (R.Text.IndexOf(" ") == 0)
                R.Text = R.Text.Substring(1);
            while (R.Text.IndexOf(",") == 0)
                R.Text = R.Text.Substring(1);
            if (R.Text.Length != 0)
            {
                while (R.Text.LastIndexOf(" ") == R.Text.Length - 1 && R.Text.Length != 0)
                    R.Text = R.Text.Remove(R.Text.Length - 1);
                while (R.Text.LastIndexOf("-") == R.Text.Length - 1 && R.Text.Length != 0)
                    R.Text = R.Text.Remove(R.Text.Length - 1);
                while (R.Text.LastIndexOf(",") == R.Text.Length - 1 && R.Text.Length != 0)
                    R.Text = R.Text.Remove(R.Text.Length - 1);
            }
            R.Text = R.Text.ToLower();
            R.Text = FirstLetterToUpper(R.Text);

        }

        private static string FirstLetterToUpper(string str)
        {
            if (str.Length > 0)
            {
                int index = 0;
                string text = Char.ToUpper(str[0]) + str.Substring(1);
                while (str.IndexOf(",", index + 1) > index)
                {
                    index = str.IndexOf(",", index + 1);
                    for (int i = index + 1; i < text.Length; i++)
                    {
                        if (text[i] >= 'А' && text[i] <= 'я')
                        {
                            text = text.Substring(0, i) + Char.ToUpper(text[i]) + text.Substring(i + 1);
                            break;
                        }
                    }
                }
                return text;
            }
            return "";
        }

        private void fieldChanged(object sender, EventArgs e)
        {
            TextBox R = sender as TextBox;
            if (R.TextLength == 0)
                R.BackColor = Color.Red;
            else
                R.BackColor = Color.White;
        }

        private void SelectNP_Click(object sender, EventArgs e)
        {
            CreateFormForEditAndChoiceUnviversity();
        }

        private void AddGroup_Shown(object sender, EventArgs e)
        {
            if (RefData.CTrainingProfile.Rows.Count == 0)
            {
                var resultNotification = MessageBox.Show("В созависимом справочнике Профили подготовки отсутствуют записи. " +
                    "Отрыть форму для редкатирования справочника Профили подготовки?",
                    "Отсутствие записей в созависимом справочнике", MessageBoxButtons.YesNo);
                if (resultNotification == DialogResult.Yes)
                    CreateFormForEditAndChoiceUnviversity();
            }
        }

        private void CreateFormForEditAndChoiceUnviversity()
        {
            TrainingProfiles selectNP = new TrainingProfiles(true);
            selectNP.Owner = this;
            selectNP.FormClosed += SelectNP_FormClosed;
            selectNP.Show();
        }

        private void SelectNP_FormClosed(object sender, FormClosedEventArgs e)
        {
            string shortNameSpeciality = (sender as TrainingProfiles).ChoseShortNameTrainingProfile;
            if (shortNameSpeciality != null)
                cbSpec.Text = shortNameSpeciality;
        }
    }
}
