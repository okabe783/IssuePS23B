using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitArea : MonoBehaviour
{
    public int _radius = 6;


    void Update()
    {
        var x = transform.position.x;
        var z = transform.position.z;

        if (x * x + z * z < _radius * _radius)
        {
            transform.position = (transform.position).normalized * _radius;
        }
    }
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawSphere(transform.position,0.5f);
    }
}