using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMove : MonoBehaviour
{
    private Transform _playerTransform;

    private void Start()
    {
        _playerTransform = transform;
    }

    private void Update()
    {
        if (Keyboard.current.aKey.isPressed)
            Move(new Vector3(-0.01f, 0, 0));
        if (Keyboard.current.dKey.isPressed)
            Move(new Vector3(0.01f, 0, 0));
    }

    private void Move(Vector3 pos)
    {
        _playerTransform.position += pos;
    }
}