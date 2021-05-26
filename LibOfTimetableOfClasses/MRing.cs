namespace LibOfTimetableOfClasses
{
    /// <summary>
    /// Звонки
    /// </summary>
    public class MRing : Model
    {

        /// <summary>
        /// Институт
        /// </summary>
        string university;
        /// <summary>
        /// Номер пары
        /// </summary>     
        string number;
        /// <summary>
        /// Время начала
        /// </summary>
        string timeOfStart;
        /// <summary>
        /// Время конца
        /// </summary>                 
        string timeOfEnd;

        /// <summary>
        /// Создает экземпляр Звонки
        /// </summary>
        /// <param name="university">Название института</param>
        /// <param name="number">Номер пары </param>
        /// <param name="timeOfStart">Время начала</param>
        /// <param name="timeOfEnd">Время конца</param>
        public MRing(string university, string number, string timeOfStart, string timeOfEnd) : base()
        {
            University = university;
            Number = number;
            TimeOfStart = timeOfStart;
            TimeOfEnd = timeOfEnd;
        }

        /// <summary>
        /// nameofaud - название аудитории
        /// </summary>
        public string University
        {
            get
            {
                return university;
            }

            set
            {
                university = value;
            }
        }

        /// <summary>
        /// cafedra - кафедру
        /// </summary>
        public string Number
        {
            get
            {
                return number;
            }

            set
            {
                number = value;
            }
        }

        /// <summary>
        /// building - корпус
        /// </summary>
        public string TimeOfStart
        {
            get
            {
                return timeOfStart;
            }

            set
            {
                timeOfStart = value;
            }
        }

        /// <summary>
        /// spacious - вместительность
        /// </summary>
        public string TimeOfEnd
        {
            get
            {
                return timeOfEnd;
            }

            set
            {
                timeOfEnd = value;
            }
        }
    }
}
