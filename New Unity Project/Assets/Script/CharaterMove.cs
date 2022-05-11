using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharaterMove : MonoBehaviour
{
    
    public float speed = 5f;

    void Start()
    {
        
    }

    void Update()
    {
     

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(-speed * Time.deltaTime, 0, 0);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(speed * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(0, speed * Time.deltaTime, 0);
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(0, -speed * Time.deltaTime, 0);
        }

      
    }

    private void OnTriggerEnter(Collider other)
    {
        
    }

}
