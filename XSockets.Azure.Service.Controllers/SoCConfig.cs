using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XSockets.Core.Configuration;

namespace XSockets.Azure.Service.Controllers
{
    public class SoCConfig : ConfigurationSetting
    {
        public SoCConfig() : base(new Uri("ws://websockets.primedia.co.za:80"), new Uri("ws://websockets.primedia.co.za:4502")) { }
    }
}
