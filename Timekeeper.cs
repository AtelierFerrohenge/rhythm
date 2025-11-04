using Godot;
using System;

public abstract partial class Timekeeper<T> : Node
{
	public T Target { get; protected set; }

	protected abstract void UpdateTarget();

	protected abstract void CompareTarget();

	private void OnTimerTimeout()
	{
		UpdateTarget();
		CompareTarget();
	}
}
