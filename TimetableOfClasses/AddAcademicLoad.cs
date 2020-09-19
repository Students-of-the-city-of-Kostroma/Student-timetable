using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms;
using LibOfTimetableOfClasses;
using System.Text.RegularExpressions;

namespace TimetableOfClasses
{
    public partial class AddAcademicLoad : Form
    {
        private MAcademicLoad Lehrer;

        public AddAcademicLoad()
        {
            InitializeComponent();
            Text = "Изменение нагрузки";
            textBox1.Text = "17-ИСбо-2а";
            textBox2.Text = "156";
            textBox3.Text = "Мат";
            textBox4.Text = "Иванов Иван Иванович";
            textBox5.Text = "ТРПО";
            //itsupdate = true;
        }

        private bool isEmpty(string[] strArgs)
        {
            foreach (var cur in strArgs)
            {
                if (cur.Length == 0)
                {
                    return true;
                }
            }
            return false;
        }

        private void message()
        {
            MessageBox.Show("Заполните все пустые строки", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public AddAcademicLoad(MAcademicLoad mAcademicLoad)
        {
            InitializeComponent();
            this.Text = "Изменение нагрузки";

            textBox1.Text = mAcademicLoad.Group;

            textBox2.Text = mAcademicLoad.TotalHours;

            textBox3.Text = mAcademicLoad.Discipline;

            textBox4.Text = mAcademicLoad.Teacher;

            textBox5.Text = mAcademicLoad.Occupation;

            Lehrer = mAcademicLoad;

        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                Logs.GetInfo("Click button Save in AddAcademicLoad");
                if (!isEmpty(new string[] { textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox2.Text }))
                {
                    if (Add())
                    {
                        Close();
                    }
                    else MessageBox.Show("Невозможно добавить эту нагрузку", "Попробуйте снова");
                }
                else message();
            }
            catch (Exception ex)
            {
                Logs.GetError(ex);
            }
        }

        private bool Add()
        {
            try
            {
                if (Lehrer == null)
                {
                    MAcademicLoad Load1 = new MAcademicLoad(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox2.Text);
                    return Program.refData.CAcademicLoad.Insert(Load1);
                }
                else
                {
                    Lehrer.Group = textBox1.Text;
                    Lehrer.TotalHours = textBox2.Text;
                    Lehrer.Discipline = textBox3.Text;
                    Lehrer.Teacher = textBox4.Text;
                    Lehrer.Occupation = textBox5.Text;
                    Lehrer.Distributed = textBox2.Text;
                    return Program.refData.CAcademicLoad.Update(Lehrer);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Заполнены не все поля или заполнены некорректно", "Ошибка", MessageBoxButtons.OK);
                return false;
            }
        }

        private void SelectionOfLetters1(object sender, EventArgs e)
        {
            TextBox R = sender as TextBox;
            R.Text = Regex.Replace(R.Text, "[^а-яА-Я ]", "");
            R.Text = Regex.Replace(R.Text, "[, ]+", ", ");

            if (R.Text.Length > 2)
            {
                if (R.Text.IndexOf(", ") == 0)
                    R.Text = R.Text.Substring(1);
                if (R.Text.LastIndexOf(", ") == R.Text.Length - 1)
                    R.Text = R.Text.Remove(R.Text.Length - 1);
                R.Text = R.Text.ToLower();
                R.Text = PeriodLetterToUpper(R.Text);
            }

        }

        private void SelectionOfLetters2(object sender, EventArgs e)
        {
            TextBox R = sender as TextBox;
            R.Text = Regex.Replace(R.Text, "[^а-яА-Я ]", "");
            R.Text = Regex.Replace(R.Text, "[ ]+", " ");
            if (R.Text.Length > 2)
            {
                if (R.Text.IndexOf(" ") == 0)
                    R.Text = R.Text.Substring(1);
                if (R.Text.LastIndexOf(" ") == R.Text.Length - 1)
                    R.Text = R.Text.Remove(R.Text.Length - 1);
                R.Text = R.Text.ToLower();
                R.Text = FirstLetterToUpper(R.Text);
            }
            if (R.Text.Length == 1)
            {
                R.Text = R.Text.ToLower();
                R.Text = FirstLetterToUpper(R.Text);
            }

        }

        private void SelectionOfLetters3(object sender, EventArgs e)
        {
            TextBox R = sender as TextBox;
            R.Text = Regex.Replace(R.Text, "[^а-яА-Я ]", "");
            R.Text = Regex.Replace(R.Text, "[ ]+", " ");

            if (R.Text.Length > 2)
            {
                if (R.Text.IndexOf(" ") == 0)
                    R.Text = R.Text.Substring(1);
                if (R.Text.LastIndexOf(" ") == R.Text.Length - 1)
                    R.Text = R.Text.Remove(R.Text.Length - 1);
                R.Text = R.Text.ToUpper();
            }

        }

        private void SelectionOfLetters4(object sender, EventArgs e)
        {
            TextBox R = sender as TextBox;
            R.Text = Regex.Replace(R.Text, "[^0-9а-яА-Я-, ]", "");
            R.Text = Regex.Replace(R.Text, "[ ]+", " ");

            if (R.Text.Length > 2)
            {
                if (R.Text.IndexOf(" ") == 0)
                    R.Text = R.Text.Substring(1);
                if (R.Text.LastIndexOf(" ") == R.Text.Length - 1)
                    R.Text = R.Text.Remove(R.Text.Length - 1);
                R.Text = R.Text.ToLower();
                R.Text = FirstLetterToUpper(R.Text);
            }

        }

        private static string FirstLetterToUpper(string str)
        {
            if (str.Length > 0)
            {
                if (str.IndexOf("-") > 0)
                {
                    return Char.ToUpper(str[0]) + str.Substring(1, str.IndexOf("-")) + Char.ToUpper(str[str.IndexOf("-") + 1]) + str.Substring(str.IndexOf("-") + 2);
                }
                else
                    return Char.ToUpper(str[0]) + str.Substring(1);
            }
            return "";
        }

        private static string PeriodLetterToUpper(string str)
        {
            if (str.Length > 0)
            {
                if (str.IndexOf(",") > 0)
                {
                    char p;
                    str = Char.ToUpper(str[0]) + str.Substring(1);
                    for (int i = 0; i < str.Length; i++)
                    {
                        if (str[i] == ',')
                        {
                            p = Char.ToUpper(str[i + 2]);
                            str = str.Remove(i + 2, 1);
                            str = str.Insert(i + 2, "" + p);
                        }
                    }
                    return str;
                }
                else
                    return Char.ToUpper(str[0]) + str.Substring(1);
            }
            return "";
        }



        private void KeyPress1(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if ((l < 'А' || l > 'я') && l != '\b')
            {
                e.Handled = true;
            }
        }

        private void KeyPress2(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if ((l < 'A' || l > 'z') && (l < 'А' || l > 'я') && l != '\b' && l != '-' && l != ' ' && l != ',' && (l < '0' || l > '9') && l != '.')
            {
                e.Handled = true;
            }
        }

        private void KeyPress3(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if ((l < 'А' || l > 'я') && l != '\b' && l != ' ')
            {
                e.Handled = true;
            }
            e.Handled = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                Logs.GetInfo("Click button Cancel in AddAcademicLoad");
                Close();
            }
            catch (Exception ex)
            {
                Logs.GetError(ex);
            }
        }
        private void fieldChanged(object sender, EventArgs e)
        {
            TextBox R = sender as TextBox;
            if (R.TextLength == 0)
                R.BackColor = Color.Red;
            else
                R.BackColor = Color.White;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CreateFormForEditAndChoiceG();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CreateFormForEditAndChoiceD();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CreateFormForEditAndChoiceT();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CreateFormForEditAndChoiceTOo();
        }
        private void CreateFormForEditAndChoiceG()
        {
            Groups selectG = new Groups();
            selectG.Owner = this;
            selectG.FormClosed += SelectG_FormClosed;
            selectG.Show();
        }
        private void SelectG_FormClosed(object sender, FormClosedEventArgs e)
        {
            string reduction = (sender as Groups).ChoseGroupe;
            if (reduction != null)
                textBox1.Text = reduction;
        }
        private void CreateFormForEditAndChoiceD()
        {
            Discipline selectD = new Discipline();
            selectD.Owner = this;
            selectD.FormClosed += SelectD_FormClosed;
            selectD.Show();
        }
        private void SelectD_FormClosed(object sender, FormClosedEventArgs e)
        {
            string reduction = (sender as Discipline).ChoseDiscipline;
            if (reduction != null)
                textBox3.Text = reduction;
        }
        private void CreateFormForEditAndChoiceT()
        {
            Teachers selectT = new Teachers();
            selectT.Owner = this;
            selectT.FormClosed += SelectT_FormClosed;
            selectT.Show();
        }
        private void SelectT_FormClosed(object sender, FormClosedEventArgs e)
        {
            string reduction = (sender as Teachers).ChoseTeacher;
            if (reduction != null)
                textBox4.Text = reduction;
        }
        private void CreateFormForEditAndChoiceTOo()
        {
            TypesOfOccupations selectTO = new TypesOfOccupations();
            selectTO.Owner = this;
            selectTO.FormClosed += SelectTO_FormClosed;
            selectTO.Show();
        }
        private void SelectTO_FormClosed(object sender, FormClosedEventArgs e)
        {
            string reduction = (sender as TypesOfOccupations).ChoseType;
            if (reduction != null)
                textBox5.Text = reduction;
        }

    }
}
