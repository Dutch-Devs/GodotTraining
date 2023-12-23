using System;
using Godot;

public abstract partial class TankController : Resource {
    [Export]
	public Stats Stats = new Stats();

    public abstract MovementOptions Move();
}