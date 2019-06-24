using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDesignPattern
{
    public class BirdAdapter : IToyDuck
    {

        IBird bird;
        public BirdAdapter(IBird _bird)
        {
            this.bird = _bird;
        }

        public void squeak()
        {
            bird.makeSound();
        }
    }
}
