using UnityEngine;
using System.Collections;

public class EnemyScript : MonoBehaviour {

    protected void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            SceneSelector.LoadScene("GameOverScene");
            return;
        }
    }
}
   