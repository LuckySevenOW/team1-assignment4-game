// Include code libraries you need below (use the namespace).
using System;
using System.Numerics;
using System.Security.Principal;
using Team1_Assignment4_GameProject;

// The namespace your code is in.
namespace Game10003
{
    /// <summary>
    ///     Your game code goes inside this class!
    /// </summary>
    public class Game
    {
        // Place your variables here:
        Shape_Creation shape_Creation = new Shape_Creation();
        Collision collision = new Collision();

        /// <summary>
        ///     Setup runs once before the game loop begins.
        /// </summary>
        public void Setup()
        {
            Window.SetTitle("W.I.P");

            Window.SetSize(600, 1000);

            collision.shape_Creation = shape_Creation;
            shape_Creation.collision = collision;
        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {
            collision.barrelLastPosition = collision.barrelLocation;
            shape_Creation.playerLastPosition = shape_Creation.playerPosition;

            Window.ClearBackground(Color.White);

            shape_Creation.platforms(100, 950, 400, 20);
            collision.platformBarrelCollision(100, 950, 400);

            shape_Creation.platforms(0, 850, 100, 25);
            collision.platformBarrelCollision(0, 850, 100);
            shape_Creation.platforms(Window.Width - 100, 850, 100, 25);
            collision.platformBarrelCollision(Window.Width - 100, 850, 100);

            shape_Creation.platforms(400, 750, 75, 25);
            collision.platformBarrelCollision(400, 750, 75);
            shape_Creation.platforms(0, 750, 50, 25);
            collision.platformBarrelCollision(0, 750, 50);

            shape_Creation.platforms(90, 650, 125, 25);
            collision.platformBarrelCollision(100, 650, 125);
            shape_Creation.platforms(325, 650, 75, 25);
            collision.platformBarrelCollision(325, 650, 75);

            shape_Creation.platforms(175, 550, 150, 20);
            collision.platformBarrelCollision(175, 550, 150);

            shape_Creation.platforms(75, 450, 100, 20);
            collision.platformBarrelCollision(75, 450, 100);
            shape_Creation.platforms(300, 450, 125, 20);
            collision.platformBarrelCollision(300, 450, 125);

            shape_Creation.platforms(0, 350, 75, 20);
            collision.platformBarrelCollision(0, 350, 75);
            shape_Creation.platforms(400, 350, 100, 20);
            collision.platformBarrelCollision(400, 350, 100);

            shape_Creation.platforms(100, 250, 100, 20);
            collision.platformBarrelCollision(100, 250, 100);
            shape_Creation.platforms(285, 250, 100, 20);
            collision.platformBarrelCollision(285, 250, 100);
            shape_Creation.platforms(500, 250, 100, 20);
            collision.platformBarrelCollision(500, 250, 100);

            shape_Creation.platforms(50, 150, 100, 20);
            collision.platformBarrelCollision(50, 150, 100);
            shape_Creation.platforms(450, 150, 100, 20);
            collision.platformBarrelCollision(450, 150, 100);

            shape_Creation.platforms(0, 50, 50, 20);
            collision.platformBarrelCollision(0, 50, 50);
            shape_Creation.platforms(150, 60, 300, 20);
            collision.platformBarrelCollision(150, 60, 300);
            shape_Creation.platforms(Window.Width - 50, 50, 50, 20);
            collision.platformBarrelCollision(Window.Width - 50, 50, 50);


            shape_Creation.barrel();
            shape_Creation.player();

            collision.barrelCollision();
            collision.playerBarrelCollision();

            shape_Creation.barrelMovement();

            
        }
    }
}
