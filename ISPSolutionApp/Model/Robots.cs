using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISPSolutionApp.Model
{
    class Robots : IWork
    {
        public void StartWork()
        {
            Console.WriteLine("Robots have started working....");
        }

        public void StopWork()
        {
            Console.WriteLine("Robots have stopped working....");
        }
    }
}
