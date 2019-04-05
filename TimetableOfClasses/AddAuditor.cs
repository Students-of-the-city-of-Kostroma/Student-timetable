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
	public partial class AddAuditor : Form
	{
		public AddAuditor()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)// отмена
		{
			Close();
		}

		private void button2_Click(object sender, EventArgs e)// создать и очистить
		{
			if (textBox1.Text.Contains(" ") || textBox2.Text.Contains(" ") || textBox3.Text.Contains(" ") || Convert.ToString(numericUpDown1.Value) == "")
				MessageBox.Show("Заполните все поля");
			MAuditor Auditor = new MAuditor(textBox1.Text, textBox2.Text, (ushort)numericUpDown1.Value, Convert.ToByte(textBox3.Text));
			try
			{
				Controllers.CAuditor.Insert(Auditor);
				textBox1.Text = "";
				textBox2.Text = "";
				textBox3.Text = "";
				numericUpDown1.Value = 0;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void button3_Click(object sender, EventArgs e)// создать и закрыть
		{
			if (textBox1.Text.Contains(" ") || textBox2.Text.Contains(" ") || textBox3.Text.Contains(" ") || Convert.ToString(numericUpDown1.Value) == "")
				MessageBox.Show("Заполните все поля");
			MAuditor Auditor = new MAuditor(textBox1.Text, textBox2.Text, (ushort)numericUpDown1.Value, Convert.ToByte(textBox3.Text));
			try
			{
				Controllers.CAuditor.Insert(Auditor);
				Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void textBox1_KeyPress(object sender, KeyPressEventArgs e)// Аудитория
		{
			if (Char.IsLetterOrDigit(e.KeyChar) || e.KeyChar == 8) return;
			else
				e.Handled = true;
		}

		private void textBox2_KeyPress(object sender, KeyPressEventArgs e)// Кафедра
		{
			if (Char.IsLetter(e.KeyChar) || Convert.ToString(e.KeyChar) == " " || e.KeyChar == 8) return;
			else
				e.Handled = true;
		}

		private void textBox3_KeyPress(object sender, KeyPressEventArgs e)// Корпус
		{
			byte k;
			if (!(byte.TryParse(Convert.ToString(e.KeyChar), out k) || e.KeyChar == 8))
			{
				e.Handled = true;
			}
		}
	}
}
