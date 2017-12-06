using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LED_Controller
{
    public static class GlobalVar
    {
        public static int timesRun = 0;
        public static Byte[] presetOne = { 255, 255, 255 };
        public static Byte[] presetTwo = { 0, 0, 0 };
        public static Byte[] colorRGBApplied = { 255, 255, 255 };
        public static Byte[] colorRGBPreview = { 255, 255, 255 };
    }
}
