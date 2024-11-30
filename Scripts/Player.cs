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

	public override void _Ready()
	{
		MoveAndSlide(new Vector2(100,0));
	}
	
	public override void _PhysicsProcess(float delta)
	{
		
		if (Input.IsActionPressed("MoveUp"))
		{
			MoveAndSlide(new Vector2(0,-1 * Speed));
		}
		else if(Input.IsActionPressed("MoveLeft"))
		{
			MoveAndSlide(new Vector2(-1 * Speed,0));
		}
		else if(Input.IsActionPressed("MoveDown"))
		{
			MoveAndSlide(new Vector2(0,Speed));
		}
		else if(Input.IsActionPressed("MoveRight"))
		{
			MoveAndSlide(new Vector2(Speed,0));
		}
	}
//  // Called every frame. 'delta' is the elapsed time since the previous frame.
//  public override void _Process(float delta)
//  {
//      
//  }
}
