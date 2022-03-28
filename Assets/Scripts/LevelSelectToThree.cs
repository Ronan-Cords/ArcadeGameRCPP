using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelectToThree : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.B))
        {
            ToLevel3();
        }

        if (Input.GetKey(KeyCode.Alpha6))
        {
            ToLevel3();
        }
    }
    public void ToLevel3()
    {
        SceneManager.LoadScene(5);
    }
}
