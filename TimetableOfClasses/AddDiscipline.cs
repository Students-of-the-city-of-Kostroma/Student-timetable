using LibOfTimetableOfClasses;
using System;
using System.Windows.Forms;

namespace TimetableOfClasses
{
    public partial class AddDiscipline : Form
    {
        bool itsupdate = false;

        public AddDiscipline()
        {
            InitializeComponent();
        }

        public AddDiscipline(MDiscipline mDiscipline)
        {
            InitializeComponent();
            Text = "Изменение дисциплины";
            btCreateAndClean.Visible = false;
            btCreateAndClose.Text = "Сохранить";
            tbFullName.Text = mDiscipline.Fullname;
            tbFullName.Enabled = false;
            tbShortName.Text = mDiscipline.Shortname;
            tbCycleOfDis.Text = mDiscipline.CycleofDiscipline;
            itsupdate = true;
        }

        private void btCreateAndClean_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(tbFullName.Text) || String.IsNullOrWhiteSpace(tbShortName.Text) || String.IsNullOrWhiteSpace(tbCycleOfDis.Text))
                MessageBox.Show("Заполните все поля");
            else
            {
                MDiscipline mDiscipline = new MDiscipline(tbFullName.Text, tbShortName.Text, tbCycleOfDis.Text);
                try
                {

                    if (!Program.refData.CDiscipline.Insert(mDiscipline))
                    {
                        throw new Exception("Невозможно добавить дисциплину");
                    }

                    tbFullName.Text = "";
                    tbShortName.Text = "";
                    tbCycleOfDis.Text = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btCreateAndClose_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(tbFullName.Text) || String.IsNullOrWhiteSpace(tbShortName.Text) || String.IsNullOrWhiteSpace(tbCycleOfDis.Text))
                MessageBox.Show("Заполните все поля");
            else
            {
                MDiscipline mDiscipline = new MDiscipline(tbFullName.Text, tbShortName.Text, tbCycleOfDis.Text);
                try
                {
                    if (!itsupdate)
                    {
                        if (!Program.refData.CDiscipline.Insert(mDiscipline))
                        {
                            throw new Exception("Невозможно добавить дисциплину");
                        }
                    }
                    else Program.refData.CDiscipline.Update(mDiscipline);
                    Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
