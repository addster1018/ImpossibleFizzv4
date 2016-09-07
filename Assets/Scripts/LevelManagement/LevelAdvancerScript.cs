using UnityEngine;
using System.Collections;

public class LevelAdvancerScript : MonoBehaviour {

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            //Debug.Break();
            Destroy(this.gameObject);
            LevelAnnouncementScript.IncreaseLevel();
            return;
        } else if (other.tag == "Block" || other.tag == "Enemy")
        {
            if (other.gameObject.transform.parent)
            {
                Destroy(other.gameObject.transform.parent.gameObject);
            }
            else
            {
                Destroy(other.gameObject);
            }
        }
    }
}
