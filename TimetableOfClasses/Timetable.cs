using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace TimetableOfClasses
{
    public partial class Timetable : Form
    {
        List<InstituteDto> institutes = new List<InstituteDto>();
        


        public Timetable()
        {
            InitializeComponent();
        }

        public void initRefData(LibOfTimetableOfClasses.RefData refData)
        {
            List<InstituteDto> institutes = refData.CInstitute.AsEnumerable()
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
            
        }

    }
}
