namespace MyCenter;

public delegate void ServiceMessageHandler(string message, MessageType messageType);

public static class EventCenter
{
    public static event ServiceMessageHandler? ServiceMessage;

    public static void OnServiceMessage(string message, MessageType messageType)
    {
        ServiceMessage?.Invoke(message, messageType);
    }
}

public enum MessageType
{
    Success,
    Warning,
    Error,
}