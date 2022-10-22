using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; // Text Mesh Pro name space added to access the unity librarys for UI

public class ScoreManager : MonoBehaviour
{

    public int score; //Store score value

    public TextMeshProUGUI scoreText; // Reference visual text UI element to change


    // Start is called before the first frame update
    

    // This function rewards the player

    public void IncreaseScore(int amount)
    {
        score += amount; // Add amount to the score
        UpdateScoreText(); // Update the score UT text
    }

    public void DecreaseScore(int amount)
    {
        score -= amount; //Subtract amount from the score
        UpdateScoreText(); //Upadte the score UI text 
    }

    public void UpdateScoreText()
    {
        scoreText.text = "Score:" + score;
    }
}
