using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Animator controller;
    public float velocidad = 30f;
    public float h;
    public float v;


    void Update()
    {
        if(Input.GetKey(KeyCode.LeftArrow) || Input.GetKey("a"))
        {
            controller.SetFloat("run", 4f);
        	transform.position += Vector3.left * velocidad * Time.deltaTime;

        }

        if(Input.GetKey(KeyCode.RightArrow) || Input.GetKey("d"))
        {
            controller.SetFloat("run", 4f);
        	transform.position += Vector3.right * velocidad * Time.deltaTime;
        }
        
        if(Input.GetKeyDown(KeyCode.Space) || Input.GetKey("w"))
        {
             controller.SetTrigger("jump");
        }
    }
}
