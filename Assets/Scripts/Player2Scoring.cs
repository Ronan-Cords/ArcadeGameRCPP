using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Player2Scoring : MonoBehaviour
{
    private int player2ScoreToAdd;
    public int Player2score;
    public TextMeshProUGUI Player2scoreText;

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
            UpdatePlayer2Score(player2ScoreToAdd);
            Debug.Log("Cat Scored");
        }

    }

    public void UpdatePlayer2Score(int player2ScoreToAdd)
    {
        Player2score = player2ScoreToAdd + 1;
        Player2scoreText.text = "Cat Score: " + Player2score;

    }
    
}
