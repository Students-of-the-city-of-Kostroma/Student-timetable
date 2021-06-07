using System;
using System.Text.RegularExpressions;

namespace LibOfTimetableOfClasses
{
    /// <summary>
    /// Класс созданный, для исключения дублирования
    /// </summary>  
    public class LetterCaseNormal : Model
    {
        public bool isLetterСaseNormal(string input)
        {
            input = Regex.Replace(input, @"\s+", " ");
            input = Regex.Replace(input, @"-+", "-");
            input = Regex.Replace(input, @" - ", "-");
            input = Regex.Replace(input, @"- -", " ");
            bool isSpacePressed = true;
            foreach (var ch in input)
            {
                if (isSpacePressed)
                {
                    if (Char.IsLower(ch))
                        return false;
                    isSpacePressed = false;
                }
                else if (Char.IsUpper(ch))
                    return false;
                if (ch == ' ' || ch == '-')
                    isSpacePressed = true;
            }
            return true;
        }
    }
}