using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private Score _score;
    [SerializeField] private GameObject _yellowCube;
    [SerializeField] private Transform _start;
    [SerializeField] private Transform _goal;

    private void Start()
    {
        CreateCube();
        _score.SetUp();
    }

    //Cubeを生成する
    private void CreateCube()
    {
        var startPos = _start.position;
        var goalPos = _goal.position;
        var dic = (goalPos - startPos).normalized;
        var distance = Vector3.Distance(startPos, goalPos);

        for (var i = 0; i < distance - 50; i += 50)
        {
            if (i == 0) continue;
            var spawnPos = startPos + dic * i;
            spawnPos.y += 2;
            if (i != 1)
                spawnPos.x += Random.Range(-101, 101) / 50 * 50;

            Instantiate(_yellowCube, spawnPos, Quaternion.identity);
        }
    }
}