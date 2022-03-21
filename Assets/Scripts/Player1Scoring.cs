using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1Scoring : MonoBehaviour
{
    private int player1ScoreToAdd;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnCollisionEnter(Collision collision)
    {
        if(gameObject.CompareTag("Player1"))
        {
            //Stage1Manager.UpdatePlayer1Score(player1ScoreToAdd);
        }
    }
}
