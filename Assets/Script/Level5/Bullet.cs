using UnityEngine;

public class Bullet : MonoBehaviour
{

    private float _speed = 5f;
    private void Update()
    {
        transform.Translate(_speed * Time.deltaTime, 0, 0);
    }
}
