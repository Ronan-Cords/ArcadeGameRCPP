using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Stage1Manager : MonoBehaviour
{
    private int Player2score;
    public TextMeshProUGUI Player2scoreText;

    private int Player1score;
    public TextMeshProUGUI Player1scoreText;

    public GameObject Player_1;
    public GameObject Player1EndGoal;
    public GameObject Player_2;

    string Player_1tag = "Player1";
    string Player_2tag = "Player2";
    string Player1EndGoaltag = "Player1Goal";

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void UpdatePlayer2Score(int player2scoreToAdd)
    {
        Player2score += player2scoreToAdd;
        Player2scoreText.text = "Cat Score: " + Player2score;
    }

    public void UpdatePlayer1Score(int player1ScoreToAdd)
    {
        Player1score += player1ScoreToAdd;
        Player1scoreText.text = "Dog Score: " + Player1score;

    }
}
