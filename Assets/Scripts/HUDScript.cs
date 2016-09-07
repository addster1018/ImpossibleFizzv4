using UnityEngine;
using System.Collections;

public class HUDScript : MonoBehaviour {

    private static float PlayerScore = 0;
    private static float TmpScore = 0;
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.U))
        {
            IncreaseScore(100);
        }
        PlayerScore += Time.deltaTime;
	}

    public static void IncreaseScore(int amount)
    {
        PlayerScore += amount;
    }

    void OnGUI()
    {
        GUI.Label(new Rect(Screen.width / 100, Screen.height / 100, Screen.width / 10, Screen.height / 3), "Score: " + (int)(PlayerScore));
    }

    void OnDisable()
    {
        PlayerPrefs.SetInt("Score", (int)(PlayerScore));
    }

    public static void GrabScore()
    {
        TmpScore = PlayerScore;
    }

    public static void ReloadScore()
    {
        PlayerScore = TmpScore;
    }
}
