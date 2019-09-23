using System;

namespace LibOfTimetableOfClasses
{
    public class MHEI : Model
    {
        /// <summary>
        /// Полное название
        /// </summary>
        string fullName;
        /// <summary>
        /// Сокращенное название
        /// </summary>
        string abbreviatedName;
        /// <summary>
        /// Ректор
        /// </summary>
        string rector;
        /// <summary>
        /// Контактный телефон
        /// </summary>
        string phone;
        /// <summary>
        /// Электронная почта
        /// </summary>
        string email;

        /// <summary> 
        /// Конструктор иницциализирующий экземпляр объекта ВУЗ 
        /// </summary> 
        /// <param name="fullName">Полное название</param> 
        /// <param name="abbreviatedName">Сокращенное название</param> 
        /// <param name="rector">Ректор</param> 
        /// <param name="phone">Контактный телефон</param> 
        /// <param name="email">Электронная почта</param>
        public MHEI(string fullName, string abbreviatedName, string rector, string phone, string email) : base()
        {
            FullName = fullName;
            AbbreviatedName = abbreviatedName;
            Rector = rector;
            Phone = phone;
            Email = email;
        }
        /// <summary>
        /// Возвращает или задает fullName - полное название.
        /// </summary>
        public string FullName
        {
            get
            {
                return fullName;
            }
            set
            {
                if (value == null) throw new ArgumentNullException("Полное название не может быть не инициализировано");
                if (value == "") throw new AggregateException("Все значения должны быть заполнены");
                fullName = value;
            }
        }
        /// <summary>
        /// Возвращает или задает abbreviatedName - сокащенное название.
        /// </summary>
        public string AbbreviatedName
        {
            get
            {
                return abbreviatedName;
            }
            set
            {
                if (value == null) throw new ArgumentNullException("Сокащенное название не может быть не инициализировано");
                if (value == "") throw new AggregateException("Все значения должны быть заполнены");
                abbreviatedName = value;
            }
        }
        /// <summary>
        /// Возвращает или задает rector - ректор.
        /// </summary>
        public string Rector
        {
            get
            {
                return rector;
            }
            set
            {
                if (value == null) throw new ArgumentNullException("Ректор не может быть не инициализировано");
                if (value == "") throw new AggregateException("Все значения должны быть заполнены");
                rector = value;
            }
        }
        /// <summary>
        ///  Возвращает или задает phone - контактный телефон.
        /// </summary>
        public string Phone
        {
            get
            {
                return phone;
            }
            set
            {
                if (value == null) throw new ArgumentNullException("Контактный телефон не может быть не инициализировано");
                if (value == "") throw new AggregateException("Все значения должны быть заполнены");
                phone = value;
            }
        }
        /// <summary>
        /// Возвращает или задает email - электронная почта.
        /// </summary>
        public string Email
        {
            get
            {
                return email;
            }
            set
            {
                if (value == null) throw new ArgumentNullException("Электронная почта не может быть не инициализировано");
                if (value == "") throw new AggregateException("Все значения должны быть заполнены");
                email = value;
            }
        }

    }
}

