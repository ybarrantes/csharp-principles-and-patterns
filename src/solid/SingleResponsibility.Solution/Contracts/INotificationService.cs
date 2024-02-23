namespace SingleResponsibility.Solution.Contracts;

public interface INotificationService
{
    bool SendNotification(string message);
}