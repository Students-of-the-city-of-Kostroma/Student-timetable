using System.Data;
using System.Windows.Forms;

namespace TimetableOfClasses
{
    public partial class Directory : Form
    {
        public Directory()
        {
            InitializeComponent();
        }

        public void UploadTable(DataTable table)
        {
            dataGridView1.DataSource = table;
            this.Text = table.TableName;
        }
    }
}
