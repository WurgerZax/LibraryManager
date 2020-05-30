using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.IO;

namespace LibraryManager {
    public class BookManager {
        public static BookManager Main { get; set; }
        private List<Book> books = new List<Book>();
        public string Password { get; private set; }
        private const string _DefaultFilePath = ".\\db.json";
        public static string DefaultFilePath
        {
            get
            {
                string filePath = _DefaultFilePath;
                if (filePath.StartsWith("."))
                {
                    filePath = Path.GetFullPath(
                        Path.Combine(Directory.GetCurrentDirectory(), filePath));
                }
                return filePath;
            }
        }
        public string FilePath { get; private set; }

        private BookManager() {
        }

        public static BookManager Create(string password, string filePath = null) {
            BookManager bm = new BookManager();
            bm.FilePath = filePath == null ? DefaultFilePath : filePath;
            bm.Password = password;
            return bm;
        }

        public List<Book> GetBooks() {
            return books;
        }

        public Book GetBook(string id)
        {
            return books.Find(book => book.ID == new Guid(id));
        }

        public void RemoveBook(string id)
        {
            books.RemoveAll(book => book.ID == new Guid(id));
        }

        public List<Book> FindBooksByTitle(string title) {// Функция FindAll вызывает делегат с параметром элемента массива типа Book 
            return books.FindAll(book => book.Title.Contains(title));// если делегат вернёт true, то функция этот элемент добавит в возвращаемый массив
        }// Мы ищем в массиве книг все книги, для которых выполнится условие book.Title.Contains(строка). Где Title это get string

        public List<Book> FindBooksByAuthor(string author) {
            return books.FindAll(book => book.Author.Contains(author));
        }

        public List<Book> FindBooksByYears(int from, int to) {
            return books.FindAll(book => book.Year >= from && book.Year <= to);
        }

        public List<Book> FindBooksByPublisher(string publisher) {
            return books.FindAll(book => book.Publisher.Contains(publisher));
        }

        public List<Book> FindBooksByPrice(float min, float max) {
            return books.FindAll(book => book.Price >= min && book.Price <= max);
        }

        public List<Book> FindBooksByQuality(string quality) {
            return books.FindAll(book => book.Quality == quality);
        }

        public List<Book> FindBooksTakenSince(DateTime date) {
            return books.FindAll(book => book.TakenSince != null && book.TakenSince >= date);
        }
        public List<Book> FindBooksTakenBefore(DateTime date)
        {
            return books.FindAll(book => book.TakenSince != null && book.TakenSince <= date);
        }

        public List<Book> FindBooksTaken()
        {
            return books.FindAll(book => book.TakenSince != null);
        }

        public List<Book> FindBooksAvailable()
        {
            return books.FindAll(book => book.TakenSince == null);
        }

        public void updateBooksQualityByAgeMoreThan(int age, string quality)
        {
            books.ForEach((book) =>
            {
                if (DateTime.Today.Year - book.Year > age)
                {
                    book.Quality = quality;
                }
            });
        }
        public void GenerateBooks(int min, int max)
        {
            Func<Book> generateBook = delegate ()
            {
                Book book = new Book();
                book.Title = Generator.newString(8);
                book.Author = Generator.newString(8);
                book.Publisher = Generator.newString(8);
                book.Year = Generator.newInteger(1970, 2020);
                book.Price = Convert.ToSingle(
                    Math.Round((float)Generator.newInteger(1000, 100000) / 100, 2));
                book.Quality = "New";
                book.TakenSince = DateTime.Now.AddDays(-Generator.newInteger(60, 120));
                return book;
            };

            int count = Generator.newInteger(min, max);
            for (int i = 0; i < count; ++i)
            {
                books.Add(generateBook());
            }
        }

        public void AddBook(string title, string author, string publisher, int year, string quality, float price) {
            Book book = new Book();
            book.Title = title;
            book.Author = author;
            book.Publisher = publisher;
            book.Year = year;
            book.Price = price;
            book.Quality = quality;
            book.TakenSince = null;
            books.Add(book);
        }

        public bool Save() {
            try {
                BookManagerTemplate bmt = new BookManagerTemplate();
                bmt.Password = this.Password;
                bmt.Books = this.books;
                string json = JsonSerializer.Serialize<BookManagerTemplate>(bmt);
                File.WriteAllText(this.FilePath, json);
                return true;
            } catch (Exception) {
            }
            return false;
        }

        public static BookManager Load(string filePath = null) {
            try {
                filePath = filePath == null ? DefaultFilePath : filePath;
                string json = File.ReadAllText(filePath);
                BookManagerTemplate bmt = JsonSerializer.Deserialize<BookManagerTemplate>(json);
                BookManager bm = BookManager.Create(bmt.Password, filePath);
                bm.books = bmt.Books;
                return bm;
            } catch (Exception e) {
            }
            return null;
        }
    }
}
