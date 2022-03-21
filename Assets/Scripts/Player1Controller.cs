using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1Controller : MonoBehaviour
{
    public float speed = 10;

    public Rigidbody Player1Rb;
    public float JumpForce;
    public bool IsOnGround;

    void Start()
    {
        Player1Rb = gameObject.GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Input.GetKey("d"))
        {
            transform.Translate(Vector3.right * Time.deltaTime * speed);
        }

        if (Input.GetKey("a"))
        {
            transform.Translate(Vector3.left * Time.deltaTime * speed);
        }

        if (Input.GetKeyUp(KeyCode.W) && IsOnGround == true)
        {
            PlayerJump();
            IsOnGround = false;
        }
    }

    public void PlayerJump()
    {
        Player1Rb.AddForce(0, JumpForce, 0, ForceMode.Impulse);
    }

    private void OnCollisionEnter(Collision collision)
    {
        IsOnGround = true;
    }

}
