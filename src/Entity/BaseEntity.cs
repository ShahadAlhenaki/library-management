using System.Runtime.CompilerServices;

namespace sda_onsite_2_csharp_library_management.src.Entity
{
    public class BaseEntity
    {
        public Guid Id { get;} = Guid.NewGuid();
        public DateTime CreatedDate;

        public BaseEntity(DateTime? inputDate = null)
        {
            CreatedDate = inputDate is null ? DateTime.Now : (DateTime)inputDate;
        }
    }
}