using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace FlyBird.Classes
{
    static class Networking
    {
        public static void ShowIpV4Adress()
        {
            string hostName = Dns.GetHostName(); // Retrive the Name of HOST
            Console.WriteLine(hostName);
            // Get the IP
            string myIP = Dns.GetHostByName(hostName).AddressList[1].ToString();
            Console.WriteLine("My IP Address is : " + myIP);
            Console.ReadKey();
        }
    }
}
