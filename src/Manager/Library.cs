using sda_onsite_2_csharp_library_management.src.constant;
using sda_onsite_2_csharp_library_management.src.Entity;

namespace sda_onsite_2_csharp_library_management.src.Manager
{
    public class Library
    {
        private IEnumerable<User> _users = [];
        private IEnumerable<Book> _books = [];

        public Library() { }

        public Book? FindBooksByTitle(string title)
        {
            return _books.FirstOrDefault(b => b.Title == title);
        }
        public User? FindUsersByName(string name)
        {
            return _users.FirstOrDefault(u => u.Name == name);
        }

        public void AddUser(User user)
        {
            var userFound = _users.FirstOrDefault(u => u.Name.Equals(user.Name));
            if (userFound != null)
            {
                Console.WriteLine("The user is already exists");
            }
            else
            {
                _users = _users.Append(user);
                Console.WriteLine($"User has been added ({user.Name})");
            }
        }

        public void AddBook(Book book)
        {
            var bookFound = _books.FirstOrDefault(b => b.Title.Equals(book.Title));
            if (bookFound != null)
            {
                Console.WriteLine("The book is already exists");
            }
            else
            {
                _books = _books.Append(book);
                Console.WriteLine($"Book has been added  ({book.Title})");
            }
        }

        public IEnumerable<User> GetUsers()
        {
            return _users;
        }
        public IEnumerable<Book> GetBooks()
        {
            return _books;
        }

        public IEnumerable<User> GetUsers(int page)
        {
            var itemsPerPage = 3;
            var offset = (page - 1) * itemsPerPage;
            var paginated = _users.Skip(offset).Take(itemsPerPage);
            return paginated;
        }
        public IEnumerable<Book> GetBooks(int page)
        {
            var itemsPerPage = 3;
            var offset = (page - 1) * itemsPerPage;
            var paginated = _books.Skip(offset).Take(itemsPerPage);
            return paginated;
        }

        public IEnumerable<User> DeleteUsersByNId(Guid id)
        {
            _users = _users.Where((u) => u.Id != id);
            return _users;
        }
        public IEnumerable<Book> DeleteBooksById(Guid id)
        {
            _books = _books.Where((b) => b.Id != id);
            return _books;
        }

        public IEnumerable<User> SortByDateUser(SortBy? sortBy = SortBy.Ascending)
        {
            if (sortBy == SortBy.Ascending)
            {
                return _users.OrderBy(u => u.CreatedDate);
            }
            else
            {
                return _users.OrderByDescending(u => u.CreatedDate);
            }
        }
        public IEnumerable<Book> SortByDate(SortBy? sortBy = SortBy.Ascending)
        {
            if (sortBy == SortBy.Ascending)
            {
                return _books.OrderBy(b => b.CreatedDate);
            }
            else
            {
                return _books.OrderByDescending(b => b.CreatedDate);
            }
        }
    }
}