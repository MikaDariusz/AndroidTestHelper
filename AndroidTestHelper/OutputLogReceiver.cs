using Managed.Adb;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AndroidTestHelper
{
    class OutputLogReceiver : IShellOutputReceiver
    {
        System.Windows.Forms.TextBox text;

        public bool IsCancelled
        {
            get
            {
                return false;
            }
        }

        public void AddOutput(byte[] data, int offset, int length)
        {
            text.AppendText(System.Text.Encoding.UTF8.GetString(data));
        }

        public void Flush()
        {
        }

        public void setLogOutput(System.Windows.Forms.TextBox text)
        {
            this.text = text;
        }
        
    }
}
