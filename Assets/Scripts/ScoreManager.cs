using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    #region Singleton
    public static ScoreManager instance;

    private void Awake()
    {
        ScoreManager.instance = this;
    }
    #endregion Singleton

    public Text textScore;
    private int score;

    public Text textHighScore;
    private int highScore;


    #region Regular Get-Set Functions
    /*
    public int GetScore(){
        return score;
    }

    public void SetScore(int value){
        score = value;
        textScore.text = "Score: " + score.ToString();
    }


    */
    #endregion Regular Get-Set Functions

    #region Property: Score

    public int SCORE {

        get { return score; }

        set {
            score = value;
            textScore.text = "Score: " + score.ToString();

            if (score > highScore) {
                HIGHSCORE = score;
                PlayerPrefs.SetInt("HighScore", highScore);
            }
        }

    }

    #endregion Property: Score

    #region Property: High Score

    public int HIGHSCORE
    {

        get { return highScore; }

        set
        {
            highScore = value;
            textHighScore.text = "High Score: " + highScore.ToString();
        }

    }

    #endregion Property: High Score


    void Start()
    {
        //SetScore(0);
        SCORE = 0;
        HIGHSCORE = PlayerPrefs.GetInt("HighScore", highScore);
    }
}

