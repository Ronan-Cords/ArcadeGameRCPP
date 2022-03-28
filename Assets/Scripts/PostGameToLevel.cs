using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PostGameToLevel : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.Space))
        {
            PostGameToLevelSelect();
        }

        if (Input.GetKey(KeyCode.Alpha4))
        {
            PostGameToLevelSelect();
        }
    }

    public void PostGameToLevelSelect()
    {
        SceneManager.LoadScene(9);
    }
}
