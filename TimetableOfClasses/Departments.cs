using System;
using System.Windows.Forms;

namespace TimetableOfClasses
{
    public partial class Departments : Form
    {
        public Departments()
        {
            InitializeComponent();
        }

        private void FormLoad(object sender, EventArgs e)
        {
            // Do
        }

        private void DeleteBtnClick(object sender, EventArgs e)
        {
            // Do
        }

        private void UpdateBtnClick(object sender, EventArgs e)
        {
            // Do
        }

        /// <summary>
        /// Открывает форму добавления кафедры
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddBtnClick(object sender, EventArgs e)
        {
            AddDepartment addDepartment = new AddDepartment();
            addDepartment.Show();
        }
    }
}
