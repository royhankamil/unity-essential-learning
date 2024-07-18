using UnityEngine;


public class CannonController : MonoBehaviour
{
    public float maxYRotation;
    public float minYRotation;
    public float maxXRotation;
    public float minXRotation;
    public float rotationSpeed;

    public float projectileFireForce;
    public GameObject projectilePrefab;

    public Transform barrelTransform;
    public Transform baseTransform;

    private void Update()
    {
        AimCannon();
        TryFireCannon();
    }

    private void AimCannon()
    {
        float newBaseRotation = baseTransform.localRotation.eulerAngles.y + rotationSpeed * Input.GetAxis("Mouse X");
        newBaseRotation = Mathf.Clamp(newBaseRotation, minYRotation, maxYRotation);
        baseTransform.localRotation = Quaternion.Euler(0, newBaseRotation, 0);
    }

    private void TryFireCannon()
    {
    }
}