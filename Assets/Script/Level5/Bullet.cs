using System;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private Player _player;
    private float _speed = 5f;

    private bool _isPlayerBullet;

    private void Start()
    {
        _player = FindObjectOfType<Player>();
        if (CompareTag("PlayerBullet"))
            _isPlayerBullet = true;
        else
            _isPlayerBullet = false;
    }

    private void Update()
    {
        MoveBullet();
    }

    private void MoveBullet()
    {
        if (_isPlayerBullet)
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
                    Destroy(gameObject);
                    enemy.Life -= 1;
                    break;
                }
            }
        }
        else
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

    // private void PlayerBullet()
    // {
    //     transform.Translate(_speed * Time.deltaTime, 0, 0);
    //     var enemies = FindObjectsOfType<Enemy>();
    //     foreach (var enemy in enemies)
    //     {
    //         var bulletBounds = new Bounds(transform.position, Vector3.one);
    //         var enemyPos = enemy.transform.position;
    //         //削除
    //         if (bulletBounds.Contains(enemyPos))
    //         {
    //             Destroy(gameObject);
    //             enemy.Life -= 1;
    //             break;
    //         }
    //     }
    // }
    //
    // private void EnemyBullet()
    // {
    //     transform.Translate(-_speed * Time.deltaTime, 0, 0);
    //
    //     var bulletBounds = new Bounds(transform.position, Vector3.one);
    //     var playerPos = _player.transform.position;
    //     
    //     if (bulletBounds.Contains(playerPos))
    //     {
    //         Destroy(gameObject);
    //         _player.Life -= 1;
    //     }
    // }
}