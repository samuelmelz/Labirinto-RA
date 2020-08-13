using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickDown : MonoBehaviour
{
    public GameObject Sphere;
    bool Clique = false;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Clique)
        {
            Sphere.transform.Translate(0f, 0f, -1f * Time.deltaTime);
        }


    }
    private void OnMouseDown()
    {
        Clique = !Clique;
    }
}
