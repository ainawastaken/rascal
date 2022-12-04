﻿using System;
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

        private void devForm_Load(object sender, EventArgs e)
        {
            try
            {
                config = new util.configTemplate.Root();
                XmlSerializer xs = new XmlSerializer(typeof(util.configTemplate.Root));
                FileStream file = new FileStream(Directory.GetParent(Application.ExecutablePath)+@"\resource\config.xml", FileMode.Open);
                config = (util.configTemplate.Root)xs.Deserialize(file);
            }catch (Exception ex){}

            pubIp = new WebClient().DownloadString("https://api.ipify.org");
            ipLbl.Text = pubIp;
            webRequest.response r = webRequest.request(config.RemoteURl + config.ClientUrl + pubIp);
            GC.Collect();
        }

        private void devForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            string request = $"{config.RemoteURl}{config.ClientUrl}{pubIp}/{config.DisconnectUrl}";
            webRequest.response r = webRequest.request(request);
        }
    }
}
