using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SampleRotation : MonoBehaviour
{
    [SerializeField] float rotationSpeed = 1.0f;

    void Update()
    {
        this.transform.localRotation *= Quaternion.Euler(0f, rotationSpeed, 0f);
    }
}
