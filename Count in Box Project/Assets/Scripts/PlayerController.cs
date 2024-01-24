using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public GameObject[] cubeFaces;
    void Update()
    {
        ActivateCubeFaces();
    }
    void ActivateCubeFaces()
    {
        for (int i = 0; i < cubeFaces.Length; i++)
        {
            if(Input.GetKeyDown(KeyCode.Alpha1 +i))
            {
                cubeFaces[i].SetActive(!cubeFaces[i].activeSelf);
            }
        }
    }
}
