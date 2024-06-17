using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private GameObject _player;
    [SerializeField] private float _searchArea = 1.0f;
    [SerializeField] private GameObject _enemyBullet;
    [SerializeField] private GameObject _enemyMuzzle;
    [SerializeField] private Player _playerBullet;
    private Vector3 _currentPos;
    private float _timer;
    public float Life { get; set; } = 3;

    private void Start()
    {
        _currentPos = transform.position;
    }

    private void Update()
    {
        Search();
        if (Life <= 0)
        {
            Destroy(gameObject);
        }
    }

    private void Search()
    {
        var _playerPos = _player.transform.position;
        _currentPos = transform.position;
        var distance = Vector3.Distance(_playerPos, _currentPos);

        if (distance <= _searchArea)
        {
            _timer += Time.deltaTime;
            if (_timer >= 1)
            {
                CreateBullet();
                _timer = 0;
            }
        }
    }
    
    private void CreateBullet()
    {
        Instantiate(_enemyBullet, _enemyMuzzle.transform.position, Quaternion.identity);
    }
}
