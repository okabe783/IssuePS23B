using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private GameObject _bullet;
    private Vector3 _muzzle;
    private void Start()
    {
        //親のTransform オブジェクトから見た相対的な位置
        _muzzle = transform.Find("Muzzle").localPosition;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            CreateBullet();
    }

    private void CreateBullet()
    {
        Instantiate(_bullet, transform.position + _muzzle, Quaternion.identity);
    }
}
