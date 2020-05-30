using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManager
{
    static class Generator
    {
        private static Random random = new Random();

        public static int newInteger(int min, int max)
        {
            if (min > max)
            {
                min = max;
            }
            return random.Next(min, max);
        }

        public static string newString(int length)
        {
            if (length <= 0)
            {
                return "";
            }
            StringBuilder builder = new StringBuilder();

            for (int i = 0; i < length; i++)
            {
                char letter = Convert.ToChar(
                    Convert.ToInt32(Math.Floor(// при умножение на случайное число получается значение с плавающей точкой, а floor усекает.(Например 25.9999=>25)
                        ('z' - 'a' + 1) * random.NextDouble())) + 'a');// По сути 'z'-'a'+1 это число 26 равное кол-ву букв от a до z
                if (i == 0)
                {
                    letter = Char.ToUpper(letter);// ToUpper - с большой буквы
                }
                builder.Append(letter);
            }

            return builder.ToString();
        }
    }
}
