using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    [SerializeField] private Text _scoreText;
    private int _score;

    public void SetUp()
    {
        _scoreText.text = $"Score {_score}";
    }

    //Scoreを更新
    public void ScoreUp()
    {
        _score++;
        _scoreText.text = $"Score {_score}";
    }
}
