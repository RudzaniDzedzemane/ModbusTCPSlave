using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace ModbusTCPSlave
{
    public class ModbusSlave
    {
        // Parameters

        Int32 port;

        IPAddress ServerIPAddress;

        TcpClient client;


        public ModbusSlave(String ServerIPAddressString, Int32 port)
        {

            this.port = port;
            this.ServerIPAddress = IPAddress.Parse(ServerIPAddressString);

            client = new TcpClient();

        }

        public void OpenConnectionAndprintMessages()
        {

            Console.WriteLine("Attempting to connect to server");

            client.Connect(this.ServerIPAddress, this.port);

            Console.WriteLine("Connection Sucessful");

            //wait for 15 seconds

            Thread.Sleep(15000);

            Console.WriteLine("Closing Connection");

            client.Close();

        }

        void CloseConnection()
        {
            client.Close();
        }
    }
}
