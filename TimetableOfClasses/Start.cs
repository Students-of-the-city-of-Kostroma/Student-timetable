using LibOfTimetableOfClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimetableOfClasses
{
	public partial class Start : Form
	{
		public Start()
		{
			InitializeComponent();
		}

		private void преподавателиToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Teachers t = new Teachers();
			t.Show();
		}

		private void группыToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Groups group = new Groups();
			group.Show();
		}

		private void дисциплиныToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Discipline d = new Discipline();
			d.Show();
		}

		private void аудиторииToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Auditor audit = new Auditor();
			audit.Show();
		}

		private void расписаниеToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Timetable tt = new Timetable();
			tt.Show();
		}
		private void вУЗыToolStripMenuItem_Click(object sender, EventArgs e)
		{
			University university = new University();
			university.Show();
		}
		private void министерстваToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Ministry ministry = new Ministry();
			ministry.Show();
		}
		private void редактироватьЗаписьToolStripMenuItem_Click(object sender, EventArgs e)
		{
			AddOrEditDirectory addOrEditDirectory = new AddOrEditDirectory();
			addOrEditDirectory.EditRow(null);
			addOrEditDirectory.Show();
		}

		private void добавитьЗаписьToolStripMenuItem_Click(object sender, EventArgs e)
		{
			AddOrEditDirectory addOrEditDirectory = new AddOrEditDirectory();
			addOrEditDirectory.NewRow(null);
			addOrEditDirectory.Show();
		}


		private void ученыеЗванияToolStripMenuItem_Click(object sender, EventArgs e)
		{
			AcademicTitle academicTitle = new AcademicTitle();
			academicTitle.Show();
		}

		private void ученыеСтепениToolStripMenuItem_Click(object sender, EventArgs e)
		{
			AcademicDegree academicDegree = new AcademicDegree();
			academicDegree.Show();
		}

		private void видыЗанятийПодготовкиToolStripMenuItem_Click(object sender, EventArgs e)
		{
			TypesOfOccupations typesOfOccupations = new TypesOfOccupations();
			typesOfOccupations.Show();
		}

		private void справочникиToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			Directory directory = new Directory();
			directory.UploadTable(Controllers.CAuditor.Select());
			directory.Show();
		}

		private void направлениеПодготовкиToolStripMenuItem_Click(object sender, EventArgs e)
		{
			DirectionOfPreparation directionOfPreparation = new DirectionOfPreparation();
			directionOfPreparation.Show();
		}
	}
}