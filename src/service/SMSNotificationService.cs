using sda_onsite_2_csharp_library_management.src.abstraction;

namespace sda_onsite_2_csharp_library_management.src.service
{
    public class SMSNotificationService : INotificationService
    {
        public void SendNotificationOnSucess(string title, string name)
        {
            Console.WriteLine($"item {name} {title} added to Library. Thank you!");
        }

        public void SendNotificationOnFailure(string title, string name)
        {
            Console.WriteLine($"Error adding item {name} {title}. Please email support@library.com");
        }

        public void SendNotificationOnSucess(string name)
        {
            throw new NotImplementedException();
        }

        public void SendNotificationOnFailure(string name)
        {
            throw new NotImplementedException();
        }
    }
}