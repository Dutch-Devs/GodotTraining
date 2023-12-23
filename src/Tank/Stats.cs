using System;
using Godot;

public partial class Stats : Resource
{
    [Export]
    public int Health;
    [Export]
    public int Defence;
    [Export]
    public int Regen;
    [Export]
    public int BulletSpeed;
    [Export]
    public int BulletDamage;
    [Export]
    public int BulletPenetration;
    [Export]
    public int ReloadSpeed;
    [Export]
    public int MovementSpeed;

    public int TokensSpend => Health + Defence + Regen + BulletDamage + BulletPenetration + BulletSpeed + MovementSpeed + ReloadSpeed;
}