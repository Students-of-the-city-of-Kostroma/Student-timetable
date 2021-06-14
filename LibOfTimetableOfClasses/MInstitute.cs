using System;
using System.Text.RegularExpressions;

namespace LibOfTimetableOfClasses
{

    /// <summary>
    /// Институт
    /// </summary>
    public class MInstitute : Model
    {
        string _fullname;
        string _shortname;
        string _director;
        string _VUS;


         public string FullName
        {
            get
            {
                return _fullname;
            }
            set
            {
                if (value == null || !Regex.IsMatch(value, @"[А-Яа-я\-\' ']") || value.Length > 60 || value.Length <= 1)
                    throw new Exception("Некорректная запись поля");
                for (int i = 1; i < value.Length; i++)
                {
                    if (((value[i] < 'А' || value[i] > 'я') || (value[i] >= 'А' && value[i] <= 'Я')) && value[i] != ' ' && value[i] != '.')
                        throw new Exception("Заглавные буквы разрешены только в начале слова!");
                }
                for (int i = 1; i < value.Length-1; i++)
                    if ((value[i-1] >= 'А' && value[i-1] <= 'я') && (value[i]=='.' && value[i+1] !=' ')) 
                        throw new Exception("Точка разрешена тольео в конце слова !");
                
                _fullname = value;
            }
        }

        public string VUS
        {
            get
            {
                return _VUS;
            }
            set
            {
                if (value == null)
                    throw new Exception("Поле ВУЗ пустое");
                _VUS = value;
            }
        }

        public string ShortName
        {
            get
            {
                return _shortname;
            }
            set
            {
                if (value == null || value == "")
                    throw new Exception("Поле Короткое название иннститута пустое");
                if (!Regex.IsMatch(value, @"[А-Я]"))
                    throw new Exception("Поле Короткое назавание института содержит недопустимые символы");
                if (value.Length < 1 || value.Length > 10)
                    throw new Exception("Поле Короткое название института недопустимой длины");
                _shortname = value;
            }
        }

        public string Director
        {
            get
            {
                return _director;
            }
            set
            {

                if (value == null || value == "")
                    throw new Exception("Поле Директор пустое");
                if (!Regex.IsMatch(value, @"[а-яА-Я\-\' ']"))
                    throw new Exception("Поле Директор содержит недопустимые символы");
                _director = value;
            }
        }

        public MInstitute(string fullname, string shortname, string director, string vus) : base()
        {
            FullName = fullname;
            ShortName = shortname;
            Director = director;
            VUS = vus;
        }
    }
}
