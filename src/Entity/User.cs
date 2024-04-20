namespace sda_onsite_2_csharp_library_management.src.Entity
{
    public class User : BaseEntity
    {
        public string Name { get; set; }

        public User(string name, DateTime? dateValue = null) : base(dateValue)
        {
            Name = name;
        }
        public override string ToString()
        {
            return Name + " " + base.Id + " " + base.CreatedDate;
        }
    }
}