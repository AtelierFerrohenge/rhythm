using Godot;
using System;

[GlobalClass]
public abstract partial class Timekeeper : Node
{
	// Should split input handling out later
	private InputEvent _lastInput;

	// Allow this to handle more than just InputEvents later
	protected abstract void CompareNotes(InputEvent @event);

	private void OnTimerTimeout()
	{
		CompareNotes(_lastInput);
	}

	public override void _Input(InputEvent @event)
	{
		if(@event.IsActionPressed("W") || @event.IsActionPressed("A") || @event.IsActionPressed("S") || @event.IsActionPressed("D"))
		{
			_lastInput = @event;
		}
	}
}
