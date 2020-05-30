using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManager
{
    static class InputValidator
    {
        public const int YearMinimum = 1900;
        public static int YearMaximum {
            get {
                return DateTime.Today.Year;
            }
        }
        public static int YearDefault
        {
            get
            {
                return DateTime.Today.Year;
            }
        }

        public const int AgeMinimum = 0;
        public static int AgeMaximum
        {
            get
            {
                return YearMaximum - YearMinimum;
            }
        }
        public const int AgeDefault = 0;

        public static bool validateAge(int age)
        {
            return age >= AgeMinimum && age <= AgeMaximum;
        }

        public const float PriceMinimum = 0.01F;
        public const float PriceMaximum = 999999F;
        public const float PriceDefault = 100.0F;

        public static bool validateTitle(string title)
        {
            return title.Length > 0;
        } 

        public static string parseTitle(string value)
        {
            if (!validateTitle(value))
            {
                throw new ArgumentException($"Поле название не может быть пустым");
            }
            return value;
        }

        public static bool validateAuthor(string author)
        {
            return author.Length > 0;
        }
        public static string parseAuthor(string value)
        {
            if (!validateAuthor(value))
            {
                throw new ArgumentException($"Поле автор не может быть пустым");
            }
            return value;
        }

        public static bool validatePublisher(string publisher)
        {
            return publisher.Length > 0;
        }
        public static string parsePublisher(string value)
        {
            if (!validatePublisher(value))
            {
                throw new ArgumentException($"Поле издатель не может быть пустым");
            }
            return value;
        }

        public static bool validateYear(int year)
        {
            return (year >= YearMinimum && year <= YearMaximum);
        }
        public static int parseYear(string value)
        {
            int year = Int32.Parse(value);
            if (!validateYear(year))
            {
                throw new ArgumentException($"Диапазон года выпуска {YearMinimum}-{YearMaximum}");
            }
            return year;
        }
        public static bool validateQuality(string quality)
        {
            return quality.Length > 0;
        }
        public static string parseQuality(string value)
        {
            if (!validateQuality(value))
            {
                throw new ArgumentException($"Поле качество не может быть пустым");
            }
            return value;
        }

        public static bool validatePrice(float price)
        {
            return (price >= PriceMinimum && price <= PriceMaximum);
        }
        public static float parsePrice(string value)
        {
            float price = Convert.ToSingle(
                Math.Round(Decimal.Parse(value), 2));
            if (!validatePrice(price))
            {
                throw new ArgumentException($"Диапазон цен {PriceMinimum}-{PriceMaximum} грн");
            }
            return price;
        }
    }
}
