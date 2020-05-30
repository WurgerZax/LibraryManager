using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManager
{
    class BookManagerTemplate
    {
        public BookManagerTemplate() { }
        public string Password { get; set; }
        public List<Book> Books { get; set; }
    }
}
