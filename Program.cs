using System.Reflection.Metadata;
using Telegram.Bot;
using Telegram.Bot.Polling;

class Program
{
    private static ITelegramBotClient? client;
    private static ReceiverOptions? receiverOptions;
    private static string token = "7527295657:AAFxiTsCyYn3ROgeJNC8o3D-BFi2dD-gUKk";

    private static void Main()
    {
        client = new TelegramBotClient(token);
        receiverOptions = new ReceiverOptions()
        {
           
        };
    }
}