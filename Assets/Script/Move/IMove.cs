using UnityEngine;

public interface IMove
{
    void ApplyForce(Vector3 force);
}

public interface IPlayerInput
{
    Vector3 GetInput();
}