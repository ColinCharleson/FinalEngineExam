using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public int lives;

    public int score;
    public int maxDucks = 2;

    public Text scoreDisplay;
    public Text healthDisplay;

    public Text lose;
    public Text win;

    private void Awake()
    {
        if (!instance)
        {
            instance = this;
        }
        else
        {
            Destroy(this);
        }
    }

    public void Damage(int value)
	{
        lives -= value;

        healthDisplay.text = lives.ToString();

        if (lives <= 0)
        {
            lose.enabled = true;
            Time.timeScale = 0;
        }

	}
    public void UpdateScore(int value)
	{
        score += value;

        scoreDisplay.text = score.ToString("000000") + "\nScore";


        switch (score)
        {
            case 500:
                maxDucks = 3;
                break;
            case 1000:
                maxDucks = 5;
                break;
            case 1500:
                maxDucks = 7;
                break;
            case 2000:
                win.enabled = true;
                Time.timeScale = 0;
                break;
            default:
                break;
        }
    }
}
