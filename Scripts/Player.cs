using Godot;
using System;

public class Player : Character
{
	// Declare member variables here. Examples:
	// private int a = 2;
	// private string b = "text";
	// Called when the node enters the scene tree for the first time.

	private static float Speed = 500.0f;

	private Vector2 MoveVector = new Vector2(0,0);
	private AnimatedSprite AnimSpr;

	public override void _Ready()
	{
		AnimSpr = GetNode<AnimatedSprite>("AnimatedSprite");
		MoveAndSlide(new Vector2(100,0));
	}
	
	public override void _PhysicsProcess(float delta)
	{
		MoveVector = new Vector2(0,0);

		if (Input.IsActionPressed("MoveUp"))
		{
			MoveVector += new Vector2(0,-1 * Speed);
		}
		if(Input.IsActionPressed("MoveLeft"))
		{
			MoveVector += new Vector2(-1 * Speed,0);
		}
		if(Input.IsActionPressed("MoveDown"))
		{
			MoveVector += new Vector2(0,Speed);
		}
		if(Input.IsActionPressed("MoveRight"))
		{
			MoveVector += new Vector2(Speed,0);
		}

		MoveAndSlide(MoveVector);
		if(MoveVector.x > 0)
		{
			AnimSpr.FlipH = true;
		}
		if(MoveVector.x < 0)
		{
			AnimSpr.FlipH = false;
		}
	}
}
