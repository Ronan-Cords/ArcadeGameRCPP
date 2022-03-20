using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2Controller : MonoBehaviour
{
    public float speed = 10;
    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKey("right"))
        {
            transform.Translate(Vector3.right * Time.deltaTime * speed);
        }

        if (Input.GetKey("left"))
        {
            transform.Translate(Vector3.left * Time.deltaTime * speed);
        }
    }
}
