using UnityEngine;

public class BlackjackGame : CardGame
{
    public BlackjackGame(IGameRule gameRule) : base(gameRule)
    {
    }

    public override void StartGame()
    {
        Debug.Log("Starting Blackjack Game");
        gameRule.ApplyRule();
    }
}