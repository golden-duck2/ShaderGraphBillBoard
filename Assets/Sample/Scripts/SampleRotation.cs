using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shader : MonoBehaviour
{
    [SerializeField] float rotationSpeed = 1.0f;

    bool isUp = true;


    void Update()
    {
        this.transform.localRotation *= Quaternion.Euler(0f, rotationSpeed, 0f);
    }
}
