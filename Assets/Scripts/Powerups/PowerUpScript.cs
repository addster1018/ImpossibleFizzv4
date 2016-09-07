using UnityEngine;
using System.Collections;


public abstract class PowerUpScript : MonoBehaviour {

    protected string scene;

    protected abstract void doAction();

    void OnTriggerEnter2D(Collider2D Other)
    {
        Debug.Log(Other.tag);
        if (Other.tag == "Player")
        {
            //Debug.Log("Doing things");
            this.doAction();
            SceneSelector.LoadScene(scene);
            Destroy(this.gameObject);
        }
    }

}
