using XSockets.Core.XSocket;
using XSockets.Core.XSocket.Helpers;

namespace XSockets.Azure.Service.Controllers
{
    public class SoC : XSocketController
    {
        public string stationName { get; set; }
        public string eventName { get; set; }
        public void OnSoCMessage(string message)
        {
            this.SendTo(p => p.stationName == this.stationName, message, this.eventName);
        }
    }
}
