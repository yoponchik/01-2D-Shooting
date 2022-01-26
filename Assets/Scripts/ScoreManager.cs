using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public Text textScore;
    private int score;


    #region Singleton
    public static ScoreManager instance;

    private void Awake()
    {
        ScoreManager.instance = this;
    }
    #endregion Singleton


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

    #region Property

    public int SCORE {

        get { return score; }

        set {
            score = value;
            textScore.text = "Score: " + score.ToString();
        }

    }

    #endregion Property

    void Start()
    {
        //SetScore(0);
        SCORE = 0;

    }
}

