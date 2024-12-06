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

        public Vector2 barrelLocation = new Vector2(5, 35);
        public int barrelRadius = 15;

        public Vector2 barrelLastPosition;
        public float barrelDirectionX = 3;
        public float barrelDirectionY = -3;

        public bool altBarrelDirection;

        public void barrelCollision()
        {

            bool isPastScreenLeft = barrelLocation.X - barrelRadius <= 0;
            bool isPastScreenRight = barrelLocation.X + barrelRadius >= Window.Width;
            bool isUnderScreen = barrelLocation.Y + barrelRadius >= Window.Height + 50;

            if (isPastScreenLeft == true)
            {
                barrelDirectionX = 3f;
                barrelLocation.X = 0 + barrelRadius;
            }
            else if (isPastScreenRight == true)
            {
                barrelDirectionX = -3f;
                barrelLocation.X = Window.Width - barrelRadius;
            }

            if (isUnderScreen == true)
            {
                barrelLocation.X = 5;
                barrelLocation.Y = 35;
            }
        }

        public void platformBarrelCollision(float platformX, float platformY, float platformSizeX)
        {
            shape_Creation.platformTopEdge = platformY;

            bool doesOverlapTop = shape_Creation.platformTopEdge <= barrelLocation.Y + barrelRadius && shape_Creation.platformTopEdge + 20 >= barrelLocation.Y + barrelRadius;

            if (doesOverlapTop == true && platformX <= barrelLocation.X + barrelRadius && platformX + platformSizeX >= barrelLocation.X - barrelRadius)
            {
                //barrelDirectionY = 0;
                //barrelDirectionX = 3;
                altBarrelDirection = true;
                barrelLocation.Y = barrelLastPosition.Y;
                Console.WriteLine("WEEWOOWEEWOO");
            }
            else if (doesOverlapTop == false || platformX > barrelLocation.X + barrelRadius && platformX + platformSizeX < barrelLocation.X - barrelRadius)
            {
                altBarrelDirection = false;
                Console.WriteLine("noot noot");

            }
        }

        public void playerBarrelCollision()
        {
            shape_Creation.playerLeftEdge = shape_Creation.playerPosition.X;
            shape_Creation.playerRightEdge = shape_Creation.playerPosition.X + shape_Creation.playerSize.X;
            shape_Creation.playerTopEdge = shape_Creation.playerPosition.Y;
            shape_Creation.playerBottomEdge = shape_Creation.playerPosition.Y + shape_Creation.playerSize.Y;

            bool doesOverlapPlayerLeft = shape_Creation.playerLeftEdge < barrelLocation.X + barrelRadius;
            bool doesOverlapPlayerRight = shape_Creation.playerRightEdge > barrelLocation.X - barrelRadius;
            bool doesOverlapPlayerTop = shape_Creation.playerTopEdge < barrelLocation.Y + barrelRadius;
            bool doesOverlapPlayerBottom = shape_Creation.playerBottomEdge > barrelLocation.Y - barrelRadius;

            bool doesOverlap = doesOverlapPlayerLeft && doesOverlapPlayerRight && doesOverlapPlayerTop && doesOverlapPlayerBottom;

            if (doesOverlap == true)
            {
                Console.WriteLine("BEEPBOOP");
                //Lose or minus health
            }
        }
    }
}
