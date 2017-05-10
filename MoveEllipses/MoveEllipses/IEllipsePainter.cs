﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoveEllipses
{
    public interface IShapesPainter
    {
        void DrawEllipse(Ellipse el, System.Drawing.Graphics g);
        void DrawRectangle(Rectangle r, System.Drawing.Graphics g);
    }
}
