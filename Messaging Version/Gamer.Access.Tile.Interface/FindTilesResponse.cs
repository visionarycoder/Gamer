﻿using Gamer.Framework.ServiceMessaging;

namespace Gamer.Access.Tile.Interface
{
	public class FindTilesResponse : ServiceMessageResponse
	{
		public Tile[] Tiles { get; set; }
	}
}