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
             
        }
    }
}
