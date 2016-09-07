using UnityEngine;
using System.Collections;

public class GameOverScript : MonoBehaviour {

    int score = 0;

	// Use this for initialization
	void Start () {
        score = PlayerPrefs.GetInt("Score");
	}

    void OnGUI()
    {
        GUI.Label(new Rect(Screen.width / 2 - 40, 50, 80, 30), "GAME OVER");
        GUI.Label(new Rect(Screen.width / 2 - 40, 100, 80, 30), "Score: " + score);
        if (GUI.Button(new Rect(Screen.width / 2 - 80, 150, 60, 30), "Retry?"))
        {
            //LevelAnnouncementScript.DecreaseLevel();
            HUDScript.ReloadScore();
            SceneSelector.LoadScene("LevelAnnouncementScene");
        } else if (GUI.Button(new Rect(Screen.width / 2 - 20, 150, 60, 30), "Quit?"))
        {
            SceneSelector.LoadScene("LeaderboardScene");
        }
    }

}
