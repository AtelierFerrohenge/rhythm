using Godot;
using System;

[GlobalClass]
public partial class StringTimekeeper : Timekeeper<string>
{
	// Input handling and hardcoded inputs are for testing purposes only, final implementation should be more flexible
	private InputEvent _lastInput;

	private Godot.Collections.Array<string> _targets = ["W", "A", "S", "D"];

	public override void _Input(InputEvent @event)
	{
		if (@event.IsActionPressed("W") || @event.IsActionPressed("A") || @event.IsActionPressed("S") || @event.IsActionPressed("D"))
		{
			_lastInput = @event;
		}
	}

	protected override void UpdateTarget()
	{
		Target = _targets.PickRandom();
		GD.Print("Press " + Target + "!");
	}

	protected override void CompareTarget()
	{
		if (_lastInput?.IsActionPressed(Target) ?? false)
		{
			GD.Print(Target + " was pressed.");
		}
		else
		{
			GD.Print(Target + " was not pressed.");
		}
	}
}
