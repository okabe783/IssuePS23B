using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    private float _speed = 5f;
    private GameObject _player;
    private Player _playerLife;

    private void Start()
    {
        _player = GameObject.FindGameObjectWithTag("Player");
        _playerLife = FindObjectOfType<Player>();
    }

    private void Update()
    {
        transform.Translate(-_speed * Time.deltaTime, 0, 0);
        
        var bulletBounds = new Bounds(transform.position, Vector3.one);
        var playerPos = _player.transform.position;
        
        if (bulletBounds.Contains(playerPos))
        {
            Destroy(gameObject);
            _playerLife.Life -= 1;
        }
    }
}
