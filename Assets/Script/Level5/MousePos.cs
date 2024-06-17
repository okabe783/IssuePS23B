using UnityEngine;

public class MousePos : MonoBehaviour
{
    private Vector3 _mousePos;
    private Camera _camera;

    private void Start()
    {
        _camera = Camera.main; 
    }

    private void Update()
    {
        var screenPos = Input.mousePosition;
        
        _mousePos = _camera.ScreenToWorldPoint(new Vector3(screenPos.x, screenPos.y, 0));
        
        var direction = _mousePos - transform.position;
        var angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle));
    }
}