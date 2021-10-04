﻿using LibOfTimetableOfClasses;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace TimetableOfClasses
{
    public partial class AddAcademicDegree : AddInstance
    {
        public AddAcademicDegree()
        {
            InitializeComponent();
            update = false;
        }
        bool update = false;

        public AddAcademicDegree(MAcademicDegree mAcademicDegree)
        {
            InitializeComponent();
            this.Text = "Изменение учёной степени";
            this.button1.Visible = false;
            this.button2.Text = "Изменить";
            this.Reduction.Enabled = false;
            FullName.Text = mAcademicDegree.FullName;
            Reduction.Text = mAcademicDegree.Reduction;
            update = true;
        }
        public void CreateDegree()
        {
            if ((Reduction.Text.Length != 0) || (FullName.Text.Length != 0))
            {
                if (Reduction.Text.Length != 0)
                {
                    if (FullName.Text.Length != 0)
                    {
                        if (FullName.Text.Length >= Reduction.Text.Length)
                        {
                            try
                            {
                                MAcademicDegree AcademicDegree = new MAcademicDegree(FullName.Text, Reduction.Text);
                                if (update)
                                {
                                    Program.refData.CAcademicDegree.Update(AcademicDegree);
                                }
                                else 
                                {
                                    Program.refData.CAcademicDegree.Insert(AcademicDegree);
                                }
                                FullName.Text = "";
                                Reduction.Text = "";
                            }
                            catch (Exception)
                            {
                                MessageBox.Show("Некорректно заполнены поля", "Ошибка");
                            }
                        }
                        else MessageBox.Show("Полe 'Полная запись учёной степени' должно быть больше или равно полю 'Сокращённая запись учёной степени'",
                            "Попробуйте снова", MessageBoxButtons.OK);
                    }
                    else MessageBox.Show("Заполните полe 'Полная запись учёной степени'", "Попробуйте снова", MessageBoxButtons.OK);
                }
                else MessageBox.Show("Заполните полe 'Сокращённая запись учёной степени'", "Попробуйте снова", MessageBoxButtons.OK);
            }
            else MessageBox.Show("Заполните поля", "Попробуйте снова", MessageBoxButtons.OK);
        }
        private void Button1_Click(object sender, EventArgs e)  // Создать и очистить
        {
            CreateDegree();
        }
        private void Button2_Click(object sender, EventArgs e) //Создать и закрыть
        {
                CreateDegree();
                Close();
        }

        private void Button3_Click(object sender, EventArgs e) //Отмена
        {
            this.Close();
        }

        private void Reduction_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if ((l < 'А' || l > 'я') && l != '\b' && l != '.' && l != '-')
            {
                e.Handled = true;
            }
        }

        private void FullName_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if ((l < 'А' || l > 'я') && l != '\b' && l != '.' && l != '-')
            {
                e.Handled = true;
            }
        }

        private void Reduction_TextChanged(object sender, EventArgs e)
        {
            if (((TextBox)sender).Text.Length == 1)
                ((TextBox)sender).Text = ((TextBox)sender).Text.ToUpper();
            ((TextBox)sender).Select(((TextBox)sender).Text.Length, 0);
        }

        private void FullName_TextChanged(object sender, EventArgs e)
        {
            if (((TextBox)sender).Text.Length == 1)
                ((TextBox)sender).Text = ((TextBox)sender).Text.ToUpper();
            ((TextBox)sender).Select(((TextBox)sender).Text.Length, 0);
        }
        
        private void Reduction_Leave(object sender, EventArgs e)
        {
            TerxtBox_Leave(sender, e);
        }
        private void TerxtBox_Leave(object sender, EventArgs e)
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
        private void FullName_Leave(object sender, EventArgs e)
        {
            TerxtBox_Leave(sender, e);
        }
    }
}