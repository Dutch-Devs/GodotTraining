using Godot;
using System;

public partial class Tank : CharacterBody2D
{
    [Export]
    public TankController Controller = new PlayerControlledTank();

    public override void _Ready()
    {
        MotionMode = MotionModeEnum.Floating;
    }

    public override void _PhysicsProcess(double delta)
    {
        var movement = Controller.Move();
        Velocity = movement.Direction.Normalized() * ((float)delta) * 40000;
        // Velocity *= Controller.Stats.MovementSpeed;

        MoveAndSlide();
    }
}
