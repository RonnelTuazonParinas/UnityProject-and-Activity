using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatingCube : MonoBehaviour
{
    float xspeed = 0.0f;
    float yspeed = 0.0f;
    float zspeed = 0.0f;
    public bool Rotate = false;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Rotate)
        {
            yspeed = 50;

        }
        else
        {
            yspeed = 0;
        }
        transform.Rotate
            (
            xspeed + Time.deltaTime,
            yspeed + Time.deltaTime,
            zspeed + Time.deltaTime
        
            );
        if (Input.GetMouseButton(0))
        {
            Rotate = true;
        }
       
    }

    public void ChangeBool()
    {
        Rotate = !Rotate;

    }
}
