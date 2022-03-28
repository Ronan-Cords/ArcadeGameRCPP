using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelectToFour : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Z))
        {
            ToLevel4();
        }

        if (Input.GetKey(KeyCode.Alpha7))
        {
            ToLevel4();
        }
    }

    public void ToLevel4()
    {
        SceneManager.LoadScene(6);
    }
}
