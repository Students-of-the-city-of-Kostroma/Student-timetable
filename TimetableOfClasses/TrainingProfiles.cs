﻿using LibOfTimetableOfClasses;
using System;
using System.Data;
using System.Windows.Forms;

namespace TimetableOfClasses
{
    public partial class TrainingProfiles : Form
    {
        public string ChoseShortNameTrainingProfile;

        public TrainingProfiles(bool forChoice = false)
        {
            InitializeComponent();
            dgProfile.AutoGenerateColumns = false;
            dgProfile.DataSource = RefData.CTrainingProfile;

            if (forChoice)
            {
                this.Name = "ВЫбор профиля";
            }
        }

        public TrainingProfiles(int tmp)
        {
            InitializeComponent();

        }

        private void AddProfile_Click(object sender, EventArgs e)
        {
            AddProfile p = new AddProfile();
            p.Show();
        }

        private void DeleteProfile_Click(object sender, EventArgs e)
        {
            string SelectedName = "";
            foreach (DataGridViewRow row in dgProfile.SelectedRows)
            {
                DataRow Row = ((DataRowView)row.DataBoundItem).Row;
                SelectedName += (string)Row["FullName"] + ", ";
            }
            if (SelectedName.Length > 2)
                SelectedName = SelectedName.Remove(SelectedName.Length - 2);
            if (SelectedName != "")
            {
                DialogResult dr = MessageBox.Show("Удалить профиль - " + SelectedName + "?", "Подтверждение", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dgProfile.SelectedRows.Count > 0 && dr == DialogResult.OK)
                {
                    int countSelected = dgProfile.SelectedRows.Count;

                    MTrainingProfile Profile;
                    foreach (DataGridViewRow row in dgProfile.SelectedRows)
                    {
                        DataRow Row = ((DataRowView)row.DataBoundItem).Row;
                        Profile = new MTrainingProfile((string)Row["FullName"], (string)Row["ShortName"], (string)Row["Shiphr"]);
                        RefData.CTrainingProfile.Delete(Profile);
                    }
                }
            }
        }

        private void ChangeProfile_Click(object sender, EventArgs e)
        {

            if (dgProfile.SelectedRows.Count == 1)
            {
                DataRow Row = ((DataRowView)dgProfile.SelectedRows[0].DataBoundItem).Row;
                MTrainingProfile Profile = new MTrainingProfile((string)Row["FullName"], (string)Row["ShortName"], (string)Row["Shiphr"]);
                AddProfile add = new AddProfile(Profile);
                add.Owner = this;
                add.Show();
            }
            else { MessageBox.Show("Для изменения выделите только одну строку!"); }
        }

        private void dgProfile_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            int index = e.RowIndex;
            string indexStr = (index + 1).ToString();
            object header = dgProfile.Rows[index].HeaderCell.Value;
            if (header == null || !header.Equals(indexStr))
                dgProfile.Rows[index].HeaderCell.Value = indexStr;
        }

        private void dgProfile_SelectionChanged(object sender, EventArgs e)
        {
            if (dgProfile.SelectedCells.Count > 0)
            {
                DeleteProfile.Enabled = true;
                ChangeProfile.Enabled = true;
            }
            else
            {
                DeleteProfile.Enabled = false;
                ChangeProfile.Enabled = false;
            }
        }

        private void DgProfile_DoubleClick(object sender, EventArgs e)
        {
            if (dgProfile.SelectedRows.Count == 1 && this.Name == "ВЫбор профиля")
            {
                DataRow Row = ((DataRowView)dgProfile.SelectedRows[0].DataBoundItem).Row;
                ChoseShortNameTrainingProfile = (string)Row["ShortName"];
                Close();
            }
        }
    }
}
