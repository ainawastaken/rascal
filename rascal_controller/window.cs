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
using System.Xml.Serialization;
using rascal_controller.configTemplate;
using Microsoft.VisualBasic;
using System.Drawing.Imaging;
using System.Threading;

namespace rascal_controller
{
    public partial class window : Form
    {
        char newlist = '¶';
        char newitem = '»';
        char errorfix = 'Â';

        Root config;
        string configPath;

        string usr="";
        string pass="";
        #region LOAD
        public window()
        {
            InitializeComponent();
        }

        public static string DecodeBase64(string value)
        {
            if (string.IsNullOrEmpty(value))
                return string.Empty;
            var valueBytes = Convert.FromBase64String(value);
            return Encoding.UTF8.GetString(valueBytes);
        }
        private void window_Load(object sender, EventArgs e)
        {
            Stopwatch stopw = new Stopwatch();
            stopw.Start();
            loadingForm lf = new loadingForm();
            lf.Show();
            lf.loadingLbl1.Text = "Loading Configuration";
            lf.Update();
            communicationsText_rtxt1.AppendText("Loading config: " + configPath_txt1.Text + "\n");
            configPath =
                Directory.GetParent(Application.ExecutablePath) + @"\" + configPath_txt1.Text;
            try
            {
                config = new configTemplate.Root();
                XmlSerializer xs = new XmlSerializer(typeof(configTemplate.Root));
                FileStream file = new FileStream(configPath, FileMode.Open);
                config = (configTemplate.Root)xs.Deserialize(file);
            }
            catch (Exception ex)
            {
                communicationsText_rtxt1.AppendText(ex.Message + "\n");
            }
            lf.loadingLbl1.Text = "Pinging server & getting users";
            lf.Update();
            serverPing_btn1.PerformClick();
            string _result = "";
            communicationsText_rtxt1.AppendText("Getting response from: " + config.RemoteURl + "\n");

            util.webRequest.response r = util.webRequest.request(config.RemoteURl);
            if (r.success)
            {
                MessageBox.Show(r.message);
                return;
            }

            _result = (r.responeText).Replace(errorfix.ToString(), "");
            communicationsText_rtxt1.AppendText("Response: " + _result + "\n");
            List<string> admins = new List<string>();
            List<string> clients = new List<string>();
            string[] list = _result.Split(newlist);
            admins = list[0].Split(newitem).ToList();
            clients = list[1].Split(newitem).ToList();
            clients.Remove("");
            admins.Remove("");
            adminsListBox1.Items.Clear();
            foreach (string item in admins)
            {
                adminsListBox1.Items.Add(item);
            }
            clientsListBox1.Items.Clear();
            foreach (string item in clients)
            {
                clientsListBox1.Items.Add(item);
            }

            lf.loadingLbl1.Text = "Performing requisites";
            lf.Update();
            communicationsText_rtxt1.AppendText(
                "Ordeal took: " + stopw.ElapsedMilliseconds + "ms\n"
            );
            clientMonitor1.SizeMode = PictureBoxSizeMode.StretchImage;

            foreach (KeyValuePair<string, Size[]> kvp in util.resolutions.aspects)
            {
                foreach (Size size in kvp.Value)
                {
                    monitorAspectRatioList1.DropDownItems.Add($"[{kvp.Key}] {size.Width}X{size.Height}");
                }
            }

            captureThread = new Thread(captureSingle);
            captureThread.Start();
            lf.Hide();
            lf.Dispose();
            GC.Collect();
            stopw.Stop();
        }
        #endregion
        #region CONFIG AND PING
        private void serverPing_btn1_Click(object sender, EventArgs e)
        {
            Stopwatch stopw = Stopwatch.StartNew();
            Ping ping = new Ping();
            var ip = Dns.GetHostAddresses(new Uri(config.RemoteURl).Host)[0];
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
        }
        private void editConfigBtn1_Click(object sender, EventArgs e)
        {
            fileEditor newWind = new fileEditor();
            newWind.Show();
        }
        #endregion
        #region CLIENTS HADNLING
        private void clientsReload_btn1_Click(object sender, EventArgs e)
        {
            string _result;
            _result = util.webRequest.request(config.RemoteURl).responeText.Replace(errorfix.ToString(),"");
            List<string> clients = new List<string>();
            string[] list = _result.Split(newlist);
            clients = list[1].Split(newitem).ToList();
            clients.Remove("");
            clientsListBox1.Items.Clear();
            foreach (string item in clients)
            {
                clientsListBox1.Items.Add(item);
            }
        }
        private void clientsAdd_btn1_Click(object sender, EventArgs e)
        {
            string input = Interaction.InputBox("Client IP", "Add client", null);
            string request = $"{config.RemoteURl}{config.ClientUrl}{input}";
            var _result = util.webRequest.request(request);
            if (input.Replace(" ","") != "")
            {
                Console.WriteLine(request);
                communicationsText_rtxt1.AppendText($"Latest request resulted in: {_result.responeText}\n");
            }
            clientsReload_btn1.PerformClick();
        }
        private void clientsRemove_btn1_Click(object sender, EventArgs e)
        {
            if (clientsListBox1.SelectedIndex != -1)
            {
                string request = $"{config.RemoteURl}{config.ClientUrl}{clientsListBox1.SelectedItem}/{config.DisconnectUrl}";
                util.webRequest.request(request);
                clientsReload_btn1.PerformClick();
            }
        }
        private void clientsEdit_btn1_Click(object sender, EventArgs e)
        {
            string input = Interaction.InputBox("Client IP", "Add client", null);
            string request = $"{config.RemoteURl}{config.ClientUrl}{input}";
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(request);
            if (input.Replace(" ", "") != "")
            {
                Console.WriteLine(request);
                communicationsText_rtxt1.AppendText($"Latest request resulted in: {req.GetResponse().ToString()}\n");
            }
            clientsRemove_btn1.PerformClick();
            clientsReload_btn1.PerformClick();
        }
        private void clientsListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (clientsListBox1.SelectedIndex != -1)
            {
                clientsRemove_btn1.Enabled = true;
                clientsEdit_btn1.Enabled = true;
            }
        }
        #endregion
        #region CONTROL
        Size clientRes;
        float clientFPS;
        Point pointerPos1;
        Font controlFont1 = new Font(SystemFonts.DefaultFont.FontFamily, 9f, FontStyle.Regular);
        Bitmap bmp;
        Thread captureThread;
        int refreshRate = 7; //ms ~24fps
        long lastFrameTime;
        private void clientMonitor1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawString($"W:{clientRes.Width} H:{clientRes.Height}", controlFont1, Brushes.Red, new Point(0,controlFont1.Height*0));
            e.Graphics.DrawString($"X:{pointerPos1.X} Y:{pointerPos1.Y}", controlFont1, Brushes.Red, new Point(0,controlFont1.Height*1));
            e.Graphics.DrawString($"FPS:{clientFPS}", controlFont1, Brushes.Red, new Point(0, controlFont1.Height * 2));
            e.Graphics.DrawLine(Pens.Black, pointerPos1.X - 5f, pointerPos1.Y, pointerPos1.X + 5f, pointerPos1.Y);
            e.Graphics.DrawLine(Pens.Black, pointerPos1.X, pointerPos1.Y+5, pointerPos1.X, pointerPos1.Y - 5f);
        }

        private void clientMonitor1_MouseMove(object sender, MouseEventArgs e)
        {
            pointerPos1 = e.Location;
        }
        private void clientMonitor1_Click(object sender, EventArgs e)
        {

        }

        private void clientMonitor1_MouseEnter(object sender, EventArgs e)
        {
            Cursor.Hide();
        }

        private void clientMonitor1_MouseLeave(object sender, EventArgs e)
        {
            Cursor.Show();
        }
        private void captureSingle()
        {
            while (true)
            {
                if (!this.Visible)
                {
                    captureThread.Abort();
                }

                Stopwatch sw = new Stopwatch();
                sw.Start();
                bmp = new Bitmap(Screen.PrimaryScreen.Bounds.Width,
                                                           Screen.PrimaryScreen.Bounds.Height,
                                                           PixelFormat.Format32bppArgb);
                Graphics screenshot = Graphics.FromImage(bmp);
                screenshot.CopyFromScreen(Screen.PrimaryScreen.Bounds.X,
                                            Screen.PrimaryScreen.Bounds.Y,
                                            0,
                                            0,
                                            Screen.PrimaryScreen.Bounds.Size,
                                            CopyPixelOperation.SourceCopy);

                clientMonitor1.Image = bmp;
                GC.Collect();
                Thread.Sleep(refreshRate);
                lastFrameTime = sw.ElapsedMilliseconds;
                clientFPS = (float)Math.Round((float)(1000f / lastFrameTime));
            }
        }

        #endregion
    }
}
