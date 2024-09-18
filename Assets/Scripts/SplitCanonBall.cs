using System.Collections;
using System.Collections.Generic;
using Org.BouncyCastle.Asn1.Cmp;
using UnityEngine;

public class SplitCanonBall : CanonBall
{
    private static readonly int SpecialAvailableHash = Animator.StringToHash("SpecialAvailable");
    private static readonly int SpecialUsedHash = Animator.StringToHash("SpecialUsed");
    public float splitTime = 0.7f;
    public float splitAngle = 20.0f;
    public CanonBall splitCanonBallPrefab;
    public override void Setup(Vector3 fireforce)
    {
        base.Setup(fireforce);

        animator.SetTrigger(SpecialAvailableHash);
    }

    protected override void OnCollisionEnter(Collision collision)
    {
        base.OnCollisionEnter(collision);

        enabled = false;
    }

    private void SpawnSplitCanonBall()
    {
        var position = transform.position;
        var forward = _rigidbody.velocity;

        var ball1Forward = Quaternion.AngleAxis(-splitAngle, Vector3.up) * forward;
        var ball1 =Instantiate(splitCanonBallPrefab, position, Quaternion.identity);
        ball1.Setup(ball1Forward);

        var ball2Forward = Quaternion.AngleAxis(splitAngle, Vector3.up) * forward;
        var ball2 =Instantiate(splitCanonBallPrefab, position, Quaternion.identity);
        ball1.Setup(ball2Forward);

        animator.SetTrigger(SpecialUsedHash);
        enabled = false;
    }

    private void Update() 
    {
        splitTime -= Time.deltaTime;
        if (splitTime <= 0)
        {
            SpawnSplitCanonBall();
        }    
    }
}
