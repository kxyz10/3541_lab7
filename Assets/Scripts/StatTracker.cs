using UnityEngine;
using UnityEngine.UI;

public class StatTracker : MonoBehaviour
{
    public int score;
    public Text scoreText;

    // Update is called once per frame
    //void Update()
    //{
    //    scoreText.text
    //}

    public void addScore()
    {
        score += 100;
        scoreText.text = score.ToString();
    }
}
