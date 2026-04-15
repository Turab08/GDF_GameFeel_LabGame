using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleSystemExplosion : MonoBehaviour
{
    public float shakeTime;
    public float shakeMagnitude;

    [SerializeField] GameObject barrel;
    [SerializeField] ParticleSystem explosionEffect;

    void Update() {
        if (Input.GetKeyDown(KeyCode.Space) && barrel != null)
        {
            Explode();
        }    
    }

    void Explode()
    {
        Instantiate(explosionEffect);
        Destroy(barrel);
        StartCoroutine(CameraShake.Instance.Shake(shakeTime, shakeMagnitude));
    }
}
