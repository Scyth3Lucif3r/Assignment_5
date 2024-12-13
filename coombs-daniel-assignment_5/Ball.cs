using Godot;
using System;

public partial class Ball : RigidBody2D
{

	private float speed = 2;
	
	private Vector2 dir;
    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
	{
        dir = new Vector2(230, -230);
        ApplyImpulse(dir * speed);
    }

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
        
		
	}
}
