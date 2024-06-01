using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Move : MonoBehaviour,IMove
{
    public Rigidbody Rb { get; private set; }

    private void Awake()
    {
        Rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        ApplyForce(new Vector3(5f,0,0));
    }

    public void ApplyForce(Vector3 force)
    {
        Rb.AddForce(force);
    }
    
}