using System;
using System.Windows.Forms;

namespace winPower
{
    class Program
    {
        static void Main(string[] args)
        {
           if (args.Length>0)
            {
                if (args[0].Equals("standby"))
                {
                    // Standby
                    Application.SetSuspendState(PowerState.Suspend, true, true);
                }
                else if (args[0].Equals("standby"))
                {
                    // Hibernate
                    Application.SetSuspendState(PowerState.Hibernate, true, true);
                }
                else
                    printUsage();

            }
            else
            {
                printUsage();
            }
        }
        static void printUsage()
        {
            Console.WriteLine("Usage:");
            Console.WriteLine("\twinPower.exe standby ==> Making windows standby");
            Console.WriteLine("\twinPower.exe hibernate ==> Making windows hibernate");

        }
    }
}
