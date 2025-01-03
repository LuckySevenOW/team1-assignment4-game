﻿using Game10003;
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

        public GameGraphics gamegraphics = new GameGraphics();

        public Vector2 playerPosition = new Vector2(250, 600);
        public Vector2 playerSize = new Vector2(60, 25);
        public Vector2 playerLastPosition;

        public float playerLeftEdge;
        public float playerRightEdge;
        public float playerTopEdge;
        public float playerBottomEdge;

        public float platformTopEdge;

        public void platforms(float rectangleLocationX, float rectangleLocationY, float rectangleSizeX, float rectangleSizeY)
        {
            Draw.FillColor = Color.Clear;
            Draw.LineColor = Color.Clear;
            Draw.Rectangle(rectangleLocationX, rectangleLocationY, rectangleSizeX, rectangleSizeY);
        }

        public void barrel()
        {
            Draw.FillColor = Color.Clear;
            Draw.LineColor = Color.Clear;
            Draw.Circle(collision.barrelLocation.X, collision.barrelLocation.Y, collision.barrelRadius);
            gamegraphics.DrawBarrel(collision.barrelLocation);
        }

        public void barrelMovement()
        {
            if (collision.altBarrelDirection == true)
            {
                collision.barrelLocation.X += 3;
                collision.barrelLocation.Y += 0;
                //Console.WriteLine("BEANS");
            } 
            else if (collision.altBarrelDirection == false)
            {
                collision.barrelLocation.X += 0;
                collision.barrelLocation.Y += 3;
                //collision.barrelLocation.X += collision.barrelDirectionX;
                //collision.barrelLocation.Y += collision.barrelDirectionY;
            }

        }

        public void player()
        {
            Draw.FillColor = Color.Clear;
            Draw.Rectangle(playerPosition.X, playerPosition.Y, playerSize.X, playerSize.Y);
        }
    }
}
