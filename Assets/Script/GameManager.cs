using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject _yellowCube;
    [SerializeField] private Transform _start;
    [SerializeField] private Transform _goal;

    private void Start()
    {
        CreateCube();
    }

    private void CreateCube()
    {
        var startPos = _start.position;
        var goalPos = _goal.position;
        var dic = (goalPos - startPos).normalized;
        var distance = Vector3.Distance(startPos, goalPos);

        for (var i = 0; i < distance; i += 50)
        {
            if (i != 0)
            {
                var spawnPos = startPos + dic * i;
                spawnPos.y += 2;
                Instantiate(_yellowCube, spawnPos, Quaternion.identity);
            }
        }
    }
}