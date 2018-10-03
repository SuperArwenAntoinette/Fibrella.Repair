using Fibrella.Repair.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibrella.ConsoleApp
{
    class Program
    {

        private const string READY = "READY";
        private const string NOTREADY = "NOT READY";
        static void Main(string[] args)
        {
            Console.WriteLine("*********************************************************************************************");
            Console.WriteLine("Welcome to the Fibrella Repair Console Application");
            Console.WriteLine("Please input the SMNE number of your umbrella.");
            Console.WriteLine("*********************************************************************************************");
            string smne = Console.ReadLine();

            RepairCenter rc = new RepairCenter();
            var umbrellaStatus = rc.CheckStatus(smne);

            if (umbrellaStatus != null)
            {
                string status = NOTREADY;
                if (umbrellaStatus.IsDone.HasValue)
                {
                    status = umbrellaStatus.IsDone == true ? READY : NOTREADY;
                }
                Console.WriteLine(string.Format("Umbrella {0} is {1}.", smne, status));
                Console.WriteLine("Do you want to print? (Y) Yes or (N) No");
                string response = Console.ReadLine();
                if (response == "Y" || response == "y")
                {
                    Console.WriteLine("Printing...");
                    //printing functionality goes here.
                }
                    
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Umbrella not found.");
            }
        }
    }
}
