using Godot;
using System;

public class custom_label : Label
{
	// Declare member variables here. Examples:
	// private int a = 2;
	// private string b = "text";
	[Export] public string Message;

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		Text = latin_to_sitelen(Message);
	}

//  // Called every frame. 'delta' is the elapsed time since the previous frame.
//  public override void _Process(float delta)
//  {
//      
//  }
	public string latin_to_sitelen(string word)
	{
		switch (word)
		{
			case "ku":
				return "";
				break;
				
		}
		return "";
	}
	
	//public override void _
}
