using Godot;
using System;

public abstract partial class Timekeeper<T> : Node
{
	[Export]
	public double Delay { get; set; } = 1.0;
	
	[Export]
	public double InputWindow { get; set; } = 1.0;

	public T Target { get; protected set; }

	protected abstract void UpdateTarget();

	// Think of a better name for these "Trigger" methods as they're not accurate
	private void TriggerUpdate()
	{
		UpdateTarget();
		// May want to set process always to false
		GetTree().CreateTimer(Delay).Timeout += TriggerAnnounce;
	}

	protected abstract void AnnounceTarget();

	// Think of a better name for these "Trigger" methods as they're not accurate
	private void TriggerAnnounce()
	{
		AnnounceTarget();
		// May want to set process always to false
		GetTree().CreateTimer(InputWindow).Timeout += CompareTarget;
	}

	// May want to make a TriggerCompare wrapper too
	protected abstract void CompareTarget();

	// Make this dependent on some sort of global tick or beat rather than an individual timer
	private void OnTimerTimeout()
	{
		TriggerUpdate();
	}
}
