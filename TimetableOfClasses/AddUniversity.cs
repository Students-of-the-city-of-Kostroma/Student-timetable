using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Net.Mail;
using LibOfTimetableOfClasses;

namespace TimetableOfClasses
{
	public partial class AddUniversity : Form
	{
		bool isSpacePressed = true;
		MUniversity cur;
		public AddUniversity()
		{
			InitializeComponent();
			tbShortTittle.CharacterCasing = CharacterCasing.Upper;
			tbShortTittle.Text = "КГУ";
			tbFullTitle.Text = "Костромской Государственный Университет";
			tbActualAddress.Text = "156005, Костромская область, г. Кострома, ул. Дзержинского, 17";
			tbLegalAddress.Text = "156005, Костромская область, г. Кострома, ул. Дзержинского, 17";
			tbPhone.Text = "84942317960";
			tbMail.Text = "info@kstu.edu.ru";
			tbRectorName.Text = "Наумов Александр Рудольфович";
			tbINN.Text = "4401006286";
		}

		public AddUniversity(MUniversity model)
		{
			InitializeComponent();
			tbINN.Enabled = false;
			this.Text = "Изменение университета";
			tbShortTittle.Text = model.ShortName;
			tbFullTitle.Text = model.FullName;
			tbActualAddress.Text = model.ActualAddress;
			tbLegalAddress.Text = model.LegalAddress;
			tbPhone.Text = model.Phone;
			tbMail.Text = model.Email;
			tbRectorName.Text = model.SurnameRector + " " + model.NameRector + " " + model.MiddleNameRector;
			cur = model;
			tbINN.Text = model.INN;
		}


		private void FullTitle_KeyPress(object sender, KeyPressEventArgs e)
		{
			Regex regex = new Regex(@"[а-яА-Я\- ]");
			if (!regex.IsMatch(e.KeyChar.ToString()) && e.KeyChar != (char)Keys.Back)
			{
				e.Handled = true;
				return;
			}

		}

