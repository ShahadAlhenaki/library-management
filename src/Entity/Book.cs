namespace sda_onsite_2_csharp_library_management.src.Entity
{
    public class Book : BaseEntity
    {
        public string Title { get; set; }

        public Book(string title)
        {
            Title = title;
        }
    }
}