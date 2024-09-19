using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.Rendering;

public abstract class Weapon : MonoBehaviour
{
    public float projectileFireForce;
    public CanonBall projectilePrefab;

    private void Update()
    {
        AimCannon();
        TryFireCannon();
    }

    protected abstract void AimCannon();
    protected abstract void TryFireCannon();
}
