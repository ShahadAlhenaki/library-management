using System.Runtime.CompilerServices;

namespace sda_onsite_2_csharp_library_management.src.Entity
{
    public class BaseEntity
    {
        public Guid Id;
        public DateTime CreatedDate;

        public BaseEntity(DateTime? inputDate = null)
        {
            Id = Guid.NewGuid();
            CreatedDate = inputDate is null ? DateTime.Now : (DateTime)inputDate;
        }

    }
}