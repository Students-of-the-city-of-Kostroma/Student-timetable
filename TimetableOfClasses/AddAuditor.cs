using LibOfTimetableOfClasses;
using System;
using System.Windows.Forms;

namespace TimetableOfClasses
{
    public partial class AddAuditor : Form
    {
        bool itsupdate = false;

        public AddAuditor()
        {
            InitializeComponent();
            itsupdate = false;
        }

        public AddAuditor(MAuditor mAuditor)
        {
            InitializeComponent();
            this.Text = "Изменение аудитории";
            bt_Cr_n_Cl.Visible = false;
            bt_Cr_n_Close.Text = "Сохранить";
            tbAuditor.Text = mAuditor.NameOfAuditor;
            tbAuditor.Enabled = false;
            tbKaf.Text = mAuditor.Cafedra;
            tbCorpus.Text = Convert.ToString(mAuditor.Building);
            tbCorpus.Enabled = false;
            nuPlaces.Value = mAuditor.Spacious;
            itsupdate = true;
        }

        private void btCancel_Click(object sender, EventArgs e)// отмена
        {
            Close();
        }

        private void bt_Cr_n_Cl_Click(object sender, EventArgs e)// создать и очистить
        {
            if (String.IsNullOrWhiteSpace(tbAuditor.Text) || String.IsNullOrWhiteSpace(tbKaf.Text) || String.IsNullOrWhiteSpace(tbCorpus.Text) || String.IsNullOrWhiteSpace(tbCorpus.Text) || String.IsNullOrWhiteSpace(nuPlaces.Text) || nuPlaces.Value == 0)
                MessageBox.Show("Заполните все поля корректно");
            else
            {
                MAuditor Auditor = new MAuditor(tbAuditor.Text, tbKaf.Text, (ushort)nuPlaces.Value, tbCorpus.Text);
                try
                {

                    if (!RefData.CAuditor.Insert(Auditor))
                    {
                        MessageBox.Show("Невозможно добавить аудиторию");
                        return;
                    }

                    tbAuditor.Text = "";
                    tbKaf.Text = "";
                    tbCorpus.Text = "";
                    nuPlaces.Value = 1;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void bt_Cr_n_Close_Click(object sender, EventArgs e)// создать и закрыть
        {
            if (String.IsNullOrWhiteSpace(tbAuditor.Text) || String.IsNullOrWhiteSpace(tbKaf.Text) || String.IsNullOrWhiteSpace(tbCorpus.Text) || String.IsNullOrWhiteSpace(tbCorpus.Text) || String.IsNullOrWhiteSpace(nuPlaces.Text) || nuPlaces.Value == 0)
                MessageBox.Show("Заполните все поля корректно");
            else
            {
                MAuditor Auditor = new MAuditor(tbAuditor.Text, tbKaf.Text, (ushort)nuPlaces.Value, tbCorpus.Text);
                try
                {
                    if (!itsupdate)
                    {
                        if (!RefData.CAuditor.Insert(Auditor))
                        {
                            MessageBox.Show("Невозможно добавить аудиторию");
                            return;
                        }
                    }
                    else RefData.CAuditor.Update(Auditor);
                    Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void tbAuditor_KeyPress(object sender, KeyPressEventArgs e)// Аудитория
        {
            if (Char.IsLetterOrDigit(e.KeyChar) || e.KeyChar == 8) return;
            else
                e.Handled = true;
        }

        private void tbKaf_KeyPress(object sender, KeyPressEventArgs e)// Кафедра
        {
            if (Char.IsLetter(e.KeyChar) || Convert.ToString(e.KeyChar) == " " || e.KeyChar == 8) return;
            else
                e.Handled = true;
        }

        private void tbCorpus_KeyPress(object sender, KeyPressEventArgs e)// Корпус
        {
            byte k;
            if (!(byte.TryParse(Convert.ToString(e.KeyChar), out k) || e.KeyChar == 8))
            {
                e.Handled = true;
            }
        }

        private void btCorpus_Click(object sender, EventArgs e)
        {
            Enclosures selectCorpus = new Enclosures(true);
            selectCorpus.FormClosing += SelectCorpus_FormClosing;
            selectCorpus.Show();
        }
        private void SelectCorpus_FormClosing(object sender, FormClosingEventArgs e)
        {
            Enclosures selectCorpus = (Enclosures)sender;
            tbCorpus.Text = selectCorpus.selectEnclosures;
        }
    }
}
