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
    public class ParentLettersToUpper:Form
    {
        public static string PeriodLetterToUpper(string str)
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
    }
}
