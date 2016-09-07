using UnityEngine;
using System.Collections;

public class LevelAnnouncementScript : MonoBehaviour {

    private static int level = 0;

    string[] levelDescriptions =
    {
        "Avoid falling into the gaps for 45 seconds!",
        "Avoid falling into the gaps for 45 seconds!",
        "Avoid the enemies for 45 seconds!",
        "Avoid falling into the gaps and hitting the enemies for 45 seconds!",
        "Avoid the enemies while bouncing on springs for 45 seconds!",
        "Avoid falling into the gaps and hitting the enemies while bouncing on springs for 45 seconds!",
        "Avoid falling into the gaps for 45 seconds!"   
    };

    // Use this for initialization
    void Start()
    {
        //level = 0;
    }

    void OnGUI()
    {
        if (level == 0)
        {
            GUI.Label(new Rect(Screen.width / 2 - 25, 50, 80, 30), "Level 1");
        } else
        {
            GUI.Label(new Rect(Screen.width / 2 - 25, 50, 80, 30), "Level " + level);
        }

        if (level > 6)
        {
            GUI.Label(new Rect(Screen.width / 2 - 130, 100, 300, 50), levelDescriptions[level - 1]);
        } else
        {
            GUI.Label(new Rect(Screen.width / 2 - 130, 100, 300, 50), levelDescriptions[level]);
        }

        if (GUI.Button(new Rect(Screen.width / 2 - 30, 150, 60, 30), "GO"))
        {
            //Debug.Log(level);
            SceneSelector.LoadLevel(level);
            if (level == 0)
                level++;
        }
    }

    void Update()
    {
        //Debug.Log("Level: " + level);
    }

    public static void DecreaseLevel()
    {
        if (level != 1)
        {
            Debug.Log("Level decreasing from " + level + " to " + (level - 1));
            level--;
            //SceneSelector.LoadScene("LevelAnnouncementScene");
        }
    }

    public static void IncreaseLevel()
    {
        if (level < SceneSelector.GetLevelCount() - 1)
        {
            Debug.Log("Level increasing from " + level + " to " + (level + 1));
            level++;
            HUDScript.IncreaseScore(100);
            HUDScript.GrabScore();
            //Debug.Break();
            SceneSelector.LoadScene("LevelAnnouncementScene");
        }
        else
        {
            Debug.Log("IncreaseLevel failed");
            Debug.Break();
        }
    }
}
