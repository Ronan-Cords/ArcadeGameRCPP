using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToInstruction : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyUp(KeyCode.V))
        {
            LoadGame();
        }

        if(Input.GetKeyUp(KeyCode.Alpha5))
        {
            LoadGame();
        }
    }

    public void LoadGame()
    {
        SceneManager.LoadScene(1);
    }
}
