using LibOfTimetableOfClasses;
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
        private LibOfTimetableOfClasses.RefData refData;

        List<InstituteDto> institutes = new List<InstituteDto>();
        List<GroupDto> allGroups = new List<GroupDto>();
        List<CourseDto> allCourses = new List<CourseDto>();
        List<TrainingProfileDto> allProfiles = new List<TrainingProfileDto>();

        private string[] headers = new string[8] { "Время", "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье" };

        private string[] timespans =
            {
                string.Format("{0}-{1}",new TimeSpan(8,30,0).ToString(), new TimeSpan(10, 0, 0).ToString()),
                string.Format("{0}-{1}",new TimeSpan(10,10,0).ToString(), new TimeSpan(11, 40, 0).ToString()),
                string.Format("{0}-{1}",new TimeSpan(11,50,0).ToString(), new TimeSpan(13, 20, 0).ToString()),
                string.Format("{0}-{1}",new TimeSpan(14,0,0).ToString(), new TimeSpan(15, 30, 0).ToString()),
                string.Format("{0}-{1}",new TimeSpan(15,40,0).ToString(), new TimeSpan(17, 10, 0).ToString()),
                string.Format("{0}-{1}",new TimeSpan(17,20,0).ToString(), new TimeSpan(18, 50, 0).ToString()),
                string.Format("{0}-{1}",new TimeSpan(19,0,0).ToString(), new TimeSpan(20, 30, 0).ToString())
            };

        const string pattern = @"{0}
        {1}-{2}({3})
        {4}";

        public Timetable()
        {
            InitializeComponent();

            tpSchedule.ColumnStyles.Clear();
            tpSchedule.RowStyles.Clear();

            tpSchedule.ColumnCount = headers.Length;
            tpSchedule.RowCount = timespans.Length + 1; // +1 строка заголовка
            //tpSchedule.AutoScroll = true;
            tpSchedule.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;

            tpSchedule.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            tpSchedule.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));

            // заголовок
            for (int i = 0; i < headers.Length; i++)
            {
                tpSchedule.Controls.Add(new Label() { Text = headers[i] }, i, 0);
            }

            //строки в первой колонке -"Время"
            for (int i = 0; i < timespans.Length; i++)
            {
                tpSchedule.Controls.Add(new Label() { Text = timespans[i] }, 0, i + 1);
            }

        }

        public void initRefData(LibOfTimetableOfClasses.RefData data)
        {
            refData = data;

            institutes = data.CInstitute.AsEnumerable()
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

            allCourses = data.CDirectionOfPreparation.AsEnumerable()
                .Select(row => new CourseDto
                {
                    ID = row.Field<string>("CodeOfDP"),
                    NameOfDP = row.Field<string>("NameOfDP"), 
                    InstituteShortName = row.Field<string>("InstituteShortName")
                }).ToList();

            allProfiles = data.CTrainingProfile.AsEnumerable()
                .Select(row => new TrainingProfileDto
                {
                    Code = row.Field<string>("Shiphr"),
                    ShortName = row.Field<string>("ShortName")
                }).ToList();

            allGroups = data.CGroup.AsEnumerable()
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
            GroupDto selectedGroup = (GroupDto)cbo.SelectedItem;

            var groupSchedule = (from al in refData.CAcademicLoad.AsEnumerable()
                                join cs in refData.CCourseSchedule.AsEnumerable() on (int?)al["ID"] equals (int)cs["AcademicId"]
                                where (string)al["Group"] == selectedGroup.Group
                                orderby (string)cs["DayOfWeek"]
                                select new
                                {
                                    Id = (int?)al["ID"],
                                    Group = (string)al["Group"],
                                    Speciality = (string)al["Discipline"],
                                    Teacher = (string)al["Professor"],
                                    KindOfLesson = (string)al["KindOfLesson"],
                                    Building = (string)cs["Building"],
                                    Classroom = (string)cs["Classroom"],
                                    DayOfWeek = (string)cs["DayOfWeek"],
                                    Time = string.Format("{0}-{1}", ((TimeSpan)cs["StartTime"]).ToString(), ((TimeSpan)cs["EndTime"]).ToString()),
                                }).ToList();

            for (int x = 1; x < headers.Length; x++)
            {
                for (int y = 0; y < timespans.Length; y++)
                {
                    
                    var daySchedule = groupSchedule.Where(r => r.DayOfWeek == headers[x]).OrderBy(r => r.Time);
                    if (daySchedule.Count() > 0)
                    {
                        var lesson = daySchedule.Where(s => s.Time == timespans[y]).SingleOrDefault();
                        if (lesson != null)
                        {
                            var text = string.Format(pattern,lesson.Speciality, lesson.Building, lesson.Classroom, lesson.KindOfLesson, lesson.Teacher);
                            tpSchedule.Controls.Add(new Label() { Text = text }, x, y+1);
                        }
                    }
                }
            }


        }

    }
}
