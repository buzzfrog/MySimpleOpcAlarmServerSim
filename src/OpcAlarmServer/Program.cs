using System;

namespace OpcAlarmServer
{
    class Program
    {
        static void Main(string[] args)
        {
            MyServer server = new MyServer();
            server.Run();
        }
    }
}
