using TMPro;
using UnityEngine;


public class ScoreTraker : MonoBehaviour
{
    private int playerScore;
    public TextMeshProUGUI scoreText;

    public void AddScore(int addScoreAmount)
    {
        playerScore += addScoreAmount ;
        scoreText.text = "Score: " + playerScore.ToString();
    }
}
