﻿using System;
using System.Text.RegularExpressions;

namespace LibOfTimetableOfClasses
{


    /// <summary>
    /// ВУЗ
    /// </summary>
    public class MUniversity : Model
    {
        /// <summary>
        /// ИНН
        /// </summary>
        string _inn;

        /// <summary>
        /// Краткое название ВУЗа
        /// </summary>
        string _shortName;

        /// <summary>
        /// Полное название ВУЗа
        /// </summary>
        string _fullName;

        /// <summary>
        /// Текущий адресс ВУЗа
        /// </summary>
        string _actualAddress;

        /// <summary>
        /// Юридический адресс ВУЗа
        /// </summary>
        string _legalAddress;

        /// <summary>
        /// Имя реактора ВУЗа
        /// </summary>
        string _nameRector;

        /// <summary>
        /// Фамилия ректора ВУЗа
        /// </summary>
        string _surnameRector;

        /// <summary>
        /// Отчество ректора ВУЗа
        /// </summary>
        string _middleNameRector;

        /// <summary>
        /// Электронная почта ВУЗа
        /// </summary>
        string _email;

        /// <summary>
        /// Номер телефона ВУЗа
        /// </summary>
        string _phone;

        /// <summary>
        /// Возвращает или задаёт ИНН ВУЗа
        /// </summary>
        public string INN
        {
            get
            {
                return _inn;
            }
            set
            {
                if (value == null)
                    throw new Exception("Ошибка создания модели. В свойство INN получен null-объект");
                if (!Regex.IsMatch(value, @"[0-9]"))
                    throw new Exception("Ошибка создания модели. В свойство INN получена строка содержащая недопустимые символы");
                if (value.Length != 10)
                    throw new Exception("Ошибка создания модели. В свойство INN получена строка недопустимой длины");
                _inn = value;
            }
        }
        /// <summary>
        /// Возвращает или задаёт краткое название ВУЗа
        /// </summary>
        public string ShortName
        {
            get
            {
                return _shortName;
            }
            set
            {
                if (value == null || value == "")
                    throw new Exception("Ошибка создания модели. В свойство ShortName получен null-объект");
                if (value.Length < 1 || value.Length > 10)
                    throw new Exception("Ошибка создания модели. В свойство ShortName получена строка недопустимой длины");
                if (!Regex.IsMatch(value, @"[А-Я]"))
                    throw new Exception("Ошибка создания модели. В свойство ShortName получена строка содержащая недопустимые символы");
                _shortName = value;
            }
        }
        /// <summary>
        /// Возвращает или задаёт полное наименование ВУЗа
        /// </summary>
        public string FullName
        {
            get
            {
                return _fullName;
            }
            set
            {
                if (value == null || value == "")
                    throw new Exception("Ошибка создания модели. В свойство FullName получен null-объект");
                if (value.Length < 1 || value.Length > 256)
                    throw new Exception("Ошибка создания модели. В свойство FullName получена строка недопустимой длины");
                if (!Regex.IsMatch(value, @"[А-Яа-я\- ]"))
                    throw new Exception("Ошибка создания модели. В свойство FullName получена строка содержащая недопустимые символы");
                if (!isLetterСaseNormal(value))
                    throw new Exception("Ошибка создания модели. В свойство FullName получена строка неверного формата");
                _fullName = value;
            }
        }
        /// <summary>
        /// Возвращает или задаёт текущий адрес
        /// </summary>
        public string ActualAddress
        {
            get
            {
                return _actualAddress;
            }
            set
            {
                if (value == null || value == "")
                    throw new Exception("Ошибка создания модели. В свойство ActualAddress получен null-объект");
                if (value.Length < 1 || value.Length > 256)
                    throw new Exception("Ошибка создания модели. В свойство ActualAddress получена строка недопустимой длины");
                if (!Regex.IsMatch(value, @"[а-яА-Я0-9.,\-\ ]"))
                    throw new Exception("Ошибка создания модели. В свойство ActualAddress получена строка содержащая недопустимые символы");
                _actualAddress = value;
            }
        }
        /// <summary>
        /// Возвращает или задаёт юридический адрес
        /// </summary>
        public string LegalAddress
        {
            get
            {
                return _legalAddress;
            }
            set
            {
                if (value == null || value == "")
                    throw new Exception("Ошибка создания модели. В свойство LegalAddress получен null-объект");
                if (value.Length < 1 || value.Length > 256)
                    throw new Exception("Ошибка создания модели. В свойство LegalAddress получена строка недопустимой длины");
                if (!Regex.IsMatch(value, @"[а-яА-Я0-9.,\-\ ]"))
                    throw new Exception("Ошибка создания модели. В свойство LegalAddress получена строка содержащая недопустимые символы");
                _legalAddress = value;
            }
        }
        /// <summary>
        /// Возвращает или задаёт имя ректора
        /// </summary>
        public string NameRector
        {
            get
            {
                return _nameRector;
            }
            set
            {
                if (value == null || value == "")
                    throw new Exception("Ошибка создания модели. В свойство NameRector получен null-объект");
                if (value.Length < 1 || value.Length > 85)
                    throw new Exception("Ошибка создания модели. В свойство NameRector получена строка недопустимой длины");
                if (!Regex.IsMatch(value, @"[а-яА-Я\- ]"))
                    throw new Exception("Ошибка создания модели. В свойство NameRector получена строка содержащая недопустимые символы");
                if (!isLetterСaseNormal(value))
                    throw new Exception("Ошибка создания модели. В свойство NameRector получена строка неверного формата");
                _nameRector = value;
            }
        }
        /// <summary>
        /// Возвращает или задаёт фамилию ректора
        /// </summary>
        public string SurnameRector
        {
            get
            {
                return _surnameRector;
            }
            set
            {
                if (value == null || value == "")
                    throw new Exception("Ошибка создания модели. В свойство SurnameRector получен null-объект");
                if (value.Length < 1 || value.Length > 85)
                    throw new Exception("Ошибка создания модели. В свойство SurnameRector получена строка недопустимой длины");
                if (!Regex.IsMatch(value, @"[а-яА-Я\- ]"))
                    throw new Exception("Ошибка создания модели. В свойство SurnameRector получена строка содержащая недопустимые символы");
                if (!isLetterСaseNormal(value))
                    throw new Exception("Ошибка создания модели. В свойство SurnameRector получена строка неверного формата");
                _surnameRector = value;
            }
        }
        /// <summary>
        ///  Возвращает или задаёт отчество ректора
        /// </summary>
        public string MiddleNameRector
        {
            get
            {
                if (_middleNameRector == null) return "";
                else
                    return _middleNameRector;
            }
            set
            {
                if (value == "" || value == null)
                {
                    _middleNameRector = null;
                    return;
                }

                if (value.Length < 1 || value.Length > 85)
                    throw new Exception("Ошибка создания модели. В свойство MiddleNameRector получена строка недопустимой длины");
                if (!Regex.IsMatch(value, @"[а-яА-Я\- ]"))
                    throw new Exception("Ошибка создания модели. В свойство MiddleNameRector получена строка содержащая недопустимые символы");
                if (!isLetterСaseNormal(value))
                    throw new Exception("Ошибка создания модели. В свойство MiddleNameRector получена строка неверного формата");
                _middleNameRector = value;
            }
        }
        /// <summary>
        /// Возвращает или задаёт адрес электронной почты
        /// </summary>
        public string Email
        {
            get
            {
                return _email;
            }
            set
            {
                if (value == null || value == "")
                    throw new Exception("Ошибка создания модели. В свойство Email получен null-объект");
                if (value.Length < 1 || value.Length > 256)
                    throw new Exception("Ошибка создания модели. В свойство Email получена строка недопустимой длины");
                if (!Regex.IsMatch(value, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$"))
                    throw new Exception("Ошибка создания модели. В свойство Email получена строка содержащая недопустимые символы");
                _email = value;
            }
        }
        /// <summary>
        /// Возвращает или задаёт номер телефона
        /// </summary>
        public string Phone
        {
            get
            {
                return _phone;
            }
            set
            {
                if (value == null || value == "")
                    throw new Exception("Ошибка создания модели. В свойство Phone получен null-объект");
                if (value.Length < 1 || value.Length > 11)
                    throw new Exception("Ошибка создания модели. В свойство Phone получена строка недопустимой длины");
                if (!Regex.IsMatch(value, @"[0-9]"))
                    throw new Exception("Ошибка создания модели. В свойство Phone получена строка содержащая недопустимые символы");
                _phone = value;
            }
        }

        /// <summary>
        /// Создаёт экземлпяр класса ВУЗ со всеми полями
        /// </summary>
        public MUniversity(string inn, string shortName, string fullName, string actualAddress, string legalAddress, string nameRector, string surnameRector, string middleNameRector, string email, string phone) : base()
        {
            INN = inn;
            ShortName = shortName;
            FullName = fullName;
            ActualAddress = actualAddress;
            LegalAddress = legalAddress;
            NameRector = nameRector;
            SurnameRector = surnameRector;
            MiddleNameRector = middleNameRector;
            Email = email;
            Phone = phone;

        }

        private bool isLetterСaseNormal(string input)
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
