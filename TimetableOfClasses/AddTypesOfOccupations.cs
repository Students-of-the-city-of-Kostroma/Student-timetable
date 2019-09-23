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
            itsupdate = false;
        }

        private readonly bool itsupdate;
        public AddTypesOfOccupations(MTypesOfOccupations mTypesOfOccupations)
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
                    RefData.CTypesOfOccupations.Insert(mTypesOfOccupations);
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
                        RefData.CTypesOfOccupations.Insert(mTypesOfOccupations);
                    else RefData.CTypesOfOccupations.Update(mTypesOfOccupations);
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

