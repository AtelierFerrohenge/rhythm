using Godot;
using System;

[GlobalClass]
public partial class StringTimekeeper : Timekeeper<string>
{
	// Input handling and hardcoded inputs are for testing purposes only, final implementation should be more flexible
	private bool _targetPressed = false;

	private Godot.Collections.Array<string> _targets = ["W", "A", "S", "D"];

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		// Workaround to _Input with "" Target
		Target = "W";
	}

	public override void _Input(InputEvent @event)
	{
		if (@event.IsActionPressed(Target))
		{
			_targetPressed = true;
		}
	}

	protected override void UpdateTarget()
	{
		Target = _targets.PickRandom();
	}
	
	protected override void AnnounceTarget()
	{
		GD.Print("Press " + Target + "!");
	}

	protected override void CompareTarget()
	{
		if (_targetPressed)
		{
			GD.Print(Target + " was pressed.");
		}
		else
		{
			GD.Print(Target + " was not pressed.");
		}
		_targetPressed = false;
	}
}
