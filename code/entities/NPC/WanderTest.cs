﻿using Sandbox;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

[Spawnable]
[Library( "npc_wandertest", Title = "Wander" )]
public partial class Wandertest : NPC
{
	public override float SpawnHealth => 100;

	// public NavSteer Steer;

	public override void Spawn()
	{
		base.Spawn();

		SetModel("models/scientist/scientist.vmdl");

		var wander = new Sandbox.Nav.Wander();
		Steer = wander;
	}
}
