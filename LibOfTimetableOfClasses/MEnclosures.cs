using System;
using System.Text.RegularExpressions;

namespace LibOfTimetableOfClasses
{

    /// <summary>
    /// Класс со свойствами определяющими запись о корпусе в справочнике Корпуса
    /// </summary>
    public class MEnclosures : Model
    {
        string _name;
        string _university;
        string _address;
        string _phone;
        string _comment;
        /// <summary>
        /// Наименование корпуса
        /// Часть ключа (другая University)
        /// В случае записи свойства проводятся проверки переданнаго значения:
        /// Проверка нулевой строки, проверка пустой, проверка длины строки, проверка допустимости введенных символов
        /// Строка должна быть: не-null,не пустая, не более 50 символов, содержать только А-Я, а-я, 0-9, A-Z, a-z, '-'
        /// </summary>
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (value == "") throw new Exception("Пустая строка названия корпуса");
                if (value == null) throw new Exception("Null строка названия корпуса");
                foreach (char s in value)
                {
                    if ((s < 'А' || s > 'я') && (s < 'A' || s > 'z') && s != '-' && (s < '0' || s > '9'))
                    {
                        throw new Exception("Присутствует недопустимый символ в строке названия корпуса");
                    }
                }
                if (value.Length > 50) throw new Exception("Слишком длинная строка названия корпуса");
                _name = value;
            }
        }
        /// <summary>
        /// Университет к которому принадлежит корпус
        /// Часть ключа (Другая Name)
        /// В случае записи свойства проводятся проверки переданнаго значения:
        /// Проверка нулевой строки, проверка пустой, проверка длины строки, проверка допустимости введенных символов
        /// Строка должна быть: не-null,не пустая, не более 10 символов, содержать только А-Я
        /// </summary>
        public string University
        {
            get
            {
                return _university;
            }
            set
            {
                if (value == null || value == "")
                    throw new Exception("Ошибка создания модели. В свойство FullName получен null-объект");
                if (value.Length < 1 || value.Length > 256)
                    throw new Exception("Ошибка создания модели. В свойство FullName получена строка недопустимой длины");
                if (!Regex.IsMatch(value, @"[А-Яа-я\- ]"))
                    throw new Exception("Ошибка создания модели. В свойство FullName получена строка содержащая недопустимые символы");
                if (!IsLetterСaseNormal(value))
                    throw new Exception("Ошибка создания модели. В свойство FullName получена строка неверного формата");
                _university = value;
            }
        }


        /// <summary>
        /// Адрес корпуса
        /// В случае записи свойства проводятся проверки переданнаго значения:
        /// Проверка нулевой строки, проверка пустой, проверка длины строки, проверка допустимости введенных символов
        /// Строка должна быть: не-null,не пустая, не более 256 символов, содержать только А-Я, 0-9, '-', ',', ' ', '.'
        /// </summary>
        public string Address
        {
            get
            {
                return _address;
            }
            set
            {
                if (value == "") throw new Exception("Пустая строка адреса");
                if (value == null) throw new Exception("Null строка адреса");
                foreach (char s in value)
                {
                    if ((s < 'А' || s > 'я') && s != '-' && s != ',' && s != ' ' && s != '.' && (s < '0' || s > '9'))
                    {
                        throw new Exception("Присутствует недопустимый символ в строке адреса");
                    }
                }
                if (value.Length > 256) throw new Exception("Слишком длинная строка адреса");
                _address = value;
            }
        }
        /// <summary>
        /// Номер телефона корпуса
        /// В случае записи свойства проводятся проверки переданнаго значения:
        /// Проверка нулевой строки, проверка пустой, проверка длины строки, проверка допустимости введенных символов
        /// Строка должна быть: не-null,не пустая, не более 11 символов, содержать только  0-9
        /// </summary>
        public string Phone
        {
            get
            {
                return _phone;
            }
            set
            {
                if (value == "") throw new Exception("Пустая строка телефона");
                if (value == null) throw new Exception("Null строка телефона");
                foreach (char s in value)
                {
                    if ((s < '0' || s > '9'))
                    {
                        throw new Exception("Присутствует недопустимый символ в строке телефона");
                    }
                }
                if (value.Length > 11) throw new Exception("Слишком длинная строка телефона");
                _phone = value;
            }
        }
        /// <summary>
        /// Примечание
        /// В случае записи свойства проводятся проверки переданнаго значения:
        /// Проверка нулевой строки, проверка пустой, проверка длины строки, проверка допустимости введенных символов
        /// Строка должна быть: не-null,не пустая, не более 11 символов, содержать только  А-Я, а-я, A-Z, a-z, 0-9,'-', ',', ' ', '.'
        /// </summary>
        public string Comment
        {
            get
            {
                if (_comment != null)
                    return _comment;
                else return "";
            }
            set
            {
                if (value == "" || value == null)
                {
                    _comment = null;
                    return;
                }

                foreach (char s in value)
                {
                    if ((s < 'А' || s > 'я') && (s < 'A' || s > 'z') && s != '-' && s != ',' && s != ' ' && s != '.' && (s < '0' || s > '9'))
                    {
                        throw new Exception("Присутствует недопустимый символ в строке примечания");
                    }
                }
                if (value.Length > 256) throw new Exception("Слишком длинная строка примечания");
                _comment = value;
            }
        }


        /// <summary>
        /// Конструктор класса MEnclosures.
        /// </summary>
        /// <param name="name">Название Корпуса</param>
        /// <param name="university">Краткое название универститета, к которому относится корпус</param>
        /// <param name="address">Адресс корпуса </param>
        /// <param name="phone">Телефон корпуса</param>
        /// <param name="comment">Примечание к записи таблицы</param>
        public MEnclosures(string name, string university, string address, string phone, string comment) : base()
        {
            Name = name;
            University = university;
            Address = address;
            Phone = phone;
            Comment = comment;
        }

        private bool IsLetterСaseNormal(string input)
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

