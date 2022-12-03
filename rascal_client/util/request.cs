using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Diagnostics;
using System.Net.NetworkInformation;

namespace rascal_client.util
{
    class webRequest
    {
        public static bool CheckURLValid(string source)
        {
            Uri uriResult;
            return Uri.TryCreate(source, UriKind.Absolute, out uriResult) && uriResult.Scheme == Uri.UriSchemeHttp;
        }
        public struct response
        {
            public string responeText;
            public int responseLength;
            public byte[] bytes;

            public string[][] headers;

            public float RTP;
            public float RT;

            public bool success;
            public string message;
        }
        public static async Task<PingReply> PingAsync(string url)
        {

            Ping ping = new Ping();

            PingReply result = await ping.SendPingAsync(url);
            return result;
        }
        public static response request(string url, string usr="", string pass="")
        {
            Stopwatch stopw = new Stopwatch();
            stopw.Start();
            response r = new response();
            if (!CheckURLValid(url))
            {
                r.success = false;
                r.message = "url invalid";
                return r;
            }
            PingReply png = PingAsync(url).Result;
            if (png.Status != IPStatus.Success)
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
                if (pass != "" & usr != "")
                {
                    client.Credentials = new NetworkCredential(usr, pass);
                }
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
