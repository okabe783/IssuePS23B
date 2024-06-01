//抽象クラス
public abstract class CardGame
{
    protected readonly IGameRule gameRule;

    protected CardGame(IGameRule gameRule)
    {
        this.gameRule = gameRule;
    }

    public abstract void StartGame();
}