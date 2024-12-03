using Game10003;
using System;
using System.Numerics;

namespace Game10003
{
    public class Player
    {
        public Vector2 position;
        public Vector2 velocity;
        public Vector2 size;
        public float speed;
        public Vector2 gravity = new Vector2(0, +10);

        public void DrawPlayer()
        {
            Draw.LineSize = 1;
            Draw.LineColor = Color.Red;
            Draw.FillColor = Color.White;
            Draw.Rectangle(position, size);
        }
        public void MovePlayer()
        {
            // Movement Checks
            if (Input.IsKeyboardKeyDown(KeyboardInput.Left))
            {
                position.X -= speed + Time.DeltaTime;
            }
            if (Input.IsKeyboardKeyDown(KeyboardInput.Right))
            {
                position.X += speed + Time.DeltaTime;
            }
            if (Input.IsKeyboardKeyDown(KeyboardInput.Up))
            {
                position.Y -= 40;
            }

            // Keeps player inside border
            if (position.X < 0)
            {
                position.X = 0;
            }
            if (position.X + size.X > Window.Width)
            {
                position.X = Window.Width - size.X;
            }
            if (position.Y > 500)
            {
                position.Y = 500;
            }
        }
        public void Gravity()
        {
            Vector2 gravityForce = gravity * Time.DeltaTime;
            velocity += gravityForce;
            position += velocity;
        }
    }
}
