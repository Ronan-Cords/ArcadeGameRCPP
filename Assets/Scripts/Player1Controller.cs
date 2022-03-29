using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1Controller : MonoBehaviour
{
    public float speed = 10;

    public Rigidbody Player1Rb;
    public float JumpForce = 10;
    public bool IsOnGround;
    public bool ReadyToSprint;
    public int SprintDuration = 3;
    

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

        if (Input.GetKeyDown(KeyCode.W) && IsOnGround == true)
        {
            PlayerJump();
            IsOnGround = false;
        }

        if (Input.GetKey(KeyCode.V))
        {
            if (ReadyToSprint == true)
            {
                speed = 20;
                ReadyToSprint = false;
                StartCoroutine("SprintLength", SprintDuration);
            }
            ReadyToSprint = true;
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
        Player1Rb.AddForce(0, JumpForce, 0, ForceMode.Impulse);
    }

    private void OnCollisionEnter(Collision collision)
    {
        IsOnGround = true;
    }

    IEnumerator SprintLength(int SprintDuration)
    {
        yield return new WaitForSeconds(SprintDuration);
        speed = 10;
        
    }



    
    
        
    

}
