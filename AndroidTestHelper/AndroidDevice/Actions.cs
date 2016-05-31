using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Managed.Adb;
using System.IO;
using Managed.Adb.IO;

namespace AndroidTestHelper.Device
{
    class Actions
    {
        OutputLogReceiver output;

        public Actions()
        {
        }

        public Actions(OutputLogReceiver output)
        {
            this.output = output;
        }

        //simulates pressing power button using adb command
        public void pressPowerButtons()
        {
            List<Managed.Adb.Device> devices = AdbHelper.Instance.GetDevices(AndroidDebugBridge.SocketAddress);

            devices.ElementAt(0).ExecuteShellCommand("input keyevent " + BUTTONS.POWER_BUTTON, output);
            devices.ElementAt(0).ExecuteShellCommand("ls", output);
        }
    }

    
}
