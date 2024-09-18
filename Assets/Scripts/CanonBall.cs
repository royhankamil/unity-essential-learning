using UnityEngine;

public class CanonBall : MonoBehaviour
{
    public float explosionForce = 9.0f;
    public float explosionRadius = 7.0f;
    public float explosionUpwardsModifier = 1.0f;
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

        Vector3 explosionPos = transform.position;
        Collider[] colliders = Physics.OverlapSphere(explosionPos, explosionRadius, LayerMask.GetMask("Targets"));

        foreach (Collider hit in colliders)
        {
            Rigidbody collidedRigidbody = hit.GetComponent<Rigidbody>();
            if(collidedRigidbody != null)
            {
                collidedRigidbody.AddExplosionForce(explosionForce, explosionPos, explosionRadius, explosionUpwardsModifier, ForceMode.Impulse);
            }
        }
    }

    private void OnTriggerEnter(Collider other) 
    {
        Destroy(gameObject);    
    }
}
