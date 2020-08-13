using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    bool Clique=false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Clique)
        {
            transform.Translate(-1f * Time.deltaTime, 0f, 0f);
        }
        

    }
    private void OnMouseDown()
    {
        Clique = !Clique;
    }
}
