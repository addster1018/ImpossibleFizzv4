using UnityEngine;
using System.Collections;

public class MagnetismScript_Positive : MonoBehaviour {

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            if (other.transform.position.y > this.transform.position.y)
            {
                other.attachedRigidbody.AddForce(new Vector2(0, 1 * UnityStandardAssets._2D.PlatformerCharacter2D.polarity));
            }
            else
            {
                other.attachedRigidbody.AddForce(new Vector2(0, -1 * UnityStandardAssets._2D.PlatformerCharacter2D.polarity));
            }
            return;
        }
    }
}
