using UnityEngine;

public class CanonBall : MonoBehaviour
{
    private Rigidbody _rigidbody;

    void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    public void Setup(Vector3 fireforce) 
    {
        _rigidbody.AddForce(fireforce, ForceMode.Impulse);
        _rigidbody.angularVelocity = new Vector3 (Random.Range(-10, 10), Random.Range(-10, 10), Random.Range(-10, 10));
    }

    private void OnCollisionEnter(Collision other) 
    {
        _rigidbody.angularVelocity = Vector3.zero;
        _rigidbody.velocity = Vector3.zero;
        _rigidbody.isKinematic = true;
        _rigidbody.detectCollisions = false;
    }
}
