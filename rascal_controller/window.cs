using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.NetworkInformation;

namespace rascal_controller
{
    public partial class window : Form
    {
        public window()
        {
            InitializeComponent();
        }
        private void window_Load(object sender, EventArgs e)
        {
            Ping ping = new Ping();
            var ip = Dns.GetHostAddresses(new Uri(remoteUrlBox1.Text).Host)[0];
            PingReply result = ping.Send(ip);
            pingLog_rtxt1.Clear();
            pingLog_rtxt1.AppendText($"Status: {result.Status}\n");
            pingLog_rtxt1.AppendText($"Address: {result.Address}\n");
            pingLog_rtxt1.AppendText($"RTP: {result.RoundtripTime}MS\n");
            pingLog_rtxt1.AppendText($"Last checked: {DateTime.Now}");
            ping.Dispose();
            result = null;
            ip = null;
            GC.Collect();
        }
        private void serverPing_btn1_Click(object sender, EventArgs e)
        {
            Ping ping = new Ping();
            var ip = Dns.GetHostAddresses(new Uri(remoteUrlBox1.Text).Host)[0];
            PingReply result = ping.Send(ip);
            pingLog_rtxt1.Clear();
            pingLog_rtxt1.AppendText($"Status: {result.Status}\n");
            pingLog_rtxt1.AppendText($"Address: {result.Address}\n");
            pingLog_rtxt1.AppendText($"RTP: {result.RoundtripTime}MS\n");
            pingLog_rtxt1.AppendText($"Last checked: {DateTime.Now}");
            ping.Dispose();
            result = null;
            ip = null;
            GC.Collect();
        }
    }
}
