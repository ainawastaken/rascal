using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using rascal_controller.util;

namespace rascal_controller.util
{
    public class bufferHandler
    {
        struct d_response
        {
            long index;
            string leader;
            byte[] data;
            string text;

            d_response parse(byte[] data)
            {
                var re = new d_response();
                int indent_i = 0;
                string dat;

                string s_ind = "";
                string s_led = "";
                string s_dat = "";
                List<byte> d_dat = new List<byte>();

                foreach (byte let in data)
                {
                    if (indent_i == 0)
                    {
                        s_ind += let;
                    }
                    else if (indent_i == 1)
                    {
                        s_led += let;
                    }
                    else if (indent_i == 2)
                    {
                        s_dat += let;
                        d_dat.Add(let);
                    }


                    if (let == helpers.valSplit)
                    {
                        indent_i++;
                        continue;
                    }
                }
                re.text = Encoding.ASCII.GetString(data);
                re.data = d_dat.ToArray();
                re.leader = s_led;
                re.index = Int64.Parse(s_ind);
                return re;
            }
            d_response parse(string data)
            {
                var re = new d_response();
                int indent_i = 0;
                string dat;

                string s_ind = "";
                string s_led = "";
                string s_dat = "";

                foreach (char let in data)
                {
                    if (indent_i == 0)
                    {
                        s_ind += let;
                    }
                    else if (indent_i == 1)
                    {
                        s_led += let;
                    }
                    else if (indent_i == 2)
                    {
                        s_dat += let;
                    }


                    if (let == helpers.valSplit)
                    {
                        indent_i++;
                        continue;
                    }
                }


                return re;
            }
        }
        struct buffer
        {
            int size;
            
        }
    }
}
