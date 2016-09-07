using UnityEngine;
using System.Collections;

public class GravitySuitScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	    
	}

    void OnGUI()
    {
        GUI.Label(createTextRect(Screen.width / 2f, 50f, "You have picked up the gravity suit!"), "You have picked up the gravity suit!");
        GUI.Label(createTextRect(Screen.width / 2f, 100f, "With this powerup, you can " +
                            "click to reverse the direction of gravity."), "With this powerup, you can " +
                            "click to reverse the direction of gravity.");
        
        if (GUI.Button(createTextRect(Screen.width / 2f, 150f, "OK"), "OK"))
        {
            SceneSelector.LoadScene("MechanicsLevel1");
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
        if (width > Screen.width * (4f/5f))
        {
            tmp_width = Screen.width * (4f / 5f);
            //Debug.Log("Old X: " + x_Rect + ", New X: " + (x_Rect + Mathf.Abs(tmp_width - width) / 2));
        } else if (width < 30) {
            tmp_width = 30;
        }
       
        x_Rect += Mathf.Abs(tmp_width - width) / 2f;
        width = tmp_width;
        float height = textWidth_Pixels * 4f;

        return new Rect(x_Rect, y_Rect, width, height);

    }
}
