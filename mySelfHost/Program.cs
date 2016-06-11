using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Owin.Hosting;
using Owin;
using OwinMidware;

namespace mySelfHost
{
    class Program
    {
        static void Main(string[] args)
        {
            using (WebApp.Start<Startup>("http://localhost:50000")) {
                Console.WriteLine("The self host are running!");
                Console.ReadLine();
            }
        }
    }
}
