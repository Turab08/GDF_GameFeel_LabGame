using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleExplosion : MonoBehaviour
{
    void Update() {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Explode();
        }    
    }

    void Explode()
    {
        Destroy(gameObject);
    }
}
