using System;
using Godot;

public partial class PlayerControlledTank : TankController
{
    public override MovementOptions Move()
    {
        var velocity = Vector2.Zero;

        if (Input.IsActionPressed("move_right"))
        {
            velocity.X += 1;
        }

        if (Input.IsActionPressed("move_left"))
        {
            velocity.X -= 1;
        }

        if (Input.IsActionPressed("move_down"))
        {
            velocity.Y += 1;
        }

        if (Input.IsActionPressed("move_up"))
        {
            velocity.Y -= 1;
        }

        return new MovementOptions
        {
            Direction = velocity,
            Shoot = false,
        };
    }
}