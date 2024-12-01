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
        // Fundamental variables
        float GroundScale;
        float ForceofGravity = 1;
        int FrameRate = 60;
        public Vector2 PlayerPos = new Vector2(290, 682);
        Vector2 PlayerScale = new Vector2(18, 40);
        Vector2 PlayerVel = new Vector2(0, 0);
        bool UpPressed;
        bool LeftPressed;
        bool DownPressed;
        bool RightPressed;
        bool IsStanding = false;
      
        // Location Bools
        bool Plat1Passed = false;
        bool AtLadder1Bottom;
        bool AtLadder1Top;
        bool CollidingWithLadder = false;
        bool LadderState = false;
        bool CollidingWithLadder1 = false;
        bool CollidingWithPlat1 = false;
       
        // Collision and shit
        Vector2 Ladder1Pos = new Vector2(240, 600);
        Vector2 Ladder1Scale = new Vector2(30, 100);
        Vector2 Plat1Pos = new Vector2(270, 600);
        Vector2 Plat1Scale = new Vector2(200, 20);
       
        // Score Variables
        float GameScore = 0;
        float TotalFrames = 0;
        float GameTime = 0;
        Score score;
        bool BarrelAvoided = false;

        //Jake's Variables
        GameGraphics gameGraphics = new GameGraphics();
        public GameGraphics daGraphics;

        /// :::::::::: DANIEL'S VARIABLES ::::::::::
        Shape_Creation shape_Creation = new Shape_Creation();
        Collision collision = new Collision();

        public void Setup()
        {
            Window.ClearBackground(Color.OffWhite);
            Window.SetSize(600, 900);
            Window.SetTitle("Filler Name");
            Window.TargetFPS = FrameRate;
            GroundScale = 200;
            score = new Score();
            /// :::::::::: DANIEL'S CODE::::::::::
            collision.shape_Creation = shape_Creation;
            shape_Creation.collision = collision;
        }

        /// Update runs every frame.
        public void Update()
        {
            Window.ClearBackground(Color.OffWhite);

            //Added by Jake
            daGraphics.DrawBackground();

            /// The objects are drawn to the canvas
            DrawPlatform1(Plat1Pos, Plat1Scale);
            DrawLadder1(Ladder1Pos, Ladder1Scale);
            DrawPlayer();
            DrawGround(GroundScale);
            /// Scoring and Internal timer
            score.Show(GameScore);
            score.Time(GameTime);
            if (BarrelAvoided == true)
            {
                score.Increase(GameScore, 100);
                BarrelAvoided = false;
            }
            if (TotalFrames == FrameRate)
            {
                TotalFrames = 0;
                GameTime++;
            }
            TotalFrames++;
            
            /// When the player moves, show that they moved
            PlayerPos += PlayerVel;
            
            /// Keyboard Inputs
            if (Input.IsKeyboardKeyPressed(KeyboardInput.W) || Input.IsKeyboardKeyDown(KeyboardInput.W)) { UpPressed = true; }
            else { UpPressed = false; }
           
            if (Input.IsKeyboardKeyPressed(KeyboardInput.A) || Input.IsKeyboardKeyDown(KeyboardInput.A)) { LeftPressed = true; }
            else { LeftPressed = false; }
           
            if (Input.IsKeyboardKeyPressed(KeyboardInput.S) || Input.IsKeyboardKeyDown(KeyboardInput.S)) { DownPressed = true; }
            else { DownPressed = false; }
           
            if (Input.IsKeyboardKeyPressed(KeyboardInput.D) || Input.IsKeyboardKeyDown(KeyboardInput.D)) { RightPressed = true; }
            else { RightPressed = false; }
            if (CollidingWithLadder1 == true) { CollidingWithLadder = true; } else { CollidingWithLadder = false; }
            
            if (LeftPressed == true)
            {
                PlayerVel.X = -5;
            }
           
            if (RightPressed == true)
            {
                PlayerVel.X = 5;
            }
           
            /// Ladder mechanics and jumping
            if (DownPressed == true && CollidingWithLadder == true && LadderState == true)
            {
                PlayerVel.Y = 3;
            }
            if (UpPressed == true && CollidingWithLadder == false && IsStanding == true)
            {
                PlayerPos.Y -= 1;
                PlayerVel.Y = -9;
                IsStanding = false;
            }
            else if (UpPressed == true && CollidingWithLadder == true && LadderState == true) { PlayerVel.Y = -3; IsStanding = false; }
            
            /// Overridden button fixes
            if (LeftPressed == false && RightPressed == false) { PlayerVel.X = 0; }
            if (LeftPressed == true && RightPressed == true) { PlayerVel.X = 0; }
            if (UpPressed == false && DownPressed == false && CollidingWithLadder == true) { PlayerVel.Y = 0; }
            if (UpPressed == true && DownPressed == true && CollidingWithLadder == true) { PlayerVel.Y = 0; }
            
            /// Constant downward velocity
            if (IsStanding == true)
            {
                PlayerVel.Y = 0;
            }
            else if (CollidingWithLadder == false) { PlayerVel.Y = PlayerVel.Y + (ForceofGravity); }
            
            /// Collsion Detection
            if ((PlayerPos.Y + PlayerScale.Y) >= 900 - GroundScale) { PlayerPos.Y = 900 - (GroundScale + PlayerScale.Y); IsStanding = true; }
            if (Plat1Passed == false)
            
            {
                /// If the player is above the first ladder, disable its collision
                Ladder1Detect(Ladder1Pos, Ladder1Scale, PlayerPos, PlayerScale);
            }
            
            Platform1Detect(Plat1Pos, Plat1Scale, PlayerPos, PlayerScale);
            if (CollidingWithLadder1 == true)
            {
                Text.Color = Color.Red;
                Text.Draw("LADDER!", 10, 10);
                
                if (AtLadder1Bottom == true)
                {
                    LadderState = true;
                }
                else if (AtLadder1Top == true)
                {
                    IsStanding = true;
                    LadderState = false;
                }
               
                /// If you are on a ladder and not at the top or bottom, you can't move left or right
                else { PlayerVel.X = 0; }
            }
            
            else { Text.Color = Color.Red; Text.Draw("NO LADDER?", 10, 10); }
            
            /// Platform Collision
            if (CollidingWithPlat1 == true)
            {
                if (PlayerPos.X < Plat1Pos.X && PlayerPos.Y < Plat1Pos.Y && (PlayerPos.Y + PlayerScale.Y) > (Plat1Pos.Y + Plat1Scale.Y))
                {
                    PlayerPos.X = Plat1Pos.X - PlayerScale.X;
                    IsStanding = false;
                }
                else if ((PlayerPos.X + PlayerScale.X) > (Plat1Pos.X + Plat1Scale.X) && PlayerPos.Y < Plat1Pos.Y && (PlayerPos.Y + PlayerScale.Y) > (Plat1Pos.Y + Plat1Scale.Y))
                {
                    PlayerPos.X = Plat1Pos.X + Plat1Scale.X;
                    IsStanding = false;
                }
                else if (PlayerPos.Y < Plat1Pos.Y)
                {
                    PlayerPos.Y = Plat1Pos.Y - PlayerScale.Y;
                    IsStanding = true;
                }
                else if ((PlayerPos.Y + PlayerScale.Y) > (Plat1Pos.Y + Plat1Scale.Y))
                {
                    PlayerPos.Y = Plat1Pos.Y + Plat1Scale.Y;
                    IsStanding = false;
                }
            }

            /// Ladders become intangible after climbing
            if ((PlayerPos.Y + PlayerScale.Y) < Ladder1Pos.Y && Plat1Passed == false) { Plat1Passed = true; Plat1Pos = new Vector2(Ladder1Pos.X, Plat1Pos.Y); Plat1Scale = new Vector2((Plat1Scale.X + Ladder1Scale.X), Plat1Scale.Y); }
            if ((PlayerPos.Y + PlayerScale.Y) > Ladder1Pos.Y && Plat1Passed == true) { Plat1Passed = false; Plat1Pos = new Vector2((Ladder1Pos.X + Ladder1Scale.X), Plat1Pos.Y); Plat1Scale = new Vector2((Plat1Scale.X - Ladder1Scale.X), Plat1Scale.Y); }
            
            /// :::::::::: BELOW THIS POINT IS DANIEL'S CODE ::::::::::
            collision.barrelLastPosition = collision.barrelLocation;
            shape_Creation.playerLastPosition = shape_Creation.playerPosition;


            shape_Creation.platforms(100, 950, 400, 20);

            shape_Creation.platforms(89, 150, 200, 20);
            collision.platformBarrelCollision(89, 200);
            shape_Creation.platforms(178, 200, 150, 20);
            collision.platformBarrelCollision(178, 150);
            shape_Creation.platforms(285, 250, 100, 20);
            collision.platformBarrelCollision(285, 100);
            shape_Creation.platforms(400, 750, 75, 25);
            collision.platformBarrelCollision(400, 75);
            shape_Creation.platforms(0, 850, 100, 25);
            collision.platformBarrelCollision(0, 100);
            shape_Creation.platforms(Window.Width - 100, 850, 100, 25);
            collision.platformBarrelCollision(Window.Width - 100, 100);

            shape_Creation.barrel();
            shape_Creation.player();

            collision.barrelCollision();
            collision.playerBarrelCollision();

            shape_Creation.barrelMovement();
        }
        
        public void DrawPlayer()
        {
            /// Just collision, really. In fact, all of these public voids should be made clear for the final project.
            Draw.FillColor = Color.Black;
            Draw.Rectangle(PlayerPos.X, PlayerPos.Y, 18, 40);
            Graphics.Draw(daGraphics.texturePlayerRunRight, PlayerPos.X, PlayerPos.Y);
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
            Draw.FillColor = Color.Blue;
            Draw.Rectangle(Pos, Scale);
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
            Draw.FillColor = Color.Red;
            Draw.Rectangle(Pos, Scale);
        }
    }
}
