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
    public partial class AddTypesOfOccupations : Form
    {
        public AddTypesOfOccupations()
        {
            InitializeComponent();
            bool itsupdate = false;
        }
        bool itsupdate = false;
        public AddTypesOfOccupations(MTypesOfOccupations mTypesOfOccupations)
        {
            InitializeComponent();
            Text = "Изменение вида занятия";
            btCreateAndClean.Visible = false;
            btCreateAndClose.Text = "Сохранить";
            tbFullName.Text = mTypesOfOccupations.Fullname;
            tbFullName.Enabled = false;
            tbShortName.Text = mTypesOfOccupations.Shortname;
            itsupdate = true;
        }

        private void btCreateAndClean_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(tbFullName.Text) || String.IsNullOrWhiteSpace(tbShortName.Text))
                MessageBox.Show("Заполните все поля");
            else
            {
                MTypesOfOccupations mTypesOfOccupations = new MTypesOfOccupations(tbFullName.Text, tbShortName.Text);
                try
                {
                    Controllers.CTypesOfOccupations.Insert(mTypesOfOccupations);
                    tbFullName.Text = "";
                    tbShortName.Text = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btCreateAndClose_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(tbFullName.Text) || String.IsNullOrWhiteSpace(tbShortName.Text))
                MessageBox.Show("Заполните все поля");
            else
            {
                MTypesOfOccupations mTypesOfOccupations = new MTypesOfOccupations(tbFullName.Text, tbShortName.Text);
                try
                {
                    if (!itsupdate)
                        Controllers.CTypesOfOccupations.Insert(mTypesOfOccupations);
                    else Controllers.CTypesOfOccupations.Update(mTypesOfOccupations);
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

