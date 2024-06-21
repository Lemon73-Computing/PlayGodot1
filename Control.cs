using Godot;
using System;

public partial class Control : Sprite2D
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		float amount = 5;
		if (Input.IsKeyPressed(Key.W))
		{
			Position += new Vector2(0, -amount);
		}
		if (Input.IsKeyPressed(Key.A))
		{
			Position += new Vector2(-amount, 0);
		}
		if (Input.IsKeyPressed(Key.S))
		{
			Position += new Vector2(0, amount);
		}
		if (Input.IsKeyPressed(Key.D))
		{
			Position += new Vector2(amount, 0);
		}
	}
}
