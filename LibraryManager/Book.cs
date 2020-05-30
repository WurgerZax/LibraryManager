using System;
namespace LibraryManager {
    public class Book {
        public Guid ID { get; private set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public int Year { get; set; }
        public string Publisher { get; set; }
        public float Price { get; set; }
        public string Quality { get; set; }
        public DateTime? TakenSince { get; set; }

        public Book() {
            ID = Guid.NewGuid();
        }
    }
}
