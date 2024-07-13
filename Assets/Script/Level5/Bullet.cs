using System;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private Player _player;
    private float _speed = 5f;

    private bool _isPlayerBullet;

    private void Start()
    {
        if (CompareTag("PlayerBullet"))
        {
            _isPlayerBullet = true;
        }
    }

    private void Update()
    {
        if (_isPlayerBullet)
        {
            PlayerBullet();
        }
        else
            EnemyBullet();
    }

    private void PlayerBullet()
    {
        transform.Translate(_speed * Time.deltaTime, 0, 0);
        var enemies = FindObjectsOfType<Enemy>();
        foreach (var enemy in enemies)
        {
            var bulletBounds = new Bounds(transform.position, Vector3.one);
            var enemyPos = enemy.transform.position;
            //削除
            if (bulletBounds.Contains(enemyPos))
            {
                Debug.Log("aaa");
                Destroy(gameObject);
                enemy.Life -= 1;
                break;
            }
        }
    }

    private void EnemyBullet()
    {
        transform.Translate(-_speed * Time.deltaTime, 0, 0);

        var bulletBounds = new Bounds(transform.position, Vector3.one);
        var playerPos = _player.transform.position;
        
        if (bulletBounds.Contains(playerPos))
        {
            Destroy(gameObject);
            _player.Life -= 1;
        }
    }
}