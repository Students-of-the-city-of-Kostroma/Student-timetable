using System.Windows.Forms;

namespace TimetableOfClasses
{
    public partial class Characteristic : Form
    {
        public Characteristic() => InitializeComponent();

        private void radioButton1_CheckedChanged(object sender, System.EventArgs e)
        {
            this.Most.Text = "7";
            this.First.Text = "7";
            this.Second.Text = "7";
            this.Third.Text = "7";
        }

        private void Most_SelectedItemChanged(object sender, System.EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                DomainUpDown.DomainUpDownItemCollection collection = this.Most.Items;


                if (this.Most.Text != "7")
                {
                    collection.Add("7");
                    collection.Add("6");
                    collection.Add("5");
                    collection.Add("4");
                    collection.Add("3");
                    collection.Add("2");
                    collection.Add("1");
                    collection.Add("0");
                }
                else
                {
                  
                    collection.Add("6");
                    collection.Add("5");
                    collection.Add("4");
                    collection.Add("3");
                    collection.Add("2");
                    collection.Add("1");
                    collection.Add("0");
                }

            }
        }

        private void First_SelectedItemChanged(object sender, System.EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                DomainUpDown.DomainUpDownItemCollection collection1 = this.First.Items;


                if (this.First.Text != "7")
                {
                    collection1.Add("7");
                    collection1.Add("6");
                    collection1.Add("5");
                    collection1.Add("4");
                    collection1.Add("3");
                    collection1.Add("2");
                    collection1.Add("1");
                    collection1.Add("0");
                }
                else
                {
                   
                    collection1.Add("6");
                    collection1.Add("5");
                    collection1.Add("4");
                    collection1.Add("3");
                    collection1.Add("2");
                    collection1.Add("1");
                    collection1.Add("0");
                }

            }
        }

        private void Second_SelectedItemChanged(object sender, System.EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                DomainUpDown.DomainUpDownItemCollection collection2 = this.Second.Items;


                if (this.Second.Text != "7")
                {
                    collection2.Add("7");
                    collection2.Add("6");
                    collection2.Add("5");
                    collection2.Add("4");
                    collection2.Add("3");
                    collection2.Add("2");
                    collection2.Add("1");
                    collection2.Add("0");
                }
                else
                {
              
                    collection2.Add("6");
                    collection2.Add("5");
                    collection2.Add("4");
                    collection2.Add("3");
                    collection2.Add("2");
                    collection2.Add("1");
                    collection2.Add("0");
                }

            }
        }

        private void Third_SelectedItemChanged(object sender, System.EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                DomainUpDown.DomainUpDownItemCollection collection3 = this.Third.Items;


                if (this.Third.Text != "7")
                {
                    collection3.Add("7");
                    collection3.Add("6");
                    collection3.Add("5");
                    collection3.Add("4");
                    collection3.Add("3");
                    collection3.Add("2");
                    collection3.Add("1");
                    collection3.Add("0");
                }
                else
                {
                 
                    collection3.Add("6");
                    collection3.Add("5");
                    collection3.Add("4");
                    collection3.Add("3");
                    collection3.Add("2");
                    collection3.Add("1");
                    collection3.Add("0");
                }

            }
        }

        private void Cancel_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
    }
}
