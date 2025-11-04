using Godot;
using System;

[GlobalClass]
public partial class StringTimekeeper : Timekeeper<string>
{
	// Input handling and hardcoded inputs are for testing purposes only, final implementation should be more flexible
	private InputEvent _lastInput;

	public override void _Input(InputEvent @event)
	{
		if (@event.IsActionPressed("W") || @event.IsActionPressed("A") || @event.IsActionPressed("S") || @event.IsActionPressed("D"))
		{
			_lastInput = @event;
		}
	}

	protected override void UpdateTarget()
	{
		Target = "W";
	}

	protected override void CompareTarget()
	{
		if (_lastInput?.IsActionPressed(Target) ?? false)
		{
			GD.Print("W was last pressed.");
		}
		else
		{
			GD.Print("W was not last pressed.");
		}
	}
}
