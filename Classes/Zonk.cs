using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace FlyBird.Classes
{
    internal class Zonk
    {
        private int _zonkNumber = 1;

        public string ZonkNumber
        {
            
            get => _zonkNumber.ToString();

            set 
            {
                int _parsevalue = 0;
                try
                {
                    _parsevalue = int.Parse(value);
                    
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }

                if ((_parsevalue < 6 && _parsevalue > 0) && (_parsevalue - (int)_parsevalue) == 0)
                    this._zonkNumber = _parsevalue;
                else if (_parsevalue == 9)
                    Console.WriteLine("Good by");
                else 
                    Console.WriteLine("Please choose numbers 1-6 to play and 9 to leave game");
            }

        }
        public Zonk()
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("You are welcome to zonk game");
            Console.WriteLine("Enter value from 1 to 5");
        }

        public void AcceptValue()
        {
            
            int _parsevalue = 0;

            while (_parsevalue != 9)
            {

                    try
                    {
                        _parsevalue = int.Parse(Console.ReadLine());

                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Please choose numbers 1-6 to play or 9 to leave game");
                    }


                if ((_parsevalue < 6 && _parsevalue > 0) && (_parsevalue - (int)_parsevalue) == 0)
                {
                    this._zonkNumber = _parsevalue;
                    Game();
                }
                else if (_parsevalue == 9)
                    Console.WriteLine("Good by");
                else
                    Console.WriteLine("Please choose numbers 1-6 to play or 9 to leave game");
            }

        }

        private void Game()
        {
            
                int result = 0, increment = 0;
                for (int i = 0; i < _zonkNumber; i++)
                {
                    increment = new Random().Next(1, 6);
                    result += increment;
                    Console.WriteLine(increment);
                }

                Console.WriteLine("Total sum is " + result.ToString());
   //         return new Random().Next(1, 6) == _zonkNumber ? "Get our congretulation. You are win!" : "You are lost";
        }
    }
}
