using System.ServiceProcess;

namespace NFS.CoreService
{
    public partial class NfsCoreService : ServiceBase
    {
        public NfsCoreService()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
        }

        protected override void OnStop()
        {
        }
    }
}
