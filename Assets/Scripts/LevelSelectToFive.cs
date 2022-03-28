using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelectToFive : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.X))
        {
            ToLevel5();
        }

        if (Input.GetKey(KeyCode.Alpha8))
        {
            ToLevel5();
        }
    }

    public void ToLevel5()
    {
        SceneManager.LoadScene(7);
    }
}
