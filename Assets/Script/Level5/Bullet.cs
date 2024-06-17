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
            var enemyPosition = enemy.transform.position;
            var bulletPosition = transform.position;
           //削除
            if (Vector3.Distance(enemyPosition, bulletPosition) < 0.5f)
            {
                Destroy(gameObject);
                enemy.Life -= 1;
                break; 
            }
        }
    }
}