using System.Collections;
using UnityEngine;

public class Jump : MonoBehaviour
{
    [SerializeField] private Transform _endPos;
    [SerializeField] private float _flightTime = 2f;
    [SerializeField] private float _speedRate = 1f;
    private const float _gravity = -9.8f;

    private bool _isJump = true;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            if (_isJump)
                StartCoroutine(Jumping( _flightTime, _speedRate, _gravity));
        }
    }

    private IEnumerator Jumping(float _flight, float _speed, float _grav)
    {
        _isJump = false;
        var startPos = transform.position; //Start地点
        //始点と終点のy成分の差分　- 0.5 * 重力 * 滞空時間2乗　/ 滞空時間
        var vn = (0 - _grav * 0.5f * _flight * _flight) / _flight;

        for (var i = 0f; i < _flight; i += Time.deltaTime * _speed)
        {
            var p = startPos;
            p.y = startPos.y + vn * i + 0.5f * _grav * i * i;
            transform.position = p;
            yield return null;
        }

        StartCoroutine(IsJump());
        transform.position = startPos;
    }

    private IEnumerator IsJump()
    {
        yield return new WaitForSeconds(0.8f);
        _isJump = true;
    }
}