using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicManagerScript : MonoBehaviour
{

    public int playerScore;
    public Text scoreText;
    //public GameObject gameOverScreen;
    
    [ContextMenu("Increase Score")]
    public void addScore(){
        Debug.Log("in addScore");
        playerScore = playerScore + 1;
        scoreText.text = playerScore.ToString();
    }


}
