// Include code libraries you need below (use the namespace).
using Game10003;
using System;
using System.Numerics;

// The namespace your code is in.
namespace Game10003
{
    /// <summary>
    ///     Your game code goes inside this class!
    /// </summary>
    public class Game
    {
        // Place your variables here:
        Player player = new Player();
        TestGround ground = new TestGround();

        /// <summary>
        ///     Setup runs once before the game loop begins.
        /// </summary>
        public void Setup()
        {
            Window.SetSize(600, 1000);
            Window.SetTitle("Woo Yeah");

            player.position.X = Window.Width / 2;
            player.position.Y = 100;
            player.size = Vector2.One * 50;
            player.speed = 50;
        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {
            Window.ClearBackground(Color.OffWhite);

            player.MovePlayer();
            player.DrawPlayer();
            player.Gravity();
            
        }
    }
}
