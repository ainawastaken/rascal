using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Collections;
namespace rascal_controller.util
{
    public class resolutions
    {
        
        public static Size[] aspects4x3 = new Size[]{
            new Size(640,480),
            new Size(800,600),
            new Size(960,720),
            new Size(1024,768),
            new Size(1280,960),
            new Size(1400,1050),
            new Size(1440,1080),
            new Size(1600,1200),
            new Size(1856,1392),
            new Size(1920,1440),
            new Size(2048,1536)
        };
        public static Size[] aspects16x10 = new Size[]{
            new Size(1280,800),
            new Size(1440,900),
            new Size(1680,1050),
            new Size(1920,1200),
            new Size(2560,1600)
        };
        public static Size[] aspects16x9 = new Size[]{
            new Size(1024,576),
            new Size(1152,648),
            new Size(1280,720),
            new Size(1366,768),
            new Size(1600,900),
            new Size(1920,1080),
            new Size(2560,1440),
            new Size(3840,2160)
        };
        public static Dictionary<string, Size[]> aspects = new Dictionary<string, Size[]>{
            {"4:3", aspects4x3 },
            {"16:10", aspects16x10 },
            {"16:9", aspects16x9 },

        };
    }
}
