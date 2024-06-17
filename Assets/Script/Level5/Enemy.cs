using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private GameObject _player;
    [SerializeField] private float _searchArea = 100.0f;
    [SerializeField] private GameObject _enemyBullet;
    [SerializeField] private GameObject _enemyMuzzle;
    private float _timer;
    public float Life { get; set; } = 3;

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
        // 矩形
        var searchBounds = new Bounds(transform.position, Vector3.one * _searchArea);
        var playerPos = _player.transform.position;
        
        if (!searchBounds.Contains(playerPos)) return;
        _timer += Time.deltaTime;
        if (!(_timer >= 1)) return;
        CreateBullet();
        _timer = 0;
    }
    
    private void CreateBullet()
    {
        Instantiate(_enemyBullet, _enemyMuzzle.transform.position, Quaternion.identity);
    }
}
