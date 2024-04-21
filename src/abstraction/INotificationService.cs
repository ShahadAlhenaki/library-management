namespace sda_onsite_2_csharp_library_management.src.abstraction
{
    public interface INotificationService
    {
        public void SendNotificationOnSucess(string title, string name);
        public void SendNotificationOnFailure(string title, string name);

    }
}