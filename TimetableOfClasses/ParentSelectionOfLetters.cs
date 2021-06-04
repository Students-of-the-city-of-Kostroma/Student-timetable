using LibOfTimetableOfClasses;
using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace TimetableOfClasses
{
   public class ParentSelectionOfLetters :Form
    {
        public void SelectionOfLetters2(object sender, EventArgs e)
        {
            TextBox R = sender as TextBox;
            R.Text = Regex.Replace(R.Text, "[^а-яА-Я-, ]", "");

            while (R.Text.IndexOf("-") == 0)
                R.Text = R.Text.Substring(1);
            while (R.Text.IndexOf(" ") == 0)
                R.Text = R.Text.Substring(1);
            while (R.Text.IndexOf(",") == 0)
                R.Text = R.Text.Substring(1);
            if (R.Text.Length != 0)
            {
                while (R.Text.LastIndexOf(" ") == R.Text.Length - 1 && R.Text.Length != 0)
                    R.Text = R.Text.Remove(R.Text.Length - 1);
                while (R.Text.LastIndexOf("-") == R.Text.Length - 1 && R.Text.Length != 0)
                    R.Text = R.Text.Remove(R.Text.Length - 1);
                while (R.Text.LastIndexOf(",") == R.Text.Length - 1 && R.Text.Length != 0)
                    R.Text = R.Text.Remove(R.Text.Length - 1);
            }
            R.Text = R.Text.ToLower();
            R.Text = FirstLetterToUpper(R.Text);

        }

        private static string FirstLetterToUpper(string str)
        {
            if (str.Length > 0)
            {
                int index = 0;
                string text = Char.ToUpper(str[0]) + str.Substring(1);
                while (str.IndexOf(",", index + 1) > index)
                {
                    index = str.IndexOf(",", index + 1);
                    for (int i = index + 1; i < text.Length; i++)
                    {
                        if (text[i] >= 'А' && text[i] <= 'я')
                        {
                            text = text.Substring(0, i) + Char.ToUpper(text[i]) + text.Substring(i + 1);
                            break;
                        }
                    }
                }
                return text;
            }
            return "";
        }
    }
}
