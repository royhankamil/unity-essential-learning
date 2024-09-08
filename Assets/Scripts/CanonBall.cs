using UnityEngine;

public class CanonBall : MonoBehaviour
{
    private static readonly int ExplodeHash = Animator.StringToHash("Exploded");
    private Rigidbody _rigidbody;
    public Animator animator;

    void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    public void Setup(Vector3 fireforce) 
    {
        _rigidbody.AddForce(fireforce, ForceMode.Impulse);
        _rigidbody.angularVelocity = new Vector3 (Random.Range(-10, 10), Random.Range(-10, 10), Random.Range(-10, 10));
    }

    public void OnFinishedExplosionAnimation()
    {
        Destroy(gameObject);
    }

    private void OnCollisionEnter(Collision other) 
    {
        _rigidbody.angularVelocity = Vector3.zero;
        _rigidbody.velocity = Vector3.zero;
        _rigidbody.isKinematic = true;
        _rigidbody.detectCollisions = false;

        animator.SetTrigger(ExplodeHash);
    }
}
