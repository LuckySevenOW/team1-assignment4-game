using System;
using System.Numerics;

namespace Game10003;

public class GameGraphics
{

    public GameGraphics()
    { 
    
    }

    //Player Textures
    public Texture2D texturePlayerRunRight = Graphics.LoadTexture("Assets/PlayerRunningRight1.png");
    public Texture2D texturePlayerRunLeft = Graphics.LoadTexture("Assets/PlayerRunningLeft1.png");
    public Texture2D texturePlayerClimb1 = Graphics.LoadTexture("Assets/PlayerClimbing1.png");
    public Texture2D texturePlayerClimb2 = Graphics.LoadTexture("Assets/PlayerClimbing2.png");
    public Texture2D texturePlayerJump = Graphics.LoadTexture("Assets/PlayerStandingRight.png");

    //Barrel Textures
    public Texture2D textureBarrelOil = Graphics.LoadTexture("Assets/BarrelOil.png");
    public Texture2D textureBarrelBio = Graphics.LoadTexture("Assets/BarrelBio.png");
    public Texture2D textureBarrelRad = Graphics.LoadTexture("Assets/BarrelRad.png");

    //Background Textures
    public Texture2D textureBackground = Graphics.LoadTexture("Assets/Background.png");
    public Texture2D texturePoles = Graphics.LoadTexture("Assets/PlatformSupports.png");

    //Platform Textures
    public Texture2D texturePlatformSmallLeft = Graphics.LoadTexture("Assets/PlatformSmallLeft.png");
    public Texture2D texturePlatformSmallRight = Graphics.LoadTexture("Assets/PlatformSmallRight.png");
    public Texture2D texturePlatformLargeLeft = Graphics.LoadTexture("Assets/PlatformLargeLeft.png");
    public Texture2D texturePlatformLargeRight = Graphics.LoadTexture("Assets/PlatformLargeRight.png");
    public Texture2D texturePlatformMiddle = Graphics.LoadTexture("Assets/PlatformMiddle.png");

    Vector2 backgroundPosition = new Vector2(0, 0);

    public void DrawPlayerSprite()
    {
        //Graphics.Draw(texturePlayerRunRight, position);
        //Graphics.Draw(texturePlayerRunleft, position);
        //Graphics.Draw(texturePlayerClimb1, position);
        //Graphics.Draw(texturePlayerClimb2, position);
        //Graphics.Draw(texturePlayerJump, position);
    }

    public void DrawBackground()
    {
        Graphics.Draw(textureBackground, backgroundPosition);
    }

    public void DrawPoles()
    {
        //Graphics.Draw(texturePoles, position);
    }

    public void DrawBarrel()
    {
       // Graphics.Draw(textureBarrel, position);
    }
}
