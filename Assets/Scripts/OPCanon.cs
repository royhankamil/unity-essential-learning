using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OPCanon : CanonBall
{
    public CanonBall canonBallPrefab;
    public float splitTime = 0.7f;
    public float splitAngle = 20.0f;
    public float timeBlow = 2.0f;
    public override void Setup(Vector3 fireforce)
    {
        base.Setup(fireforce);
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
        var ball1 = Instantiate(canonBallPrefab, position, Quaternion.identity);
        ball1.Setup(ball1Forward);

        var ball2Forward = Quaternion.AngleAxis(splitAngle, Vector3.up) * forward;
        var ball2 = Instantiate(canonBallPrefab, position, Quaternion.identity);
        ball2.Setup(ball2Forward);

        enabled = false;
    }

    private void Start() 
    {
        Invoke("SpawnSplitCanonBall", timeBlow);    
    }
}
