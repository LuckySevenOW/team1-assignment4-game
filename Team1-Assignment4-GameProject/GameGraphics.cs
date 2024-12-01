using System;
using System.Numerics;

namespace Game10003;

public class GameGraphics
{
    Texture2D texturePlayerRight = Graphics.LoadTexture("Assets/texturePlayerRight.png");
    Texture2D texturePlayerLeft = Graphics.LoadTexture("Assets/texturePlayerLeft.png");
    Texture2D texturePlayerClimb = Graphics.LoadTexture("Assets/texturePlayerClimb.png");
    Texture2D texturePlayerJump = Graphics.LoadTexture("Assets/texturePlayerJump.png");

    Texture2D textureBarrel = Graphics.LoadTexture("Assets/textureBarrel.png");
    Texture2D textureBackground = Graphics.LoadTexture("Assets/textureBackground.png");
    public void DrawPlayerSprite()
    {
        //Graphics.Draw(texturePlayerRight, position);
        //Graphics.Draw(texturePlayerRight, position);
        //Graphics.Draw(texturePlayerRight, position);
        //Graphics.Draw(texturePlayerRight, position);
    }

    public void DrawBackground()
    {
        //Graphics.Draw(textureBackground, position);
    }

    public void DrawBarrel()
    {
       // Graphics.Draw(textureBarrel, position);
    }
}
