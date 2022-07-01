using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control : MonoBehaviour
{   
    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.A))
        {
            if (transform.position.x < -0.5) return;

            transform.position += new Vector3(-1f, 0, 0);
            
        }
        if (Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.D))
        {
            if (transform.position.x > 0.5) return;
            
              transform.position += new Vector3(1f, 0, 0);
            
        }
    }
}
