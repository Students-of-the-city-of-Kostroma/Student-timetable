using LibOfTimetableOfClasses;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace TimetableOfClasses
{
    public partial class AddDirectionOfPreparation : Form
    {
        public AddDirectionOfPreparation()
        {
            InitializeComponent();
            itsupdate = false;
            input = Convert.ToString(nuPeriod.Value);
            result = ushort.TryParse(input, out number);
        }
        string input;
        ushort number;
        bool result;
        bool itsupdate = false;
        public AddDirectionOfPreparation(MDirectionOfPreparation mDirection)
        {
            InitializeComponent();
            Text = "Изменение направления";
            bt_Cr_n_Cl.Visible = false;
            bt_Cr_n_Close.Text = "Сохранить";
            tbCod.Text = mDirection.CodeOfDP;
            tbCod.Enabled = false;
            tbName.Text = mDirection.NameOfDP;
            nuPeriod.Text = Convert.ToString(mDirection.PeriodOfStudy);
            input = Convert.ToString(nuPeriod.Value);
            result = ushort.TryParse(input, out number);
            itsupdate = true;
        }
        private void btCancel_Click(object sender, EventArgs e)// отмена
        {
            Close();
        }

        private void bt_Cr_n_Cl_Click(object sender, EventArgs e)// создать и очистить
        {
            if (!(Regex.IsMatch(tbCod.Text, @"\d{2}.\d{2}.\d{2}")))
            {
                MessageBox.Show("Ведите Код направления в виде: 2 цифры, любой символ, 2 цифры, любой символ, 2 цифры (запятую опустить)");
                tbCod.Focus();
            }
            if (!result || String.IsNullOrWhiteSpace(tbCod.Text) || String.IsNullOrWhiteSpace(tbName.Text) || String.IsNullOrWhiteSpace(nuPeriod.Text))
                MessageBox.Show("Заполните все поля корректно");
            else
            {
                MDirectionOfPreparation mDirection = new MDirectionOfPreparation(tbCod.Text, tbName.Text, (ushort)nuPeriod.Value);
                try
                {
                    if (!RefData.CDirectionOfPreparation.Insert(mDirection))
                    {
                        MessageBox.Show("Невозможно добавить направление подготовки");
                        return;
                    }
                    tbCod.Text = "";
                    tbName.Text = "";
                    nuPeriod.Value = 1;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void bt_Cr_n_Close_Click(object sender, EventArgs e)// создать и закрыть
        {
            if (!(Regex.IsMatch(tbCod.Text, @"\d{2}.\d{2}.\d{2}")))
            {
                MessageBox.Show("Ведите Код направления в виде: 2 цифры, любой символ, 2 цифры, любой символ, 2 цифры (запятую опустить)");
                tbCod.Focus();
            }
            else
            {
                if (!result || String.IsNullOrWhiteSpace(tbCod.Text) || String.IsNullOrWhiteSpace(tbName.Text) || String.IsNullOrWhiteSpace(nuPeriod.Text))
                    MessageBox.Show("Заполните все поля корректно");
                else
                {
                    MDirectionOfPreparation mDirection = new MDirectionOfPreparation(tbCod.Text, tbName.Text, (ushort)nuPeriod.Value);
                    try
                    {
                        if (!itsupdate)
                        {
                            if (!RefData.CDirectionOfPreparation.Insert(mDirection))
                            {
                                MessageBox.Show("Невозможно добавить направление подготовки");
                                return;
                            }
                        }
                        else RefData.CDirectionOfPreparation.Update(mDirection);
                        Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void tbCod_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (tbCod.Text.Length < 8 && (Char.IsLetterOrDigit(e.KeyChar) || e.KeyChar == '.') || e.KeyChar == 8)
            {
                return;
            }
            else
                e.Handled = true;
        }
    }
}
