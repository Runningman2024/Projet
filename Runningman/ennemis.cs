using Godot;
using System;

public class ennemis : KinematicBody2D
{
	public override void _Ready()
	{
		Input.is_action_pressed("ui_right");
	}

}


private void _on_Timer_timeout()
{
	// Replace with function body.
}
