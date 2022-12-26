using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFirewallHelper;
using System.Net;
using System.Net.Sockets;


namespace rascal_controller.util.connection
{
    internal static class tools
    {
        public static byte[] formulateData(byte[] data, long index, string receiver="none", char decorator = ']')
        {
            string preString = $"{index}{decorator}{receiver}";
            byte[] preData = Encoding.ASCII.GetBytes(preString);

            byte[] targetData = new byte[preData.Length + data.Length];

            int i = 0;
            foreach (byte b in preData)
            {
                targetData[i] = b;
                i++;
            }
            foreach (byte b in data)
            {
                targetData[i] = b;
                i++;
            }

            return targetData;
        }
    }

    public class udpServer
    {
        public static int port = 5010;
        public int bufferSize = 1024;

        public static List<Action<byte[]>> outputs = new List<Action<byte[]>>();

        public static void serverThread()
        {
            UdpClient udpClient = new UdpClient(port);
            while (true)
            {
                IPEndPoint RemoteIpEndPoint = new IPEndPoint(IPAddress.Any, 0);
                Byte[] receiveBytes = udpClient.Receive(ref RemoteIpEndPoint);
                foreach (Action<byte[]> a in outputs){a.Invoke(receiveBytes);}
            }
        }
    }

    public static class udpClient
    {
        static string host = "127.0.0.1";
        static int port = 5010;

        static long index = 0;

        public static void send(byte[] data)
        {
            UdpClient udpClient = new UdpClient();
            udpClient.Connect(host, port);
            byte[] dat = tools.formulateData(data, index);
            udpClient.Send(dat, dat.Length);
            index++;
        }
        public static void send(string text)
        {
            UdpClient udpClient = new UdpClient();
            udpClient.Connect(host, port);
            Byte[] senddata = tools.formulateData(Encoding.ASCII.GetBytes(text),index);
            udpClient.Send(senddata, senddata.Length);
            index++;
        }
    }   
}
