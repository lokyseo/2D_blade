using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharaterMove : MonoBehaviour
{

    public float speed = 5f;

    void Update()
    {
      // Vector3 pos = Camera.main.WorldToViewportPoint(transform.position);
      //
      // if (pos.x < 0f) pos.x = 0f;
      // if (pos.x > 1f) pos.x = 1f;
      // if (pos.y < 0f) pos.y = 0f;
      // if (pos.y > 1f) pos.y = 1f;
      //
      // transform.position = Camera.main.ViewportToWorldPoint(pos);

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

}
