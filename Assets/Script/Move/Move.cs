using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Move : MonoBehaviour
{
    // inspectorで変更可能なパラメータ
    [SerializeField] private float _speedZ = 10.0f;
    [SerializeField] private float _accelerationZ = 0.2f; // 加速

    // 移動方向を初期化
    private Vector3 _moveDirection = Vector3.zero;
    public Rigidbody Rb { get; private set; }
    private int _currentLane = 1; // 現在のレーン（0: 左、1: 中央、2: 右）
    [SerializeField] private float _laneWidth = 50.0f; // レーンの幅

    private void Awake()
    {
        Rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        ChangeLane();
        PlayerMove();
    }

    private void PlayerMove()
    {
        // X方向に少しずつ加速する
        _moveDirection.z += _accelerationZ * Time.deltaTime;
        _moveDirection.z = Mathf.Clamp(_moveDirection.z, _speedZ, _speedZ);

        // 移動方向を更新
        var globalDirection = new Vector3(_moveDirection.x, Rb.velocity.y, _moveDirection.z);
        Rb.velocity = globalDirection;
    }

    private void ChangeLane()
    {
        // レーンを切り替える
        //レーンが1or2で左ボタンを押したとき左に移動
        if (Input.GetKeyDown(KeyCode.LeftArrow) && _currentLane > 0)
        {
            transform.position += Vector3.left * _laneWidth;
            _currentLane--;
        }
        //レーンが0or1で右ボタンを押したとき右に移動
        else if (Input.GetKeyDown(KeyCode.RightArrow) && _currentLane < 2)
        {
            transform.position += Vector3.right * _laneWidth;
            _currentLane++;
        }
    }
}