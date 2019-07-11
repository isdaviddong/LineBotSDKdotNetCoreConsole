using System;

namespace LineBotSDKdotNetCoreConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Channel Access Token : ");
            var token = Console.ReadLine();
            Console.Write("To User ID : ");
            var toUserID = Console.ReadLine();
            Console.Write("Message To Send : ");
            var Msg = Console.ReadLine();

            var bot = new isRock.LineBot.Bot(token);
            var ret = bot.PushMessage(toUserID, Msg);
            Console.WriteLine($"Send message done with result '{ret}'");
            ret = bot.PushMessage(toUserID, new isRock.LineBot.StickerMessage(1, 2));
            Console.WriteLine($"Send Ticker done with result '{ret}'");
            Console.ReadKey();
        }
    }
}
