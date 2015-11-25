using System.ServiceProcess;

namespace NFS.CoreService
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main()
        {
            ServiceBase[] ServicesToRun;
            ServicesToRun = new ServiceBase[] 
            { 
                new NfsCoreService() 
            };
            ServiceBase.Run(ServicesToRun);
        }
    }
}
