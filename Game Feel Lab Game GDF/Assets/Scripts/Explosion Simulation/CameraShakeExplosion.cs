using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShakeExplosion : MonoBehaviour
{
    public float shakeTime;
    public float shakeMagnitude;

    [SerializeField] GameObject barrel;

    void Update() {
        if (Input.GetKeyDown(KeyCode.Space) && barrel != null)
        {
            Explode();
        }    
    }

    void Explode()
    {
        Destroy(barrel);
        StartCoroutine(CameraShake.Instance.Shake(shakeTime, shakeMagnitude));
    }
}
