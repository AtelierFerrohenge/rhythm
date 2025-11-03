using Godot;
using System;

[GlobalClass]
public abstract partial class Timekeeper : Node
{
	protected abstract void OnTimerTimeout();
}
