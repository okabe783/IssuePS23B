using UnityEngine;
 
 public class Player : MonoBehaviour
 {
     [SerializeField] private GameObject _bullet;
     private Transform _muzzle;
     public float Life { get; set; } = 5;
 
     private void Start()
     {
         //親のTransform オブジェクトから見た相対的な位置
         _muzzle = transform.Find("Muzzle");
     }
 
     private void Update()
     {
         if (Input.GetKeyDown(KeyCode.Space))
             CreateBullet();
     }
 
     private void CreateBullet()
     {
         Instantiate(_bullet, _muzzle.transform.position, _muzzle.transform.rotation);
     }
 }