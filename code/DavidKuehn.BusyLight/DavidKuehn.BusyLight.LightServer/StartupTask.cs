using Windows.ApplicationModel.Background;

namespace DavidKuehn.BusyLight.LightServer
{
    public sealed class StartupTask : IBackgroundTask
    {
        private BackgroundTaskDeferral deferral;

        public void Run(IBackgroundTaskInstance taskInstance)
        {
            deferral = taskInstance.GetDeferral();

            //
            // TODO: Insert code to start one or more asynchronous methods; Call deferral.Complete to stop
            //
        }
    }
}
