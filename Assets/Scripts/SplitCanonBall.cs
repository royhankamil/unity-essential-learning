using System.Collections;
using System.Collections.Generic;
using Org.BouncyCastle.Asn1.Cmp;
using UnityEngine;

public class SplitCanonBall : CanonBall
{
    public override void Setup(Vector3 fireforce)
    {
        base.Setup(fireforce);

        // explosion animation
    }

    protected override void OnCollisionEnter(Collision collision)
    {
        base.OnCollisionEnter(collision);

        enabled = false;
    }
}
