using sda_onsite_2_csharp_library_management.src.Entity;

namespace sda_onsite_2_csharp_library_management.src.Manager
{
    public class Library
    {
        private IEnumerable<User> _users = [];
        private IEnumerable<Book> _books = [];

        public IEnumerable<Book> FindBooksByTitle(string title)
        {
            return _books.Where(b => b.Title.IndexOf(title, StringComparison.OrdinalIgnoreCase) >= 0);
        }
        public IEnumerable<User> FindUsersByName(string name)
        {
            return _users.Where(u => u.Name.IndexOf(name, StringComparison.OrdinalIgnoreCase) >= 0);
        }

        public void AddUser(User user)
        {
            _users.Append(user);
        }
        public void AddBook(Book book)
        {
            _books.Append(book);
        }
    }
}