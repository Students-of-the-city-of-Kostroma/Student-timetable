using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibOfTimetableOfClasses;

namespace TimetableOfClasses
{
    public partial class AddProfile : Form
    {
        public string codeSpec;
        bool itsupdate = false;
        public AddProfile()
        {
            InitializeComponent();
            itsupdate = false;
        }
        public AddProfile(MTrainingProfile mProfile)
        {
            InitializeComponent();
            tbCodeSpec.ReadOnly = true;
            Text = "Изменение профиля подготовки";
            bt_Cr_n_Cl.Visible = false;
            bt_Cr_n_Close.Text = "Сохранить";
            tbFullName.Text = mProfile.FullName;
            tbFullName.Enabled = false;
            tbShortName.Text = mProfile.ShortName;
            tbCodeSpec.Text = mProfile.Shiphr;
            itsupdate = true;
        }
        private void btCancel_Click(object sender, EventArgs e)// отмена
        {
            Close();
        }

        private void bt_Cr_n_Cl_Click(object sender, EventArgs e)// создать и очистить
        {
            if (tbShortName.Text.Length > tbFullName.Text.Length)
            {
                MessageBox.Show("Длина поля 'Краткое название профиля' должно быть меньше длины поля 'Полное название профиля'");
                return;
            }
            if (String.IsNullOrWhiteSpace(tbFullName.Text) || String.IsNullOrWhiteSpace(tbShortName.Text) || String.IsNullOrWhiteSpace(tbCodeSpec.Text))
                MessageBox.Show("Заполните все поля корректно");
            else
            {

                MTrainingProfile Profile = new MTrainingProfile(tbFullName.Text, tbShortName.Text, tbCodeSpec.Text);
                try
                {
                    if (!RefData.CTrainingProfile.Insert(Profile))
                    {
                        MessageBox.Show("Невозможно добавить профиль подготовки");
                        return;
                    }

                    tbFullName.Text = "";
                    tbShortName.Text = "";
                    tbCodeSpec.Text = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void bt_Cr_n_Close_Click(object sender, EventArgs e)// создать и закрыть
        {
            if (tbShortName.Text.Length > tbFullName.Text.Length)
            {
                MessageBox.Show("Длина поля 'Краткое название профиля' должно быть меньше длины поля 'Полное название профиля'");
                return;
            }
            if (String.IsNullOrWhiteSpace(tbFullName.Text) || String.IsNullOrWhiteSpace(tbShortName.Text))
                MessageBox.Show("Заполните все поля корректно");
            else
            {
                MTrainingProfile Profile = new MTrainingProfile(tbFullName.Text, tbShortName.Text, tbCodeSpec.Text);
                try
                {
                    if (!itsupdate)
                    {
                        if (!RefData.CTrainingProfile.Insert(Profile))
                        {
                            MessageBox.Show("Невозможно добавить профиль подготовки");
                            return;
                        }
                    }
                    else RefData.CTrainingProfile.Update(Profile);
                    Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }


        private void btCodeSpec_Click(object sender, EventArgs e)
        {
            DirectionOfPreparation selectCode = new DirectionOfPreparation(true);
            //selectCode.Owner = this;
            //selectCode.ShowDialog();
            //tbCodeSpec.Text = codeSpec;
            selectCode.FormClosing += SelectCode_FormClosing;
            selectCode.Show();
        }

        private void SelectCode_FormClosing(object sender, FormClosingEventArgs e)
        {
            DirectionOfPreparation selectCode = (DirectionOfPreparation)sender;
            tbCodeSpec.Text = selectCode.selectDirectionOfPreparation;
        }

        private void tbFullName_Leave(object sender, EventArgs e)
        {
            var R = sender as TextBox;
            R.Text = Regex.Replace(R.Text, @"[^А-Яа-я ]", "");
            if (R.Text.Length != 0)
                R.Text = R.Text.First().ToString().ToUpper() + R.Text.Substring(1);

        }

        private void tbShortName_Leave(object sender, EventArgs e)
        {
            var R = sender as TextBox;
            R.Text = R.Text.ToUpper();
            R.Text = Regex.Replace(R.Text, @"[^А-Я]", "");
        }

        private void tbFullName_KeyPress(object sender, KeyPressEventArgs e)
        {
            Regex regex = new Regex(@"[а-яА-Я ]");
            if (!regex.IsMatch(e.KeyChar.ToString()) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
                return;
            }
        }

        private void tbShortName_KeyPress(object sender, KeyPressEventArgs e)
        {
            Regex regex = new Regex(@"[А-Яа-я]");
            if (!regex.IsMatch(e.KeyChar.ToString()) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
                return;
            }
        }
    }
}
