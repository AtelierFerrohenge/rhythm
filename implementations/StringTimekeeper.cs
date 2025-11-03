using Godot;
using System;

[GlobalClass]
public partial class StringTimekeeper : Timekeeper
{
	protected override void CompareNotes(InputEvent @event)
	{
		// Hardcoded for testing
		if(@event?.IsActionPressed("W") ?? false)
		{
			GD.Print("W was last pressed.");
		}
		else
		{
			GD.Print("W was not last pressed.");
		}
	}
}
