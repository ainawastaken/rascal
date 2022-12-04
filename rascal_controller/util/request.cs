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
        public struct pingResponse
        {
            public float RTP;
            public bool success;
            public int status;
        }
        public static pingResponse PingHost(string nameOrAddress)
        {
            Ping pinger = null;
            pingResponse pr = new pingResponse();
            try
            {
                pinger = new Ping();
                PingReply reply = pinger.Send(nameOrAddress);
                pr.status = (int)reply.Status;
                pr.success = (pr.status == (int)IPStatus.Success);
                pr.RTP = reply.RoundtripTime;
            }
            catch (PingException)
            {
                // Discard PingExceptions and return false;
            }
            finally
            {
                if (pinger != null)
                {
                    pinger.Dispose();
                }
            }

            return pr;
        }
        public static response request(string url)
        {
            Stopwatch stopw = new Stopwatch();
            stopw.Start();
            response r = new response();
            r.success = true;
            if (!isValidUrl(url))
            {
                r.success = false;
                r.message = "url invalid";
                return r;
            }
            var response = PingHost(url);
            if (response.success)
            {
                r.success = false;
                r.message = "ping failed";
                return r;
            }
            r.success = response.success;
            r.RTP = response.RTP;

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
