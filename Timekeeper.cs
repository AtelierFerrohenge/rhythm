using Godot;
using System;

public abstract partial class Timekeeper<T> : Node
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		UpdateTarget();
	}

	public T Target { get; protected set; }

	// Might want to call this on ready
	protected abstract void UpdateTarget();

	protected abstract void CompareTarget();

	private void OnTimerTimeout()
	{
		CompareTarget();
		UpdateTarget();
	}
}
