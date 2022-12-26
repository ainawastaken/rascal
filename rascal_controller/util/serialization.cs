using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rascal_controller.util
{
    public class serialization
    {

        byte[] serializeDictionary(Dictionary<object,object> dict)
        {
            List<byte> bytes = new List<byte>();

            foreach (KeyValuePair<object,object> kvp in dict)
            {

            }


            return bytes.ToArray();
        }

    }
}
