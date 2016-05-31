using Managed.Adb;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AndroidTestHelper
{
    public partial class Form1 : Form
    {
        Device.Actions actions;
        IShellOutputReceiver output;

        public Form1()
        {
            InitializeComponent();
            output = new OutputLogReceiver();
            ((OutputLogReceiver)output).setLogOutput(this.txtLog);

            actions = new Device.Actions((OutputLogReceiver)output);
        }

        private void btnPwr_Click(object sender, EventArgs e)
        {
            actions.pressPowerButtons();
        }

        private void txtLog_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
