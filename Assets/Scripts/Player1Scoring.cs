using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Player1Scoring : MonoBehaviour
{
    private int player1ScoreToAdd;
    public int Player1score;
    public TextMeshProUGUI Player1scoreText;

   
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
        if (other.CompareTag("Player1Goal"))
        {
            UpdatePlayer1Score(player1ScoreToAdd);
            Debug.Log("Dog Scored");
        }
       
    }

    public void UpdatePlayer1Score(int player1ScoreToAdd)
    {
        Player1score = player1ScoreToAdd + 1;
        Player1scoreText.text = "Cobalt Canine Score: " + Player1score;
        SceneManager.LoadScene(8);
    }
}
