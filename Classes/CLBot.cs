using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace FlyBird.Classes
{
    internal class CLBot
    {
        private string _filePath = "C:\\Users\\Artem\\source\\repos\\FlyBird\\help\\helpdatasheet.txt";
        public string input_data;
        public CLBot()
        {
            Console.WriteLine("Listener class object was created");
        }

        public void Listener()
        {

            //ConsoleKeyInfo cki;
            string incomeLine;
            while (true)
            {
                
                incomeLine = Console.ReadLine().ToLower();
                if (incomeLine == "exit")
                    break;
                CaseCommand(incomeLine);

            }
        }

        private void CaseCommand(string cmd)
        {

            switch (cmd)
            {
                case "help":
                    FileMode.ReadFile(_filePath);
                    break;
                case "cl":
                    Console.Clear();
                    break;
                case "show os":
                    Console.WriteLine(Environment.OSVersion);
                    break;
                case "show user":
                    Console.WriteLine(Environment.UserName);
                    Console.WriteLine(Environment.MachineName);
                    break;
                case "show network":
                    Networking.ShowIpV4Adress();
                    break;
                case "start":
                    var psi = new ProcessStartInfo("cmd.exe");
                    psi.UseShellExecute = true;
                    Process.Start(psi);
                    Console.ReadKey();
                    break;
                case "game":
                    Zonk zonkObject = new Zonk();
                    zonkObject.AcceptValue();
                    break;
                default:
                    Console.WriteLine(cmd + " is not an internal command");
                    break;
            }

        }


    }
}
