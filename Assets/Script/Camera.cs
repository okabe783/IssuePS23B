using UnityEngine;

/// <summary>Cameraがキャラクターに追従するためのScript</summary>
public class Camera : MonoBehaviour
{
    [SerializeField] private Transform _target; 
    [SerializeField] private float _followSpeed = 2.0f; // カメラの追従速度

    private Vector3 _offset; // playerとカメラの距離

    private void Start()
    {
        _offset = transform.position - _target.position;
    }

    private void FixedUpdate()
    {
        var targetPosition = _target.position + _offset;
        transform.position = Vector3.Lerp(transform.position, targetPosition, _followSpeed * Time.deltaTime);
    }
}
