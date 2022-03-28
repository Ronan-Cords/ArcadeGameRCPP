using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelectToTwo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.V))
        {
            ToLevel2();
        }

        if (Input.GetKey(KeyCode.Alpha5))
        {
            ToLevel2();
        }
    }

    public void ToLevel2()
    {
        SceneManager.LoadScene(4);
    }
}
