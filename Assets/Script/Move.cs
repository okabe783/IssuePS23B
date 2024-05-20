using System;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Move : MonoBehaviour
{
    private Rigidbody _rigidBody;

    public Rigidbody Rb => _rigidBody;

    private void Awake()
    {
        _rigidBody = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        _rigidBody.AddForce(new Vector3(-3f, 0f, 0f)); //力を加える
    }
}