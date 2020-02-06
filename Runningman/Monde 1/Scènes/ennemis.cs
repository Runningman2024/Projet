using Godot;
using System;

public class ennemis : KinematicBody2D
{
	const float gravity = 200.0f;
	const int walkSpeed = 200;
	
	Vector2 velocity;
	
	public override void _PhysicsProcess(float delta)
	{
		velocity.y += delta * gravity;

		if (Input.IsActionPressed("ui_left"))
		{
			GetNode<AnimationPlayer>("walk").Play();
			velocity.x = -walkSpeed;
		}
		else if (Input.IsActionPressed("ui_right"))
		{
			GetNode<AnimationPlayer>("walk").Play();
			velocity.x = walkSpeed;
		}
		else
		{
			velocity.x = 0;
		}
		
		MoveAndSlide(velocity, new Vector2(0, -1));
	}
}
