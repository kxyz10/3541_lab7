using UnityEngine;
using UnityEngine.UI;

public class StatTracker : MonoBehaviour
{
    public int score;
    public float time = 101;
    public Text scoreText;
    public Text timeText;

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

    public void subtractScore()
    {
        score -= 50;
        scoreText.text = score.ToString();
    }

    public void trackTime()
    {
        time -= Time.deltaTime;
        if (time < 100f) timeText.color = Color.red;
        timeText.text = time.ToString("0");
    }
}
