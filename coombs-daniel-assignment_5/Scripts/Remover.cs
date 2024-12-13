using Godot;
using System;

public partial class Remover : Area2D
{
	private void OnBodyEntered(Node2D body)
	{
		GD.Print($"Destory object: {body.Name}");
		body.QueueFree();
	}
}
