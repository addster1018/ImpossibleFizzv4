using UnityEngine;
using System.Collections;

public class CollectableScript : MonoBehaviour {

    void OnTriggerEnter2D(Collider2D other)
    {
        Destroy(this.gameObject);
        if (other.tag == "Player")
        {
            Debug.Log(this.tag);
            if(this.tag == "red")
            {
                UnityStandardAssets._2D.PlatformerCharacter2D.SetPolarity(1);
            }
            else
            {
                UnityStandardAssets._2D.PlatformerCharacter2D.SetPolarity(-1);
            }
        }
               
    }
    
}
