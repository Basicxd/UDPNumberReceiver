using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace UDPNumberReceiver
{
    class Program
    {
        static void Main(string[] args)
        {
            UDPNumberReceiver udpNumberReceiver = new UDPNumberReceiver();
            udpNumberReceiver.UDPReceiver();
        }
    }
}
