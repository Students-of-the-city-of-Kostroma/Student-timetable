using LibOfTimetableOfClasses;
using System;
using System.Windows.Forms;


namespace TimetableOfClasses
{
    public partial class AddTypesOfOccupation : Form
    {
        public AddTypesOfOccupation()
        {
            InitializeComponent();
            itsupdate = false;
        }

        private readonly bool itsupdate;
        public AddTypesOfOccupation(MTypesOfOccupations mTypesOfOccupations)
        {
            InitializeComponent();
            Text = "Изменение вида занятия";
            btCreateAndClean.Visible = false;
            btCreateAndClose.Text = "Сохранить";
            tbFullName.Text = mTypesOfOccupations.FullName;
            tbFullName.Enabled = false;
            tbShortName.Text = mTypesOfOccupations.ShortName;
            itsupdate = true;
        }

        private void BtCreateAndClean_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(tbFullName.Text) || String.IsNullOrWhiteSpace(tbShortName.Text))
                MessageBox.Show("Заполните все поля");
            else
            {
                MTypesOfOccupations mTypesOfOccupations = new MTypesOfOccupations(tbFullName.Text, tbShortName.Text);
                try
                {
                    Program.refData.CTypesOfOccupations.Insert(mTypesOfOccupations);
                    tbFullName.Text = "";
                    tbShortName.Text = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void BtCreateAndClose_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(tbFullName.Text) || String.IsNullOrWhiteSpace(tbShortName.Text))
                MessageBox.Show("Заполните все поля");
            else
            {
                MTypesOfOccupations mTypesOfOccupations = new MTypesOfOccupations(tbFullName.Text, tbShortName.Text);
                try
                {
                    if (!itsupdate)
                        Program.refData.CTypesOfOccupations.Insert(mTypesOfOccupations);
                    else Program.refData.CTypesOfOccupations.Update(mTypesOfOccupations);
                    Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void BtCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

