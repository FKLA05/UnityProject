using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TopUIManager : MonoBehaviour
{
    public TextMeshProUGUI FlappyBestScoreText;
    void Start()
    {
        int FlappyBestScore = PlayerPrefs.GetInt("BestScore", 0);
        FlappyBestScoreText.text = " BestScore \n FlappyPlane:" + FlappyBestScore.ToString();
    }

    void OnApplicationQuit()
    {
        PlayerPrefs.DeleteKey("BestScore");
        PlayerPrefs.Save();
        Debug.Log("최고기록 삭제");
    }
}
