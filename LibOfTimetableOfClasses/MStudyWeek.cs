using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibOfTimetableOfClasses
{
    public class MStudyWeek : Model
    {
        private int _number;
        private String _name;

        public MStudyWeek(int number, string name)
        {
            _number = number;
            _name = name;
        }

        public int Number { get => _number; set => _number = value; }
        public string Name
        {
            get => _name;
            set
            {
                if (value == null || value == "") throw new Exception("Строка не может быть пустой");
                if (value.Length > 25) throw new Exception("Кол-во символов превышает 25");

                foreach (char l in value)
                    if (l < 'А' || l > 'я') throw new Exception("Можно использовать только русские буквы !");

                if (value[0] < 'А' || value[0] > 'Я') throw new Exception("Первая буквы должна быть заглавной !");

                for (int i = 1; i < value.Length; i++)
                    if (value[i] < 'а' || value[i] > 'я') throw new Exception("Все буквы, кроме первой, не могут быть заглавными !");
                _name = value;
            }
        }
    }
}
