﻿using nyolcadik_tok4cz.Abstractions;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nyolcadik_tok4cz.Entities
{
    public class PresentFactory: IToyFactory
    {
        public Color PresentColor { get; set; }

        public Toy CreateNew()
        {
            return new Present(PresentColor);
        }

    }
}
