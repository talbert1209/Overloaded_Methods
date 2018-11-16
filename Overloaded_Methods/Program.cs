using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overloaded_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Card cardToCheck = new Card(Suit.Clubs, Value.Three);
            bool doesItMatch = Card.DoesCardMatch(cardToCheck, Value.Three);
            Console.WriteLine(doesItMatch);
        }
    }
}
