﻿using System;
using System.Drawing;
using System.Text;
using System.Collections.Generic;

namespace TelCo.ColorCoder.SubModule
{
    class ColorPair
    {
        internal Color majorColor;
        internal Color minorColor;
        public override string ToString()
        {
            return string.Format("MajorColor:{0}, MinorColor:{1}", majorColor.Name, minorColor.Name);
        }
    }
}
