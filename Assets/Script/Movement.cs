using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float velocidad = 30f;

    void Update()
    {
        if(Input.GetKey(KeyCode.LeftArrow) || Input.GetKey("a"))
        {
        	transform.position += Vector3.left * velocidad * Time.deltaTime;
        }

        if(Input.GetKey(KeyCode.RightArrow) || Input.GetKey("d"))
        {
        	transform.position += Vector3.right * velocidad * Time.deltaTime;
        }
        
       /* if(Input.GetKey(KeyCode.up) || Input.GetKey("d"))
        {
        	transform.position += Vector3.right * velocidad * Time.deltaTime;
        }*/

    }
}
