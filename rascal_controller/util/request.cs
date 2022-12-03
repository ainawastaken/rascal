using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Diagnostics;

namespace rascal_controller.util
{
    class webRequest
    {
        public struct response
        {
            string responeText;
            int responseLength;
            byte[] bytes;

            string[] headers;

            float ping;
            float RTP;
            float RT;

            bool success;
            string message;
        }

        public response request(string url, string[][] headers)
        {
            response r = new response();
            using (var client = new WebClient())
            {

            }

            return r;
        }
    }
}
