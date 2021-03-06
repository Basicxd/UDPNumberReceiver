﻿using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace UDPNumberReceiver
{
    public class UDPNumberReceiver
    {
        public void UDPReceiver()
        {
            //Creates a UdpClient for reading incoming data.
            UdpClient udpServer = new UdpClient(7000);

            //Creates an IPEndPoint to record the IP Address and port number of the sender.  
            IPAddress ip = IPAddress.Any;
            IPEndPoint RemoteIpEndPoint = new IPEndPoint(ip, 7000);

            try
            {
                // Blocks until a message is received on this socket from a remote host (a client).
                Console.WriteLine("Server is blocked");
                while (true)
                {
                    Byte[] receiveBytes = udpServer.Receive(ref RemoteIpEndPoint);
                    //Server is now activated");

                    string receivedData = Encoding.ASCII.GetString(receiveBytes);
                    string[] data = receivedData.Split(' ');
                    string clientName = data[0];
                    string text = data[1] + data[2];

                    Console.WriteLine(receivedData);
                    //Console.WriteLine("Received from: " + clientName.ToString() + " " + text.ToString());

                    //string sendData = "Server: " + text.ToUpper();
                    //Byte[] sendBytes = Encoding.ASCII.GetBytes(sendData);

                    //udpServer.Send(sendBytes, sendBytes.Length, RemoteIpEndPoint);

                    Console.WriteLine("This message was sent from " +
                                      RemoteIpEndPoint.Address.ToString() +
                                      " on their port number " +
                                      RemoteIpEndPoint.Port.ToString());
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
    }
        
}