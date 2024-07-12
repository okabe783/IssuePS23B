using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    [SerializeField,Header("敵のプレハブ")] private GameObject _enemy;
    [SerializeField,Header("敵の出現頻度")] private float _spawnTime;
    [SerializeField, Header("出現するポジション")] private Transform _spawnPos;
    private float _setTime;

    public void Start()
    {
        _setTime = _spawnTime;
        //初期Enemyを生成
        Instantiate(_enemy, _spawnPos);
    }

    private void Update()
    {
        SetTimer();
        ReSpawn();
    }

    private void SetTimer()
    {
        if (_spawnPos.childCount == 0)
            _spawnTime -= Time.deltaTime;
    }
    private void ReSpawn()
    {
        if (_spawnTime <= 0 && _spawnPos.childCount == 0)
        {
            Instantiate(_enemy, _spawnPos);
            _spawnTime = _setTime;
        }
    }
}
