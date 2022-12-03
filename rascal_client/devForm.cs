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
using System.Xml.Serialization;
using System.IO;
using rascal_client.util;

namespace rascal_client
{
    public partial class devForm : Form
    {
        public devForm()
        {
            InitializeComponent();
        }
        util.configTemplate.Root config;

        string pubIp;


        public static string DecodeBase64(string value)
        {
            if (string.IsNullOrEmpty(value))
                return string.Empty;
            var valueBytes = Convert.FromBase64String(value);
            return Encoding.UTF8.GetString(valueBytes);
        }

        private void devForm_Load(object sender, EventArgs e)
        {
            try
            {
                config = new util.configTemplate.Root();
                XmlSerializer xs = new XmlSerializer(typeof(util.configTemplate.Root));
                FileStream file = new FileStream(Directory.GetParent(Application.ExecutablePath)+@"\resource\config.xml", FileMode.Open);
                config = (util.configTemplate.Root)xs.Deserialize(file);
            }
            catch (Exception ex){}

            pubIp = new WebClient().DownloadString("https://api.ipify.org");
            ipLbl.Text = pubIp;
            GC.Collect();

            string usr;
            string pass;

            if (config.B64)
            {
                usr = DecodeBase64(config.Username);
                pass = DecodeBase64(config.Password);
            }
            else
            {
                usr = config.Username;
                pass = config.Password;
            }
            util.webRequest.response r = util.webRequest.request(config.RemoteURl + pubIp, usr, pass);
        }

        private void devForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            string usr;
            string pass;

            if (config.B64)
            {
                usr = DecodeBase64(config.Username);
                pass = DecodeBase64(config.Password);
            }
            else
            {
                usr = config.Username;
                pass = config.Password;
            }
            util.webRequest.response r = util.webRequest.request(config.RemoteURl+pubIp+config.DisconnectUrl,usr,pass);
        }
    }
}
