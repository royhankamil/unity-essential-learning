using System;
using UnityEngine;


public class Target : MonoBehaviour
{
    private LevelController levelController;

    public void Setup(LevelController _levelController)
    {
        levelController = _levelController;
    }

    private void OnTriggerEnter(Collider other) 
    {
        if (!other.gameObject.layer.Equals(LayerMask.NameToLayer("WaterTrigger")))    
           return;

        levelController.TargetDestroyed();
        Destroy(gameObject);

    }
}