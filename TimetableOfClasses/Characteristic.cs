using LibOfTimetableOfClasses;
using System.Windows.Forms;
using System;
using System.Data;
using System.Collections.Generic;

namespace TimetableOfClasses
{
    public partial class Characteristic : Form
    {
        List<int> nums = new List<int> { 8, 7, 6, 5, 4, 3, 2, 1 };
        List<int> FirstSm = new List<int> { 3, 2, 1 };
        List<int> SecondSm = new List<int> { 5, 4 };
        List<int> ThirdSm = new List<int> { 8, 7, 6 };

        public Characteristic()
        {
            InitializeComponent();            
            Most.Text = nums[0].ToString();
            Most.Items.AddRange(nums);
            Most.TextChanged += Most_SelectedItemChanged;

            First.Text = FirstSm[0].ToString();
            First.Items.AddRange(FirstSm);
            First.TextChanged += First_SelectedItemChanged;

            Second.Text = SecondSm[0].ToString();
            Second.Items.AddRange(SecondSm);
            Second.TextChanged += Second_SelectedItemChanged;

            Third.Text = ThirdSm[0].ToString();
            Third.Items.AddRange(ThirdSm);
            Third.TextChanged += Third_SelectedItemChanged;

            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = Program.refData.CRing;
        }

        private void Most_SelectedItemChanged(object sender, EventArgs e)
        {
            if (int.TryParse(Most.Text, out int a))
            {
                if (nums.Contains(a))
                    Most.Text = a.ToString();
                else Most.Text = "";
            }
            else Most.Text = "";
        }

        private void First_SelectedItemChanged(object sender, EventArgs e)
        {
            if (int.TryParse(First.Text, out int a))
            {
                if (FirstSm.Contains(a))
                    First.Text = a.ToString();
                else First.Text = "";
            }
            else First.Text = "";
        }

        private void Second_SelectedItemChanged(object sender, EventArgs e)
        {
            if (int.TryParse(Second.Text, out int a))
            {
                if (SecondSm.Contains(a))
                    Second.Text = a.ToString();
                else Second.Text = "";
            }
            else Second.Text = "";
        }

        private void Third_SelectedItemChanged(object sender, EventArgs e)
        {
            if (int.TryParse(Third.Text, out int a))
            {
                if (ThirdSm.Contains(a))
                    Third.Text = a.ToString();
                else Third.Text = "";
            }
            else Third.Text = "";
        }
    }
}
