using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelectToOne : MonoBehaviour
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
            ToLevel1();
        }

        if(Input.GetKey(KeyCode.Alpha4))
        {
            ToLevel1();
        }
    }

    public void ToLevel1()
    {
        SceneManager.LoadScene(3);
    }
}
