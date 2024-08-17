using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyBird.Classes
{
    static class FileMode
    {
        public static void ReadFile(string filePath)
        {
            if (!File.Exists(filePath)) 
            { 
                throw new ArgumentException(nameof(filePath), "No such file"); 
            }

            StreamReader f = new StreamReader(filePath);
            while (!f.EndOfStream)
            {
                Console.WriteLine(f.ReadLine());
            }
            f.Close();
        }
    }
}
