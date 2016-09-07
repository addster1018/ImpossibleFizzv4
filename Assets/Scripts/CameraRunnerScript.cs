using UnityEngine;
using System.Collections;

public class CameraRunnerScript : MonoBehaviour {

    public Transform Player;

	void Update () {
        transform.position = new Vector3(Player.position.x + 3, 0, -10);
	}
}
