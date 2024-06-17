using UnityEngine;

public class Bullet : MonoBehaviour
{
    private float _speed = 5f;

    private void Update()
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
}