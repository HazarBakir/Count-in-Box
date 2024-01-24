using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BouncyBallController : MonoBehaviour
{
    [SerializeField]float explosionForce;
    private Rigidbody sphereRb;

    void Start()
    {
        int randomNumber = Random.Range(0, 2);
           sphereRb = GetComponent<Rigidbody>();
        sphereRb.AddForce(Vector3.forward* explosionForce ,ForceMode.Impulse);
        if (randomNumber == 0)
        {
            sphereRb.AddForce(Vector3.right * explosionForce, ForceMode.Impulse);
        }
        else
        {
            sphereRb.AddForce(Vector3.left * explosionForce, ForceMode.Impulse);
        }
    }

    void Update()
    {
        
    }
}
