using System;
using System.Net.NetworkInformation;

class Program
{
    static void Main()
    {
        var connectionStatus = CheckInternetConnection();

        switch (connectionStatus)
        {
            case InternetConnectionStatus.Connected:
                Console.WriteLine("Internet is connected.");
                break;
            case InternetConnectionStatus.NotConnected:
                Console.WriteLine("No internet connection.");
                break;
            case InternetConnectionStatus.Unknown:
                Console.WriteLine("Unable to determine internet connection status.");
                break;
        }
    }

    static InternetConnectionStatus CheckInternetConnection()
    {
        try
        {
            Ping ping = new Ping();
            PingReply reply = ping.Send("www.google.com", 3000);

            if (reply.Status == IPStatus.Success)
            {
                return InternetConnectionStatus.Connected;
            }
            else
            {
                Console.WriteLine($"Ping failed with status: {reply.Status}");
                return InternetConnectionStatus.NotConnected;
            }
        }
        catch (PingException ex)
        {
            Console.WriteLine($"Exception during ping: {ex.Message}");
            return InternetConnectionStatus.Unknown;
        }
    }
}

enum InternetConnectionStatus
{
    Connected,
    NotConnected,
    Unknown
}
