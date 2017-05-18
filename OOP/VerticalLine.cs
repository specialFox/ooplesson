﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class VerticalLine:Figure
    {
        public VerticalLine(int yTop,int yBottom,int x, char sym) {
            pList = new List<Point>();
            for (int y = yTop; y <= yBottom; y++) {
                pList.Add(new Point(x, y, sym));
            }
        }

    }
}
