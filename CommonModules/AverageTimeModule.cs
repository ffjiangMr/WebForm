using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace CommonModules
{

    public class AverageEventArgs : EventArgs
    {
        public Double AverageTime { get; set; }
    }

    public class AverageTimeModule : IHttpModule
    {
        private static Double totalTime;
        private static Int32 requestCount;
        private static Object lockObject = new Object();

        public event EventHandler<AverageEventArgs> NewAverages;

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public void Init(HttpApplication app)
        {
            for (Int32 flag = 0; flag < app.Modules.Count; flag++)
            {
                if (app.Modules[flag] is TimerModule)
                {
                    var module = app.Modules[flag] as TimerModule;
                    module.RequestTimed += (src, args) =>
                    {
                        AddNewDataPoint(args.Duration);
                    };
                    break;
                }
            }
        }

        private void AddNewDataPoint(Double duration)
        {
            lock (lockObject)
            {
                Double ave = (totalTime += duration) / (++requestCount);
                System.Diagnostics.Debug.WriteLine("Average request duration :{0:F2}", ave);
                if (this.NewAverages != null)
                {
                    this.NewAverages(this, new AverageEventArgs() { AverageTime = ave });
                }
            }
        }
    }
}
