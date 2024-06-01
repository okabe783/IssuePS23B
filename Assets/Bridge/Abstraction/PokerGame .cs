using UnityEngine;

public class PokerGame : CardGame
{
    public PokerGame(IGameRule gameRule) : base(gameRule)
    {
        
    }

    public override void StartGame()
    {
        Debug.Log("Starting Poker Game");
        gameRule.ApplyRule();
    }
}