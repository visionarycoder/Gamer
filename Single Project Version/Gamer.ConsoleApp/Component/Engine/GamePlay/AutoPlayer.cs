﻿using System;
using System.Linq;
using Gamer.Component.Access.Tile;

namespace Gamer.Component.Engine.GamePlay
{

	internal class AutoPlayer
	{

		//ToDo: Add logic for better auto-player game play.  
		// https://en.wikipedia.org/wiki/Tic-tac-toe

		public Tile PlayTurn(Tile[] tiles)
		{

			var emptyTiles = tiles.Where(i => i.IsEmpty).ToList();
			// ToDo: Remove "new Random()" with AutoPlay upgrades.
			var idx = new Random().Next(0, emptyTiles.Count - 1);
			var tile = tiles[idx];
			return tile;

		}

	}

}
