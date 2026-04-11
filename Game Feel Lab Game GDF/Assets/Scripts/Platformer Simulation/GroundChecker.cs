using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundChecker : MonoBehaviour
{
    public bool isGrounded;

    public static GroundChecker Instance;

    void Awake()
    {
        Instance = this;
    }

    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            isGrounded = false;
        }
    }
}
