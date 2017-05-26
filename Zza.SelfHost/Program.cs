using System;
using System.Diagnostics;
using System.ServiceModel;
using Zza.Services;

namespace Zza.SelfHost
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ServiceHost host = new ServiceHost(typeof(ZzaService));
                host.Open();
                Console.WriteLine("Hit any key to exit ");
                Console.ReadKey();
                host.Close();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }            
        }
    }
}
