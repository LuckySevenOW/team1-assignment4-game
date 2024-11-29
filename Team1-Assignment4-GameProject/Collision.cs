using Game10003;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Team1_Assignment4_GameProject
{
    public class Collision
    {
        public Shape_Creation shape_Creation;

        public Vector2 barrelLocation = new Vector2(Window.Width - 50, 100);
        public int barrelSize = 15;

        public Vector2 barrelLastPosition;
        public float barrelDirectionX = 3;
        public float barrelDirectionY = -3;
    }
}
