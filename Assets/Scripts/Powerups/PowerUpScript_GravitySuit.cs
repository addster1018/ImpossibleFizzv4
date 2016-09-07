using UnityEngine;
using System.Collections;

public class PowerUpScript_GravitySuit : PowerUpScript {

	// Use this for initialization
	void Start () {
        this.scene = "GravitySuitPowerupScene";
    }

    protected override void doAction() {
        UnityStandardAssets._2D.PlatformerCharacter2D.movementMode =
                UnityStandardAssets._2D.PlatformerCharacter2D.MOVEMENT_MODES.gravity;
    }
}
