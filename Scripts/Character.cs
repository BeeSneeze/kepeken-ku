using Godot;
using System;
using System.Collections.Generic;

public class Character : KinematicBody2D
{
	// Declare member variables here. Examples:
	// private int a = 2;
	// private string b = "text";

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{

	}

	//  // Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(float delta)
	{
		ZIndex = (int)Position.y;
	}

	public void Say(string MsgName)
	{

	}

	public void Listen(string CharacterName)
	{

	}

	public void OnCharacterEnter(string CharacterName)
	{

	}
	public void OnCharacterLeave(string CharacterName)
	{

	}

	public void TriggerAction(string ActionName, )
	{

	}
}
