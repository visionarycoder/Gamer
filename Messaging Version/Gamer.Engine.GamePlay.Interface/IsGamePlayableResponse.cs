using Gamer.Framework.ServiceMessaging;

namespace Gamer.Engine.GamePlay.Interface
{
	public class IsGamePlayableResponse : ServiceMessageResponse
	{
		public bool Value { get; set; }
	}
}