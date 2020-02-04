using Godot;
using System;

public class new_script : Node
{
    public int Speed = 400; //Vitesse de l'ennemi
	
    public override void _Ready()
    {
    }
	
	public override void _Process(float delta)
	{
		var velocity = new Vector2(); //Mouvement
		var animationPlayer = GetNode<AnimationPlayer>("AnimationPlayer") //Animation
		
		if (Input.IsActionPressed("ui_right"))
		{
			velocity.x += 1; //Déplacement vers la droite
			animationPlayer.Play()
		}
		
		if (Input.IsActionPressed("ui_left"))
		{
			velocity.x -= 1; //Déplacement vers la gauche
			animationPlayer.Play()
		}
		
		if velocity.x > 0:
			animationPlayer.GaucheR = true
		else:
			animationPlayer.GaucheR = false
		} //Permet de retourner notre animation en fonction de la direction
		
		
	}

}
