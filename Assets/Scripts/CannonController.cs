using UnityEngine;


public class CannonController : Weapon
{
    public float maxYRotation;
    public float minYRotation;
    public float maxXRotation;
    public float minXRotation;
    public float rotationSpeed;
    public Transform firePointTransform;

    public Transform barrelTransform;
    public Transform baseTransform;

    private bool fireDisable;

    public void DisableFire()
    {
        fireDisable = true;
        Cursor.lockState = CursorLockMode.None;
    }

    private void Update()
    {
        AimCannon();
        TryFireCannon();
    }

    protected override void AimCannon()
    {
        float newBaseRotation = baseTransform.localRotation.eulerAngles.y + rotationSpeed * Input.GetAxis("Mouse X");
        newBaseRotation = Mathf.Clamp(newBaseRotation, minYRotation, maxYRotation);
        baseTransform.localRotation = Quaternion.Euler(0, newBaseRotation, 0);

        float newBarrelRotation = barrelTransform.localRotation.eulerAngles.x - rotationSpeed * Input.GetAxis("Mouse Y");
        newBarrelRotation = Mathf.Clamp(newBarrelRotation, minXRotation, maxXRotation);
        barrelTransform.localRotation = Quaternion.Euler(newBarrelRotation, 0, 0);
    }

    protected override void TryFireCannon()
    {
        if (fireDisable || !Input.GetButtonDown("Fire1"))
            return;
            
        CanonBall instiantiateBall = Instantiate(projectilePrefab, firePointTransform.position, Quaternion.identity);
        instiantiateBall.Setup(firePointTransform.forward * projectileFireForce);
    }

    private void Awake()
    {
        Cursor.lockState = CursorLockMode.Locked; 
    }
}