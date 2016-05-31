using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AndroidTestHelper.AndroidDevice
{
    class DeviceInfo
    {

        public void startGettingDeviceInfo(String serial)
        {

        }
        

        public float BATTERY_PERCENTAGE
        {
            get
            {
                return battery_level;
            }

            set
            {
                battery_level = value;
            }
        }
        private float battery_level;
    }


}
