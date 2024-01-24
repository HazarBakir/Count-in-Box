using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCamera : MonoBehaviour
{
    private float speed = 150;
    public GameObject player;

    // Update is called once per frame
    void FixedUpdate()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        transform.LookAt(player.transform);
        transform.Translate(Vector3.right * horizontalInput * speed * Time.deltaTime);

    }
}
