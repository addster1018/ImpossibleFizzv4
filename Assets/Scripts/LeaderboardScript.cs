    using UnityEngine;
using System.Collections;

public class LeaderboardScript : MonoBehaviour {

    int score = 0, highScore = -1;

	// Use this for initialization
	void Start () {
        score = PlayerPrefs.GetInt("Score");
        if (score > PlayerPrefs.GetInt("High Score", -1))
        {
            PlayerPrefs.SetInt("High Score", score);
        }
        highScore = PlayerPrefs.GetInt("High Score", -1);
	}

    void OnGUI()
    {
        GUI.Label(new Rect(Screen.width / 2 - 40, 40, 100, 30), "Your Score: " + score);
        GUI.Label(new Rect(Screen.width / 2 - 40, 70, 100, 30), "High Score: " + highScore);
        if (GUI.Button(new Rect(Screen.width / 2 - 40, 150, 60, 30), "Quit"))
        {
            Application.Quit();
        }
    }
}
