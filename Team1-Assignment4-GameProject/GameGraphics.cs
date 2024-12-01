using System;
using System.Numerics;
using Team1_Assignment4_GameProject;

namespace Game10003;

public class GameGraphics
{

    public GameGraphics()
    { 
    
    }

    //Player Textures
    //Graphics.Draw(texturePlayerJump, position);


    //Barrel Textures
    //public Texture2D textureBarrelOil = Graphics.LoadTexture("../../../Assets/BarrelOil.png");
    //public Texture2D textureBarrelBio = Graphics.LoadTexture("../../../Assets/BarrelBio.png");


    //Background Textures



    //Platform Textures
    //public Texture2D texturePlatformSmallLeft = Graphics.LoadTexture("../../../Assets/PlatformSmallLeft.png");
    //public Texture2D texturePlatformSmallRight = Graphics.LoadTexture("../../../Assets/PlatformSmallRight.png");
    //public Texture2D texturePlatformLargeLeft = Graphics.LoadTexture("../../../Assets/PlatformLargeLeft.png");
    //public Texture2D texturePlatformLargeRight = Graphics.LoadTexture("../../../Assets/PlatformLargeRight.png");
    //public Texture2D texturePlatformMiddle = Graphics.LoadTexture("../../../Assets/PlatformMiddle.png");

    Vector2 backgroundPosition = new Vector2(0, 0);
    public Game game;
    public Collision collision;

    public void DrawPlayerSprite(Vector2 PlayerPos)
    {
        Texture2D texturePlayerRunRight = Graphics.LoadTexture("../../../Assets/PlayerRunningRight1.png");
        Texture2D texturePlayerRunLeft = Graphics.LoadTexture("../../../Assets/PlayerRunningLeft1.png");
        Texture2D texturePlayerClimb1 = Graphics.LoadTexture("../../../Assets/PlayerClimbing1.png");
        Texture2D texturePlayerClimb2 = Graphics.LoadTexture("../../../Assets/PlayerClimbing2.png");
        Texture2D texturePlayerJump = Graphics.LoadTexture("../../../Assets/PlayerStandingRight.png");

        if (Input.IsKeyboardKeyPressed(KeyboardInput.W) || Input.IsKeyboardKeyDown(KeyboardInput.W)) 
        {
            Graphics.Draw(texturePlayerClimb1, PlayerPos);
        }

        if (Input.IsKeyboardKeyPressed(KeyboardInput.A) || Input.IsKeyboardKeyDown(KeyboardInput.A)) 
        {
            Graphics.Draw(texturePlayerRunLeft, PlayerPos);
        }

        if (Input.IsKeyboardKeyPressed(KeyboardInput.S) || Input.IsKeyboardKeyDown(KeyboardInput.S)) 
        {
            Graphics.Draw(texturePlayerClimb2, PlayerPos);
        }

        if (Input.IsKeyboardKeyPressed(KeyboardInput.D) || Input.IsKeyboardKeyDown(KeyboardInput.D)) 
        {
            Graphics.Draw(texturePlayerRunRight, PlayerPos);
        }
    }
     
    public void DrawBackground()
    {
          Texture2D textureBackground = Graphics.LoadTexture("../../../Assets/Background.png");
          Graphics.Draw(textureBackground, backgroundPosition);
          
          Texture2D texturePoles = Graphics.LoadTexture("../../../Assets/PlatformSupports.png");
          Graphics.Draw(texturePoles, backgroundPosition);
    }

    public void DrawBarrel(Vector2 barrelLocation)
    {
        Texture2D textureBarrelRad = Graphics.LoadTexture("../../../Assets/BarrelRad.png");
        Graphics.Draw(textureBarrelRad, barrelLocation);
    }
}
