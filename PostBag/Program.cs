using PostBag.Model;
using System;

namespace PostBag
{
    class Program
    {
        static void Main(string[] args)
        {
            Bag bag = new Bag();
            bag.Add(new Letter("Alice", "Bob"));
            bag.Add(new Letter("Charles", "Diane", true));
            bag.Add(new Package("Ethan", "Flora", 10));
            bag.Add(new Package("Gwen", "Henry", 10, true));
            bag.Add(new Postcard("Igor", "Jonas"));
            bag.Add(new ValuableLetter("Kate", "Liam", 1000));
            bag.Add(new ValuableLetter("Martin", "Nathan", 1000, true));
            bag.Add(new ValuablePackage("Olivia", "Peter", 10, 1000));
            bag.Add(new ValuablePackage("Quinn", "Ronald", 10, 1000, true));
            bag.Add(new PostalOrder("Simon", 1000));

            Console.WriteLine("Zásilky");
            foreach (var item in bag.Deliveries)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Cennosti");
            foreach (var item in bag.Valuables)
            {
                Console.WriteLine(item);
            }
        }
    }
}
