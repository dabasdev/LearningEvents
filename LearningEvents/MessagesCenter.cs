using MyCenter;

namespace LearningEvents;

public static class MessagesCenter
{
    public static void HandelMessage()
    {
        EventCenter.ServiceMessage += EventCenterOnServiceMessage;
    }

    private static void EventCenterOnServiceMessage(string message, MessageType messageType)
    {
        switch (messageType)
        {
            case MessageType.Success:
                MessageBox.Show($@"Success  {message} -  Type  {messageType}");
                break;
            case MessageType.Error:
                MessageBox.Show($@"Error  {message} -  Type  {messageType}");
                break;
        }
    }
}