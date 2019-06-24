using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Sparrow sparrow = new Sparrow();
            IToyDuck toyDuck = new PlasticToyDuck();

            IToyDuck birdAdapter = new BirdAdapter(sparrow);

            Console.WriteLine("Sparrow...");
            sparrow.fly();
            sparrow.makeSound();

            Console.WriteLine("ToyDuck...");
            toyDuck.squeak();

            // Oyuncak ördek kuş gibi davranıyor 
            Console.WriteLine("BirdAdapter...");
            birdAdapter.squeak();
        }
    }
}
