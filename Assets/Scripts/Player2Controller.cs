using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Player2Controller : MonoBehaviour
{
    public float speed = 10;

    public Rigidbody Player2Rb;
    public float JumpForce = 10;
    public bool IsOnGround;

    public float JumpBoostDuration = 3;


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

        if(Input.GetKey(KeyCode.UpArrow) && IsOnGround == true)
        {
            PlayerJump();
            IsOnGround = false;
        }

        if (Input.GetKey(KeyCode.Alpha5))
        {
            JumpForce = 20;
            StartCoroutine("JumpDuration", JumpBoostDuration);
            
        }

        if (transform.position.y > 15)
        {
            transform.position = new Vector3(transform.position.x, 15, transform.position.z);
        }

        if (transform.position.x < -27)
        {
            transform.position = new Vector3(-27, transform.position.y, transform.position.z);
        }

        if (transform.position.x > 27)
        {
            transform.position = new Vector3(27, transform.position.y, transform.position.z);
        }
    }

    public void PlayerJump()
    {
        Player2Rb.AddForce(0, JumpForce, 0, ForceMode.Impulse);
    }

    private void OnCollisionEnter(Collision collision)
    {
        IsOnGround = true;
    }

    IEnumerator JumpDuration(int JumpBoostDuration)
    {
        yield return new WaitForSeconds(JumpBoostDuration);
        JumpForce = 10;
    }

}
