using System;

namespace ProxyPattern
{
    class Client
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Day la Proxy demo *******\n");
            Subject proxy = new Proxy();
            proxy.DoSomeWork();
            Console.ReadKey();
        }
    }
}
