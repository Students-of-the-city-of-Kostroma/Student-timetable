using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibOfTimetableOfClasses;

namespace TimetableOfClasses
{
	public partial class TrainingProfiles : Form
	{
		public string ChoseShortNameTrainingProfile;

		public TrainingProfiles(bool forChoice = false)
		{
			InitializeComponent();
			dgProfile.AutoGenerateColumns = false;
			dgProfile.DataSource = Controllers.CTrainingProfile;

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
			p.ShowDialog();
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
						Profile = new MTrainingProfile((string)Row["FullName"], (string)Row["ShortName"]);
						Controllers.CTrainingProfile.Delete(Profile);
					}
				}
			}
		}

		private void ChangeProfile_Click(object sender, EventArgs e)
		{

			if (dgProfile.SelectedRows.Count == 1)
			{
				DataRow Row = ((DataRowView)dgProfile.SelectedRows[0].DataBoundItem).Row;
				MTrainingProfile Profile = new MTrainingProfile((string)Row["FullName"], (string)Row["ShortName"]);
				AddProfile add = new AddProfile(Profile);
				add.Owner = this;
				add.ShowDialog();
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
			if (this.Name == "ВЫбор профиля")
			{
				DataRow Row = ((DataRowView)dgProfile.SelectedRows[0].DataBoundItem).Row;
				ChoseShortNameTrainingProfile = (string)Row["ShortName"];
				Close();
			}
		}
	}
}
