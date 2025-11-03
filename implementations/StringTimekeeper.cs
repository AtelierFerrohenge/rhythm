using Godot;
using System;

[GlobalClass]
public partial class StringTimekeeper : Timekeeper
{
	protected override void OnTimerTimeout()
	{
		GD.Print("Next");
	}
}
