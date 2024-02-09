using SingleResponsibility.Solution.Contracts;

namespace SingleResponsibility.Solution.Services;

public class NotificationService : INotificationService
{
    public bool SendNotification(string message)
    {
        Console.WriteLine("Sending notification: " + message);
        return true;
    }
}