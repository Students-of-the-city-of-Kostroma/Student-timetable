using System.Data;
using System.Windows.Forms;

namespace TimetableOfClasses
{
    public partial class AddOrEditDirectory : Form
    {
        public AddOrEditDirectory()
        {
            InitializeComponent();
        }

        public void NewRow(DataRow dataRow)
        {
            this.Text = "Добавить запись";
            this.btClear.Text = "Создать и очистить";
            this.btClose.Text = "Создать и закрыть";

        }

        public void EditRow(DataRow dataRow)
        {
            this.Text = "Редактировать запись";
            this.btClear.Text = "Изменить и очистить";
            this.btClose.Text = "Изменить и закрыть";
        }
    }
}
