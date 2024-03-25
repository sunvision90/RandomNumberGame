using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomNumberGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int computernumber = random.Next(0, 101);

            int usernumber = 0;
            
            int guesses = 0;

            while (true)
            {
                Console.WriteLine("Podaj liczbę od 1 do 100");
                string input = Console.ReadLine();
                if (string.IsNullOrEmpty(input))
                {
                    Console.WriteLine("Nie podano żadnej wartości");
                    continue;
                }
                try
                {
                    usernumber = int.Parse(input);
                    if(usernumber < 0 ||  usernumber > 100) 
                    {
                        throw new ArgumentOutOfRangeException();
                    }
                    guesses++;

                    if (usernumber > computernumber)
                    {
                        Console.WriteLine("Podana liczba jest za wysoka");
                        continue;
                    }
                    else if (usernumber < computernumber)
                    {
                        Console.WriteLine("Podana liczba jest za niska");
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("Brawo, odgadłeś liczbe w " + guesses + " próbach");
                        break;

                    }

                }
               
                catch (FormatException) 
                {
                    Console.WriteLine("Podana wartość nie jest liczbą");

                }
                catch (ArgumentOutOfRangeException ex)
                {
                    Console.WriteLine(ex.Message);
                }

                
                
            }
            











        }
        
    }

}
