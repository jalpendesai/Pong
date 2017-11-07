using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Scoreboard : MonoBehaviour {

    public static Scoreboard instance;

    public Text playerOne;
    public Text playerTwo;

    public int playerOneScore;
    public int playerTwoScore;

	// Use this for initialization
	void Start () {
        instance = this;
        playerOneScore = playerTwoScore = 0;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void PlayerOneScored()
    {
        playerOneScore += 1;
        playerOne.text = playerOneScore.ToString();

        if (playerOneScore > 1)
        {
            SceneManager.LoadScene(2);
        }
    }

    public void PlayerTwoScored()
    {
        playerTwoScore += 1;
        playerTwo.text = playerTwoScore.ToString();

        if (playerTwoScore > 1)
        {
            SceneManager.LoadScene(0);
        }
    }
}
