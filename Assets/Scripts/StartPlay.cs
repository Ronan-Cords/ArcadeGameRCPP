using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartPlay : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyUp(KeyCode.Space))
        {
            LoadGameStart();
        }

        if(Input.GetKeyUp(KeyCode.Alpha4))
        {
            LoadGameStart();
        }
    }

    public void LoadGameStart()
    {
        SceneManager.LoadScene(3);
    }
}
