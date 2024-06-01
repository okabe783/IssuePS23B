using UnityEngine;

public class BridgePatternDemo : MonoBehaviour
{
    private void Start()
    {
        IGameRule pokerRule = new PokerRule();
        IGameRule blackjackRule = new BlackjackRule();

        CardGame pokerGame = new PokerGame(pokerRule);
        CardGame blackjackGame = new BlackjackGame(blackjackRule);

        pokerGame.StartGame();
        blackjackGame.StartGame();
    }
}