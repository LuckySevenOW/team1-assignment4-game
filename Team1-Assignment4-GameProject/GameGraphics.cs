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

    Vector2 backgroundPosition = new Vector2(0, 0);
    public Game game;
    public Collision collision;

    public void DrawPlayerSprite(Vector2 PlayerPos)
    {
        Texture2D texturePlayerRunRight = Graphics.LoadTexture("../../../Assets/PlayerRunningRight1.png");
        Texture2D texturePlayerRunLeft = Graphics.LoadTexture("../../../Assets/PlayerRunningLeft1.png");
        Texture2D texturePlayerIdle = Graphics.LoadTexture("../../../Assets/PlayerStandingRight.png");
        Texture2D texturePlayerClimb1 = Graphics.LoadTexture("../../../Assets/PlayerClimbing1.png");
        Texture2D texturePlayerClimb2 = Graphics.LoadTexture("../../../Assets/PlayerClimbing2.png");
        Texture2D texturePlayerJump = Graphics.LoadTexture("../../../Assets/PlayerStandingLeft.png");

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
        else if (!(Input.IsKeyboardKeyPressed(KeyboardInput.D) || Input.IsKeyboardKeyDown(KeyboardInput.D) || Input.IsKeyboardKeyPressed(KeyboardInput.S) || Input.IsKeyboardKeyDown(KeyboardInput.S) || Input.IsKeyboardKeyPressed(KeyboardInput.A) || Input.IsKeyboardKeyDown(KeyboardInput.A) || Input.IsKeyboardKeyPressed(KeyboardInput.W) || Input.IsKeyboardKeyDown(KeyboardInput.W)))
        {
            Graphics.Draw(texturePlayerIdle, PlayerPos);
        }
    }

    public void DrawPlatforms()
    {
        Texture2D texturePlatformSmallLeft = Graphics.LoadTexture("../../../Assets/PlatformSmallLeft.png");
        Texture2D texturePlatformSmallRight = Graphics.LoadTexture("../../../Assets/PlatformSmallRight.png");
        Texture2D texturePlatformLargeLeft = Graphics.LoadTexture("../../../Assets/PlatformLargeLeft.png");
        Texture2D texturePlatformLargeRight = Graphics.LoadTexture("../../../Assets/PlatformLargeRight.png");
        Texture2D texturePlatformMiddle = Graphics.LoadTexture("../../../Assets/PlatformMiddle.png");

        // Middle Platform - 285 x 28
        Graphics.Draw(texturePlatformMiddle, 0, 829);

        // Small Platforms - 216 x 28
        Graphics.Draw(texturePlatformSmallLeft, 0, 729);
        Graphics.Draw(texturePlatformSmallRight, 0, 729);


        //Small Platforms - 216 x 28
        Graphics.Draw(texturePlatformSmallLeft, 0, 629);
        Graphics.Draw(texturePlatformSmallRight, 0, 629);


        //Middle Platform - 285 x 28
        Graphics.Draw(texturePlatformMiddle, 0, 529);

        //Small Platforms - 216 x 28
        Graphics.Draw(texturePlatformSmallLeft, 0, 429);
        Graphics.Draw(texturePlatformSmallRight, 0, 429);


        //Small Platforms - 216 x 28
        Graphics.Draw(texturePlatformSmallLeft, 0, 329);
        Graphics.Draw(texturePlatformSmallRight, 0, 329);

        //Middle Platform - 285 x 28
        Graphics.Draw(texturePlatformMiddle, 0, 229);

        //Small Platforms - 216 x 28
        Graphics.Draw(texturePlatformSmallLeft, 0, 129);
        Graphics.Draw(texturePlatformSmallRight, 0, 129);
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
        Graphics.Draw(textureBarrelRad, barrelLocation.X - 15, barrelLocation.Y - 15);
    }
}
