using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2Scoring : MonoBehaviour
{
    private int player2ScoreToAdd;
    public int Player2score;
    //public TextMeshProUGUI Player2scoreText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player1"))
        {
            //UpdatePlayer2Score(player2ScoreToAdd);
            Debug.Log("Cat Scored");
        }

    }

    /*public void UpdatePlayer1Score(int player1ScoreToAdd)
    {
        Player1score = player1ScoreToAdd + 1;
        Player1scoreText.text = "Dog Score: " + Player1score;

    }
    */
}
