using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using TimetableOfClasses.DTO;

namespace TimetableOfClasses
{
    public partial class Timetable : Form
    {
        List<InstituteDto> institutes = new List<InstituteDto>();
        List<GroupDto> allGroups = new List<GroupDto>();
        List<CourseDto> allCourses = new List<CourseDto>();
        List<TrainingProfileDto> allProfiles = new List<TrainingProfileDto>();

        public Timetable()
        {
            InitializeComponent();
        }

        public void initRefData(LibOfTimetableOfClasses.RefData refData)
        {
            institutes = refData.CInstitute.AsEnumerable()
                .Select(row => new InstituteDto
                {
                    ID = row.Field<string>("ShortName"),
                    FullName = row.Field<string>("FullName")
                }).ToList();
            cboInstitute.DataSource = institutes;
            cboInstitute.DisplayMember = "FullName";
            cboInstitute.ValueMember = "ID";

            cboCourse.Enabled = false;
            cboGroup.Enabled = false;

            allCourses = refData.CDirectionOfPreparation.AsEnumerable()
                .Select(row => new CourseDto
                {
                    ID = row.Field<string>("CodeOfDP"),
                    NameOfDP = row.Field<string>("NameOfDP"), 
                    InstituteShortName = row.Field<string>("InstituteShortName")
                }).ToList();

            allProfiles = refData.CTrainingProfile.AsEnumerable()
                .Select(row => new TrainingProfileDto
                {
                    Code = row.Field<string>("Shiphr"),
                    ShortName = row.Field<string>("ShortName")
                }).ToList();

            allGroups = refData.CGroup.AsEnumerable()
                .Select(row => new GroupDto
                {
                    ID = row.Field<string>("Group"),
                    Group = row.Field<string>("Group"),
                    Speciality = row.Field<string>("Specialty")
                }).ToList();
        }

        private void CboInstitute_SelectionChangeCommitted(object sender, System.EventArgs e)
        {
            ComboBox cbo = (ComboBox)sender;
            InstituteDto selectedInstitute = (InstituteDto)cbo.SelectedItem;

            var courses = allCourses.Where<CourseDto>(gr => gr.InstituteShortName == selectedInstitute.ID).ToList();
            if (courses.Count > 0)
            {
                cboCourse.Enabled = true;
                cboCourse.DisplayMember = "NameOfDP";
                cboCourse.ValueMember = "ID";
                cboCourse.DataSource = courses;
            }
            else
            {
                cboCourse.DataSource = null;
                cboCourse.Enabled = false;
                cboCourse.Text = "Выберите направление подготовки";
                cboGroup.DataSource = null;
                cboGroup.Enabled = false;
                cboGroup.Text = "Выберите группу";
            }
        }

        private void CboCourse_SelectionChangeCommitted(object sender, System.EventArgs e)
        {
            ComboBox cbo = (ComboBox)sender;
            var sv = cbo.SelectedValue;
            CourseDto selectedCourse = (CourseDto)cbo.SelectedItem;

            var groups = allProfiles.Join(allGroups, p => p.ShortName, gr => gr.Speciality, 
                (p, gr) => new GroupDto
                {
                    ID = gr.ID,
                    Group = gr.Group,
                    Speciality = gr.Speciality,
                    Code = p.Code
                }).ToList().Where<GroupDto>(gr => gr.Code == selectedCourse.ID).ToList();

            if (groups.Count() > 0)
            {
                cboGroup.Enabled = true;
                cboGroup.DisplayMember = "Group";
                cboGroup.ValueMember = "ID";
                cboGroup.DataSource = groups;
            }
            else
            {
                cboGroup.DataSource = null;
                cboGroup.Enabled = false;
                cboGroup.Text = "Выберите группу";
            }

        }

        private void CboGroup_SelectionChangeCommitted(object sender, System.EventArgs e)
        {
            ComboBox cbo = (ComboBox)sender;
            var sv = cbo.SelectedValue;
            GroupDto selectedGroup = (GroupDto)cbo.SelectedItem;

            throw new NotImplementedException("Отображение расписания не реализовано.");
        }

    }
}
