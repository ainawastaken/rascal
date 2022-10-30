using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rascal_controller.util
{
    internal class responseReader
    {
        public static string writeResponse(string[][][] items)
        {

        }

        public static string[][][] readResponse(string response)
        {
            var reading_item = false;
            var item_index = 0;
            var list_index = 0;
            var section_index = 0;
            var item_string = "";
            var items = new List<string>();
            var sections = new List<string[]>();
            var lists = new List<string[][]>();
            foreach (char letter in response)
            {
                if (letter == '«')
                {
                    item_string = "";
                    reading_item = true;
                    continue;
                }
                else if (letter == '»')
                {
                    items.Add(item_string);
                    item_string = "";
                    reading_item = false;
                    continue;
                }
                else if (letter == '►')
                {
                    item_index += 1;
                    continue;
                }
                else if (letter == '▼')
                {
                    sections.Add(items.ToArray());
                    items = new List<string>();
                    section_index += 1;
                    continue;
                }
                else if (letter == '¶')
                {
                    lists.Add(sections.ToArray());
                    sections = new List<string[]>();
                    list_index += 1;
                    continue;
                }
                else 
                {
                    if (reading_item)
                    {
                        item_string += letter;
                    }
                }
            }
            return lists.ToArray();
        }
    }
}
