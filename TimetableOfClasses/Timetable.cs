using LibOfTimetableOfClasses;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace TimetableOfClasses
{
    public partial class Timetable : Form
    {
        private LibOfTimetableOfClasses.RefData refData;

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

        const string LessonPattern = @"{0}{5}{1}-{2} ({3}) {5}{4}{5}";

        public Timetable()
        {
            InitializeComponent();

            // TableLayoutPanel инициализация
            TlpSchedule_Init();
        }

        public void initRefData(LibOfTimetableOfClasses.RefData data)
        {
            this.refData = data;

            cboInstitute.DataSource = data.CInstitute;
            cboInstitute.DisplayMember = "FullName";
            cboInstitute.ValueMember = "ShortName";

            cboCourse.Enabled = false;
            cboGroup.Enabled = false;
        }

        private void CboInstitute_SelectionChangeCommitted(object sender, System.EventArgs e)
        {
            ComboBox cbo = (ComboBox)sender;

            DataView courses = refData.CDirectionOfPreparation.DefaultView;
            courses.RowFilter = "InstituteShortName = '" + cbo.SelectedValue + "'";
            if (courses.Count > 0)
            {
                cboCourse.Enabled = true;
                cboCourse.DisplayMember = "NameOfDP";
                cboCourse.ValueMember = "CodeOfDP";
                cboCourse.DataSource = courses;
            }
            else
            {
                cboCourse.DataSource = null;
                cboCourse.Enabled = false;
                cboCourse.Text = "Выберите направление подготовки";
            }
            cboGroup.DataSource = null;
            cboGroup.Enabled = false;
            cboGroup.Text = "Выберите группу";
        }

        private void CboCourse_SelectionChangeCommitted(object sender, System.EventArgs e)
        {
            ComboBox cbo = (ComboBox)sender;

            DataRow[] profile = refData.CTrainingProfile.Select("Shiphr = '" + cbo.SelectedValue + "'");
            DataView groups = refData.CGroup.DefaultView;
            groups.RowFilter = "Specialty = '" + profile[0].Field<string>("ShortName") + "'";

            if (groups.Count > 0)
            {
                cboGroup.Enabled = true;
                cboGroup.DisplayMember = "Group";
                cboGroup.ValueMember = "Group";
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

            TlpSchedule_Clear();
            TlpSchedule_Init();

            var groupSchedule = (from al in refData.CAcademicLoad.AsEnumerable()
                                join cs in refData.CCourseSchedule.AsEnumerable() on (int?)al["ID"] equals (int)cs["AcademicId"]
                                where (string)al["Group"] == cbo.SelectedValue.ToString()
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
                    
                    var lesson = groupSchedule.Where(r => r.DayOfWeek == headers[x] && r.Time == timespans[y]).SingleOrDefault();
                    if (lesson != null)
                    {
                        var text = string.Format(LessonPattern, lesson.Speciality, lesson.Building, lesson.Classroom, lesson.KindOfLesson, lesson.Teacher, Environment.NewLine);
                        Label lLesson = new Label() { Text = text, Dock = DockStyle.Fill };
                        tpSchedule.Controls.Add(lLesson, x, y + 1);
                    }
                }
            }
        }

        private void TlpSchedule_Clear()
        {
            tpSchedule.Controls.Clear();
        }

        private void TlpSchedule_Init()
        {
            tpSchedule.ColumnStyles.Clear();
            tpSchedule.RowStyles.Clear();

            tpSchedule.ColumnCount = headers.Length;
            tpSchedule.RowCount = timespans.Length + 1; // +1 строка заголовка
            var percentH = (float)(100 / timespans.Length); // расчитываем процент высоты строки
            var percentW = (float)(100 / headers.Length); // расчитываем процент ширины строки

            tpSchedule.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;

            // заполняем заголовок
            for (int i = 0; i < headers.Length; i++)
            {
                if (i == 0)
                {
                    // ширина колонок подбирается автоматически
                    tpSchedule.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
                }
                else
                {
                    tpSchedule.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, percentW));
                }
                tpSchedule.Controls.Add(new Label() { Text = headers[i], Dock = DockStyle.Fill }, i, 0);
            }

            // заполняем строки в первой колонке -"Время"
            for (int i = 0; i < timespans.Length + 1; i++)
            {
                if (i == 0)
                {
                    // для строки заголовка высота подбирается автоматически
                    tpSchedule.RowStyles.Add(new RowStyle(SizeType.AutoSize));
                }
                else
                {
                    tpSchedule.RowStyles.Add(new RowStyle(SizeType.Percent, percentH));
                    tpSchedule.Controls.Add(new Label() { Text = timespans[i - 1], Dock = DockStyle.Fill }, 0, i);
                }
            }

        }
    }
}
