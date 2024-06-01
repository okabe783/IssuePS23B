using UnityEngine;

public class PlayerInput : MonoBehaviour, IPlayerInput
{
    [SerializeField] private float _moveSpeed = 5f;
    [SerializeField] private Vector2 restriction = new Vector2(-100f, 100f);
    private IMove _move;

    private void Start()
    {
        _move = GetComponent<IMove>();
    }

    private void Update()
    {
        if (_move == null) return;
        var input = GetInput();
        var force = new Vector3(0, 0, input.z * _moveSpeed);
        _move.ApplyForce(force);
        PositionLimit();
    }

    public Vector3 GetInput()
    {
        var v = Input.GetAxis("Vertical");
        return new Vector3(0, 0, v * _moveSpeed);
    }

    private void PositionLimit()
    {
        // 現在の位置を取得
        var position = transform.position;

        // z軸の制限を超えないようにする
        position.z = Mathf.Clamp(position.z, restriction.x, restriction.y);

        // 位置を更新
        transform.position = position;
    }
}