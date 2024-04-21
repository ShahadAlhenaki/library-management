using sda_onsite_2_csharp_library_management.src.abstraction;

namespace sda_onsite_2_csharp_library_management.src.service;

public class EmailNotificationService : INotificationService
{
    public void SendNotificationOnFailure(string title, string name)
    {
        Console.WriteLine($"We encountered an issue adding {title}. Please review the input data. For more help, visit our FAQ at library.com/faq");
    }

    public void SendNotificationOnSucess(string title, string name)
    {
        Console.WriteLine($"Hello, a new book titled {title} has been successfully added to the Library. If you have any queries or feedback, please contact our support team at support@library.com");
    }

    internal void SendNotificationOnFailure(string name)
    {
        Console.WriteLine($"We encountered an issue adding {name}. Please review the input data. For more help, visit our FAQ at library.com/faq");
    }

    internal void SendNotificationOnSucess(string name)
    {
        Console.WriteLine($"Hello, a new item {name} has been successfully added to the Library. If you have any queries or feedback, please contact our support team at support@library.com");
    }
}
