using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI BestScoreText;
    public TextMeshProUGUI ScoreText;
    public TextMeshProUGUI RestartText;

    public int NowScore = 0;

    void Start()
    {
        if (RestartText == null)
        {
            Debug.LogError("restart text is null");
        }    
        if(ScoreText == null)
        {
                Debug.LogError("score text is null");
        }

        RestartText.gameObject.SetActive(false);

        int BestScore = PlayerPrefs.GetInt("BestScore", 0);
        BestScoreText.text = "BestScore: " + BestScore.ToString();
    }

    public void UpdateScore(int score)
    {
        ScoreText.text = score.ToString();
        NowScore = int.Parse(ScoreText.text);
    }

    public void SetRestart()
    {
        RestartText.gameObject.SetActive(true);
        int BestScore = PlayerPrefs.GetInt("BestScore", 0);
        if (NowScore > BestScore)
        {
            if (NowScore > BestScore)
            {
                PlayerPrefs.SetInt("BestScore", NowScore);
                PlayerPrefs.Save();
                Debug.Log("새로운 최고기록 저장됨: " + NowScore);
                BestScoreText.text = "BestScore:" + NowScore.ToString();
            }
            else
            {
                Debug.Log("현재 점수: " + NowScore + ", 최고기록 유지됨: " + BestScore);
            }
        }
    }


   
}
