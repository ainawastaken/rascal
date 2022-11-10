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
using System.IO;
using System.Diagnostics;

namespace rascal_controller
{
    public partial class window : Form
    {
        char newline = '￼';

        public window()
        {
            InitializeComponent();
        }
        private void window_Load(object sender, EventArgs e)
        {
            Stopwatch stopw = new Stopwatch();
            stopw.Start();
            Ping ping = new Ping();
            var ip = Dns.GetHostAddresses(new Uri(configPath_txt1.Text).Host)[0];
            PingReply result = ping.Send(ip);
            pingLog_rtxt1.Clear();
            pingLog_rtxt1.AppendText($"Status: {result.Status}\n");
            pingLog_rtxt1.AppendText($"Address: {result.Address}\n");
            pingLog_rtxt1.AppendText($"RTP: {result.RoundtripTime}MS\n");
            pingLog_rtxt1.AppendText($"Last checked: {DateTime.Now}\n");
            ping.Dispose();
            GC.Collect();
            stopw.Stop();
            pingLog_rtxt1.AppendText("Ordeal took: " + stopw.ElapsedMilliseconds + "ms\n");
            stopw.Reset();
            stopw.Start();
            string _result;
            using (var client = new WebClient())
            {
                communicationsText_rtxt1.AppendText("Getting response from: " + configPath_txt1.Text + "\n");
                _result = client.DownloadString(configPath_txt1.Text);
                communicationsText_rtxt1.AppendText("Response: " + _result.Replace('\n',newline) + "\n\n");
                string[] elems = _result.Split("],[".ToCharArray());
                communicationsText_rtxt1.AppendText($"{string.Join(",", elems)}\n\n");
                elems[0]=elems[0].Replace("[","");elems[0]=elems[0].Replace("]","");
                elems[1]=elems[1].Replace("[","");elems[1]=elems[1].Replace("]","");
                List<string> admins = new List<string>();
                List<string> clients = new List<string>();
                //admins = elems[0].Split(',').ToList();
                //clients = elems[1].Split(',').ToList();
                adminsListBox1.Items.Clear();
                Console.WriteLine(admins);
                Console.WriteLine(clients);
                communicationsText_rtxt1.AppendText($"{string.Join(",", admins.ToArray())}\n");
                communicationsText_rtxt1.AppendText($"{string.Join(",", clients.ToArray())}\n");
                foreach (string item in admins)
                {
                    adminsListBox1.Items.Add(item);
                }
                clientsListBox1.Items.Clear();
                foreach (string item in clients)
                {
                    clientsListBox1.Items.Add(item);
                }
            }
            stopw.Stop();
            communicationsText_rtxt1.AppendText("Ordeal took: " + stopw.ElapsedMilliseconds + "ms\n");
            GC.Collect();
        }
        private void serverPing_btn1_Click(object sender, EventArgs e)
        {
            Ping ping = new Ping();
            var ip = Dns.GetHostAddresses(new Uri(configPath_txt1.Text).Host)[0];
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

        private void editConfigBtn1_Click(object sender, EventArgs e)
        {
            fileEditor newWind = new fileEditor();
            newWind.Show();
        }
    }
}
