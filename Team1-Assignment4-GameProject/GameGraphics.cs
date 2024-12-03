using System;
using System.Numerics;
using Team1_Assignment4_GameProject;

namespace Game10003;

public class GameGraphics
{

    public GameGraphics()
    {

    }

    Vector2 backgroundPosition = new Vector2(0, 0);
    public Game game;
    public Collision collision;
    public int playerDirection = 0;
    public Vector2 lifeicon1;
    public Vector2 lifeicon2;
    public Vector2 lifeicon3;

    public void DrawPlayerSprite(Vector2 PlayerPos)
    {
        //Loads the player sprites and then draws them depending on what direction you are moving. If I had the time, I would have added some way to make it only draw one
        //direction at a time if I had time, because as it stands, it will draw the sprite for both directions at once if you press both A and D at the same time. 

        Texture2D texturePlayerRunRight = Graphics.LoadTexture("../../../Assets/PlayerRunningRight1.png");
        Texture2D texturePlayerRunLeft = Graphics.LoadTexture("../../../Assets/PlayerRunningLeft1.png");
        Texture2D texturePlayerIdle = Graphics.LoadTexture("../../../Assets/PlayerStandingRight.png");
        Texture2D texturePlayerClimb1 = Graphics.LoadTexture("../../../Assets/PlayerClimbing1.png");
        Texture2D texturePlayerClimb2 = Graphics.LoadTexture("../../../Assets/PlayerClimbing2.png");

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
        //Loads the platform textures and then draws them. 
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
        //Loads and draws background texture
        Texture2D textureBackground = Graphics.LoadTexture("../../../Assets/Background.png");
        Graphics.Draw(textureBackground, backgroundPosition);

        //Draws the pole textures in front of the background. I did this so that way we could have the background and foreground moving separately, creating an illusion of movement
        //but I'm not sure if we'll get around to that.
        Texture2D texturePoles = Graphics.LoadTexture("../../../Assets/PlatformSupports.png");
        Graphics.Draw(texturePoles, backgroundPosition);
    }

    public void DrawLadder(Vector2 Ladder1Pos)
    {
        //Loads the texture and then draws the ladder. There are two versions of the ladder, but only one is used. 
        Texture2D textureLadder = Graphics.LoadTexture("../../../Assets/LadderShort.png");

        //Drawing Ladder 1
        Graphics.Draw(textureLadder, Ladder1Pos.X, Ladder1Pos.Y + 50);
    }

    public void DrawBarrel(Vector2 barrelLocation)
    {
        //This loads the barrel texture and then draws it at barrelLocation, -15 in order to make it line up.
        //I had wanted to have it change texture for each barrel, but I guess we didn't really have enough time to make it spawn different barrels that can then be
        //manipulated separately. 
        Texture2D textureBarrelRad = Graphics.LoadTexture("../../../Assets/BarrelRad.png");
        Graphics.Draw(textureBarrelRad, barrelLocation.X - 15, barrelLocation.Y - 15);
    } 

    public void DrawLifeIcon(Vector2 iconLocation)
    {
        //This will draw in the player life icon into the game. I did this three times because I don't know any other way to do this...
        Texture2D lifeicon1 = Graphics.LoadTexture("../../../Assets/davelifeiconcompleted.png");
        Texture2D lifeicon2 = Graphics.LoadTexture("../../../Assets/davelifeiconcompleted.png");
        Texture2D lifeicon3 = Graphics.LoadTexture("../../../Assets/davelifeiconcompleted.png");

        //Drawing Dave's Life Icons into the game.
        Graphics.Draw(lifeicon1, iconLocation.X + 50, iconLocation.Y + 50);
        Graphics.Draw(lifeicon2, iconLocation.X + 75, iconLocation.Y + 50);
        Graphics.Draw(lifeicon3, iconLocation.X + 100, iconLocation.Y + 50);
    }
}
