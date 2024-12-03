using Game10003;
using System;
using System.Drawing;
using System.Numerics;

namespace Game10003
{
    class TestGround
    {
        public void DrawGround()
        {
            Draw.LineSize = 1;
            Draw.LineColor = Color.Black;
            Draw.FillColor = Color.White;
            Draw.Rectangle(0, 500, 800, 600);
        }
    }
}
