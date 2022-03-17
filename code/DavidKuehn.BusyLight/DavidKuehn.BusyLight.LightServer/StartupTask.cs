using Blinkt;
using System;
using Windows.ApplicationModel.Background;
using Windows.System.Threading;

namespace DavidKuehn.BusyLight.LightServer
{
    public sealed class StartupTask : IBackgroundTask
    {
        private BackgroundTaskDeferral _deferral;
        private ThreadPoolTimer _timer;
        private IBlinkt _blinkt;
        private bool _isOn;
        private const int Times = 10;
        private int ticks = 0;

        public void Run(IBackgroundTaskInstance taskInstance)
        {
            _deferral = taskInstance.GetDeferral();

            _blinkt = new Blinkt.Blinkt();
            _blinkt.SetBrightness(1);

            _timer = ThreadPoolTimer.CreatePeriodicTimer(Timer_Tick, TimeSpan.FromMilliseconds(2000));
        }

        private void Timer_Tick(ThreadPoolTimer timer)
        {
            ticks++;

            if (ticks > Times)
            {
                _blinkt.Clear();
                _deferral.Complete();
            }
            
            if (_isOn)
            {
                _blinkt.SetAll(0, 255, 0, 1);
            }
            else
            {
                _blinkt.SetAll(255, 0, 0, 1);
            }

            
        }
    }
}
