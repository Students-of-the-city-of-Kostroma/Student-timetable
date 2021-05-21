using System.Windows.Forms;

namespace TimetableOfClasses
{
    public partial class Characteristic : Form
    {
        public Characteristic()
        {

            InitializeComponent();
            dataGridView1.Rows[0].Cells[0].Value = 1;
        }

        private void dataGridView1_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (dataGridView1.Rows.Count > 2)
            {
                if (dataGridView1.Rows[dataGridView1.Rows.Count - 2].Cells[1].Value == null && dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[1].Value == null && dataGridView1.CurrentCell != dataGridView1.Rows[dataGridView1.Rows.Count - 2].Cells[1] && dataGridView1.CurrentCell != dataGridView1.Rows[dataGridView1.Rows.Count - 2].Cells[1])
                {
                    dataGridView1.Rows.Remove(dataGridView1.Rows[dataGridView1.Rows.Count - 2]);
                    dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[0].Value = dataGridView1.Rows.Count;
                }
            }
        }

        private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[0].Value = dataGridView1.Rows.Count;
        }
    }
}
