using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdvancedExplosion : MonoBehaviour
{
    public float shakeTime;
    public float shakeMagnitude;

    [SerializeField] GameObject barrel;
    [SerializeField] ParticleSystem explosionEffect;
    [SerializeField] AudioSource sfx;
    [SerializeField] AudioClip explosionSfx;

    void Update() {
        if (Input.GetKeyDown(KeyCode.Space) && barrel != null)
        {
            Explode();
        }    
    }

    void Explode()
    {
        Instantiate(explosionEffect);
        sfx.PlayOneShot(explosionSfx);
        Destroy(barrel);
        StartCoroutine(CameraShake.Instance.Shake(shakeTime, shakeMagnitude));
    }
}
