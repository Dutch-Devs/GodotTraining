using System;
using Godot;


public partial class MovementOptions : Resource
{
    [Export]
    public bool Shoot;
    [Export]
    public Vector2 Direction;
}