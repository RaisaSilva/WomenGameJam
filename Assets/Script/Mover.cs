using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    public float speed;
    public Transform yo;
    public float h;
    public float v;

    void Start()
    {
        
    }
    
    void Update()
    {
    	// Movmiento horizontal
        h = Input.GetAxisRaw("Horizontal");
        v = Input.GetAxisRaw("Vertical");
        yo.position = new Vector2(transform.position.x + (h * speed), 0);
    }
}
