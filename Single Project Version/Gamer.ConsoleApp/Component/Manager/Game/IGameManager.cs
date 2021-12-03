using System;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Threading.Tasks;
using Gamer.Component.Access.GameDefinition;
using Gamer.Component.Access.Player;

namespace Gamer.Component.Manager.Game
{

	public interface IGameManager
	{

		Task<GameDefinition[]> GetGames();
		Task AutoPlayTurn(Guid gameSessionId);
		Task ApplyTurn(Guid gameSessionId, Guid playerId, string address);
		Task<ValidationResult> ConfirmUsableAddress(Guid gameSessionId, string address);
		Task<bool> IsGamePlayable(Guid gameSessionId);
		Task<Guid> StartGame(Guid gameDefinitionId, int playerCount);
		Task<DataTable> GetBoard(Guid gameSessionId);
		Task<string> GetTurnPrompt(Guid gameSessionId);
		Task<Player> GetCurrentPlayer(Guid gameSessionId);
		Task<Player> FindWinner(Guid gameSessionId);
		Task EndGame(Guid gameSessionId);
	}

}