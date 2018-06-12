using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimetableOfClasses
{
    public partial class AddTeacher : Form
    {
        public AddTeacher()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a;
            if (int.TryParse(comboBox1.Text, out a)) { this.Close(); }
            else MessageBox.Show("Введите корректный стаж! (0-60)", "Попробуйте снова", MessageBoxButtons.OK);

        }

        private void AddTeacher_Load(object sender, EventArgs e)
        {
            comboBox1.Text = "0";
            textBox1.Text = "Иван";
            textBox2.Text = "Иванов";
            textBox3.Text = "Иванович";
            textBox4.Text = "Доктор наук";
            textBox5.Text = "Профессор";

            for (int i = 0; i < 61; i++) comboBox1.Items.Add(i);

        }

        private void SelectionOfNumber(object sender, EventArgs e)
        {
            ComboBox R = sender as ComboBox;
            try
            {
                R.Text = Regex.Replace(R.Text, "[^0-9,]", "");
                R.Text = Convert.ToString(Math.Floor(Convert.ToDouble(R.Text)));
                Convert.ToInt32(R.Text);
                if ((Convert.ToInt32(R.Text) < 0))
                    R.Text = Convert.ToString(Convert.ToInt32(R.Text) * -1);
                if (Convert.ToInt32(R.Text) == 0)
                    R.Text = "0";
                if (Convert.ToInt32(R.Text) > 99)
                    comboBox1.Text = comboBox1.Text.Remove(2);
                else
                if (Convert.ToInt32(R.Text) > 60)
                    comboBox1.Text = comboBox1.Text.Remove(1);
            }
            catch
            {
                comboBox1.Text = "0";
            }
        }

        private void SelectionOfLetters1(object sender, EventArgs e)
        {
            TextBox R = sender as TextBox;
            R.Text = Regex.Replace(R.Text, "[^а-яА-Я- ]", "");
            R.Text = Regex.Replace(R.Text, "[ ]", "-");
            R.Text = Regex.Replace(R.Text, "[-]+", "-");
        }

        private void SelectionOfLetters2(object sender, EventArgs e)
        {
            TextBox R = sender as TextBox;
            R.Text = Regex.Replace(R.Text, "[^а-яА-Я ]", "");
            R.Text = Regex.Replace(R.Text, "[ ]+", " ");
        }
    }
}
