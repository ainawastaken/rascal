using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Diagnostics;
using System.Net.NetworkInformation;

namespace rascal_controller.util
{
    class webRequest
    {
        public static bool isValidUrl(string url)
        {
            return Uri.IsWellFormedUriString(url, UriKind.Absolute);
        }
        public struct response
        {
            public string responeText;
            public int responseLength;
            public byte[] bytes;

            public float RTP;
            public float RT;

            public bool success;
            public string message;
        }
        public static PingReply Ping(string url)
        {

            Ping ping = new Ping();
            Console.WriteLine(url);
            PingReply result = ping.Send(url);
            return result;
        }
        public static response request(string url)
        {
            Stopwatch stopw = new Stopwatch();
            stopw.Start();
            response r = new response();
            if (!isValidUrl(url))
            {
                r.success = false;
                r.message = "url invalid";
                return r;
            }
            PingReply png = Ping(url);
            if (png.Status == IPStatus.Success)
            {
                r.success = false;
                r.message = "ping failed";
                return r;
            }
            else
            {
                r.RTP = png.RoundtripTime;
            }


            using (var client = new WebClient())
            {
                client.Encoding = Encoding.UTF8;
                r.bytes = client.DownloadData(url);
                var str = Encoding.Default.GetString(r.bytes);
                r.responeText = str;
                r.responseLength = r.bytes.Length;
            }
            GC.Collect();
            r.RT = stopw.ElapsedMilliseconds;

            return r;
        }
    }
}
