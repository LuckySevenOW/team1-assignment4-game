// Include code libraries you need below (use the namespace).
using Game10003;
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


        /// <summary>
        ///     Setup runs once before the game loop begins.
        /// </summary>
        public void Setup()
        {

        }

            //Small Platforms - 216 x 28
            shape_Creation.platforms(30, 150, 216, 28);
            collision.platformBarrelCollision(30, 150, 216);
            shape_Creation.platforms(Window.Width - 246, 150, 216, 28);
            collision.platformBarrelCollision(Window.Width - 246, 150, 216);

            shape_Creation.barrel();
            shape_Creation.player();

            collision.barrelCollision();
            collision.playerBarrelCollision();

            shape_Creation.barrelMovement();
        }
        
        public void DrawPlayer()
        {
            /// Just collision, really. In fact, all of these public voids should be made clear for the final project.
            Draw.FillColor = Color.Clear;
            Draw.Rectangle(PlayerPos.X, PlayerPos.Y, PlayerScale.X, PlayerScale.Y);
            gameGraphics.DrawPlayerSprite(PlayerPos);
            gameGraphics.DrawLifeIcon(iconLocation1);
            gameGraphics.DrawLifeIcon(iconLocation2);
            gameGraphics.DrawLifeIcon(iconLocation3);
        }
       
        public void DrawGround(float Scale)
        {
            /// It's just the floor
            Draw.FillColor = Color.Black;
            Draw.Rectangle(0, (900 - Scale), 600, Scale);
        }
        
        public void Ladder1Detect(Vector2 LadderPos, Vector2 LadderScale, Vector2 PlayerPos, Vector2 PlayerSize)
        {
            /// This does everything you need to know about the first ladder
            if (PlayerPos.X >= LadderPos.X && (PlayerPos.X + PlayerSize.X) <= (LadderPos.X + LadderScale.X) && (PlayerPos.Y + PlayerScale.Y) >= LadderPos.Y && (PlayerPos.Y + PlayerSize.Y) <= (LadderPos.Y + LadderScale.Y))
            {
                CollidingWithLadder1 = true;
            }
            else { CollidingWithLadder1 = false; }
            
            /// Checks if the player is at the bottom of the ladder
            if (CollidingWithLadder1 == true && (PlayerPos.Y + PlayerScale.Y) == (Ladder1Pos.Y + Ladder1Scale.Y)) { AtLadder1Bottom = true; }
            else { AtLadder1Bottom = false; }
            
            /// Checks if the player is at the top of the ladder (though it's kinda useless code)
            if (CollidingWithLadder1 == true && (PlayerPos.Y + PlayerScale.Y) == Ladder1Pos.Y) { AtLadder1Top = true; }
            else { AtLadder1Top = false; }
        }
        
        public void DrawLadder1(Vector2 Pos, Vector2 Scale)
        {
            /// Self explanatory
            Draw.FillColor = Color.Clear;
            Draw.LineColor = Color.Clear;
            Draw.Rectangle(Pos, Scale);
            gameGraphics.DrawLadder(Pos);
        }
       
        public void Platform1Detect(Vector2 PlatPos, Vector2 PlatScale, Vector2 PlayerPos, Vector2 PlayerSize)
        {
            /// Same thing as the ladders. Just runs to see if the player in on/in the platform.
            if ((PlayerPos.X + PlayerSize.X) > PlatPos.X && PlayerPos.X < (PlatPos.X + PlatScale.X) && (PlayerPos.Y + PlayerScale.Y) >= PlatPos.Y && PlayerPos.Y < (PlatPos.Y + PlatScale.Y))
            {
                CollidingWithPlat1 = true;
            }
            else { CollidingWithPlat1 = false; }
        }
        
        public void DrawPlatform1(Vector2 Pos, Vector2 Scale)
        {
            /// I have no idea how raph thinks we can make all of this happen so quickly
            Draw.FillColor = Color.Clear;
            Draw.LineColor = Color.Clear;
            Draw.Rectangle(Pos, Scale);
            gameGraphics.DrawPlatforms();
        }
    }
}
