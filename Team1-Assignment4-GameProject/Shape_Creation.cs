using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Team1_Assignment4_GameProject
{
    public class Shape_Creation
    {
        public Collision collision;

        public Vector2 playerPosition = new Vector2(250, 600);
        public Vector2 playerSize = new Vector2(60, 25);
        public Vector2 playerLastPosition;

        public float playerLeftEdge;
        public float playerRightEdge;
        public float playerTopEdge;
        public float playerBottomEdge;

        public float platformTopEdge;
    }
}
