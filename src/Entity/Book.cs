namespace sda_onsite_2_csharp_library_management.src.Entity
{
    public class Book : BaseEntity
    {
        public string Title { get; set; }

        public Book(string title, DateTime? dateValue = null) : base(dateValue)
        {
            Title = title;
        }
        public override string ToString()
        {
            return Title + " " + base.Id + " " + base.CreatedDate;
        }
    }
}