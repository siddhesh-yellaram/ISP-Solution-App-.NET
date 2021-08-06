using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ISPSolutionApp.Model;

namespace ISPSolutionApp
{
    class Program
    {
        static void Main(string[] args)
        {
            DoAllWorkingJobs(new Managers());
            DoAllEatingJobs(new Managers());
            DoAllWorkingJobs(new Robots());
            Console.ReadLine();
        }
        static void DoAllWorkingJobs(IWork i)
        {
            i.StartWork();
            i.StopWork();
        }

        static void DoAllEatingJobs(IEat e)
        {
            e.StartEat();
            e.StopEat();
        }
    }
}
