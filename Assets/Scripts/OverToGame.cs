using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class OverToGame : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space))
        {
            LoadGame();
        }

        if (Input.GetKeyUp(KeyCode.Alpha4))
        {
            LoadGame();
        }
    }

    public void LoadGame()
    {
        SceneManager.LoadScene(2);
    }
}
