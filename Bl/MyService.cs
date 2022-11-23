using MyCenter;

namespace Bl;

public static class MyService
{
    public static void CallSuccessMessage()
    {
       EventCenter.OnServiceMessage("The Success Message From Bl" , MessageType.Success);
    }

    public static void CallErrorMessage()
    {
        EventCenter.OnServiceMessage("The Error Message From Bl", MessageType.Error);
    }
}