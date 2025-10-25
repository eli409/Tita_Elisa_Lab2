namespace Tita_Elisa_Lab2.Models
{
    public class BookData
    {
        public IEnumerable<Book> Books { get; set; }
        public IEnumerable<Category> categories { get; set; }
        public IEnumerable<BookCategory> BookCategories { get; set; }
    }
}
