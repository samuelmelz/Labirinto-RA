using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    public GameObject Sphere;
    private void OnTriggerEnter(Collider other)
    {
        Destroy(Sphere);
    }
}
