namespace sda_onsite_2_csharp_library_management.src.Entity
{
    public class User : BaseEntity
    {
        public string Name { get; set; }

        public User(string name)
        {
            Name = name;
        }
    }
}