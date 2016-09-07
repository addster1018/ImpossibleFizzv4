using UnityEngine;
using System.Collections;

public class MagnetismSuitScript : MonoBehaviour {

    // Use this for initialization
    void Start()
    {

    }

    void OnGUI()
    {
        GUI.Label(createTextRect(Screen.width / 2f, 50f, "You have picked up the magnetism suit! You have also won invented monopoles and won a Nobel Prize."), 
                                 "You have picked up the magnetism suit! You have also won invented monopoles and won a Nobel Prize.");
        GUI.Label(createTextRect(Screen.width / 2f, 100f, "With this powerup, you can " +
                            "click to switch your polarity."), "With this powerup, you can " +
                            "click to switch your polarity.");

        if (GUI.Button(createTextRect(Screen.width / 2f, 150f, "OK"), "OK"))
        {
            SceneSelector.LoadScene("E&MLevel1");
        }
    }

    private Rect createTextRect(float x, float y, string text)
    {
        float pixelWidthPerLetter = 5.75f;
        float textWidth_Pixels = text.Length * pixelWidthPerLetter;

        float x_Rect = x - (textWidth_Pixels / 2f);
        float y_Rect = y;
        float width = textWidth_Pixels;
        float tmp_width = width;
        if (width > Screen.width * (4f / 5f))
        {
            tmp_width = Screen.width * (4f / 5f);
        }
        else if (width < 30)
        {
            tmp_width = 30;
        }

        x_Rect += Mathf.Abs(tmp_width - width) / 2f;
        width = tmp_width;
        float height = textWidth_Pixels * 4f;

        return new Rect(x_Rect, y_Rect, width, height);

    }
}
