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
            else MessageBox.Show("Введите корректный стаж! (0-60)","Попробуйте снова",MessageBoxButtons.OK);
           
        }

        private void AddTeacher_Load(object sender, EventArgs e)
        {
            comboBox1.Text = "0";
            textBox1.Text = "Jonh";
            textBox2.Text = "Smith";
            textBox3.Text = "Hoerq";
            textBox4.Text = "First";
            textBox5.Text = "Docent";

            for(int i = 0;i<61;i++) comboBox1.Items.Add(i);
           
        }
    }
}
