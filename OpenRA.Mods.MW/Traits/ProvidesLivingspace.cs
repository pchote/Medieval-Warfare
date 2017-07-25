﻿#region Copyright & License Information
/*
 * Copyright 2007-2017 The OpenRA Developers (see AUTHORS)
 * This file is part of OpenRA, which is free software. It is made
 * available to you under the terms of the GNU General Public License
 * as published by the Free Software Foundation, either version 3 of
 * the License, or (at your option) any later version. For more
 * information, see COPYING.
 */
#endregion

using System.Collections.Generic;
using OpenRA.Traits;

namespace OpenRA.Mods.Mw.Traits
{
	[Desc("How much the unit is worth in Peasants.")]
	public class ProvidesLivingspaceInfo : TraitInfo<ProvidesLivingspace>
	{
		[FieldLoader.Require]
		[Desc("Used in production. Set 0 to not need an actor to be converted")]
		public readonly int Ammount = 1;
		
		[Desc("Offset at which that the exiting actor is spawned relative to the center of the producing actor.")]
		public readonly WVec SpawnOffset = WVec.Zero;

		[Desc("Cell offset where the exiting actor enters the ActorMap relative to the topleft cell of the producing actor.")]
		public readonly CVec ExitCell = CVec.Zero;

	}

	public class ProvidesLivingspace { }
}