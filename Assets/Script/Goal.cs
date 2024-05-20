using UnityEngine;

public class Goal : MonoBehaviour
{
    [SerializeField] private Move _player;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            _player.Rb.velocity = Vector3.zero;
            _player.Rb.angularVelocity = Vector3.zero;
        }
    }
}
