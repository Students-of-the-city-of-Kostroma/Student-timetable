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
	public partial class AddEnclosures : Form
	{
		MEnclosures Enclosures;

		public AddEnclosures()
		{
			InitializeComponent();
		}

		public AddEnclosures(MEnclosures mEnclosures)
		{
			InitializeComponent();
			Enclosures = mEnclosures;
			name.Text = Enclosures.Name;
			name.Enabled = false;
			university.Text = Enclosures.University;
			university.Enabled = false;
			address.Text = Enclosures.Address;
			phoneNumber.Text = Enclosures.Phone;
			note.Text = Enclosures.Comment;
		}

		private void name_KeyPress(object sender, KeyPressEventArgs e)//Проверка входных значений Названия корпуса
		{
			char ch = e.KeyChar;
			if ((ch < 'А' || ch > 'я') && (ch < 'A' || ch > 'z') && ch != '-' && (ch < '0' || ch > '9') && ch != '\b')
			{
				e.Handled = true;
			}
		}

		private void university_KeyPress(object sender, KeyPressEventArgs e)//Проверка входных значений ВУЗа
		{
			char ch = e.KeyChar;
			if ((ch < 'А' || ch > 'я') && ch != '\b')
			{
				e.Handled = true;
			}
		}

		private void university_Leave(object sender, EventArgs e)//Перевод букв в верхний регистр
		{
			if (university.Text.Length != 0)
				university.Text = university.Text.ToUpper();
		}

		private void address_KeyPress(object sender, KeyPressEventArgs e)//Проверка входных значений Адреса
		{
			char ch = e.KeyChar;
			if ((ch < 'А' || ch > 'я') && ch != '-' && (ch < '0' || ch > '9') && ch != '\b' && ch != ',' && ch != '.' && ch != '-' && ch != ' ')
			{
				e.Handled = true;
			}
		}

		private void note_KeyPress(object sender, KeyPressEventArgs e)//Проверка входных значений замечания
		{
			char ch = e.KeyChar;
			if ((ch < 'А' || ch > 'я') && (ch < 'A' || ch > 'z') && ch != '-' && (ch < '0' || ch > '9') && ch != '\b' && ch != ',' && ch != '.' && ch != '-' && ch != ' ')
			{
				e.Handled = true;
			}
		}

		private void phoneNumber_KeyPress(object sender, KeyPressEventArgs e)//Проверка входных значений Номера телефона
		{
			char ch = e.KeyChar;
			if ((ch < '0' || ch > '9') && ch != '\b')
			{
				e.Handled = true;
			}
		}

		private void cancel_Click(object sender, EventArgs e)//Отмена
		{
			this.Close();
		}

		private void clear_Click(object sender, EventArgs e)//Очистка полей
		{
			foreach (object obj in this.Controls)
			{
				if (obj is TextBox) (obj as TextBox).Text = "";
			}
		}

		private void save_Click(object sender, EventArgs e)//Сохранить изменения
		{
			checkNumber();
			if (checkField()) return; 

			if (Enclosures == null)
			{
				MEnclosures mEnclosures = new MEnclosures(name.Text, university.Text, address.Text, phoneNumber.Text, note.Text);

				if (LibOfTimetableOfClasses.RefData.СEnclosures.Insert(mEnclosures))
				{
					this.Close();
				}
				else
				{ MessageBox.Show("Упс, невозможно добавить такой корпус!"); }
			}
			else
			{
				Enclosures.Name = name.Text;
				Enclosures.Address = address.Text;
				Enclosures.University = university.Text;
				Enclosures.Phone = phoneNumber.Text;
				Enclosures.Comment = note.Text;

				if (LibOfTimetableOfClasses.RefData.СEnclosures.Update(Enclosures))
				{
					this.Close();
				}
				else MessageBox.Show("Упс, невозможно обновить информацию об этом корпусе!");
			}

		}

		private void phoneNumber_Layout(object sender, LayoutEventArgs e)
		{
			checkNumber();
		}
		private void checkNumber()
		{
			if (phoneNumber.Text.Length != 6 && phoneNumber.Text.Length != 11)
			{
				MessageBox.Show("Номер может быть длинной только 6 либо 11 символов!");
				phoneNumber.Text = "";
			}
		}
		private bool checkField()
		{
			bool flag = false;
			if (name.Text.Length == 0) { name.BackColor = Color.Red; flag = true; }
			if (university.Text.Length == 0) { university.BackColor = Color.Red; flag = true; }
			if (address.Text.Length == 0) { address.BackColor = Color.Red; flag = true; }
			if (phoneNumber.Text.Length == 0) { phoneNumber.BackColor = Color.Red; flag = true; }
			return flag;
		}

		private void name_TextChanged(object sender, EventArgs e)
		{
			if ((sender as TextBox).Text.Length==0) (sender as TextBox).BackColor = Color.Red;
			else (sender as TextBox).BackColor = Color.White;
		}
	}
}
