using UnityEngine;

public class Item : MonoBehaviour
{
    private Score _score;
    private void Start()
    {
        //Scoreを検索
        _score = FindObjectOfType<Score>();
    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(this.gameObject);
        _score.ScoreUp();
    }
}
