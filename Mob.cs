using Godot;
using System;

public class Mob : RigidBody2D
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		// Randomly choose 1 of 3 animation types. Start on random anim frame.
		var animSprite = GetNode<AnimatedSprite>("AnimatedSprite");
		animSprite.Playing = true;
		string[] mobTypes = animSprite.Frames.GetAnimationNames();
		animSprite.Animation = mobTypes[GD.Randi() % mobTypes.Length];
	}

//  // Called every frame. 'delta' is the elapsed time since the previous frame.
//  public override void _Process(float delta)
//  {
//      
//  }

	private void OnVisibilityNotifier2DScreenExited() {
		// Mobs delete themselves when they leave the screen.
		QueueFree();
	}
}
