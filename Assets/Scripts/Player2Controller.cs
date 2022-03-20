using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2Controller : MonoBehaviour
{
    public float speed = 10;

    public Rigidbody Player2Rb;
    public float JumpForce;
    void Start()
    {
        Player2Rb = GetComponent<Rigidbody>();
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

        if(Input.GetKeyUp(KeyCode.UpArrow))
        {
            PlayerJump();
        }
    }

    public void PlayerJump()
    {
        Player2Rb.AddForce(0, JumpForce, 0, ForceMode.Impulse);
    }
}
