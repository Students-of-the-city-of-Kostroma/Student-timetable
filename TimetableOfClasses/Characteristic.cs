using System.Windows.Forms;

namespace TimetableOfClasses
{
    public partial class Characteristic : Form
    {
        public static decimal MostPairValue, FirstPairValue, SecondPairValue, ThirdPairValue, WorkDaysValue;
        public static bool checkSecPair, checkForBreak;

        public Characteristic() => InitializeComponent();

        private void Ok_Click(object sender, System.EventArgs e)
        {
            MostPairValue = Most.Value;
            FirstPairValue = First.Value;
            SecondPairValue = Second.Value;
            ThirdPairValue = Third.Value;
            WorkDaysValue = MaxDay.Value;
            Close();
        }

        private void rbFromOneToSeven_Click(object sender, System.EventArgs e)
        {
            Most.Maximum = 7;
            Most.Minimum = 0;

            First.Maximum = 7;
            First.Minimum = 0;

            Second.Maximum = 7;
            Second.Minimum = 0;

            Third.Maximum = 7;
            Third.Minimum = 0;
        }

        private void radioButton2_Click(object sender, System.EventArgs e)
        {
            Most.Maximum = 8;
            Most.Minimum = 1;

            First.Maximum = 8;
            First.Minimum = 1;

            Second.Maximum = 8;
            Second.Minimum = 1;

            Third.Maximum = 8;
            Third.Minimum = 1;
        }

        private void SecondPair_Click(object sender, System.EventArgs e)
        {
            if (checkSecPair)
                checkSecPair = false;
            else
                checkSecPair = true;
        }
        
        private void checkBreak_Click(object sender, System.EventArgs e)
        {
            if (checkForBreak)
                checkForBreak = false;
            else
                checkForBreak = true;
        }
        
    }
}
