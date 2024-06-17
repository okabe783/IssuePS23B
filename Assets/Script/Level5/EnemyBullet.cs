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

        var distance = Vector3.Distance(transform.position, _player.transform.position);

        if (distance <= 1)
        {
            Destroy(gameObject);
            _playerLife.Life -= 1;
            
        }
    }
}
