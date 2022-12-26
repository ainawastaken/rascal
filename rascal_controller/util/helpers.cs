using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rascal_controller.util
{
    public static class helpers
    {
        public static readonly char newlist = '¶';
        public static readonly char newitem = '»';
        public static readonly char errorfix = 'Â'; //Obsolote if request is done correctly. More info here: https://stackoverflow.com/questions/35622956/where-is-the-%C3%82-c2-coming-from
        public static readonly byte valSplit = 0xC; // Form feed
    }
}
 