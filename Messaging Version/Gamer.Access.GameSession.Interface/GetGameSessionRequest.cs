﻿using System;
using Gamer.Framework.ServiceMessaging;

namespace Gamer.Access.GameSession.Interface
{
	public class GetGameSessionRequest : ServiceMessageRequest
	{
		public Guid GameSessionId { get; set; }
	}
}