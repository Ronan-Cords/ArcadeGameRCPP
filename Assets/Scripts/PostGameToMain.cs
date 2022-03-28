using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PostGameToMain : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.V))
        {
            PostLevelToMainMenu();
        }

        if(Input.GetKey(KeyCode.Alpha5))
        {
            PostLevelToMainMenu();
        }
    }

    public void PostLevelToMainMenu()
    {
        SceneManager.LoadScene(0);
    }
}
