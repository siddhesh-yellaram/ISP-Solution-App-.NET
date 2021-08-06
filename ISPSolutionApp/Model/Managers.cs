using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISPSolutionApp.Model
{
    class Managers : IWork, IEat
    {
        public void StartEat()
        {
            Console.WriteLine("Managers have started eating...");
        }

        public void StartWork()
        {
            Console.WriteLine("Managers have started working...");
        }

        public void StopEat()
        {
            Console.WriteLine("Managers have finished eating...");
        }

        public void StopWork()
        {
            Console.WriteLine("Managers have finished working...");
        }
    }
}