		private void ShortTitle_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!Regex.IsMatch(e.KeyChar.ToString(), @"[а-яА-Я]") && e.KeyChar != (char)Keys.Back)
			{
				e.Handled = true;
				return;
			}
		}

		private void tbActualAddress_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!Regex.IsMatch(e.KeyChar.ToString(), @"[а-яА-Я0-9.,\-\ ]") && e.KeyChar != (char)Keys.Back)
			{
				e.Handled = true;
				return;
			}
		}

		private void tbPhone_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!Regex.IsMatch(e.KeyChar.ToString(), @"[0-9]") && e.KeyChar != (char)Keys.Back)
			{
				e.Handled = true;
				return;
			}
		}

		private void tbMail_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!Regex.IsMatch(e.KeyChar.ToString(), @"[a-zA-Z0-9.@\-]") && e.KeyChar != (char)Keys.Back)
			{
				e.Handled = true;
				return;
			}
		}

		private void tbFullTitle_Leave(object sender, EventArgs e)
		{
			string input = ((TextBox)sender).Text;
			input = Regex.Replace(input, "[^а-яА-Я- ]", "");
			input = Regex.Replace(input, @"\s+", " ");
			input = Regex.Replace(input, @"-+", "-");
			input = Regex.Replace(input, @" - ", "-");
			input = Regex.Replace(input, @"- -", " ");
			if (input.Length > 2)
			{
				string newinput = "";
				if (input[0] == ' ' || input[0] == '-')
					input = input.Substring(1);
				if (input[input.Length-1] == ' ' || input[input.Length-1] == '-')
					input = input.Substring(1, input.Length-2);
				foreach (var ch in input)
				{
					if (isSpacePressed)
					{
						newinput += Char.ToUpper(ch);
						isSpacePressed = false;
					}
					else
						newinput += Char.ToLower(ch);
					if (ch == ' ' || ch == '-')
						isSpacePressed = true;
				}
			((TextBox)sender).Text = newinput;
				isSpacePressed = true;
			}
			if((TextBox)sender == tbRectorName)
			{
				var splitedFullName = tbRectorName.Text.Split(new char[] { ' ' });
				if (splitedFullName.Length > 3 || splitedFullName.Length < 2)
					tbRectorName.Text = "";
			}
		}

		private void tbMail_Leave(object sender, EventArgs e)
		{
			string input = ((TextBox)sender).Text;
			if (input.Length > 2)
			{
				if (input[0] == ' ' || input[0] == '-')
					input = input.Substring(1);
				if (input[input.Length - 1] == ' ' || input[input.Length - 1] == '-')
					input = input.Substring(1, input.Length - 2);
			}
			Regex email = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
			if (!email.IsMatch(input))
				((TextBox)sender).Text = "";
		}

		private void tbActualAddress_Leave(object sender, EventArgs e)
		{
			string input = ((TextBox)sender).Text;
			input = Regex.Replace(input, @"[^а-яА-Я0-9.,\-\ ]", "");
			input = Regex.Replace(input, @"\s +", " ");
			input = Regex.Replace(input, @"-+", "-");
			input = Regex.Replace(input, @"[.]{2,}", ".");
			input = Regex.Replace(input, @",+", ",");
			input = Regex.Replace(input, @" - ", "-");
			input = Regex.Replace(input, @"- -", " ");
			if (input.Length > 2)
			{
				if (input[0] == ' ' || input[0] == '-')
					input = input.Substring(1);
				if (input[input.Length - 1] == ' ' || input[input.Length - 1] == '-')
					input = input.Substring(1, input.Length - 2);
			}
			((TextBox)sender).Text = input;
		}

		private void tbShortTittle_Leave(object sender, EventArgs e)
		{
			string input = ((TextBox)sender).Text;
			input = Regex.Replace(input, "[^а-яА-Я]", "");
			if (input.Length > 2)
			{
				if (input[0] == ' ' || input[0] == '-')
					input = input.Substring(1);
				if (input[input.Length - 1] == ' ' || input[input.Length - 1] == '-')
					input = input.Substring(1, input.Length - 2);
			}
			((TextBox)sender).Text = input;
		}

		private void fieldChanged(object sender, EventArgs e)
		{
			TextBox R = sender as TextBox;
			if (R.TextLength == 0)
				R.BackColor = Color.Red;
			else
				R.BackColor = Color.White;
			TextChanged(sender, e);
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

		private void btSave_Click(object sender, EventArgs e)
		{
			if (!isEmpty(new string[] { tbINN.Text, tbShortTittle.Text, tbFullTitle.Text, tbActualAddress.Text, tbLegalAddress.Text, tbRectorName.Text, tbMail.Text, tbPhone.Text }))
			{
				if (Add()) this.Close();
				else
				{
					MessageBox.Show("Невозможно добавить этот университет");
				}
			}
			else MessageBox.Show("Не все поля заполнены");
		}

		bool Add()
		{
			var splitedFullName = (tbRectorName.Text.Split(new char[] { ' ' })).ToList();
			if (splitedFullName.Count != 3)
				splitedFullName.Add("");
			if (cur == null)
			{
				MUniversity mUniversity = new MUniversity(tbINN.Text,
															tbShortTittle.Text,
															tbFullTitle.Text,
															tbActualAddress.Text,
															tbLegalAddress.Text,
															splitedFullName[1],
															splitedFullName[0],
															splitedFullName[2],
															tbMail.Text,
															tbPhone.Text);
				return Controllers.CUniversity.Insert(mUniversity);
			}
			else
			{
				cur.INN = tbINN.Text;
				cur.ShortName = tbShortTittle.Text;
				cur.FullName = tbFullTitle.Text;
				cur.ActualAddress = tbActualAddress.Text;
				cur.LegalAddress = tbLegalAddress.Text;
				cur.NameRector = splitedFullName[1];
				cur.MiddleNameRector = splitedFullName[2];
				cur.SurnameRector = splitedFullName[0];
				cur.Email = tbMail.Text;
				cur.Phone = tbPhone.Text;
				return Controllers.CUniversity.Update(cur);
			}
		
		}

		private void tbINN_Leave(object sender, EventArgs e)
		{
			string input = ((TextBox)sender).Text;
			input = Regex.Replace(input, @"[^0-9]", "");
			((TextBox)sender).Text = input;
			if (input.Length > 2)
			{
				if (input[0] == ' ' || input[0] == '-')
					input = input.Substring(1);
				if (input[input.Length - 1] == ' ' || input[input.Length - 1] == '-')
					input = input.Substring(1, input.Length - 2);
			}
			if (((TextBox)sender).Text.Length != 10)
				((TextBox)sender).Text = "";
		}

		private void tbPhone_Leave(object sender, EventArgs e)
		{
			string input = ((TextBox)sender).Text;
			input = Regex.Replace(input, @"[^0-9]", "");
			((TextBox)sender).Text = input;
			if (input.Length > 2)
			{
				if (input[0] == ' ' || input[0] == '-')
					input = input.Substring(1);
				if (input[input.Length - 1] == ' ' || input[input.Length - 1] == '-')
					input = input.Substring(1, input.Length - 2);
			}
			if (((TextBox)sender).Text.Length > 11)
				((TextBox)sender).Text = "";
		}

		private void Cancel(object sender, EventArgs e)
		{
			this.Close();
		}

		private void TextChanged(object sender, EventArgs e)
		{
			TextBox R = sender as TextBox;
			if (R.Focused)
			{
				string clipdata = Clipboard.GetText();
				if (R.Text.Contains(clipdata))
				{
					R.Text.Replace(clipdata,"");
				}
			}
		}
	}
}
