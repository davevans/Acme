using System.Threading;
using System.Threading.Tasks;

namespace Com.Lib
{
    public class HealthCheck
    {
        private static bool _isReady;

        public HealthCheck()
        {
            Task.Run(() =>
            {
                Thread.Sleep(30000);

                _isReady = true;
            });
        }

        public bool IsReady() => _isReady;
    }
}
