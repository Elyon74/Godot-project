using Godot;
using System;

public class Player : Node
{
    // Declare member variables here. Examples:
    // private int a = 2;
    // private string b = "text";

    var Hp = 3
    var Level = 1
    var MaxExp = 100
    var CurrentExp = 0

    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
        if CurrentExp >= MaxExp:
		Level + 1
    }

//  // Called every frame. 'delta' is the elapsed time since the previous frame.
//  public override void _Process(float delta)
//  {
//      
//  }
}
