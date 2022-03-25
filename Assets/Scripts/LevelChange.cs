using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelChange : MonoBehaviour
{
    public GameObject LevelChangeScript;
    // Start is called before the first frame update
    void Start()
    {
        LevelChangeScript = gameObject.GetComponent<LevelChanger>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LevelChanger()
    {

    }
}
