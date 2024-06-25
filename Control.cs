using Godot;
using System;

public partial class Control : CharacterBody2D
{
	// https://docs.godotengine.org/en/4.2/tutorials/2d/2d_movement.html#way-movement
    [Export]
    public int Speed { get; set; } = 400;

    public override void _PhysicsProcess(double delta)
    {
        Vector2 inputDirection = Input.GetVector("left", "right", "up", "down");
        Velocity = inputDirection * Speed;
        MoveAndSlide();
    }
}
